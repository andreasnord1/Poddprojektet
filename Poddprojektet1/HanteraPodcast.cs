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
                    Podcast selectedPodcast = gridPodcasts.SelectedRows[0].DataBoundItem as Podcast;

                    // Anropa PodcastController för att radera podcasten baserat på dess ID
                    //VARFÖR GÅR PODCASTCONTROLLER ATT KALLA PÅ i STARTSIDA MEN INTE I DENNA FORM??
                    podcastController.DeletePodcast(selectedPodcast.ID);

                    // Uppdatera gridPodcasts : DataGridView efter radering
                    gridPodcasts.DataSource = null; // Ta bort datakällan
                    gridPodcasts.DataSource = podcastController.GetAllPodcasts(); // Fyll på igen med uppdaterad data

                    MessageBox.Show("Den valda Podcasten har nu raderats!");
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


        //Fyll comboBox med kategorier
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
                if (gridPodcasts.SelectedRows.Count > 0 && cmbKategori.SelectedItem != null)
                {
                    // Hämta det valda RSS-flödet från DataGridView
                    Podcast selectedPodcast = gridPodcasts.SelectedRows[0].DataBoundItem as Podcast;

                    // Hämta den valda nya kategorin
                    string newCategory = cmbKategori.SelectedItem.ToString();

                    // Ändra kategorin för det valda RSS-flödet
                    selectedPodcast.PodcastKategori = new Kategori { Namn = newCategory };

                    // Anropa PodcastController för att uppdatera flödet
                    podcastController.UpdatePodcastCategory(selectedPodcast);

                    // Uppdatera DataGridView efter ändringen
                    gridPodcasts.Refresh();

                    MessageBox.Show("Kategorin för RSS-flödet har ändrats framgångsrikt!");
                }
                else
                {
                    MessageBox.Show("Vänligen välj ett RSS-flöde och en ny kategori.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
