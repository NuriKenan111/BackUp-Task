using backup;

FlashCard fc = new FlashCard("Flash Card", "Model 1", 5000);
fc.Copy(2);

Thread.Sleep(500);
fc.PrintDeviceInfo();

Dwd dvd = new Dwd("DVD ", "Model 2", 10000);
dvd.Copy(4);
Thread.Sleep(1000);
dvd.PrintDeviceInfo();


HDD hdd = new HDD("HDD ", "Model 3", 100000);
hdd.Copy(15);
Thread.Sleep(1000);
hdd.PrintDeviceInfo();



                    