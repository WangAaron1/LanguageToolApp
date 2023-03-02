using System.Threading;

namespace HelperTool
{
    public class ThreadFactory
    {
        public static Thread CheckHeroID;
        public static ThreadStart s_CheckHeroID = new ThreadStart(() => { });

    }
}
