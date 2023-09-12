namespace backup;

public interface IStorage
{
        void CalculateStorage();
        void Copy(double dataSize);
        void FreeMemory();
        void PrintDeviceInfo();
}
