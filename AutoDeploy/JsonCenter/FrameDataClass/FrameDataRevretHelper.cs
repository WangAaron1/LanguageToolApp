using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

public static class FrameDataRevertHelper
{
    public static void RevertAll(this ControlCollection collections, List<ControlData> revertInfos)
    {
        if (revertInfos == null)
        {
            return;
        }
        for (int i = 0; i < collections.Count; i++)
        {
            var con = collections[i];
            var reInfo = revertInfos[i];
            var typeName = collections[i].GetType().Name;

            if (typeName == "DataGridView")
            {
                var grid = con as DataGridView;
                if (grid == null) return;
                for (int j = 0; j < reInfo.RowDatas.Count; j++)
                {
                    if (reInfo.RowDatas.Any((p) => { return p == null; }))
                    {
                        continue;
                    }
                    if (j >= 1)
                    {
                        grid.Rows.Add();
                        for (int p = 0; p < 3; p++)
                        {
                            grid.Rows[j].Cells[p].Value = reInfo.RowDatas[j].Cols[p].Value.ToString();
                        }
                    }
                    else
                    {
                        for (int p = 0; p < 3; p++)
                        {
                            var info = reInfo.RowDatas[j].Cols[p];
                            if (info.TypeName == "String")
                            {
                                grid.Rows[j].Cells[p].Value = "qwe";
                            }
                        }
                    }
                }
            }
            else if (typeName == reInfo.Type)
            {
                con.Name = reInfo.Name;
                con.Text = reInfo.Description;
                con.Visible = reInfo.Visible;

            }


        }
    }
}