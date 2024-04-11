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
        public RenameUtility()
        {

        }

        public List<FileInfo> GetFileInfosOfd()
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
                throw new Exception("OpenFileDialog error");
            }
        }
        public string GetFolderNameOfd()
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
                throw new Exception("GetFolderName error");
            }
        }
        public string RemoveExtension(FileInfo fi)
        {

            try
            {
                StringBuilder sb = new StringBuilder(fi.Name);
                sb.Remove(sb.Length - fi.Extension.Length, fi.Extension.Length);
                string disExtension = sb.ToString();
                return disExtension;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw new Exception("RemoveExtension error");
            }
        }
        public string FormattedKbSize(FileInfo fi)
        {
            try
            {
                long kbSize = fi.Length / 1024;
                string formattedKbSize = kbSize.ToString("N0") + "KB";
                return formattedKbSize;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw new Exception("FormattedKbSize error");
            }
        }

    }
}

