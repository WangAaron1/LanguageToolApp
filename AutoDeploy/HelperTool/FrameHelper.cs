using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public static class FrameHelper
{
    [DllImport("kernel32.dll")]
    private static extern bool SetProcessWorkingSetSize(IntPtr frame, int minsize, int maxsize);
    public static void FlushMemory()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        if (Environment.OSVersion.Platform == PlatformID.Win32NT)
        {
            SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
        }
    }

    public static void SaveControlData(this Form frame)
    {
        FrameDataJsonUtil frameData = new FrameDataJsonUtil(frame.Name);
        frameData.Instance?.Clear();
        for (int i = 0; i < frame.Controls.Count; i++)
        {
            var con = frame.Controls[i];
            ControlData control = new ControlData();
            control.Description = con.Text;
            control.Name = con.Name;
            control.Type = con.GetType().Name;
            control.Visible = con.Visible;

            //如果是列表数据空间就会记录各行数据
            if (control.Type == "DataGridView")
            {
                DataGridView view = con as DataGridView;
                if (view == null) return;
                control.RowDatas = new List<RowDataCollection>(view.ColumnCount);
                for (int t = 0; t < view?.RowCount; t++)
                {
                    control.RowDatas.Add((RowDataCollection)view.Rows[t]);
                }
            }

            frameData.Instance?.Add(control);
        }
        frameData.Save();
    }




    public static void LoadControlData(this Form frame, Action callback)
    {
        FrameDataJsonUtil frameData = new FrameDataJsonUtil(frame.Name);
        if (frameData.Instance?.Collections.Count != 0)
        {
            frame.Controls.RevertAll(frameData.Instance?.Collections);
        }
        else
        {
            callback();
        }
    }
    public static void LoadControlData(this Form frame)
    {
        FrameDataJsonUtil frameData = new FrameDataJsonUtil(frame.Name);
        if (frameData.Instance?.Collections.Count != 0)
        {
            frame.Controls.RevertAll(frameData.Instance?.Collections);
        }
        else
        {
            return;
        }
    }

    public static TreeNode CreateNewNode(this UINavMenu menu, string name, int symbol, int symbolSize, int index, UIPage page)
    {
        TreeNode node = menu.CreateNode(page);
        menu.SetNodeSymbol(node, symbol, symbolSize);
        menu.SetNodePageIndex(node, index);
        node.Text = name;

        return node;
    }

    public static TreeNode CreateNewNode(this UINavMenu menu, string name, int symbol, int symbolSize, int index)
    {
        TreeNode node = menu.CreateNode(name, symbol, symbolSize, index);
        return node;
    }

    public static TreeNode CreateNewChildNode(this UINavMenu menu, TreeNode parent, string name, int symbol, int symbolSize, int index, UIPage page)
    {
        TreeNode node = menu.CreateChildNode(parent, page);
        menu.SetNodeSymbol(node, symbol, symbolSize);
        menu.SetNodePageIndex(node, index);
        node.Text = name;

        return node;
    }
}