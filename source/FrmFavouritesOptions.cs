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
    public partial class FrmFavouritesOptions : Form
    {
        //
        List<Pesma> tempLista = new List<Pesma>();
        List<Pesma> artPesme = new List<Pesma>();
        List<Pesma> sPesme = new List<Pesma>();
        //
        List<Album> openAlbum = new List<Album>();
        Album tempAlbum = new Album();
        int brojOpcija;
        public FrmFavouritesOptions(BindingSource bs, int broj, List<Pesma> svePesme)
        {
            InitializeComponent();
            brojOpcija = broj;
            bsFavouritesOptions = bs;
            sPesme = svePesme;
            lbFavouriteOptions.DataSource = bsFavouritesOptions;
            if (brojOpcija == 1)
            {
                btnOpen.Visible = true;
                btnBack.Visible = true;
                openAlbum = (List<Album>)bsFavouritesOptions.DataSource;
                lbFavouriteOptions.DisplayMember = "NazivAlbuma";
            }
            if (brojOpcija == 2)
            {
                btnOpen.Visible = true;
                btnBack.Visible = true;
                artPesme = (List<Pesma>)bsFavouritesOptions.DataSource;
                lbFavouriteOptions.DisplayMember = "GetImeIzvodjaca";
            }
            else
            {
                lbFavouriteOptions.DisplayMember = "Naziv";
            }
        }
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (brojOpcija == 1)
            {
                for (int i = 0; i < lbFavouriteOptions.Items.Count; i++)
                {
                    if (lbFavouriteOptions.SelectedIndex == i)
                    {
                        tempAlbum = openAlbum[i];
                        bsFavouritesOptions.DataSource = tempAlbum.AlbumPesme;
                        lbFavouriteOptions.DisplayMember = "Naziv";
                        tempAlbum = null;
                    }
                }
            }
            else
            {
                tempLista.Clear();
                for (int i = 0; i < sPesme.Count; i++)
                {
                    if (sPesme[i].Izv.UmetnickoIme == artPesme[lbFavouriteOptions.SelectedIndex].Izv.UmetnickoIme)
                    {
                        tempLista.Add(sPesme[i]);
                    }
                }
                bsFavouritesOptions.DataSource = tempLista;
                lbFavouriteOptions.DisplayMember = "Naziv";
            }
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (brojOpcija == 1)
            {
                bsFavouritesOptions.DataSource = openAlbum;
                lbFavouriteOptions.DisplayMember = "NazivAlbuma";
            }
            else
            {
                bsFavouritesOptions.DataSource = artPesme;
                lbFavouriteOptions.DisplayMember = "GetImeIzvodjaca";
            }
        }
        private void FrmFavouritesOptions_Load(object sender, EventArgs e)
        {

        }
    }
}
