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
using DataAccessLayer;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using static System.Resources.ResXFileRef;

namespace Poddprojektet1
{
    public partial class HanteraPodcast : Form
    {

        private KategoriController kategoriController;
        private PodcastController podcastController;

        public HanteraPodcast()
        {
            InitializeComponent();
            kategoriController = new KategoriController();
            podcastController = new PodcastController();
            fyllMedKategorier();
        }

        private void btnRadera_Click(object sender, EventArgs e)
        {

            try
            {
                if (gridPodcasts.SelectedRows.Count > 0)
                {
                    // Hämtar den valda podcasten från gridPodcasts, men var medveten om att den kan vara null.
                    var dataBoundItem = gridPodcasts.SelectedRows[0].DataBoundItem;
                    if (dataBoundItem is Podcast selectedPodcast) // säkerställer att objektet är en Podcast
                    {
                        // Nu är vi säkra på att selectedPodcast inte är null och kan säkert komma åt dess ID.
                        podcastController?.DeletePodcast(selectedPodcast.ID);

                        // Uppdatera gridPodcasts efter radering
                        gridPodcasts.DataSource = null; // Ta bort datakällan
                        gridPodcasts.DataSource = podcastController?.GetAllPodcasts(); // Fyll på igen med uppdaterad data

                        MessageBox.Show("Den valda podcasten har nu raderats!");
                    }
                    else
                    {
                        MessageBox.Show("Det valda objektet är inte en giltig podcast.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vänligen välj en podcast att radera.", "Ingen podcast vald", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) // Här fångas eventuella undantag som uppstår i try-blocket.
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

        private void btnRedigeraNamn_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Kontrollera att en podcast är vald
                if (gridPodcasts.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vänligen välj en podcast först.");
                    return;
                }

                var selectedPodcast = gridPodcasts.SelectedRows[0].DataBoundItem as Podcast;
                if (selectedPodcast == null)
                {
                    throw new InvalidOperationException("Ingen podcast vald eller ogiltig podcast-information.");
                }

                // Öppna RedigeraNamnForm som en modal dialogruta
                using (RedigeraNamn redigeraNamnForm = new RedigeraNamn(selectedPodcast))
                {
                    if (redigeraNamnForm.ShowDialog() == DialogResult.OK)
                    {
                        // Om användaren tryckte på OK i RedigeraNamnForm, hämta uppdaterad podcast-information
                        Podcast updatedPodcast = redigeraNamnForm.UpdatedPodcast;

                        // Uppdatera podcasten genom att använda PodcastController
                        PodcastController podcastController = new PodcastController();
                        
                      if(selectedPodcast.Url != null) { 

                        podcastController.UpdatePodcastByUrl(selectedPodcast.Url, updatedPodcast);

                        MessageBox.Show("Namnet på RSS-flödet har ändrats framgångsrikt!");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                var valdKategori = kategoriController.GetAllKategorier().FirstOrDefault(k => k.Namn == newCategoryName);

                if (valdKategori != null)
                {

                    selectedPodcast.PodcastKategori = valdKategori;

                    //// Hämta kategori-ID för den valda podcasten
                    //int existingKategoriId = selectedPodcast.KategoriID;

                    //Kategori existingKategori = kategoriController.GetKategoriById(existingKategoriId);
                    //if (existingKategori == null)
                    //{
                    //    throw new Exception("Kategorin hittades inte.");
                    //}


                    //// Förbered den uppdaterade kategorin
                    //Kategori updatedKategori = new Kategori(existingKategoriId, newCategoryName);


                    //// Uppdatera kategorin genom KategoriController
                    //kategoriController.UpdateKategori(existingKategoriId, updatedKategori);

                    //// Reflektera ändringen i podcastens kategoriinformation
                    //selectedPodcast.PodcastKategori = updatedKategori; // Eller uppdatera listan/gridden om nödvändigt

                    // Informera användaren om att operationen var framgångsrik


                    MessageBox.Show("Kategorin för RSS-flödet har ändrats framgångsrikt!");
                }
            }
            catch (Exception ex)
            {
                // Hantera eventuella fel och visa ett felmeddelande
                MessageBox.Show(ex.Message, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
