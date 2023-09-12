namespace backup;

public class HDD :Storage, IStorage
{
    public double UsbSpeed { get => 2.0; }

     public double Memory {
        get => Memory;
        set => if(value > 0) Memory = value; 
     }

   public void CalculateStorage()
    {
        Console.WriteLine($"{Memory / 1000} gb memory");
    }


   public void Copy(double dataSize)
   {
        if (dataSize * 1000 > Memory ) throw new Exception("data not suitable for memory, need bigger memory");
        if (dataSize < 0) throw new Exception("Data size minimum 1 gb");
        
        Memory -= dataSize * 1000;
        double size = 0;
        for (int i = 0; i < dataSize ; i++)
        {
            Console.Write($"{size +=1000 } mb");
        }
        Console.WriteLine();

    }
   public void FreeMemory()
    {
        Console.WriteLine($"Free memory : {Memory} mb of free memory");
    }
    public override void PrintDeviceInfo()
    {
        base.PrintDeviceInfo();
        Console.WriteLine($"USB Speed : {UsbSpeed}");
        FreeMemory();
        CalculateStorage();
    }


    public HDD(string? mediaName, string? modelName, double memory) : base(mediaName, modelName)
    {
        Memory = memory;
    }
}
