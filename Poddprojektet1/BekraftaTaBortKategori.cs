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
    public partial class BekraftaTaBortKategori : Form
    {
        Kategori kategoriAttTaBort;
        KategoriController kategoriControllern;
        HanteraKategorier hanterakategorier;
        PodcastController podcastController;

        public BekraftaTaBortKategori(Kategori kategori, KategoriController kategoriController, HanteraKategorier hanteraKategorier)
        {
            InitializeComponent();
            kategoriAttTaBort = kategori;
            setTextToLabel(kategoriAttTaBort);
            kategoriControllern = kategoriController;
            podcastController = new PodcastController();
            hanterakategorier = hanteraKategorier;

        }

        private void setTextToLabel(Kategori kategoriAttTaBort)
        {
            lblTaBortKategori.Text = "Är du säker på att du vill ta bort kategorin " + kategoriAttTaBort.Namn + "?";
        }


        private void btnBekraftaTaBort_Click(object sender, EventArgs e)
        {
            int kategoriID = kategoriAttTaBort.ID;


            // Hantering av podcasts som ligger inom kategorin man tar bort
            var podcastsInomKategorinManTarBort = podcastController.GetAllPodcasts().Where(p => 
            p.PodcastKategori.ID == kategoriID);

            foreach (Podcast podcast in podcastsInomKategorinManTarBort)
            {
                AndraPodcastensKategori andraKategori = new AndraPodcastensKategori(podcast, kategoriAttTaBort);
                andraKategori.Show();
            }
            
            kategoriControllern.DeleteKategori(kategoriAttTaBort.ID);
            MessageBox.Show("Kategorin har tagits bort!");
            hanterakategorier.fyllMedKategorier();
            hanterakategorier.Enabled = true;
            this.Dispose();
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            hanterakategorier.Enabled = true;
            this.Dispose();
        }
    }
}
