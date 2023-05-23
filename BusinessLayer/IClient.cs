using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IClient
    {
        public void SetFilmFromat();
        public void SetSportFromat();
        public void SetMusicFromat();
        public void ChangeDisk();
        public void SetCustomFormat();
        public void GetParams();

    }
}
