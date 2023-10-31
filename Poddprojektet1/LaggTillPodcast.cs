using BusinessLogicLayer.Controllers;
using DataAccessLayer.Repositories;
using Models;
using System.Windows.Forms;
using DataAccessLayer;
using System.Collections.Generic;
using BusinessLogicLayer;
using System.Xml;
using System.ServiceModel.Syndication;

namespace Poddprojektet1
{
    public partial class LaggTillPodcast : Form
    {
        private PodcastController podcastController;
        private KategoriController kategoriController;
        // private Serialiserare Serialiserare = new Serialiserare();
        // private KategoriRepository kategoriRepo = new KategoriRepository();
        private Startsida startsidan;


        public LaggTillPodcast(Startsida startsida)
        {
            InitializeComponent();
            podcastController = new PodcastController();
            kategoriController = new KategoriController();
            startsidan = startsida;
            LoadCategories();
        }

        private void LoadCategories()
        {
            // Rensa kategori-comboboxen för att undvika upprepningar
            cmbPodcastKategori.Items.Clear();

            // Hämta alla tillgängliga kategorier
            var kategorier = kategoriController.GetAllKategorier();

            // Lägg till varje kategori i comboboxen
            foreach (var kategori in kategorier)
            {
                cmbPodcastKategori.Items.Add(kategori.Namn);
            }
        }

        //private void btnManageCategories_Click(object sender, EventArgs e)
        //{
        //    // Öppna Hantera Kategorier-formuläret och ladda om kategorierna när det stängs
        //    using (var form = new HanteraKategorier())
        //    {
        //        form.ShowDialog();
        //        LoadCategories();
        //    }
        //}


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

        private async Task<SyndicationFeed> fixaNyFeedAsync(string url)
        {
            using (XmlReader reader = XmlReader.Create(url))
            {
                return await Task.Run(() => SyndicationFeed.Load(reader));
            }
        }

        private async Task fixaPodcastensAvsnittAsync(string url)
        {
            SyndicationFeed feed = await fixaNyFeedAsync(url);

            string podNamn = txtNamn.Text;
            Kategori? valdKategori = kategoriController.GetAllKategorier().FirstOrDefault(k => k.Namn == cmbPodcastKategori.SelectedItem.ToString());

            string podTitel = feed.Title.Text;
            string podBeskrivning = feed.Description.Text;
            string? author = feed.Authors.ToString();
            string bildUrl = feed.ImageUrl.ToString();

            List<Avsnitt> podcastensAvsnitt = new List<Avsnitt>();

            foreach (SyndicationItem avsnitt in feed.Items)
            {
                string avsnittsTitel = avsnitt.Title.Text;
                
                // Kontrollerar så att inte avsnittsbeskrivningen saknas
                if (avsnitt.Summary.Text != null)
                {
                    string avsnittsBeskrivning = avsnitt.Summary.Text;

                    DateTimeOffset publiceringsDatum = avsnitt.PublishDate;

                    Avsnitt nyttAvsnitt = new Avsnitt(avsnittsTitel, publiceringsDatum, avsnittsBeskrivning);

                    podcastensAvsnitt.Add(nyttAvsnitt);
                }
                else
                {
                    string avsnittsBeskrivning = "Avsnittsbeskrivning saknas";

                    DateTimeOffset publiceringsDatum = avsnitt.PublishDate;

                    Avsnitt nyttAvsnitt = new Avsnitt(avsnittsTitel, publiceringsDatum, avsnittsBeskrivning);

                    podcastensAvsnitt.Add(nyttAvsnitt);
                }

            }

            Podcast nyPodcast = new Podcast(url, podNamn, podTitel, podBeskrivning, author,
                        bildUrl, valdKategori, podcastensAvsnitt);

            podcastController.AddPodcast(nyPodcast);
        }



