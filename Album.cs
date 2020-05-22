using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deezer
{
    public class Album
    {
        private string nazivAlbuma;
        public string NazivAlbuma
        {
            get { return nazivAlbuma; }
            set { nazivAlbuma = value; }
        }

        private List<Pesma> albumPesme = new List<Pesma>();
        public List<Pesma> AlbumPesme
        {
            get { return albumPesme; }
            set { albumPesme = value; }
        }

        public Album()
        {
            nazivAlbuma = null;
        }

        public Album(string nazivAlbuma)
        {
            NazivAlbuma = nazivAlbuma;
        }
    }
}
