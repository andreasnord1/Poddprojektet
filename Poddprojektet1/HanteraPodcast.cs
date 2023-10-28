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
using BusinessLogicLayer;
using DataAccessLayer.Repositories;
using Models;

namespace Poddprojektet1
{
    public partial class HanteraPodcast : Form
    {

        private KategoriController kategoriController;
        private PodcastController podcastController;

        public HanteraPodcast()
        {
            InitializeComponent();
            kategoriController = new KategoriController(new KategoriRepository());
            podcastController = new PodcastController();
            fyllMedKategorier();
        }

        private void btnRadera_Click(object sender, EventArgs e)
        {

            try
            {
                if (gridPodcasts.SelectedRows.Count > 0)
                {
                    // Hämta den valda podcasten från gridPodcasts : DataGridView
                    var selectedPodcast = gridPodcasts.SelectedRows[0].DataBoundItem as Podcast;

                    // Anropa PodcastController för att radera podcasten baserat på dess ID

                    if (selectedPodcast != null)
                    {

                        podcastController.DeletePodcast(selectedPodcast.ID);


                        // Uppdatera gridPodcasts : DataGridView efter radering
                        gridPodcasts.DataSource = null; // Ta bort datakällan
                        gridPodcasts.DataSource = podcastController.GetAllPodcasts(); // Fyll på igen med uppdaterad data

                        MessageBox.Show("Den valda Podcasten har nu raderats!");

                    }

                }
                else
                {
                    MessageBox.Show("Vänligen välj en podcast att radera.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Fyll DataGridView
        private void gridPodcasts_Load(object sender, EventArgs e)
        {
            List<Podcast> podcasts = podcastController.GetAllPodcasts();
            gridPodcasts.DataSource = podcasts;
        }

        private void fyllMedKategorier()
        {
            IEnumerable<Kategori> kategorier = kategoriController.GetAllKategorier();
            cmbKategori.Items.Clear();

            foreach (Kategori item in kategorier)
            {
                string kategori = item.Namn;
                cmbKategori.Items.Add(kategori);
            }
        }


        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAndraKategori_Click(object sender, EventArgs e)
        {
            try
            {
                // Kontrollera att en podcast och en kategori har valts
                if (gridPodcasts.SelectedRows.Count == 0 || cmbKategori.SelectedItem == null)
                {
                    MessageBox.Show("Vänligen välj ett RSS-flöde och en ny kategori.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hämta det valda RSS-flödet från DataGridView
                var selectedPodcast = gridPodcasts.SelectedRows[0].DataBoundItem as Podcast;

                if (selectedPodcast == null)
                {
                    throw new InvalidOperationException("Ingen podcast vald eller ogiltig podcast-information.");
                }

                // Hämta den valda nya kategorin
                string newCategoryName = cmbKategori.SelectedItem?.ToString() ?? string.Empty;
                if (string.IsNullOrEmpty(newCategoryName))
                {
                    MessageBox.Show("Ingen kategori vald.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Hämta kategori-ID för den valda podcasten
                int existingKategoriId = selectedPodcast.KategoriID;

                Kategori existingKategori = kategoriController.GetKategoriById(existingKategoriId);
                if (existingKategori == null)
                {
                    throw new Exception("Kategorin hittades inte.");
                }


                // Förbered den uppdaterade kategorin
                Kategori updatedKategori = new Kategori(existingKategoriId, newCategoryName);


                // Uppdatera kategorin genom KategoriController
                kategoriController.UpdateKategori(existingKategoriId, updatedKategori);

                // Reflektera ändringen i podcastens kategoriinformation
                selectedPodcast.PodcastKategori = updatedKategori; // Eller uppdatera listan/gridden om nödvändigt

                // Informera användaren om att operationen var framgångsrik
                MessageBox.Show("Kategorin för RSS-flödet har ändrats framgångsrikt!");
            }
            catch (Exception ex)
            {
                // Hantera eventuella fel och visa ett felmeddelande
                MessageBox.Show(ex.Message, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
