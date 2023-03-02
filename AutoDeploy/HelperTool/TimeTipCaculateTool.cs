using System;

namespace HelperTool
{
    internal class TimeTipCaculateTool
    {
        /// <summary>
        /// 时间戳转换为DataTime
        /// </summary>
        /// <param name="unixTimeStamp"></param>
        /// <returns></returns>
        public static DateTime TimestampToDataTime(long unixTimeStamp)
        {
            DateTime startTime = TimeZoneInfo.ConvertTimeFromUtc(new DateTime(1970, 1, 1), TimeZoneInfo.Local);
            DateTime dt = startTime.AddSeconds(unixTimeStamp);
            return dt;
        }

        /// <summary>
        /// DataTime转时间戳
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static long DataTimeToTimestamp(DateTime dateTime)
        {
            long convertTime = (long)(dateTime - new DateTime(1970, 1, 1, 8, 00, 00)).TotalSeconds;
            if (convertTime <= 0) { convertTime = -1; }
            return convertTime;
        }

    }
}
