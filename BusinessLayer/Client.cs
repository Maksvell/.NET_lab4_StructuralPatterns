using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Client : IClient
    {
        HomeCinema cinema;// = new();

        public Client()
        {
            cinema = new HomeCinema();
        }
        
        public void SetFilmFromat()
        {
            Console.WriteLine("Встановлено режим для фільмів");
            cinema.ClassicFormats(Format.Film);
        }
        public void SetSportFromat()
        {
            Console.WriteLine("Встановлено режим для спорту");
            cinema.ClassicFormats(Format.Sport);
        }
        public void SetMusicFromat()
        {
            Console.WriteLine("Встановлено режим для музики");
            cinema.ClassicFormats(Format.Music);
        }
        public void ChangeDisk()
        {
            string disk;
            Console.WriteLine("Введіть назву диску:");
            disk = Console.ReadLine();
            cinema.ChangeDisk(disk);
        }
        public void SetCustomFormat()
        {
            string format;
            int brightness, volume;
            Console.WriteLine("Введіть формат:");
            format = Console.ReadLine();
            Console.WriteLine("Введіть рівень яскравості:");
            brightness = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть рівень гучності:");
            volume = int.Parse(Console.ReadLine());
            cinema.SetParams(format, brightness, volume);
        }
        public void GetParams()
        {
            Console.WriteLine("Нинішні параметри:");
            cinema.GetParams();
        }
    }
}
