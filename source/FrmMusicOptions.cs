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
    public partial class FrmMusicOptions : Form
    {
        List<Pesma> musicListaPesama = new List<Pesma>();
        List<Pesma> musicTemporary = new List<Pesma>();
        List<Pesma> dloPesme = new List<Pesma>();
        List<Pesma> favPesme = new List<Pesma>();
        public FrmMusicOptions(BindingSource bs, List<Pesma> favouritePesme, List<Pesma> downloadPesme)
        {
            InitializeComponent();
            dloPesme = downloadPesme;
            favPesme = favouritePesme;
            bsMusicOptions = bs;
            musicListaPesama = (List<Pesma>)bsMusicOptions.DataSource;
            lbMusicOptions.ResetText();
            lbMusicOptions.DataSource = bsMusicOptions;
            lbMusicOptions.DisplayMember = "Naziv";
        }

        private void TbSearchMusic_TextChanged(object sender, EventArgs e)
        {
            string liveSearchMusicOptions = tbSearchMusic.Text;
            musicTemporary = musicListaPesama.FindAll(x => x.Naziv.Contains(liveSearchMusicOptions));
            bsMusicOptions.DataSource = musicTemporary;
            musicTemporary.Clear();
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbMusicOptions.Items.Count; i++)
            {
                if (lbMusicOptions.SelectedIndex == i)
                {
                    foreach (Pesma song in dloPesme)
                    {
                        if (lbMusicOptions.SelectedItem == song)
                        {
                            return;
                        }
                    }
                    dloPesme.Add(musicListaPesama[i]);
                }
            }
        }

        private void BtnFavourite_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbMusicOptions.Items.Count; i++)
            {
                if (lbMusicOptions.SelectedIndex == i)
                {
                    foreach (Pesma song in favPesme)
                    {
                        if (lbMusicOptions.SelectedItem == song)
                        {
                            return;
                        }
                    }
                    favPesme.Add(musicListaPesama[i]);
                }
            }
        }
        private void FrmMusicOptions_Load(object sender, EventArgs e)
        {

        }
    }
}
