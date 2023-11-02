using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.Controllers;
using Models;

namespace Poddprojektet1
{
    public partial class AndraPodcastensKategori : Form
    {
        Podcast podcast;
        Kategori kategoriSomTasbort;
        PodcastController podcastController;
        KategoriController kategoriController;

        public AndraPodcastensKategori(Podcast podcastAttAndra, Kategori kategoriSomTasBort)
        {
            InitializeComponent();
            podcast = podcastAttAndra;
            this.kategoriSomTasbort = kategoriSomTasBort;
            podcastController = new PodcastController();
            kategoriController = new KategoriController();
            fyllCombobox();
            setLabel();
        }

        private void fyllCombobox()
        {
            int kategoriID = kategoriSomTasbort.ID;

            var ovrigaKategorier = kategoriController.GetAllKategorier().Where(k => k.ID != kategoriID);

            foreach (Kategori item in ovrigaKategorier)
            {
                string kategori = item.Namn;
                cmbAndraKategori.Items.Add(kategori);
            }

            cmbAndraKategori.SelectedIndex = 0;
        }

        private void setLabel()
        {
            lblAndraKategori.Text = "Vänligen välj en ny kategori till podcasten " + podcast.Titel + "!";
        }

        private void lblAndraKategori_Click(object sender, EventArgs e)
        {

        }

        private void andraKategorin()
        {
            string valdKategoriNamn = cmbAndraKategori.SelectedItem?.ToString() ?? string.Empty;


            var valdKategori = kategoriController.GetAllKategorier().FirstOrDefault(k => k.Namn == valdKategoriNamn);

            if (valdKategori != null)
            {
                podcast.PodcastKategori = valdKategori;
                sparaAndringar();
            }
        }

        private void sparaAndringar()
        {
            int podcastID = podcast.ID;

            podcastController.UpdatePodcast(podcastID, podcast);
        }

        private void btnBekraftaAndradKategori_Click(object sender, EventArgs e)
        {
            andraKategorin();

            this.Dispose();
        }

        private void AndraPodcastensKategori_FormClosing(object sender, FormClosingEventArgs e)
        {
            andraKategorin();
        }
    }
}
