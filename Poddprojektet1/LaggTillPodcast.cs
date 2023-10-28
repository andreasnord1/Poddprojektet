using BusinessLogicLayer.Controllers;
using DataAccessLayer.Repositories;
using Models;
using System.Windows.Forms;
using DataAccessLayer;
using System.Collections.Generic;

namespace Poddprojektet1
{
    public partial class LaggTillPodcast : Form
    {
        private PodcastController podcastController;
        private KategoriController kategoriController;
        private Serialiserare Serialiserare = new Serialiserare();
        private KategoriRepository kategoriRepo = new KategoriRepository();


        public LaggTillPodcast()
        {
            InitializeComponent();
            podcastController = new PodcastController(); 
            kategoriController = new KategoriController(new KategoriRepository());
            LoadCategories();

        }

        private void LoadCategories()
        {
            // Rensa kategori-comboboxen för att undvika upprepningar
            cmbPodcastKategori.Items.Clear();

            // Hämta alla tillgängliga kategorier
            var kategorier = kategoriRepo.GetAll();

            // Lägg till varje kategori i comboboxen
            foreach (var kategori in kategorier)
            {
                cmbPodcastKategori.Items.Add(kategori.Namn);
            }
        }

        private void btnManageCategories_Click(object sender, EventArgs e)
        {
            // Öppna Hantera Kategorier-formuläret och ladda om kategorierna när det stängs
            using (var form = new HanteraKategorier())
            {
                form.ShowDialog();
                LoadCategories();
            }
        }


        private void LaggTillPodcast_Load(object sender, EventArgs e)
        {
            try
            {
                List<Kategori> kategorier = kategoriController.GetAllKategorier();
                cmbPodcastKategori.DataSource = kategorier;
                cmbPodcastKategori.DisplayMember = "Namn";
            }
            catch (Exception ex)
            {
                // Visa ett felmeddelande om något går fel
                MessageBox.Show($"Ett fel uppstod när kategorier skulle hämtas: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLaggTill_Click(object sender, EventArgs e)
        {
            try
            {
                string podcastUrl = txtURL.Text.Trim();
                string podcastTitel = txtNamn.Text.Trim();
                string? podcastKategori = cmbPodcastKategori.SelectedItem?.ToString();

                // Skapar en instans av repositoriet och kontrollern en gång.
                KategoriRepository kategoriRepo = new KategoriRepository();
                KategoriController kategoriController = new KategoriController(kategoriRepo);

                if (string.IsNullOrEmpty(podcastUrl) || string.IsNullOrEmpty(podcastTitel))
                {
                    MessageBox.Show("Vänligen ange både en URL och ett namn för podcasten.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Podcast newPodcast = new Podcast()
                {
                    Url = podcastUrl,
                    Titel = podcastTitel
                };

                if (podcastKategori != null)
                {
                    // Använd instansen av KategoriController här.
                    List<Kategori> allaKategorier = kategoriController.GetAllKategorier(); 
                    int kategoriId = kategoriController.GetNextAvailableID(allaKategorier);
                    newPodcast.PodcastKategori = new Kategori(kategoriId, podcastKategori);
                }
                else
                {
                    MessageBox.Show("Välj en kategori för podcasten.", "Kategori saknas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                podcastController.AddPodcast(newPodcast);

                // Uppdatera XML-filen med den nya podcasten
                List<Podcast> podcasts = Serialiserare.DeSerialiseraPodcasts();
                podcasts.Add(newPodcast);
                Serialiserare.SerialiseraPodcasts(podcasts);

                MessageBox.Show("Podcast har lagts till framgångsrikt!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}