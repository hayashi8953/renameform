using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
//using System.DirectoryServices.ActiveDirectory;
using System.Security.Cryptography;
using Microsoft.VisualBasic;
using System.Windows.Forms.VisualStyles;
using renameform;
using System.IO;
using renameform.RenameOption;

namespace renameForm
{
    public partial class RenameForm : Form
    {
        public RenameForm()
        {
            InitializeComponent();
            SetDgvColumnName();

        }

        private FileInfoManager fim = new FileInfoManager();
        private RenameUtility renameUtility = new RenameUtility();
        private OptionBool optionBool = new OptionBool();


        private int fileCount = 0;
        private void menuRestart_Click(object sender, EventArgs e)
        {
            //  再起動を行う
            Application.Restart();
        }
        private void menuExit_Click(object sender, EventArgs e)
        {
            //  アプリを閉じる
            Application.Exit();
        }
        private void btAddFile_Clicked(object sender, EventArgs e)
        {

            List<FileInfo> ofdFileInfos = new List<FileInfo>();

            try
            {
                //  複数ファイルの読み込み
                ofdFileInfos = renameUtility.GetFileInfosOfd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string sameFileName = "";
            try
            {
                //  既存のファイルとの重複の判定
                if (fim.DictionaryCount > 0)
                {
                    sameFileName = fim.AnyFileInfo(ofdFileInfos);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.Message);
            }

            bool sameFile = false;
            if (sameFileName != "")
            {
                sameFile = true;
            }

            //  同じファイルがあればMessageBoxで同意を求める
            if (sameFile)
            {
                DialogResult dr = MessageBox.Show(
                    "同じファイルを追加することはできません" + Environment.NewLine +
                    $"{sameFileName}" + Environment.NewLine +
                    "このファイルを除いてファイルの追加を続行しますか？",
                    "警告", MessageBoxButtons.YesNo);

                //  Yesの場合
                if (dr == DialogResult.Yes)
                {
                    //  同意の確認
                    MessageBox.Show($"{sameFileName}{Environment.NewLine}これを除いて続行します");
                }
                //  Noの場合
                else if (dr == DialogResult.No)
                {
                    //  returnで操作を取り消す
                    MessageBox.Show("キャンセルしました");
                    return;
                }
            }

            //  ofdで取得したファイルをfimの辞書とDGVに入れる
            foreach (FileInfo fi in ofdFileInfos)
            {
                try
                {
                    //  同名のファイルがfimの辞書にあればcontinueで折り返す
                    if (fim.CheckSameFile(fi))
                    {
                        continue;
                    }

                    //  ファイルを辞書とDGVに入れる
                    //  fileInfoをファイル識別番号を鍵にしてfimの辞書に入れる
                    fim.AddDictionary(fileCount, fi);

                    //  ファイル名から拡張子を除く
                    string disExtension = renameUtility.RemoveExtension(fi);

                    //  サイズをkb単位に変換して、三桁ごとに','を入れて単位を付ける
                    string formattedKbSize = renameUtility.FormattedKbSize(fi);

                    //  作成日時を入れる
                    DateTime creationTime = fi.CreationTime;

                    //  DGVにファイル名、ファイル作成日時、ファイルサイズ、識別番号を入れる
                    dgvMain.Rows.Add(
                        disExtension,
                        creationTime,
                        formattedKbSize,
                        fileCount);

                    //  識別番号をカウントする
                    fileCount++;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    Debug.WriteLine(ex.StackTrace);
                    MessageBox.Show(ex.Message + Environment.NewLine +
                        fi.FullName + "でエラーが発生しました。" + Environment.NewLine +
                        "ファイルの追加を中断します");
                }
            }
        }

        private void btDeleteFile_Clicked(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMain.SelectedRows)
            {
                try
                {
                    //  選択されている行の鍵を取り出す
                    int keyNumber = (int)row.Cells["FileKeyNumber"].Value;

                    //  鍵を送って値を削除してもらう
                    fim.DeleteElementDictionary(keyNumber);

                    //  dgvからも行を消す
                    dgvMain.Rows.RemoveAt(row.Index);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    Debug.WriteLine(ex.StackTrace);
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void btSort_Clicked(object sender, EventArgs e)
        {

            //  列名を取り出す
            string name = columnName[cbSort.SelectedIndex];

            //  降順チェックを確認して並び替え
            if (!(cbDescending.Checked))
            {
                dgvMain.Sort(dgvMain.Columns[name], ListSortDirection.Ascending);
            }
            else
            {
                dgvMain.Sort(dgvMain.Columns[name], ListSortDirection.Descending);
            }

        }

        private void btPreview_Click(object sender, EventArgs e)
        {

            try
            {
                for (int i = 0; i < dgvMain.Rows.Count; i++)
                {

                    //  DGV.Nameから値を取り出す
                    string mainString = dgvMain.Rows[i].Cells["FileName"].Value.ToString();
                    string changedName = "";

                    //  文字列をファイル名の前後に加える
                    if (optionBool.AddFront || optionBool.AddBack)
                    {
                        string addString = "";
                        if (optionBool.AddInteger)
                        {
                            addString = tbRenameString.Text;

                        }
                        else
                        {
                            int number = i + (int)nudIntegerStart.Value;
                            int digits = cbIntegerDigits.SelectedIndex + 1;
                            addString = String.Format("{0:D" + digits + "}", number);

                        }

                        //  文字列をファイル名の前に加える
                        if (optionBool.AddFront)
                        {
                            changedName = $"{addString}{mainString}";
                        }
                        //  文字列をファイル名の後に加える
                        else if (optionBool.AddBack)
                        {
                            changedName = $"{mainString}{addString}";
                        }
                    }
                    //  置換する
                    else if (optionBool.Replace)
                    {
                        string searchStr = tbReplace0.Text;
                        string replaceStr = tbReplace1.Text;

                        //  置換対象の文字列が含まれるものを判定
                        if (!mainString.Contains(searchStr))
                            return;

                        //  置換を行う
                        var sb = new StringBuilder(mainString);
                        sb.Replace(searchStr, replaceStr);

                        //  値を入れる
                        changedName = sb.ToString();
                    }
                    else if (optionBool.AllSame)
                    {
                        changedName = tbRenameString.Text;
                    }
                    dgvMain.Rows[i].Cells["FileName"].Value = changedName;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.Message);
            }
            cbInteger.Checked = false;
        }
        private void btFileNameClear_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("ファイル名をすべて削除する",
                "警告", MessageBoxButtons.OKCancel);
            //  Noの場合
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                //  DGVの中にあるファイルの名前をすべて空にする
                for (int i = 0; i < dgvMain.Rows.Count; i++)
                {
                    dgvMain.Rows[i].Cells["FileName"].Value = "";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.Message);
            }

        }
        private void btSelectFolder_Clicked(object sender, EventArgs e)
        {
            try
            {
                //  フォルダー選択ダイアログを開く
                string saveFolder = renameUtility.GetFolderNameOfd();
                //  フォルダーパスをテキストボックスに入れる
                tbFolderName.Text = saveFolder;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.Message);
            }

        }
        private void cbOverWriteSave_CheckedChanged(object sender, EventArgs e)
        {

            //  上書き保存のチェック
            if (cbOverWriteSave.Checked)
            {
                tbFolderName.Text = "それぞれのファイルを上書きで保存する";
            }
            else
            {
                tbFolderName.Text = "";
            }
        }

