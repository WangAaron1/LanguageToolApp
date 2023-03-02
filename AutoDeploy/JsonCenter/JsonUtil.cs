using System;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Windows.Forms;

public abstract class JsonUtil<T> : IDisposable where T : class, new()
{

    public string Path = "";

    public string JSON_Stirng = "";

    public T Instance;

    private JsonSerializerOptions _options = new JsonSerializerOptions
    {
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        WriteIndented = true
    };

    public JsonUtil()
    {

        Path = Application.StartupPath;
        if (!Path.EndsWith("\\"))
        {
            Path = string.Concat(Path, "\\");
        }
        if (Path == null || Path.Length == 0) return;
        if (!Path.EndsWith(".json")) Path += $"{typeof(T).Name}.json";

        Instance = new T();

        if (!File.Exists(Path))
        {
            var jsonStream = File.Create(Path);
            jsonStream.Close();
        }
        else
        {
            LoadJson();
        }
    }
    public JsonUtil(string jsonName)
    {

        Path = Application.StartupPath;
        if (Path == null || Path.Length == 0) return;
        if (!Path.EndsWith(".json")) Path += $"{jsonName}.json";

        Instance = new T();

        if (!File.Exists(Path))
        {
            var jsonStream = File.Create(Path);
            jsonStream.Close();
        }
        else
        {
            LoadJson();
        }
    }
    internal string LoadJson()
    {
        JSON_Stirng = File.ReadAllText(Path);
        if (JSON_Stirng == "" || JSON_Stirng.Length == 0) return "";
        Instance = JsonSerializer.Deserialize<T>(JSON_Stirng);
        return JSON_Stirng;
    }

    public void Save()
    {
        var infos = JsonSerializer.Serialize(Instance, _options);
        File.WriteAllText(Path, infos);
    }
    public void Delete()
    {
        File.Delete(Path);
        Instance = null;

    }
    public bool CheckFile()
    {
        if (File.Exists(Path))
        {
            return true;
        }
        return false;
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}
