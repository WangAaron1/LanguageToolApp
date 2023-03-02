using Sunny.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

public partial class MonthSelectMode : UIUserControl
{
    public MonthSelectMode()
    {
        InitializeComponent();
    }

    private void MonthControler_Load(object sender, EventArgs e)
    {
        this.BackColor = Color.FromArgb(0, 0, 0, 0); // 设置窗口背景色
        monthCalendar1.SelectionStart = DateTime.Now;
    }

    #region 日期选择模块

    private bool IsStartTime;
    private bool IsEndTime;
    public DateTime ActivityTimeStart;
    public DateTime ActivityTimeEnd;
    private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
    {
        if (IsStartTime)
        {
            ActivityTimeStart = monthCalendar1.SelectionEnd;
            ActivityTimeStart = new DateTime(ActivityTimeStart.Year, ActivityTimeStart.Month, ActivityTimeStart.Day, 5, 00, 00);
            StartTimeBox.Text = ActivityTimeStart.ToString();
        }
        else if (IsEndTime)
        {
            ActivityTimeEnd = monthCalendar1.SelectionEnd;
            ActivityTimeEnd = new DateTime(ActivityTimeEnd.Year, ActivityTimeEnd.Month, ActivityTimeEnd.Day, 3, 59, 59);
            EndTimeBox.Text = ActivityTimeEnd.ToString();
        }
    }

    public void RegisterCalendar()
    {
        monthCalendar1.Visible = true;
        monthCalendar1.MouseLeave += MonthCalendar_MouseLeave;
    }

    public void CancelCalendar()
    {
        if (IsStartTime)
        {
            monthCalendar1.MinDate = monthCalendar1.SelectionEnd;
        }
        IsStartTime = false;
        IsEndTime = false;
        monthCalendar1.Visible = false;
        monthCalendar1.MouseLeave -= MonthCalendar_MouseLeave;
    }

    /// <summary>
    /// 接近文本框后显示日期选择 离开后消失
    /// </summary>
    private void StartTimeBox_Click(object sender, EventArgs e)
    {
        monthCalendar1.Location = StartTimeBox.Location + new Size(0, 25);
        monthCalendar1.MinDate = new DateTime(1970, 1, 1);
        IsStartTime = true;
        RegisterCalendar();
    }

    private void EndTimeBox_Click(object sender, EventArgs e)
    {
        monthCalendar1.Location = EndTimeBox.Location + new Size(0, 25);
        IsEndTime = true;
        RegisterCalendar();
    }

    private void MonthCalendar_MouseLeave(object sender, EventArgs e)
    {
        CancelCalendar();
    }

    #endregion

    private void StartTimeBox_TextChanged(object sender, EventArgs e)
    {

    }
}

