using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TV
    {
        private string Format = "default";
        private int Brightness = 75;
        public void SetDisplayMode(string format)
        {
            Format = format;
            Console.WriteLine("Режим відображення встановлено: " + format);
        }
        public void SetBrightness(int level)
        {
            if (level < 1 || level > 100) Console.WriteLine("Wrong level");
            else
            {
                Brightness = level;
                Console.WriteLine("Яскравість встановлено: " + level);
            }
        }
        public void GetParams()
        {
            Console.WriteLine("Режим відображення: " + Format);
            Console.WriteLine("Яскравість: " + Brightness);
        }
    }
    
    public class DVD_Player
    {
        private string Disk = "none";
        public void InsertDisk(string disk)
        {
            Disk = disk;
            Console.WriteLine("Диск вставлено: " + disk);
        }
        public void GetParams()
        {
            Console.WriteLine("Нинішній диск: " + Disk);
        }
    }

    public class AcousticSystem
    {
        private int Volume = 75;
        public void SetVolume(int level)
        {
            if (level < 1 || level > 100) Console.WriteLine("Wrong level");
            else
            {
                Volume = level;
                Console.WriteLine("Гучність встановлено: " + level);
            }
        }
        public void GetParams()
        {
            Console.WriteLine("Гучність: " + Volume);
        }
    }
}
