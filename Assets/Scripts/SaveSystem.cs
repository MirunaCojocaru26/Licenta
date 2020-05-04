using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem 
{
    public static void SaveSettings (SettingsScript obj)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/settings.txt";
        FileStream stream;
        if (!File.Exists(path))
            stream = File.Create(path);
        else
            stream = new FileStream(path, FileMode.Open);
        SettingsData data = new SettingsData(obj);

        try
        {            
            formatter.Serialize(stream, data);
        }
        catch
        {
            Debug.LogError("Some error with save path");
        }
        finally
        {
            stream.Close();
        }
    }
    public static SettingsData LoadSettings()
    {
        string path = Application.persistentDataPath + "/settings.txt";
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Open);
        try 
        {
            SettingsData data = formatter.Deserialize(stream) as SettingsData;
            return data;
        }
        catch
        {
            Debug.LogError("Some error with path");
            return null;
        }
        finally
        {
            stream.Close();
        }
    }
}
