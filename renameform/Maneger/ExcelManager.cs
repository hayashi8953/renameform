using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using static System.Windows.Forms.AxHost;


namespace renameform
{
    public class ExcelManager
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ExcelManager() {

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        }

        /// <summary>
        /// エクセルに履歴を保存する
        /// </summary>
        /// <param name="pairs"></param>
        public static void ExcelAll(ICollection<string[]> pairs)
        {
            DateTime dtNow = DateTime.Now;
            int writeRow = 1;
            try
            {
                if (File.Exists(@"Log/RenameAppLog.xlsx"))
                {
                    using (ExcelPackage package = new ExcelPackage(@"Log/RenameAppLog.xlsx"))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(dtNow.ToString());
                        package.Save();

                        foreach (string[] pair in pairs)
                        {
                            //  Logをワークシートに記述していく
                            worksheet.Cells[writeRow, 1].Value = pair[0];
                            worksheet.Cells[writeRow, 2].Value = "=>";
                            worksheet.Cells[writeRow, 3].Value = pair[1];
                            writeRow++;
                        }
                        package.Save();

                    }
                }
                else
                {
                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(dtNow.ToString());
                        package.Save();

                        foreach (string[] pair in pairs)
                        {
                            //  Logをワークシートに記述していく
                            worksheet.Cells[writeRow, 1].Value = pair[0];
                            worksheet.Cells[writeRow, 2].Value = "=>";
                            worksheet.Cells[writeRow, 3].Value = pair[1];
                            writeRow++;
                        }
                        package.SaveAs(@"Log/RenameAppLog.xlsx");
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
    }
}
