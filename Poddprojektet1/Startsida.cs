using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using BusinessLogicLayer.Controllers;
using Models;
using HtmlAgilityPack;

namespace Poddprojektet1
{
    public partial class Startsida : Form
    {

        private TextBox? rssFeedTextBox;
        private Button? addFeedButton;
        private Label? label1;
        private ListBox? listPodcasts; 
        private PodcastController podcastController;
        private KategoriController kategoriController;




        public Startsida()
        {
            InitializeComponent();
            podcastController = new PodcastController();
            kategoriController = new KategoriController();
            //    InitializeComponents(); -- Bortkommenterad tills vidare
            // UppdateraPodcasts();
            UppdateraGridMedPodcasts();
        }

        private void UppdateraPodcasts()
        {
            // Rensa den nuvarande listan
            listPodcasts?.Items.Clear();

            // Hämta en lista över alla podcasts
            var podcasts = podcastController?.GetAllPodcasts();
            if (podcasts != null)
            {
                foreach (var podcast in podcasts)
                {
                    // Lägg till varje podcast i listrutan
                    // Antag att du vill visa podcastens namn
                    listPodcasts?.Items.Add(podcast.Namn);
                }
            }
        }

        public void UppdateraGridMedPodcasts()
        {
            // Rensar gridboxen innan laddning av uppdaterad lista
            gridPodcasts.Rows.Clear();

            // Skapar en ny controller med uppdaterad lista för att kunna hantera multipla ändringar
            PodcastController pController = new PodcastController();

            var podcasts = pController?.GetAllPodcasts();
            if (podcasts != null)
            {
                foreach (Podcast podcast in podcasts)
                {
                    Avsnitt? senasteAvsnittet = pController?.GetPodcastensSenasteAvsnitt(podcast); // Notera '?' tecknet för att indikera nullable

                    if (senasteAvsnittet == null)  // Kontrollera om senasteAvsnittet är null
                        continue;  // Hoppa över denna iteration av loopen om det är null

                    Kategori podcastensKategori = podcast.PodcastKategori;

                    // Lägg till en ny rad i gridPodcasts som vi ladda innehållet till
                    int radIndex = gridPodcasts.Rows.Add();
                    gridPodcasts.Rows[radIndex].Cells["podcastNamn"].Value = podcast.Namn;
                    gridPodcasts.Rows[radIndex].Cells["podcastTitel"].Value = podcast.Titel;
                    gridPodcasts.Rows[radIndex].Cells["kategori"].Value = podcastensKategori.Namn;
                    gridPodcasts.Rows[radIndex].Cells["senasteAvsnitt"].Value = senasteAvsnittet.Titel;
                }
            }

        }

        public void UppdateraComboBoxMedKategorier()
        {
            // Rensa comboboxen på kategorier
            cmbFiltreraKategori.Items.Clear();

            List<Kategori> kategorier = kategoriController.GetAllKategorier();

            foreach (Kategori kategori in kategorier)
            {
                cmbFiltreraKategori.Items.Add(kategori.Namn);
            }
        }

        private void RssFeedTextBox_Enter(object? sender, EventArgs e)
        {
            // Kod som körs när rssFeedTextBox får fokus
            if (rssFeedTextBox?.Text == "Ange RSS-flödets URL här...")
            {
                rssFeedTextBox.Text = "";
                rssFeedTextBox.ForeColor = Color.Black;
            }
        }

