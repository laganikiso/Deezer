using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deezer
{
    public class Izvodjac
    {
        private string umetnickoIme;
        public string UmetnickoIme
        {
            get { return umetnickoIme; }
            set { umetnickoIme = value; }
        }
        private int brojFanova;
        public int BrojFanova
        {
            get { return brojFanova; }
            set { brojFanova = value; }
        }

        public Izvodjac()
        {
            umetnickoIme = "";
            brojFanova = 0;
        }
        public Izvodjac(string umetnickoIme, int brojFanova)
        {
            UmetnickoIme = umetnickoIme;
            BrojFanova = brojFanova;
        }
    }
}
