using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace renameForm
{
    public class RenameUtility
    {

        /// <summary>
        /// ofdからファイルを取り出す
        /// </summary>
        /// <returns></returns>
        public  static List<FileInfo> GetFileInfosOfd()
        {
            List<FileInfo> files = new List<FileInfo>();
            try
            {
                //  複数ファイルの読み込み
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Multiselect = true;
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        foreach (string file in ofd.FileNames)
                        {
                            FileInfo fileInfo = new FileInfo(file);
                            files.Add(fileInfo);
                        }
                    }
                    return files;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// ofdからフォルダー名を取り出す
        /// </summary>
        /// <returns></returns>
        public static string GetFolderNameOfd()
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { 
                    FileName = "SelectFolder", Filter = "Folder|.", CheckFileExists = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        return Path.GetDirectoryName(ofd.FileName);
                    }
                    else
                    {
                        return null;
                    }
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// ファイル名から拡張子を除去してファイル名を返す
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="extension"></param>
        /// <returns></returns>
        public static string RemoveExtension(string fileName, string extension)
        {

            try
            {
                StringBuilder sb = new StringBuilder(fileName);
                sb.Remove(sb.Length - extension.Length, extension.Length);
                string disExtension = sb.ToString();
                return disExtension;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// ファイルのサイズをkb単位に変えて返す
        /// </summary>
        /// <param name="fi"></param>
        /// <returns></returns>
        public static string FormattedKbSize(long size)
        {
            try
            {
                long kbSize = size / 1024;
                string formattedKbSize = kbSize.ToString("N0") + "KB";
                return formattedKbSize;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw;
            }
        }

    }
}

