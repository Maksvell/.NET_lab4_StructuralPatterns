using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class HomeCinema
    {
        private TV tv;// = new();
        private DVD_Player dvd;// = new();
        private AcousticSystem acoustic;// = new();
        
        public HomeCinema()
        {
            tv = new TV();
            dvd = new DVD_Player();
            acoustic = new AcousticSystem();
        }
        public void GetParams()
        {
            tv.GetParams();
            dvd.GetParams();
            acoustic.GetParams();
        }

        public void SetParams(string format, int brightness, int volume)
        {
            tv.SetDisplayMode(format);
            tv.SetBrightness(brightness);
            acoustic.SetVolume(volume);
        }
        
        public void ChangeDisk(string disk)
        {
            dvd.InsertDisk(disk);
        }

        public void ClassicFormats(Format format)
        {
            switch (format)
            {
                case Format.Film:
                    SetParams("повний екран", 70, 80);
                    break;
                case Format.Sport:
                    SetParams("широкий екраy", 60, 60);
                    break;
                case Format.Music:
                    SetParams("фон", 1, 90);
                    break;
            }
        }
    }
}
