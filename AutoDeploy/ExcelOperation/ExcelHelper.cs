using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HelperTool
{
    internal static class ExcelHelper
    {
        /// <summary>
        /// 读取Excel数据，返回的RowsData默认拿第一个工作簿中的数据
        /// </summary>
        public static (ExcelData, string) LoadExcel(string path)
        {
            try
            {
                if (!path.Contains("xlsx"))
                {
                    path = path.Insert(path.Length, ".xlsx");
                }
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                //修改只读Excel状态
                if (File.GetAttributes(path).ToString().IndexOf("ReadOnly") != -1)
                {
                    File.SetAttributes(path, FileAttributes.Normal);
                }
                FileInfo fileInfo = new FileInfo(path);

                var bytes = File.ReadAllBytes(path);
                if (bytes.Length == 0)
                {
                    return (new ExcelData(), $"{fileInfo.Name} Excel 没有数据");
                }

                ExcelPackage targetPackage = new ExcelPackage(fileInfo, true);
                ExcelWorksheets targetSheets = targetPackage.Workbook.Worksheets;
                return (new ExcelData
                {
                    PathInfo = fileInfo,
                    Package = targetPackage,
                    WorkSheets = targetSheets,
                    RowDatas = targetSheets[0].GetRowDatas(6)
                }, null);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Excel{path}读取失败 ,请检查路径是否正确或者是否被占用。");
                return (new ExcelData(), error.Message);
            }
        }

        /// <summary>
        /// 读取指定的路径下的ExcelData
        /// </summary>
        /// <returns>返回Excel的各项数据</returns>
        public static (ExcelData, string) LoadSPExcel(string path)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;

            (ExcelData, string) execl = LoadExcel(path);

            return execl;
        }

        /// <summary>
        /// 从指定行数获取行数据
        /// </summary>
        /// <param name="workSheet">指定工作簿</param>
        /// <param name="startRow">指定起始行数</param>
        public static List<RowData> GetRowDatas(this ExcelWorksheet workSheet, int startRow)
        {
            List<RowData> list = new List<RowData>();
            if (workSheet == null) return list;
            int col = workSheet.Dimension.Columns;
            var rows = workSheet?.Dimension.Rows;
            //索引不能是0
            if (startRow <= 0)
            {
                return null;
            }
            for (int i = startRow; i <= rows; i++)
            {
                RowData rowData = new RowData(col);
                for (int t = 1; t <= col; t++)
                {
                    var cell = workSheet?.Cells[i, t];
                    if (cell == null || cell?.Value == null)
                    {
                        rowData.ColTexts.Add(string.Empty);
                        continue;
                    }
                    object colText = workSheet?.Cells[i, t].Value;
                    if (colText != null)
                    {
                        rowData.index = i;
                        rowData.ColTexts.Add(colText);
                    }
                }

                ///检测一下 如果一整行都是空内容 则不要这行
                int compare = 0;
                for (int e = 0; e < rowData.Columns; e++)
                {
                    if (rowData[e]?.ToString() == "")
                    {
                        compare++;
                    }
                }
                if (compare == rowData.Columns) continue;
                list.Add(rowData);

            }
            return list;
        }

        /// <summary>
        /// 获取整个Excel的行数据
        /// </summary>
        /// <param name="workSheet"></param>
        /// <returns></returns>
        public static List<RowData> GetRowDatas(this ExcelWorksheet workSheet)
        {
            return workSheet.GetRowDatas(1);
        }

        /// <summary>
        /// 获取Excel的单个行数据
        /// </summary>
        /// <param name="workSheet"></param>
        /// <returns></returns>
        public static RowData GetRowData(this ExcelWorksheet workSheet, int startRow)
        {
            var colCount = workSheet.Dimension.Columns;
            var rowData = new RowData(colCount);
            if (startRow <= 0)
            {
                return rowData;
            }
            for (int i = 0; i < colCount; i++)
            {
                var cellValue = workSheet.Cells[startRow, i + 1].Value;
                if (cellValue == null)
                {
                    rowData.ColTexts.Add("");
                    continue;
                }
                rowData.ColTexts.Add(cellValue);
            }
            return rowData;
        }

        /// <summary>
        /// 获得Excel的头部数据
        /// </summary>
        public static Dictionary<string, int> GetHeaderDic(this ExcelWorksheet workSheet)
        {
            var colCount = workSheet.Dimension.Columns;
            var rowData = new Dictionary<string, int>();
            for (int i = 1; i <= colCount; i++)
            {
                var cell = workSheet.Cells[1, i];
                if (cell.Value == null)
                {
                    continue;
                }
                rowData[cell.Value.ToString().Trim()] = i - 1;
            }
            return rowData;
        }
        /// <summary>
        /// 在Excel指定工作簿中新增一行 ,默认插在最后一行
        /// </summary>
        public static void AddExcelRow(RowData rowData, ExcelWorksheet worksheet, FileInfo excelInfo, ExcelPackage target)
        {
            if (worksheet == null || rowData.ColTexts == null) return;
            var row = worksheet.Dimension.Rows + 1;
            AddExcelRow(rowData, row, false, worksheet, excelInfo, target);
        }

        /// <summary>
        /// 插入或覆盖指定行
        /// </summary>
        /// <param name="rowData">行数据</param>
        /// <param name="row">指定行数</param>
        /// <param name="IsInsert">是否需要插入</param>
        public static void AddExcelRow(RowData rowData, int row, bool IsInsert, ExcelWorksheet worksheet, FileInfo excelInfo, ExcelPackage target)
        {
            try
            {
                if (worksheet is null || rowData.ColTexts is null) return;
                if (IsInsert)
                    worksheet.InsertRow(row, 1);
                for (int i = 0; i < rowData.Columns; i++)
                {
                    object needInsertText = rowData[i];
                    if (rowData[i] == null || rowData[i].ToString() == "") needInsertText = null;
                    string _col2Text;

                    Regex r = new Regex(@"^[0-9]+$");

                    if (needInsertText != null)
                    {
                        _col2Text = needInsertText.ToString();
                        if (_col2Text == null) return;
                        if (r.Match(_col2Text).Success)
                        {
                            needInsertText = Convert.ToInt64(_col2Text);
                        }
                        worksheet.Cells[row, 1 + i].Value = needInsertText;
                        worksheet.Cells[row, 1 + i].StyleID = worksheet.Cells[row - 1, 1 + i].StyleID;
                    }
                    else
                    {
                        worksheet.Cells[row, 1 + i].Value = needInsertText;
                    }


                }

                target.SaveAs(excelInfo);
            }
            catch (Exception e)
            {

                MessageBox.Show($"请先确保你的Excel都处于关闭状态\n报错信息:{e}");
                return;
            }
        }

        /// <summary>
        /// 插入指定行 指定列的数据
        /// </summary>
        public static void SetCell(object data, int row, int col, ExcelWorksheet worksheet, FileInfo excelInfo, ExcelPackage target)
        {
            if (worksheet is null || data is null) return;
            object needInsertText = data;
            var cell = worksheet.Cells[row, col];
            cell.Value = needInsertText;
            target.SaveAs(excelInfo);
        }

        /// <summary>
        /// 插入复数行
        /// </summary>
        public static void AddExcelRows(List<RowData> rowDatas, int row, bool IsInsert, ExcelWorksheet worksheet, FileInfo excelInfo, ExcelPackage target)
        {
            if (worksheet is null || rowDatas is null) return;
            if (IsInsert)
            {
                worksheet.InsertRow(row, rowDatas.Count);
            }
            //遍历需要添加的行信息
            for (int i = 0; i < rowDatas.Count; i++)
            {
                //拿到单个行信息
                RowData rowData = rowDatas[i];
                for (int t = 0; t < rowData.Columns; t++)
                {
                    object needInsertText = rowData[t];

                    string _col2Text;

                    Regex r = new Regex(@"^[0-9]+$");

                    if (needInsertText != null)
                    {
                        _col2Text = needInsertText.ToString();
                        if (_col2Text == null) return;
                        if (r.Match(_col2Text).Success)
                        {
                            needInsertText = Convert.ToInt64(_col2Text);
                        }
                        worksheet.Cells[row + i, 1 + t].Value = needInsertText;
                        continue;
                    }
                    else
                    {
                        worksheet.Cells[row + i, 1 + t].Value = needInsertText;
                        continue;
                    }
                }
            }

            target.SaveAs(excelInfo);
        }


        /// <summary>
        /// 获取指定工作簿的名称
        /// </summary>
        /// <param name="workSheets">Excel的WorkSheets</param>
        /// <param name="sheetName">工作簿名称</param>
        /// <returns>指定名称的工作簿，如果查找失败 返回Null</returns>
        public static ExcelWorksheet GetWorksheet(this ExcelWorksheets workSheets, string sheetName)
        {
            for (int i = 0; i <= workSheets.Count; i++)
            {
                if (workSheets[i].Name == sheetName)
                {
                    return workSheets[i];
                }
            }
            return null;
        }

        /// <summary>
        /// 从工作簿中获取指定ID的行数据
        /// </summary>
        public static RowData GetRowByID(this ExcelWorksheet worksheet, int id)
        {
            RowData rowData = new RowData();
            if (worksheet == null) return rowData;
            //默认第6行拿数据
            List<RowData> datas = worksheet.GetRowDatas(6);
            if (datas == null) return rowData;
            for (int i = 0; i < datas.Count; i++)
            {
                if (datas[i][0].ToInt32() == id)
                {
                    return datas[i];
                }

            }
            return rowData;
        }

        /// <summary>
        /// 获取指定ID的行数据
        /// </summary>
        /// <param name="id">指定ID</param>
        /// <returns>行数据</returns>
        public static RowData GetRowById(this List<RowData> rowsdatas, int id)
        {
            RowData rowData = new RowData();

            if (rowsdatas == null) return rowData;

            for (int i = 0; i < rowsdatas.Count; i++)
            {
                if (rowsdatas[i][0].ToInt32() == id)
                {
                    return rowsdatas[i];
                }

            }
            return rowData;
        }

        /// <summary>
        /// 寻找指定字符串位于第几列
        /// </summary>
        /// <param name="data"></param>
        /// <param name="text"></param>
        /// <returns>位于第几列</returns>
        public static int Find(this RowData data, string text)
        {
            for (int i = 0; i < data.Columns; i++)
            {
                var dataText = data[i]?.ToString();
                if (dataText == null) return 0;

                if (dataText == text || dataText.Contains(text))
                {
                    return i;
                }
            }
            return 0;
        }

        public static ExcelData Reload(this ExcelData excelData)
        {
            (excelData, _) = LoadSPExcel(excelData.PathInfo.FullName);
            return excelData;
        }
    }


    /// <summary>
    /// 记录一整行的数据
    /// </summary>
    public struct RowData
    {
        public int index { get; set; }
        public int Columns { get; set; }
        public List<object> ColTexts { get; set; }
        public RowData(int col)
        {
            index = 0;
            Columns = col;
            ColTexts = new List<object>(col);
        }

        public object this[int num]
        {
            get
            {
                return ColTexts[num];
            }
            set
            {
                if (num > ColTexts.Count)
                {
                    return;
                }
                ColTexts[num] = value;
            }
        }
    }

    public struct ExcelData
    {
        /// <summary>
        /// Excel工作簿数据集
        /// </summary>
        public ExcelWorksheets WorkSheets;
        /// <summary>
        /// Excel路径信息
        /// </summary>
        public FileInfo PathInfo;
        /// <summary>
        /// 拿到Excel的Pack ,用于Save
        /// </summary>
        public ExcelPackage Package;
        /// <summary>
        /// 默认拿的第一个工作簿的行数据，可修改
        /// </summary>
        public List<RowData> RowDatas;
    }
}
