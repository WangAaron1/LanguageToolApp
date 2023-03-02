using System.Collections.Generic;

public class FrameDataCenter
{
    public List<ControlData> Collections { get; set; }

    public FrameDataCenter()
    {
        Collections = new List<ControlData>();
    }
    public void Add(ControlData one)
    {
        Collections.Add(one);
    }

    public void Remove(ControlData one)
    {
        Collections.Remove(one);

    }
    public void Clear()
    {
        Collections.Clear();

    }



}

public class ControlData
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }

    public bool Visible { get; set; }

    public List<RowDataCollection> RowDatas { get; set; }

    public ControlData()

    {
        Name = string.Empty;
        Description = string.Empty;
        Type = string.Empty;
        RowDatas = new List<RowDataCollection>();
        Visible = false;
    }
}