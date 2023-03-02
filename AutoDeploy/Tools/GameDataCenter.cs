using HelperTool;
using System;

public class GameDataCenter
{
    public GameDataCenter() { }
    public static int Activity_1_MaXID()
    {
        int activityLatestID = 0;
        var activityData = ExcelPathConst.e_Activity;
        if (activityData.WorkSheets == null) return 0;
        activityData.RowDatas = activityData.WorkSheets.GetWorksheet("activity_1").GetRowDatas(6);
        if (activityData.Package == null) return 0;
        for (int i = 0; i < activityData.RowDatas?.Count; i++)
        {
            var id = activityData.RowDatas?[i][0];
            if (id == null) return 0;
            //剔除一下 回归活动和回顾基金活动
            if (id.ToString() == "8001" || id.ToString() == "1101")
            {
                continue;
            }
            activityLatestID = Math.Max(activityLatestID, Convert.ToInt32(id));
        }
        return activityLatestID;
    }
}