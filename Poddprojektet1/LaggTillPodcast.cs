using BusinessLogicLayer.Controllers;
using Models;

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

        private void btnLaggTill_Click(object sender, EventArgs e)
        {
            try
            {
                // Hämta data från UI-element
                string podcastUrl = txtURL.Text;
                string podcastTitel = txtNamn.Text;
                string? podcastKategori = cmbPodcastKategori.SelectedItem?.ToString();

                // Skapa nytt Podcast-objekt
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
                    Console.WriteLine("Värdet kan inte vara null!");
                    return; // Avbryt metoden om podcastKategori är null
                }

                // Lägg till Podcast
                podcastController.AddPodcast(newPodcast);

                MessageBox.Show("Podcast har lagts till framgångsrikt!");
            }
            catch (Exception ex)
            {
                // Visa felmeddelande till användaren om något går fel
                MessageBox.Show(ex.Message, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
