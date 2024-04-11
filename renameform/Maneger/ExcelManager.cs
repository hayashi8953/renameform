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
        public ExcelManager() {

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        }

        public void ExcelAll(ICollection<string[]> pairs)
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
                throw new Exception("ExcelALL error");
            }


        }
        #region scrap
        ////FileStream xlsxFile = null;


        //public ExcelWorksheet CreateExcelFile()
        //{
        //    try
        //    {

        //        //xlsxFile = new FileStream(@"../Log/RenameAppLog.xlsx", FileMode.OpenOrCreate);
        //        DateTime dtNow = DateTime.Now;
        //        using (ExcelPackage package = new ExcelPackage(@"../Log/RenameAppLog.xlsx"))
        //        {
        //            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(dtNow.ToString());
        //            package.Save();
        //            return worksheet;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.Message);
        //        Debug.WriteLine(ex.StackTrace);
        //        throw new Exception("CreateExcelFile error");
        //    }

        //}
        //public ExcelWorksheet CreateExcelSheet()
        //{
        //    DateTime dtNow = DateTime.Now;
        //    try
        //    {
        //        using (ExcelPackage package = new ExcelPackage(@"../Log/RenameAppLog.xlsx"))
        //        {
        //            ExcelWorksheet worksheet = null;
        //            //  今日の日付のワークシートが無かったら追加
        //            //if (!package.Workbook.Worksheets.Any(sheet => sheet.Name == dtNow.ToString()))
        //            //{ }
        //            // ワークシートを1枚追加
        //            worksheet = package.Workbook.Worksheets.Add(dtNow.ToString());


        //            //  最も新しいワークシートを特定する
        //            //worksheet = package.Workbook.Worksheets.Last();

        //            //int lastRow = 0;
        //            ////  最後の行を取得し、その次の次の行に日付を記述する

        //            //lastRow = worksheet.Dimension.End.Row;
        //            //int startRow = lastRow == 0 ? 0 : lastRow + 2;
        //            ////ExcelRangeBase lastRowCell = worksheet.Cells.Last(c => c.Start.Row == 1);
        //            ////int.TryParse(lastRowCell.ToString(), out int startRow);


        //            //worksheet.Cells[++startRow, 1].Value = dtNow.ToString();
        //            //package.Save();

        //            return worksheet;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.Message);
        //        Debug.WriteLine(ex.StackTrace);
        //        throw new Exception("CreateExcelSheet error");
        //    }

        //}
        //public void WriteExcelFile(ICollection<string[]> pairs, ExcelWorksheet worksheet)
        //{
        //    try
        //    {
        //        int writeRow = 1;
        //        // Excelファイルの作成
        //        using (ExcelPackage package = new ExcelPackage(@"../Log/RenameAppLog.xlsx"))
        //        {
        //            foreach (string[] pair in pairs)
        //            {
        //                //  Logをワークシートに記述していく
        //                worksheet.Cells[writeRow, 1].Value = pair[0];
        //                worksheet.Cells[writeRow, 2].Value = "=>";
        //                worksheet.Cells[writeRow, 3].Value = pair[1];
        //                writeRow++;
        //            }

        //            // 保存
        //            package.Save();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex.Message);
        //        Debug.WriteLine(ex.StackTrace);
        //        throw new Exception("WriteExcelFile error");
        //    }

        //}
        #endregion
    }
}
