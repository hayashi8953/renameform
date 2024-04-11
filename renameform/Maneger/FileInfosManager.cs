using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace renameForm
{
    public class FileInfosManager
    {
        public FileInfosManager()
        {
            fileInfos = new Dictionary<int, FileInfo>();
        }
        public Dictionary<int, FileInfo> fileInfos { get; set; }
        public int DictionaryCount { get; private set; }

        public string AnyFileInfo(ICollection<FileInfo> files)
        {

            StringBuilder sameFileName = new StringBuilder();
            try
            {
                foreach (FileInfo fi in files)
                {
                    //  同じファイルを探す
                    if (fileInfos.Values.Any(fileInfos => fileInfos.FullName == fi.FullName))
                    {
                        //  同じファイルの名前を取得する
                        sameFileName.Append(fi.Name)
                                    .Append(Environment.NewLine);
                    }
                }
                return sameFileName.ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw new Exception("AnyFileInfo error");
            }
        }
        public bool CheckSameFile(FileInfo fi)
        {

            try
            {
                if (fileInfos.Values.Any(fileInfos => fileInfos.FullName == fi.FullName))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw new Exception("CheckSameFile error");
            }

        }
        public void AddDictionary(int key, FileInfo fi)
        {
            try
            {
                fileInfos.Add(key, fi);
                DictionaryCount = fileInfos.Count;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw new Exception("AddDictionary error");
            }

        }
        public void DeleteElementDictionary(int key)
        {
            try
            {
                if (fileInfos.ContainsKey(key))
                {
                    fileInfos.Remove(key);
                    DictionaryCount = fileInfos.Count;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw new Exception("DeleteDictionary error");
            }
        }
        public string GetFileNameDictionary(int key)
        {
            try
            {
                if (fileInfos.ContainsKey(key))
                {
                    string fileName = fileInfos[key].Name;
                    return fileName;
                }
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw new Exception("GetFileNameDictionary error");
            }


        }
        public bool ContainDictionary(int key)
        {
            try
            {
                if (fileInfos.ContainsKey(key))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw new Exception("ContainDictionary error");
            }
        }
        public string GetFullNameDictionary(int key)
        {
            try
            {
                string fullName = fileInfos[key].FullName;
                return fullName;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw new Exception("GetFullNameDictionary error");
            }

        }
        public string GetExtensionDictionary(int key)
        {
            try
            {
                string extension = fileInfos[key].Extension;
                return extension;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw new Exception("GetExtensionDictionary error");
            }
        }


    }
}
