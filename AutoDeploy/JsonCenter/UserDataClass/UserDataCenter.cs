using System;
using System.Collections.Generic;

public class UserDataCenter
{
    public Dictionary<string, UserData> UserDatas { get; set; }

    public UserDataCenter() => UserDatas = new Dictionary<string, UserData>();
    public void Add(string name, UserData data)
    {
        UserDatas.Add(name, data);
    }
}

public class UserData
{
    public string ExcelPath { get; set; }
    public DateTime LastUseTime { get; set; }
    public UserData()
    {
        ExcelPath = "";
        LastUseTime = DateTime.Now;
    }
}