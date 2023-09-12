namespace backup;

public abstract class Storage
{
    public string MediaName { 
        get => MediaName; 
        set { if(value == null) throw new ArgumentNullException("MediaName");
            MediaName = value;
        }

    }
    public string ModelName { 
        get => ModelName; 
        set {
         if(value == null) throw new ArgumentNullException("ModelName");
            ModelName = value;
        }
    }

    public Storage(string mediaName, string modelName)
    {
        MediaName = mediaName;
        ModelName = modelName;
    }
    public virtual void PrintDeviceInfo(){
        Console.WriteLine("Media Name: " + MediaName);
        Console.WriteLine("Model Name: " + ModelName);
    }
}
