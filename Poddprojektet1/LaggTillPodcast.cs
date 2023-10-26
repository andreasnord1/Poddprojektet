using BusinessLogicLayer.Controllers;
using DataAccessLayer.Repositories;
using Models;
using System.Windows.Forms;

namespace Poddprojektet1
{
    public partial class LaggTillPodcast : Form
    {
        private PodcastController podcastController;
        private KategoriController kategoriController;

        public LaggTillPodcast()
        {
            InitializeComponent();
            podcastController = new PodcastController(); 
            kategoriController = new KategoriController(new KategoriRepository());

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

                if (string.IsNullOrEmpty(podcastUrl) || string.IsNullOrEmpty(podcastTitel))
                {
                    MessageBox.Show("Vänligen ange både en URL för podcasten.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (string.IsNullOrEmpty(podcastTitel))
                {
                    MessageBox.Show("Vänligen ange ett namn för podcasten.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Podcast newPodcast = new Podcast()
                {
                    Url = podcastUrl,
                    Titel = podcastTitel
                };

                if (podcastKategori != null)
                {
                    newPodcast.PodcastKategori = new Kategori() { Namn = podcastKategori };
                }
                else
                {
                    MessageBox.Show("Välj en kategori för podcasten.", "Kategori saknas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                podcastController.AddPodcast(newPodcast);
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