        private void RssFeedTextBox_Leave(object? sender, EventArgs e)
        {
            // Kod som körs när rssFeedTextBox förlorar fokus
            if (rssFeedTextBox != null && string.IsNullOrWhiteSpace(rssFeedTextBox.Text))
            {
                rssFeedTextBox.Text = "Ange RSS-flödets URL här...";
                rssFeedTextBox.ForeColor = Color.Gray;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Händelsehanterare för klick på label1
        }

       private void btnHanteraKategorier_Click(object sender, EventArgs e)
        {
            HanteraKategorier kategoriForm = new HanteraKategorier(this);
            kategoriForm.Visible = true;
        }

        private void EditFeedButton_Click(object? sender, EventArgs e)
        {
            if (listPodcasts?.SelectedItem != null)
            {
                try
                {
                    string url = (string)listPodcasts.SelectedItem;
                    Podcast? selectedPodcast = podcastController?.GetPodcastByUrl(url);

                    if (selectedPodcast != null)
                    {
                        EditPodcastForm editForm = new EditPodcastForm(selectedPodcast);
                        var result = editForm.ShowDialog(this);

                        if (result == DialogResult.OK)
                        {
                            // Hämta den uppdaterade podcasten från formuläret
                            Podcast updatedPodcast = editForm.UpdatedPodcast;

                            // Uppdatera podcasten i lagringen
                            if (podcastController != null && selectedPodcast != null)
                            {
                                podcastController.UpdatePodcast(selectedPodcast.ID, updatedPodcast);
                            }

                            UppdateraPodcasts(); // Uppdatera listan med podcasts
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kunde inte hitta podcasten.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ett fel uppstod vid redigering: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Vänligen välj en podcast att redigera.");
            }
        }


        private void DeleteFeedButton_Click(object? sender, EventArgs e)
        {
            // Exempelkod: Du behöver här hitta det valda podcast-objektet och sedan radera det.
            if (listPodcasts?.SelectedItem != null)
            {
                string url = (string)listPodcasts.SelectedItem;
                // Bekräfta att användaren verkligen vill radera
                DialogResult result = MessageBox.Show($"Är du säker på att du vill radera podcasten med URL: {url}?", "Bekräfta radering", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Radera podcast och uppdatera listan
                    // (Observera att detta bara är exempelkod, och du behöver troligen 
                    // göra mer arbete här beroende på hur din applikation är uppbyggd)
                    listPodcasts.Items.Remove(url);
                    UppdateraPodcasts();
                }
            }
            else
            {
                MessageBox.Show("Vänligen välj en podcast att radera.");
            }
        }

        private void fyllPodcastinformation(Podcast valdPodcast)
        {
            // Först kontrollera om 'valdPodcast' är null
            if (valdPodcast == null)
            {
                MessageBox.Show("Ingen podcast vald. Vänligen välj en podcast först.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Avsluta metoden eftersom det inte finns någon podcast att bearbeta
            }

            //string podcastBeskrivning = valdPodcast.Beskrivning ?? "Information saknas";

            //var podcastBeskrivningHTML = new HtmlAgilityPack.HtmlDocument();
            //podcastBeskrivningHTML.LoadHtml(podcastBeskrivning);

            lblPodcastNamn.Text = valdPodcast.Namn ?? "Information saknas";
            lblPodcastTitel.Text = valdPodcast.Titel ?? "Information saknas";
            txtBoxPodcastBeskrivning.Text = valdPodcast.Beskrivning ?? "Information saknas";
            string bildUrl = valdPodcast.BildUrl;
            lblKategori.Text = valdPodcast.PodcastKategori.Namn ?? "Okategoriserad";

            laddaUppBildFranUrl(bildUrl); // Antag att denna metod kan hantera null 'bildUrl'

            // Nu hanterar vi möjligheten att 'Avsnitt' kan vara null eller tom
            if (valdPodcast.Avsnitt == null || !valdPodcast.Avsnitt.Any())
            {
                MessageBox.Show("Det finns inga avsnitt tillgängliga för den här podcasten.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Om vi har giltiga avsnitt, fortsätt som vanligt
                List<Avsnitt> podcastensAvsnitt = valdPodcast.Avsnitt;
                listboxAvsnitt.Items.Clear(); // Rensa tidigare poster för att undvika dubbletter

                foreach (Avsnitt avsnitt in podcastensAvsnitt)
                {
                    string avsnittsTiteln = avsnitt?.Titel ?? "Okänd titel"; // Hantera möjligheten att 'Titel' kan vara null
                    listboxAvsnitt.Items.Add(avsnittsTiteln);
                }

                // Kontrollera om det finns några objekt i listan innan du ställer in vald index
                if (listboxAvsnitt.Items.Count > 0)
                {
                    // Automarkerar det först laddade avsnittet
                    listboxAvsnitt.SelectedIndex = 0;

                    // Eftersom 'SelectedItem' inte är null här (vi har poster och en är vald), kan vi göra en säker omvandling
                    string? avsnittetsTitel = listboxAvsnitt.SelectedItem.ToString();
                    Avsnitt? valtAvsnitt = podcastensAvsnitt.FirstOrDefault(a => a.Titel == avsnittetsTitel);

                    if (valtAvsnitt != null)
                    {
                        fyllAvsnittsinformation(valtAvsnitt); // Antag att denna metod kan hantera all nödvändig logik
                    }
                    else
                    {
                        MessageBox.Show("Kunde inte hitta information för det valda avsnittet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Inga avsnitt finns tillgängliga för visning.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private async void laddaUppBildFranUrl(string bildUrl)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    // Använda GetByteArrayAsync för att ladda ner bilden som en byte array
                    byte[] data = await httpClient.GetByteArrayAsync(bildUrl);

                    using (var stream = new System.IO.MemoryStream(data))
                    {
                        Image avsnittetsBild = Image.FromStream(stream);
                        picBoxPodcastBild.Image = avsnittetsBild;
                    }
                }
            }
            catch (HttpRequestException httpEx) // Fånga specifika fel relaterade till HTTP-begäranden
            {
                MessageBox.Show("Problem med att hämta bilden från nätet: " + httpEx.Message, "Nätverksfel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) // Generellt fånga andra typer av fel
            {
                MessageBox.Show("Kan inte ladda bilden: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void fyllAvsnittsinformation(Avsnitt avsnitt)
        {
            lblAvsnittsTitel.Text = avsnitt.Titel;
            lblPubDate.Text = avsnitt.PubliceringsDatum.ToString();
            txtBoxAvsnittsBeskrivning.Text = avsnitt.Beskrivning;
            //lblAvsnittsBeskrivning.Text = avsnitt.Beskrivning;
        }

        private void gridPodcasts_SelectedIndexChanged(object? sender, EventArgs e)
        {

        }

        private void gridPodcasts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kontrollerar så att det finns en markerad rad i grid
            if (gridPodcasts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Var god markera en rad!");
            }
            else
            {
                // Skyddar oss mot möjligheten att cellvärdet är null
                string? podcastensTitel = gridPodcasts.SelectedCells[1].Value?.ToString(); // Lägger till en null-kontroll här

                if (podcastensTitel == null)
                {
                    MessageBox.Show("Ingen titel tillgänglig för vald podcast.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Podcast? valdPodcast = podcastController?.GetAllPodcasts().FirstOrDefault(p => p.Titel == podcastensTitel);

                if (valdPodcast == null)
                {
                    MessageBox.Show("Kunde inte hitta den valda podcasten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    fyllPodcastinformation(valdPodcast); // Nu vet vi att 'valdPodcast' inte är null
                }
            }
        }


        private void listboxAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Först kontrollerar vi om podcastController är null.
            if (podcastController == null)
            {
                MessageBox.Show("Podcast-controller är inte tillgänglig.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sedan, vi ser till att en podcast verkligen hittades baserat på titeln.
            Podcast? valdPodcast = podcastController.GetAllPodcasts().FirstOrDefault(p => p.Titel == lblPodcastTitel.Text);

            if (valdPodcast == null)
            {
                MessageBox.Show("Ingen podcast matchade den valda titeln.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vi ser till att det finns ett valt objekt i listboxen och att det inte är null.
            if (listboxAvsnitt.SelectedItem == null)
            {
                MessageBox.Show("Vänligen välj ett avsnitt först.", "Inget avsnitt valt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Vi ser till att det finns ett valt objekt i listboxen och att det är av typen string.
            if (!(listboxAvsnitt.SelectedItem is string avsnittetsTitel))
            {
                MessageBox.Show("Det valda avsnittet har ogiltig information eller är inte valt.", "Fel vid val av avsnitt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Skyddar mot en situation där 'Avsnitt' listan själv kan vara null eller tom.
            if (valdPodcast.Avsnitt == null || !valdPodcast.Avsnitt.Any())
            {
                MessageBox.Show("Inga avsnitt tillgängliga för denna podcast.", "Inga avsnitt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Försök hitta avsnittet. Eftersom vi kontrollerar om listan är null ovan, bör detta inte orsaka en CS8604-varning.
            Avsnitt? valtAvsnitt = valdPodcast.Avsnitt.FirstOrDefault(a => a.Titel == avsnittetsTitel);

            if (valtAvsnitt == null)
            {
                MessageBox.Show("Det valda avsnittet finns inte i listan.", "Avsnitt ej funnet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nu när vi är säkra på att vi har ett giltigt avsnitt, fortsätt med att fylla i informationen.
            fyllAvsnittsinformation(valtAvsnitt);
        }


        private void btnLaggTillPodcast_Click(object sender, EventArgs e)
        {
            LaggTillPodcast laggTillPodcastForm = new LaggTillPodcast(this);
            laggTillPodcastForm.Visible = true;
            this.Enabled = false;
        }

        private void btnHanteraPodcast_Click(object sender, EventArgs e)
        {
            // Behöver läggas in en check / If sats här för att podcast är vald innan användaren kan 
            //navigera sig vidare till "Hantera Podcast"-formuläret + else sats med MessageBox-felmeddelande
            // - Victor


            HanteraPodcast hanteraPodcastForm = new HanteraPodcast(this);
            hanteraPodcastForm.ShowDialog();
        }

        private void btnRedigeraPodcast_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxFiltrera_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFiltrera.Checked == true)
            {
                cmbFiltreraKategori.Enabled = true;
                UppdateraComboBoxMedKategorier();
            }
            else
            {
                cmbFiltreraKategori.Enabled = false;
                UppdateraGridMedPodcasts();
            }


        }

        private void cmbFiltreraKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltreraKategori.SelectedItem == null)
            {
                // Ingen kategori vald.
                return;
            }

            string? kategoriNamn = cmbFiltreraKategori?.SelectedItem.ToString();

            var valdKategori = kategoriController.GetAllKategorier().FirstOrDefault(k => k.Namn == kategoriNamn);

            if (valdKategori == null)
            {
                // Ingen kategori hittades som matchar det valda kategoriNamn.
                return;
            }

            List<Podcast> podcastsEfterKategori = podcastController.GetPodcastsByKategori(valdKategori);

            gridPodcasts.Rows.Clear();

            foreach (Podcast podcast in podcastsEfterKategori)
            {
                Avsnitt senasteAvsnittet = podcastController.GetPodcastensSenasteAvsnitt(podcast);

                Kategori podcastensKategori = podcast.PodcastKategori;

                // Lägg till en ny rad i gridPodcasts som vi ladda innehållet till
                int radIndex = gridPodcasts.Rows.Add();
                gridPodcasts.Rows[radIndex].Cells["podcastNamn"].Value = podcast.Namn;
                gridPodcasts.Rows[radIndex].Cells["podcastTitel"].Value = podcast.Titel;
                gridPodcasts.Rows[radIndex].Cells["kategori"].Value = podcastensKategori.Namn;
                gridPodcasts.Rows[radIndex].Cells["senasteAvsnitt"].Value = senasteAvsnittet.Titel;
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}