        private async void btnLaggTill_Click(object sender, EventArgs e)
        {
            int minTeckenURL = 5;
            int maxTeckenURL = 100;
            int inskrivnaTeckenURL = txtURL.Text.Length;
            string typURL = "URL";

            int minTeckenNamn = 3;
            int maxTeckenNamn = 30;
            int inskrivnaTeckenNamn = txtNamn.Text.Length;
            string typNamn = "namn";

            if (Validering.ValideraURL(txtURL.Text, podcastController.GetAllPodcasts()) &&
                Validering.vardeFinns(txtURL) && Validering.vardeFinns(txtNamn) &&
                Validering.vardeFinns(cmbPodcastKategori, "kategori") &&
                Validering.KontrolleraTeckenAntal(inskrivnaTeckenURL, minTeckenURL, maxTeckenURL, typURL) &&
                Validering.KontrolleraTeckenAntal(inskrivnaTeckenNamn, minTeckenNamn, maxTeckenNamn, typNamn)) // Valideringar som kollar så att kategori och podcast inte är upptagna ska läggas till
            {
                string rssFeedURL = txtURL.Text;

                await fixaPodcastensAvsnittAsync(rssFeedURL);

                MessageBox.Show("En ny podcastfeed har lagts till!");
                startsidan.UppdateraGridMedPodcasts();
                this.Dispose();
                startsidan.Enabled = true;


                //string rssFeedURL = txtURL.Text;
                //string podNamn = txtNamn.Text;
                //Kategori? valdKategori = kategoriController.GetAllKategorier().FirstOrDefault(k => k.Namn == cmbPodcastKategori.SelectedItem.ToString());


                //using (XmlReader reader = XmlReader.Create(rssFeedURL))
                //{
                //    SyndicationFeed feed = SyndicationFeed.Load(reader);

                //    string podTitel = feed.Title.Text;
                //    string podBeskrivning = feed.Description.Text;
                //    string? author = feed.Authors.ToString();
                //    string bildUrl = feed.ImageUrl.ToString();

                //    List<Avsnitt> podcastensAvsnitt = new List<Avsnitt>();

                //    foreach (SyndicationItem avsnitt in feed.Items)
                //    {
                //        string avsnittsTitel = avsnitt.Title.Text;
                //        string avsnittsBeskrivning = avsnitt.Summary.Text;
                //        DateTimeOffset publiceringsDatum = avsnitt.PublishDate;

                //        Avsnitt nyttAvsnitt = new Avsnitt(avsnittsTitel, publiceringsDatum, avsnittsBeskrivning);

                //        podcastensAvsnitt.Add(nyttAvsnitt);
                //    }

                //    Podcast nyPodcast = new Podcast(rssFeedURL, podNamn, podTitel, podBeskrivning, author,
                //        bildUrl, valdKategori, podcastensAvsnitt);
                //
                //podcastController.AddPodcast(nyPodcast);

            }


            }



            //try
            //{
            //    string podcastUrl = txtURL.Text.Trim();
            //    string podcastTitel = txtNamn.Text.Trim();
            //    string? podcastKategori = cmbPodcastKategori.SelectedItem?.ToString();

            //    // Skapar en instans av repositoriet och kontrollern en gång.
            //    KategoriRepository kategoriRepo = new KategoriRepository();
            //    KategoriController kategoriController = new KategoriController(kategoriRepo);

            //    if (string.IsNullOrEmpty(podcastUrl) || string.IsNullOrEmpty(podcastTitel))
            //    {
            //        MessageBox.Show("Vänligen ange både en URL och ett namn för podcasten.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    Podcast newPodcast = new Podcast()
            //    {
            //        Url = podcastUrl,
            //        Titel = podcastTitel
            //    };

            //    if (podcastKategori != null)
            //    {
            //        // Använd instansen av KategoriController här.
            //        List<Kategori> allaKategorier = kategoriController.GetAllKategorier();
            //        int kategoriId = kategoriController.GetNextAvailableID(allaKategorier);
            //        newPodcast.PodcastKategori = new Kategori(kategoriId, podcastKategori);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Välj en kategori för podcasten.", "Kategori saknas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    podcastController.AddPodcast(newPodcast);

            //    // Uppdatera XML-filen med den nya podcasten
            //    List<Podcast> podcasts = Serialiserare.DeSerialiseraPodcasts();
            //    podcasts.Add(newPodcast);
            //    Serialiserare.SerialiseraPodcasts(podcasts);

            //    MessageBox.Show("Podcast har lagts till framgångsrikt!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        //}



        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            startsidan.Enabled = true;
            this.Dispose();
        }

        private void cmbPodcastKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LaggTillPodcast_FormClosing(object sender, FormClosingEventArgs e)
        {
            startsidan.Enabled = true;
        }
    }
}