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
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FileInfosManager()
        {
            fileInfos = new Dictionary<int, FileInfo>();
        }
        public Dictionary<int, FileInfo> fileInfos { get; set; }
        public int DictionaryCount { get; private set; }

        /// <summary>
        /// 同名のファイルフルネームが存在するかを判定し、そのファイル名を返す
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
                throw;
            }
        }

        /// <summary>
        /// 同名のファイルフルネームが存在するかを判定し、boolを返す
        /// </summary>
        /// <param name="fi"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
                throw;
            }

        }

        /// <summary>
        /// ファイルをディクショナリーに追加する
        /// </summary>
        /// <param name="key"></param>
        /// <param name="fi"></param>
        /// <exception cref="Exception"></exception>
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
                throw;
            }

        }

        /// <summary>
        /// ディクショナリーから要素を削除する
        /// </summary>
        /// <param name="key"></param>
        /// <exception cref="Exception"></exception>
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
                throw;
            }
        }

        /// <summary>
        /// 番号からファイルネームを取り出し、その名前を返す
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
                throw;
            }


        }

        /// <summary>
        /// 番号からファイルフルネームを取り出し、その名前を返す
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// 番号からファイルが存在するかを確認し、boolを返す
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
                throw;
            }
        }

        /// <summary>
        /// 鍵から拡張子を取り出す
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetExtensionDictionary(int key)
        {
            try
            {
                if (fileInfos.ContainsKey(key))
                {
                    string extension = fileInfos[key].Extension;
                    return extension;
                }
                return null;
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
