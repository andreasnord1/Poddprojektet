using BusinessLogicLayer.Controllers;
using Models;
using System.Windows.Forms;

namespace Poddprojektet1
{
    public partial class LaggTillPodcast : Form
    {
        private PodcastController podcastController;

        public LaggTillPodcast()
        {
            InitializeComponent();
            podcastController = new PodcastController(); // Skapar en ny instans av PodcastController
        }

        private void LaggTillPodcast_Load(object sender, EventArgs e)
        {
            // Här kan du initialisera saker när formuläret först laddas.
            // Exempel: Förbereda dropdown-listor, sätta standardvärden etc.
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
                    MessageBox.Show("Vänligen ange både en URL och en titel för podcasten.", "Information saknas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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