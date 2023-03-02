using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HelperTool
{
    public static class Extension
    {

        /// <summary>
        /// 用于查找行数据中指定的内容
        /// </summary>
        /// <param name="target"></param>
        /// <returns>返回含有指定内容的行数据</returns>
        public static RowData GetSpecData(this List<RowData> rowDatas, object target)
        {
            for (int i = 0; i < rowDatas.Count; i++)
            {
                for (int t = 0; t < rowDatas[i].Columns; t++)
                {
                    if (rowDatas[i][t] == target)
                    {
                        return rowDatas[i];
                    }
                }
            }
            return new RowData();
        }

        /// <summary>
        /// 获得一列顺延ID中值最大的行数据
        /// </summary>
        public static RowData GetMaxID(this List<RowData> rowDatas, int colNum, int rowIndex)
        {
            for (int i = rowIndex; i < rowDatas.Count; i++)
            {
                if (rowDatas[i][colNum].ToInt32() > rowDatas[i + 1][colNum].ToInt32())
                {
                    return rowDatas[i];
                }
            }
            return new RowData();
        }
        public static int GetHeaderIndex(this RowData headerRow, string headerName)
        {
            for (int i = 0; i < headerRow.Columns; i++)
            {
                if (headerRow[i].ToString() == headerName)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// 获取目前表格中 以IndexID开头最大的ID，主要应用在Item表中
        /// </summary>
        public static RowData GetMaxNum(this List<RowData> itemsData, int indexID, int startID)
        {
            if (itemsData == null) return new RowData();

            RowData _baseItem = itemsData.GetRowById(startID);

            if (_baseItem.ColTexts == null) return new RowData();

            object _item = _baseItem[0];

            if (_item == null) return new RowData();

            string _itemID = _item.ToString();

            if (_itemID == null) return new RowData();

            while (_itemID.Contains(indexID.ToString()))
            {
                var _normalitem = itemsData.GetRowById(startID);

                if (_normalitem.ColTexts == null) break;

                _item = _normalitem[0];

                if (_item == null) break;

                _itemID = _item.ToString();

                if (_itemID == null) break;

                startID++;
            }

            if (startID != 0)
            {
                return itemsData.GetRowById(startID - 1);
            }

            return new RowData();
        }
        public static int ToInt32(this object obj)
        {
            return Convert.ToInt32(obj);
        }
        public static long ToInt64(this object obj)
        {
            return Convert.ToInt64(obj);
        }

        public static int ToInt32(this string obj)
        {
            if (obj.All(char.IsDigit))
            {
                return Convert.ToInt32(obj);
            }
            return 0;
        }

        public static List<RowData> ConvertDataGrid2RowData(this DataGridView dataGridView)
        {
            List<RowData> rowDatas = new List<RowData>(dataGridView.Rows.Count);

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                RowData rowdata = new RowData(dataGridView.Columns.Count);
                for (int t = 0; t < dataGridView.Columns.Count; t++)
                {
                    if (rowdata.ColTexts == null) return new List<RowData>();

                    rowdata.ColTexts.Add(dataGridView.Rows[i].Cells[t].Value);
                }
                if (rowdata.ColTexts.Any(obj => obj != null))
                {
                    rowDatas.Add(rowdata);
                }
            }
            return rowDatas;
        }

        public static bool IsGridEmpty(this DataGridView dataGridView)
        {
            int emptyCount = 0;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int t = 0; t < dataGridView.Columns.Count; t++)
                {
                    var gridValue = dataGridView.Rows[i].Cells[t].Value;
                    if (gridValue == null || gridValue.ToString() == "")
                    {
                        emptyCount++;
                        continue;
                    }
                }
            }
            if (emptyCount == dataGridView.RowCount * dataGridView.ColumnCount)
            {
                return true;
            }
            return false;
        }



    }
}
