using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deezer
{
    public partial class Favourites : Form
    {
        List<Pesma> pesme = new List<Pesma>();
        List<Pesma> dloPesme = new List<Pesma>();
        List<Pesma> favPesme = new List<Pesma>();
        List<Pesma> artists = new List<Pesma>();
        List<Album> albumi = new List<Album>();
        int whichButton = 0;
        public Favourites(List<Pesma> favouritePesme, List<Pesma> downloadPesme, List<Pesma> makeFavouritePesme, List<Album> la)
        {
            InitializeComponent();
            pesme = favouritePesme;
            dloPesme = downloadPesme;
            favPesme = makeFavouritePesme;
            albumi = la;
        }

        private void BtnDownloaded_Click(object sender, EventArgs e)
        {
            bsFavourites.DataSource = dloPesme;
            FrmFavouritesOptions frmFO = new FrmFavouritesOptions(bsFavourites, whichButton, pesme);
            frmFO.Text = "Downloaded";
            frmFO.ShowDialog();
        }

        private void BtnAlbums_Click(object sender, EventArgs e)
        {
            bsFavourites.DataSource = albumi;
            whichButton = 1;
            FrmFavouritesOptions frmFO = new FrmFavouritesOptions(bsFavourites, whichButton, pesme);
            frmFO.Text = "Albums";
            frmFO.ShowDialog();
        }

        private void BtnFavouriteTracks_Click(object sender, EventArgs e)
        {
            bsFavourites.DataSource = favPesme;
            FrmFavouritesOptions frmFO = new FrmFavouritesOptions(bsFavourites, whichButton, pesme);
            frmFO.Text = "Favourite tracks";
            frmFO.ShowDialog();
        }

        private void BtnArtists_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < pesme.Count; k++)
            {
                artists.Add(pesme[k]);
            }
            for (int i = 0; i < artists.Count; i++)
            {
                for (int j = 0; j < artists.Count; j++)
                {
                    if (i != j && artists[i].Izv.UmetnickoIme == artists[j].Izv.UmetnickoIme)
                    {
                        artists.RemoveAt(j);
                        j--;
                    }
                }
            }
            bsFavourites.DataSource = artists;
            whichButton = 2;
            FrmFavouritesOptions frmFO = new FrmFavouritesOptions(bsFavourites, whichButton, pesme);
            frmFO.Text = "Artists";
            frmFO.ShowDialog();
        }

        private void Favourites_Load(object sender, EventArgs e)
        {
            
        }
    }
}
