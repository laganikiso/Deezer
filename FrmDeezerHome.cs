using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Media;

namespace Deezer
{
    public partial class FrmDeezerHome : Form
    {
        
        public FrmDeezerHome()
        {
            InitializeComponent();
            Init();
        }
        Pesma rap1 = new Pesma("3:24", "Cash Money", new Izvodjac("Tyga", 2921326), Zanr.Rap);
        Pesma rap2 = new Pesma("2:10", "Eyes Closed", new Izvodjac("Tyga", 2921326), Zanr.Rap);
        Pesma rap3 = new Pesma("3:50", "1 of 1", new Izvodjac("Tyga", 2921326), Zanr.Rap);
        Pesma rap4 = new Pesma("3:30", "Switch Lanes", new Izvodjac("Tyga", 2921326), Zanr.Rap);
        Pesma rap5 = new Pesma("4:35", "For The Road", new Izvodjac("Tyga", 2921326), Zanr.Rap);
        Pesma rnb1 = new Pesma("3:34", "Anyone But Me", new Izvodjac("Joy Crookes", 15345), Zanr.RnB);
        Pesma rnb2 = new Pesma("4:34", "For Now", new Izvodjac("Zsela", 5345), Zanr.RnB);
        Pesma jazz1 = new Pesma("3:21", "Blackberry Winter", new Izvodjac("Keith Jarrett", 26789), Zanr.Jazz);
        Pesma jazz2 = new Pesma("4:21", "From This Place", new Izvodjac("Pat Metheny", 789), Zanr.Jazz);
        Pesma electronic1 = new Pesma("2:59", "Tell The World", new Izvodjac("Norman Doray", 123344), Zanr.Electronic);
        Pesma electronic2 = new Pesma("4:01", "Get Together", new Izvodjac("DJ Dove", 2344), Zanr.Electronic);
        Pesma pop1 = new Pesma("2:33", "Intentions", new Izvodjac("Justin Miller", 245621), Zanr.Pop);
        Pesma pop2 = new Pesma("3:23", "Colors", new Izvodjac("Black Pumas", 11233), Zanr.Pop);
        Pesma rock1 = new Pesma("2:44", "Lucille", new Izvodjac("Little Richard", 281), Zanr.Rock);
        Pesma rock2 = new Pesma("3:33", "Alive", new Izvodjac("Pearl Jam", 1281), Zanr.Rock);
        Pesma classic1 = new Pesma("3:58", "Melody", new Izvodjac("Sheku Mason", 4512), Zanr.Classic);
        Pesma classic2 = new Pesma("2:49", "Room With A View", new Izvodjac("Yiruma", 212), Zanr.Classic);
        Pesma metal1 = new Pesma("3:18", "Bommbtrack", new Izvodjac("Rage Against the Machine", 6788), Zanr.Metal);
        Pesma metal2 = new Pesma("4:23", "Pull The Plug", new Izvodjac("Death", 5788), Zanr.Metal);
        Pesma blues1 = new Pesma("3:48", "Spirit", new Izvodjac("Philip Sayce", 1788), Zanr.Blues);
        Pesma blues2 = new Pesma("4:22", "Poor Old John", new Izvodjac("Dan Patlansky", 123788), Zanr.Blues);
        Album tygaBITS = new Album("Bitch I'm The Shit 2");
        Album tygaHC = new Album("Hotel California");
        List<Pesma> listaPesama = new List<Pesma>();
        List<Pesma> temporary = new List<Pesma>();
        List<Pesma> download = new List<Pesma>();
        List<Pesma> favourtieMusic = new List<Pesma>();
        List<Album> listaAlbuma = new List<Album>();
        private void Init()
        {
            /*listaPesama.Add(rap1);
            listaPesama.Add(rap2);
            listaPesama.Add(rap3);
            listaPesama.Add(rap4);
            listaPesama.Add(rap5);
            listaPesama.Add(rnb1);
            listaPesama.Add(rnb2);
            listaPesama.Add(jazz1);
            listaPesama.Add(jazz2);
            listaPesama.Add(electronic1);
            listaPesama.Add(electronic2);
            listaPesama.Add(pop1);
            listaPesama.Add(pop2);
            listaPesama.Add(rock1);
            listaPesama.Add(rock2);
            listaPesama.Add(classic1);
            listaPesama.Add(classic2);
            listaPesama.Add(metal1);
            listaPesama.Add(metal2);
            listaPesama.Add(blues1);
            listaPesama.Add(blues2);*/
            XmlSerializer mojXmlSer = new XmlSerializer(typeof(List<Pesma>));
            StreamReader streamReader = new StreamReader(Environment.CurrentDirectory + "\\myxml.xml");
            listaPesama = (List<Pesma>)mojXmlSer.Deserialize(streamReader);
            streamReader.Close();

            tygaBITS.AlbumPesme.Add(rap2);
            tygaBITS.AlbumPesme.Add(rap3);
            tygaHC.AlbumPesme.Add(rap4);
            tygaHC.AlbumPesme.Add(rap5);
            listaAlbuma.Add(tygaBITS);
            listaAlbuma.Add(tygaHC);
            bsDeezer.DataSource = listaPesama;
            lbDeezerHome.DataSource = bsDeezer;
            lbDeezerHome.DisplayMember = "Naziv";
        }
        private void BtnMusic_Click(object sender, EventArgs e)
        {
            FrmMusic frmM = new FrmMusic(listaPesama, download, favourtieMusic);
            frmM.ShowDialog();
        }

        private void BtnFavourites_Click(object sender, EventArgs e)
        {
            Favourites frmF = new Favourites(listaPesama, download, favourtieMusic, listaAlbuma);
            frmF.ShowDialog();
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            string liveSearchDeezerHome = tbSearch.Text;
            temporary = listaPesama.FindAll(x => x.Naziv.Contains(liveSearchDeezerHome));
            bsDeezer.DataSource = temporary;
            temporary.Clear();
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbDeezerHome.Items.Count; i++)
            {
                if (lbDeezerHome.SelectedIndex == i)
                {
                    foreach (Pesma song in download)
                    {
                        if (lbDeezerHome.SelectedItem == song)
                        {
                            return;
                        }
                    }
                    download.Add(listaPesama[i]);
                }
            }
        }

        private void BtnMakeFavourite_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbDeezerHome.Items.Count; i++)
            {
                if (lbDeezerHome.SelectedIndex == i)
                {
                    foreach (Pesma song in favourtieMusic)
                    {
                        if (lbDeezerHome.SelectedItem == song)
                        {
                            return;
                        }
                    }
                    favourtieMusic.Add(listaPesama[i]);
                }
            }
        }

        private void BtnSerialize_Click(object sender, EventArgs e)
        {
            Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\myxml.xml");
            XmlSerializer mojXmlSer = new XmlSerializer(typeof(List<Pesma>));
            mojXmlSer.Serialize(stream, listaPesama);
            stream.Close();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\Korisnik\Amuzika\1of1.wav");
            soundPlayer.Play();
        }
        private void BtnPause_Click(object sender, EventArgs e)
        {
        }
        private void FrmDeezerHome_Load(object sender, EventArgs e)
        {

        }
    }
}
