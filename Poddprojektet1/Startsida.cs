using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using BusinessLogicLayer.Controllers;
using Models;

namespace Poddprojektet1
{
    public partial class Startsida : Form
    {

        private TextBox? rssFeedTextBox;
        private Button? addFeedButton;
        private Label? label1;
        private ListBox? listPodcasts; // Ny ListBox för att visa podcasts
        private PodcastController? podcastController = new PodcastController();
        private Button? editFeedButton; // Ny knapp för att redigera podcast
        private Button? deleteFeedButton; // Ny knapp för att radera podcast



        public Startsida()
        {
            InitializeComponent();
            InitializeComponents();
            UppdateraPodcasts();
            // UppdateraGridMedPodcasts();
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

        private void UppdateraGridMedPodcasts()
        {
            // Rensar gridboxen innan laddning av uppdaterad lista
            gridPodcasts.Rows.Clear();

            var podcasts = podcastController?.GetAllPodcasts();
            if (podcasts != null)
            {
                foreach (Podcast podcast in podcasts)
                {
                    // Lägg till en ny rad i gridPodcasts som vi ladda innehållet till
                    int radIndex = gridPodcasts.Rows.Add();
                    gridPodcasts.Rows[radIndex].Cells["podcastNamn"].Value = "Exempelnamn"; // Istället för Exemplen här ska aktuell podcasts värden hämtas, exempelvis podcast.Namn
                    gridPodcasts.Rows[radIndex].Cells["podcastTitel"].Value = "Exempeltitel";
                    gridPodcasts.Rows[radIndex].Cells["kategori"].Value = "ExempelKategori";
                    gridPodcasts.Rows[radIndex].Cells["senasteAvsnitt"].Value = "ExempelSenaste Avsnitt";
                }
            }

        }

        private void InitializeComponents()
        {
            label1 = new Label();
            rssFeedTextBox = new TextBox();
            addFeedButton = new Button();
            listPodcasts = new ListBox(); // Initialisera ListBoxen

            // Konfigurerar TextBox för RSS-flödet
           
            rssFeedTextBox.Location = new Point(20, 20);  // Exempelposition
            rssFeedTextBox.Size = new Size(250, 30);       // Exempelstorlek
            rssFeedTextBox.PlaceholderText = "Ange RSS-flödets URL här..."; // Instruktionstext
            rssFeedTextBox.ForeColor = Color.Gray;

            // Bind Enter och Leave händelser
            if (rssFeedTextBox != null)
            {
                rssFeedTextBox.Enter += RssFeedTextBox_Enter;
                rssFeedTextBox.Leave += RssFeedTextBox_Leave;
            }

            // Konfigurera knappen för att lägga till flöde
            addFeedButton.Text = "Lägg till flöde";
            addFeedButton.Location = new Point(280, 20); // Exempelposition bredvid TextBox
            addFeedButton.Click += AddFeedButton_Click;  // Händelsehanterare

            // Konfigurera knappen för att redigera podcast
            editFeedButton = new Button
            {
                Text = "Redigera flöde",
                Location = new Point(280, 60), // Exempelposition under andra knappen
            };
            editFeedButton.Click += EditFeedButton_Click;

            // Konfigurera knappen för att radera podcast
            deleteFeedButton = new Button
            {
                Text = "Radera flöde",
                Location = new Point(280, 100), // Exempelposition under redigera-knappen
            };
            deleteFeedButton.Click += DeleteFeedButton_Click;

            // Lägg till kontroller till formuläret
            Controls.Add(rssFeedTextBox);
            Controls.Add(addFeedButton);
            Controls.Add(label1);
            Controls.Add(listPodcasts);
            Controls.Add(editFeedButton);
            Controls.Add(deleteFeedButton);
        }

        private void RssFeedTextBox_Enter(object? sender, EventArgs e)
        {
            // Kod som körs när rssFeedTextBox får fokus
            if (rssFeedTextBox?.Text == "Ange RSS-flödets URL här...")
            {   rssFeedTextBox.Text = "";
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

        private void AddFeedButton_Click(object? sender, EventArgs e)
        {
            AddFeedButton_Click(sender, e, rssFeedTextBox);
        }

        private void AddFeedButton_Click(object? sender, EventArgs e, TextBox? rssFeedTextBox)
        {
            // Check if rssFeedTextBox is not null
            if (rssFeedTextBox != null)
            {
                // Hämta URL från TextBox
                string url = rssFeedTextBox.Text;

                // Skapa en ny podcast med hämtad URL
                Podcast newPodcast = new Podcast
                {
                    Url = url
                    // Andra egenskaper kan också sättas här
                };

                try
                {
                    podcastController?.AddPodcast(newPodcast); // Använd instansen istället för klassnamnet

                    MessageBox.Show("Flödet lades till!");

                    // Check if listPodcasts is not null before accessing its Items
                    listPodcasts?.Items.Add(url);
                    rssFeedTextBox.Clear();
                    UppdateraPodcasts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ett fel uppstod: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("RSS textfältet är tomt.");
            }
        }

        private void btnHanteraKategorier_Click(object sender, EventArgs e)
        {
            HanteraKategorier kategoriForm = new HanteraKategorier();
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

            lblPodcastNamn.Text = valdPodcast.Namn ?? "Information saknas";
            lblPodcastTitel.Text = valdPodcast.Titel ?? "Information saknas";
            lblAuthor.Text = valdPodcast.Author ?? "Information saknas";
            lblPodcastBeskrivning.Text = valdPodcast.Beskrivning ?? "Information saknas";
            string bildUrl = valdPodcast.BildUrl;
            lblKategori.Text = valdPodcast.PodcastKategori?.ToString() ?? "Okategoriserad";

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
                    // Automarkerar det sist laddade avsnittet
                    listboxAvsnitt.SelectedIndex = listboxAvsnitt.Items.Count - 1;

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


        private void laddaUppBildFranUrl(string bildUrl)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] data = webClient.DownloadData(bildUrl);
                    using (var stream = new System.IO.MemoryStream(data))
                    {
                        Image avsnittetsBild = Image.FromStream(stream);
                        picBoxPodcastBild.Image = avsnittetsBild;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kan inte ladda bilden" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fyllAvsnittsinformation(Avsnitt avsnitt)
        {
            lblAvsnittsTitel.Text = avsnitt.Titel;
            lblPubDate.Text = avsnitt.PubliceringsDatum.ToString();
            lblAvsnittsBeskrivning.Text = avsnitt.Beskrivning;
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
                string? podcastensTitel = gridPodcasts.SelectedCells[1].Value.ToString();
                Podcast? valdPodcast = podcastController?.GetAllPodcasts().FirstOrDefault(p => p.Titel == podcastensTitel);

                fyllPodcastinformation(valdPodcast);

            }
        }

        private void listboxAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hämtar aktuell podcast
            Podcast? valdPodcast = podcastController?.GetAllPodcasts().FirstOrDefault(p => p.Titel == lblPodcastTitel.Text);

            // Hämtar podcastens avsnitt
          

            List<Avsnitt> podcastensAvsnitt = valdPodcast.Avsnitt;
            

            // Hämtar aktuellt avsnitt
            string avsnittetsTitel = listboxAvsnitt.SelectedItem.ToString();
            Avsnitt valtAvsnitt = podcastensAvsnitt.FirstOrDefault(a => a.Titel == avsnittetsTitel);

            // Fyller avsnittsinformationen
            fyllAvsnittsinformation(valtAvsnitt);
        }

        private void btnLaggTillPodcast_Click(object sender, EventArgs e)
        {
            LaggTillPodcast laggTillPodcastForm = new LaggTillPodcast();
            laggTillPodcastForm.Visible = true;
        }

        private void btnHanteraPodcast_Click(object sender, EventArgs e)
        {

        }

        private void btnRaderaPodcast_Click(object sender, EventArgs e)

            //JAG HAR INTE LAGT TILL NÅGON KONTROLL T.EX. "ÄR DU SÄKER PÅ ATT DU VILL RADERA DENNA PODCAST?" /DENIS
        {
            try
            {
                if (gridPodcasts.SelectedRows.Count > 0)
                {
                    // Hämta den valda podcasten från gridPodcasts : DataGridView
                    Podcast selectedPodcast = gridPodcasts.SelectedRows[0].DataBoundItem as Podcast;

                    // Anropa PodcastController för att radera podcasten baserat på dess ID
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


    }
}