
using System.Collections.Generic;
using System.Windows.Forms;

public class RowDataCollection
{
    public List<ColData> Cols { get; set; }

    public static explicit operator RowDataCollection(DataGridViewRow rowData)
    {
        var datas = new RowDataCollection();
        datas.Cols = new List<ColData>();
        for (int i = 0; i < rowData.Cells.Count; i++)
        {
            var val = rowData.Cells[i].Value;
            ColData colData = new ColData();
            if (val == null)
            {
                datas.Cols.Add(colData);
                continue;
            }
            colData.Value = val.ToString();
            var type = val.GetType();
            if (type == null)
            {
                colData.TypeName = "";
            }
            else
            {
                colData.TypeName = type.Name;
            }
            datas.Cols.Add(colData);
        }
        return datas;
    }


}

public class ColData
{
    public string TypeName { get; set; }
    public string Value { get; set; }
    public ColData()
    {
        TypeName = "";
        Value = "";
    }
}