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
    public partial class FrmMusic : Form
    {
        List<Pesma> pesme = new List<Pesma>();
        List<Pesma> dloPesme = new List<Pesma>();
        List<Pesma> favPesme = new List<Pesma>();
        List<Pesma> temp = new List<Pesma>();
        public FrmMusic(List<Pesma> musicPesme, List<Pesma> favouritePesme, List<Pesma> downloadPesme)
        {
            InitializeComponent();
            pesme = musicPesme;
            dloPesme = downloadPesme;
            favPesme = favouritePesme;
        }
        
        public List<Pesma> Temp
        {
            get { return temp; }
            set { temp = value; }
        }

        private void BtnRap_Click(object sender, EventArgs e)
        {
            temp.Clear();
            foreach (Pesma p in pesme)
            {
                if (p.ZanrPesme == Zanr.Rap)
                {
                    temp.Add(p);
                }
            }
            bsMusic.DataSource = temp;
            FrmMusicOptions frmMO = new FrmMusicOptions(bsMusic, dloPesme, favPesme);
            frmMO.Text = "Rap";
            frmMO.ShowDialog();
        }

        private void BtnRnB_Click(object sender, EventArgs e)
        {
            temp.Clear();
            foreach (Pesma p in pesme)
            {
                if (p.ZanrPesme == Zanr.RnB)
                {
                    temp.Add(p);
                }
            }
            bsMusic.DataSource = temp;
            FrmMusicOptions frmMO = new FrmMusicOptions(bsMusic, dloPesme, favPesme);
            frmMO.Text = "RnB";
            frmMO.ShowDialog();
        }

        private void BtnPop_Click(object sender, EventArgs e)
        {
            temp.Clear();
            foreach (Pesma p in pesme)
            {
                if (p.ZanrPesme == Zanr.Pop)
                {
                    temp.Add(p);
                }
            }
            bsMusic.DataSource = temp;
            FrmMusicOptions frmMO = new FrmMusicOptions(bsMusic, dloPesme, favPesme);
            frmMO.Text = "Pop";
            frmMO.ShowDialog();
        }

        private void BtnClassic_Click(object sender, EventArgs e)
        {
            temp.Clear();
            foreach (Pesma p in pesme)
            {
                if (p.ZanrPesme == Zanr.Classic)
                {
                    temp.Add(p);
                }
            }
            bsMusic.DataSource = temp;
            FrmMusicOptions frmMO = new FrmMusicOptions(bsMusic, dloPesme, favPesme);
            frmMO.Text = "Classic";
            frmMO.ShowDialog();
        }

        private void BtnJazz_Click(object sender, EventArgs e)
        {
            temp.Clear();
            foreach (Pesma p in pesme)
            {
                if (p.ZanrPesme == Zanr.Jazz)
                {
                    temp.Add(p);
                }
            }
            bsMusic.DataSource = temp;
            FrmMusicOptions frmMO = new FrmMusicOptions(bsMusic, dloPesme, favPesme);
            frmMO.Text = "Jazz";
            frmMO.ShowDialog();
        }

        private void BtnRock_Click(object sender, EventArgs e)
        {
            temp.Clear();
            foreach (Pesma p in pesme)
            {
                if (p.ZanrPesme == Zanr.Rock)
                {
                    temp.Add(p);
                }
            }
            bsMusic.DataSource = temp;
            FrmMusicOptions frmMO = new FrmMusicOptions(bsMusic, dloPesme, favPesme);
            frmMO.Text = "Rock";
            frmMO.ShowDialog();
        }

        private void BtnMetal_Click(object sender, EventArgs e)
        {
            temp.Clear();
            foreach (Pesma p in pesme)
            {
                if (p.ZanrPesme == Zanr.Metal)
                {
                    temp.Add(p);
                }
            }
            bsMusic.DataSource = temp;
            FrmMusicOptions frmMO = new FrmMusicOptions(bsMusic, dloPesme, favPesme);
            frmMO.Text = "Metal";
            frmMO.ShowDialog();
        }

        private void BtnElectronic_Click(object sender, EventArgs e)
        {
            temp.Clear();
            foreach (Pesma p in pesme)
            {
                if (p.ZanrPesme == Zanr.Electronic)
                {
                    temp.Add(p);
                }
            }
            bsMusic.DataSource = temp;
            FrmMusicOptions frmMO = new FrmMusicOptions(bsMusic, dloPesme, favPesme);
            frmMO.Text = "Electronic";
            frmMO.ShowDialog();
        }

        private void BtnBlues_Click(object sender, EventArgs e)
        {
            temp.Clear();
            foreach (Pesma p in pesme)
            {
                if (p.ZanrPesme == Zanr.Blues)
                {
                    temp.Add(p);
                }
            }
            bsMusic.DataSource = temp;
            FrmMusicOptions frmMO = new FrmMusicOptions(bsMusic, dloPesme, favPesme);
            frmMO.Text = "Blues";
            frmMO.ShowDialog();
        }

        private void FrmMusic_Load(object sender, EventArgs e)
        {

        }
    }
}
