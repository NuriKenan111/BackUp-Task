
namespace backup;
public class Dwd :Storage, IStorage
{
    public double ReadWriteSpeed { get => 9.0; }

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
            if (dataSize * 1000 > Memory ) throw new InvalidOperationException();
            if (dataSize < 0) throw new ArgumentOutOfRangeException();
            Memory -= dataSize * 1000;
            double size = 0;
            for (int i = 0; i < dataSize; i++)
                Console.WriteLine($"Dvd: {size += 1000} mb");
            Console.ReadLine();
     }

    public void FreeMemory() => Console.WriteLine($"You have {memory} mb free space");
    
    public override void PrintDeviceInfo()
    {
        base.PrintDeviceInfo();
        Console.WriteLine($"ReadWrite Speed : {ReadWriteSpeed}");
        FreeMemory();
        CalculateStorage();
    }
    
    public DVD(string mediaName, string modelName, double memory) : base(mediaName, modelName)
    {
        Memory = memory;
    }
}

