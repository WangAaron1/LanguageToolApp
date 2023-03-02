using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ADBPushApkTool
{
    public static class Commands
    {
        private static ApkPush_Tool mainForm;

        static Commands()
        {
            mainForm = ApkPush_ToolHelpers.GetFormInfo();
        }
        /// <summary>
        /// 获取Devices的List
        /// </summary>
        /// <returns></returns>
        public static MatchCollection GetPackagesNameList()
        {
            var deviceName = Regex.Replace(mainForm.Devices.SelectedItem.ToString(), @"\(.*\)", "");
            var log = CmdCommandCenter.DoSimpleCommand("adb.exe",$"-s {deviceName} shell pm list packages -3",6000,false);
            var packNames = Regex.Matches(log, @"com\.sunborn.*(?=\r)");
            return packNames;
        }
        /// <summary>
        /// 连接至MuMu模拟器，生命周期也是至Application Exit为止
        /// </summary>
        public static void Connect2Simulator()
        {
            string error = string.Empty;
            string currentSelect = mainForm.SimulatorsCheckPoint.Items[mainForm.SimulatorsCheckPoint.SelectedIndex].ToString();
            var simulatorName = Regex.Match(currentSelect,@"\(.*\)");
            var checkPoint = currentSelect.Replace(simulatorName.Value,"");
            var simulator = CmdCommandCenter.DoSimpleCommand("adb.exe", $"connect 127.0.0.1:{checkPoint}", -1, true);
            if (simulator.Contains("already"))
            {
                error = CmdCommandCenter.DoSimpleCommand("adb.exe","devices",-1,true);
            }
            if (error.Contains("offline") || simulator.Contains("failed"))
            {
                mainForm.CmdInfoWin.Text = $"{simulatorName}已离线";
                return;
            }
            mainForm.CmdInfoWin.Text = simulator;
        }
    }
}
