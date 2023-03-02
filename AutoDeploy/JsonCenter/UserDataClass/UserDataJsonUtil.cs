using System;

public class UserDataJsonUtil : JsonUtil<UserDataCenter>
{
    public UserDataJsonUtil() : base()
    {

    }

    public string GetPath(string userName)
    {
        if (Instance == null) return "";
        if (!this.Instance.UserDatas.ContainsKey(userName))
        {
            return "";
        }
        return Instance.UserDatas[userName].ExcelPath;
    }

    internal void CheckUser(string userName, string path)
    {
        LoadJson();
        if (Instance == null) return;
        if (!this.Instance.UserDatas.ContainsKey(userName))
        {
            this.Instance?.Add(userName, new UserData
            {
                ExcelPath = path,
                LastUseTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Second, DateTime.Now.Minute)
            });
        }
        else
        {
            this.Instance.UserDatas[userName] = new UserData
            {

                ExcelPath = path,
                LastUseTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Second, DateTime.Now.Minute)

            };
        }
    }
}