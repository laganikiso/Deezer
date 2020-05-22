using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deezer
{
    public enum Zanr
    {
        Rap = 1,
        RnB,
        Pop,
        Classic,
        Jazz,
        Rock,
        Metal,
        Electronic,
        Blues
    }
    public class Pesma
    {
        private string duzina;
        public string Duzina
        {
            get { return duzina; }
            set { duzina = value; }
        }
        private string naziv;
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
        private Izvodjac izv;

        public Izvodjac Izv
        {
            get { return izv; }
            set { izv = value; }
        }
        public string GetImeIzvodjaca
        {
            get => Izv.UmetnickoIme;
        }
        private Zanr zanrPesme;
        public Zanr ZanrPesme
        {
            get { return zanrPesme; }
            set { zanrPesme = value; }
        }

        public Pesma()
        {
            duzina = "";
            naziv = "";
            izv = null;
        }
        public Pesma(string duzina, string naziv, Izvodjac izv, Zanr zanrPesme)
        {
            Duzina = duzina;
            Naziv = naziv;
            Izv = izv;
            ZanrPesme = zanrPesme;
        }
    }
}
