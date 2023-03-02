using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBPushApkTool
{
    public static class CmdEventHandler
    {
        //cmd指令开始事件
        public delegate void CommandStart();
        public static CommandEnd c_start;
        //cmd指令结束事件
        public delegate void CommandEnd();
        public static CommandEnd c_end;

    }
}