        private void btDecision_Click(object sender, EventArgs e)
        {

            //  fimの辞書の要素数とdgvの行数が一致しない場合
            if (!(fim.DictionaryCount == dgvMain.Rows.Count))
            {
                MessageBox.Show("エラーが発生しました");
                return;
            }

            //  ファイルの有無
            if (dgvMain.Rows.Count == 0)
            {
                MessageBox.Show("ファイルがありません");
                return;
            }

            //  保存先フォルダーの確認
            if (tbFolderName.Text == "")
            {
                MessageBox.Show("保存フォルダーを選択してください");
                return;
            }

            List<string[]> pairs = new List<string[]>();

            try
            {
                foreach (DataGridViewRow row in dgvMain.Rows)
                {

                    //  ファイルの鍵を取り出す
                    int keyNumber = (int)row.Cells["FileKeyNumber"].Value;

                    //  鍵を使って変更前の完全パスと拡張子を取り出す
                    string fullPath = fim.GetFullName(keyNumber);
                    string extension = fim.GetExtension(keyNumber);

                    //  変更後のディレクトリを求める
                    //  上書き保存にチェックが入っている場合
                    int lastSlashPosition;
                    string directory;

                    if (cbOverWriteSave.Checked)
                    {
                        //  後ろから見て最初に//があった位置から後ろを除外する
                        lastSlashPosition = fullPath.LastIndexOf('\\');
                        directory = fullPath.Substring(0, lastSlashPosition + 1);
                    }
                    //  別のファイルにコピーする場合
                    else
                    {
                        directory = tbFolderName.Text;
                    }
                    //  変更後のファイル名
                    string name = row.Cells["FileName"].Value.ToString() + extension;

                    //  保存するフォルダーのパスと変更後のファイル名を繋げる
                    string fileDirectoryAndName = Path.Combine(directory, name);

                    //  変更前のフルネームと変更後のフルネームを格納していく
                    string[] pair = new string[] { fullPath, fileDirectoryAndName };
                    pairs.Add(pair);

                    //  値をコンソールに表示
                    Debug.WriteLine(directory);
                    Debug.WriteLine($"{fullPath} + {fileDirectoryAndName}");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.Message + Environment.NewLine + "ファイルの照合に失敗しました");
                return;
            }

            try
            {
                bool lastConfirm = false;
                FormConfirm fm = new FormConfirm(pairs);
                fm.ShowDialog();

                //  OKならtrueになる
                lastConfirm = fm.confirmThis;
                fm?.Close();

                //  NOならbreak
                if (!lastConfirm)
                {
                    //  保存をキャンセルする
                    MessageBox.Show("保存がキャンセルされました");
                    return;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.Message + Environment.NewLine + "最終確認に失敗しました");
                return;
            }

            foreach (string[] paths in pairs)
            {
                string fullPath = paths[0];
                string fileDirectoryAndName = paths[1];

                try
                {
                    //  保存
                    if (cbOverWriteSave.Checked)
                    {
                        //  上書き保存
                        File.Move(fullPath, fileDirectoryAndName);
                    }
                    else
                    {
                        //  別の場所にコピーして保存する
                        File.Copy(fullPath, fileDirectoryAndName);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    Debug.WriteLine(ex.StackTrace);
                    DialogResult dr = MessageBox.Show(ex.Message + Environment.NewLine +
                        $"{fullPath}の保存に失敗しました" + Environment.NewLine +
                        "ファイルの保存を継続しますか？",
                        "警告", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        continue;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            MessageBox.Show("変更を終了しました");

        }
        private void cbSelect_CheckedChanged(object sender, EventArgs e)
        {
            gbAddString.Visible = false;
            gbReplace.Visible = false;
            if (rbFront.Checked || rbEnd.Checked || rbSame.Checked)
            {
                gbAddString.Visible = true;
            }
            else if (rbReplace.Checked)
            {
                gbReplace.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OptionForm of = new OptionForm(optionBool);
            of.ShowDialog();
            optionBool = of.optionFormBool;
            Debug.WriteLine(optionBool.ToString());
        }
    }

}

