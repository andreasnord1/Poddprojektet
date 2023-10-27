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
        private ListBox? listPodcasts; // Ny ListBox f�r att visa podcasts
        private PodcastController? podcastController = new PodcastController();
        private Button? editFeedButton; // Ny knapp f�r att redigera podcast
        private Button? deleteFeedButton; // Ny knapp f�r att radera podcast



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

            // H�mta en lista �ver alla podcasts
            var podcasts = podcastController?.GetAllPodcasts();
            if (podcasts != null)
            {
                foreach (var podcast in podcasts)
                {
                    // L�gg till varje podcast i listrutan
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
                    // L�gg till en ny rad i gridPodcasts som vi ladda inneh�llet till
                    int radIndex = gridPodcasts.Rows.Add();
                    gridPodcasts.Rows[radIndex].Cells["podcastNamn"].Value = "Exempelnamn"; // Ist�llet f�r Exemplen h�r ska aktuell podcasts v�rden h�mtas, exempelvis podcast.Namn
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

            // Konfigurerar TextBox f�r RSS-fl�det
           
            rssFeedTextBox.Location = new Point(20, 20);  // Exempelposition
            rssFeedTextBox.Size = new Size(250, 30);       // Exempelstorlek
            rssFeedTextBox.PlaceholderText = "Ange RSS-fl�dets URL h�r..."; // Instruktionstext
            rssFeedTextBox.ForeColor = Color.Gray;

            // Bind Enter och Leave h�ndelser
            if (rssFeedTextBox != null)
            {
                rssFeedTextBox.Enter += RssFeedTextBox_Enter;
                rssFeedTextBox.Leave += RssFeedTextBox_Leave;
            }

            // Konfigurera knappen f�r att l�gga till fl�de
            addFeedButton.Text = "L�gg till fl�de";
            addFeedButton.Location = new Point(280, 20); // Exempelposition bredvid TextBox
            addFeedButton.Click += AddFeedButton_Click;  // H�ndelsehanterare

            // Konfigurera knappen f�r att redigera podcast
            editFeedButton = new Button
            {
                Text = "Redigera fl�de",
                Location = new Point(280, 60), // Exempelposition under andra knappen
            };
            editFeedButton.Click += EditFeedButton_Click;

            // Konfigurera knappen f�r att radera podcast
            deleteFeedButton = new Button
            {
                Text = "Radera fl�de",
                Location = new Point(280, 100), // Exempelposition under redigera-knappen
            };
            deleteFeedButton.Click += DeleteFeedButton_Click;

            // L�gg till kontroller till formul�ret
            Controls.Add(rssFeedTextBox);
            Controls.Add(addFeedButton);
            Controls.Add(label1);
            Controls.Add(listPodcasts);
            Controls.Add(editFeedButton);
            Controls.Add(deleteFeedButton);
        }

        private void RssFeedTextBox_Enter(object? sender, EventArgs e)
        {
            // Kod som k�rs n�r rssFeedTextBox f�r fokus
            if (rssFeedTextBox?.Text == "Ange RSS-fl�dets URL h�r...")
            {   rssFeedTextBox.Text = "";
                rssFeedTextBox.ForeColor = Color.Black;
            }
        }

        private void RssFeedTextBox_Leave(object? sender, EventArgs e)
        {
            // Kod som k�rs n�r rssFeedTextBox f�rlorar fokus
            if (rssFeedTextBox != null && string.IsNullOrWhiteSpace(rssFeedTextBox.Text))
            {
                rssFeedTextBox.Text = "Ange RSS-fl�dets URL h�r...";
                rssFeedTextBox.ForeColor = Color.Gray;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // H�ndelsehanterare f�r klick p� label1
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
                // H�mta URL fr�n TextBox
                string url = rssFeedTextBox.Text;

                // Skapa en ny podcast med h�mtad URL
                Podcast newPodcast = new Podcast
                {
                    Url = url
                    // Andra egenskaper kan ocks� s�ttas h�r
                };

                try
                {
                    podcastController?.AddPodcast(newPodcast); // Anv�nd instansen ist�llet f�r klassnamnet

                    MessageBox.Show("Fl�det lades till!");

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
                MessageBox.Show("RSS textf�ltet �r tomt.");
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
                            // H�mta den uppdaterade podcasten fr�n formul�ret
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
                MessageBox.Show("V�nligen v�lj en podcast att redigera.");
            }
        }


        private void DeleteFeedButton_Click(object? sender, EventArgs e)
        {
            // Exempelkod: Du beh�ver h�r hitta det valda podcast-objektet och sedan radera det.
            if (listPodcasts?.SelectedItem != null)
            {
                string url = (string)listPodcasts.SelectedItem;
                // Bekr�fta att anv�ndaren verkligen vill radera
                DialogResult result = MessageBox.Show($"�r du s�ker p� att du vill radera podcasten med URL: {url}?", "Bekr�fta radering", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Radera podcast och uppdatera listan
                    // (Observera att detta bara �r exempelkod, och du beh�ver troligen 
                    // g�ra mer arbete h�r beroende p� hur din applikation �r uppbyggd)
                    listPodcasts.Items.Remove(url);
                    UppdateraPodcasts();
                }
            }
            else
            {
                MessageBox.Show("V�nligen v�lj en podcast att radera.");
            }
        }

        private void fyllPodcastinformation(Podcast valdPodcast)
        {
            // F�rst kontrollera om 'valdPodcast' �r null
            if (valdPodcast == null)
            {
                MessageBox.Show("Ingen podcast vald. V�nligen v�lj en podcast f�rst.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Avsluta metoden eftersom det inte finns n�gon podcast att bearbeta
            }

            lblPodcastNamn.Text = valdPodcast.Namn ?? "Information saknas";
            lblPodcastTitel.Text = valdPodcast.Titel ?? "Information saknas";
            lblAuthor.Text = valdPodcast.Author ?? "Information saknas";
            lblPodcastBeskrivning.Text = valdPodcast.Beskrivning ?? "Information saknas";
            string bildUrl = valdPodcast.BildUrl;
            lblKategori.Text = valdPodcast.PodcastKategori?.ToString() ?? "Okategoriserad";

            laddaUppBildFranUrl(bildUrl); // Antag att denna metod kan hantera null 'bildUrl'

            // Nu hanterar vi m�jligheten att 'Avsnitt' kan vara null eller tom
            if (valdPodcast.Avsnitt == null || !valdPodcast.Avsnitt.Any())
            {
                MessageBox.Show("Det finns inga avsnitt tillg�ngliga f�r den h�r podcasten.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Om vi har giltiga avsnitt, forts�tt som vanligt
                List<Avsnitt> podcastensAvsnitt = valdPodcast.Avsnitt;
                listboxAvsnitt.Items.Clear(); // Rensa tidigare poster f�r att undvika dubbletter

                foreach (Avsnitt avsnitt in podcastensAvsnitt)
                {
                    string avsnittsTiteln = avsnitt?.Titel ?? "Ok�nd titel"; // Hantera m�jligheten att 'Titel' kan vara null
                    listboxAvsnitt.Items.Add(avsnittsTiteln);
                }

                // Kontrollera om det finns n�gra objekt i listan innan du st�ller in vald index
                if (listboxAvsnitt.Items.Count > 0)
                {
                    // Automarkerar det sist laddade avsnittet
                    listboxAvsnitt.SelectedIndex = listboxAvsnitt.Items.Count - 1;

                    // Eftersom 'SelectedItem' inte �r null h�r (vi har poster och en �r vald), kan vi g�ra en s�ker omvandling
                    string? avsnittetsTitel = listboxAvsnitt.SelectedItem.ToString();
                    Avsnitt? valtAvsnitt = podcastensAvsnitt.FirstOrDefault(a => a.Titel == avsnittetsTitel);

                    if (valtAvsnitt != null)
                    {
                        fyllAvsnittsinformation(valtAvsnitt); // Antag att denna metod kan hantera all n�dv�ndig logik
                    }
                    else
                    {
                        MessageBox.Show("Kunde inte hitta information f�r det valda avsnittet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Inga avsnitt finns tillg�ngliga f�r visning.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // Kontrollerar s� att det finns en markerad rad i grid
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
            // H�mtar aktuell podcast
            Podcast? valdPodcast = podcastController?.GetAllPodcasts().FirstOrDefault(p => p.Titel == lblPodcastTitel.Text);

            // H�mtar podcastens avsnitt
          

            List<Avsnitt> podcastensAvsnitt = valdPodcast.Avsnitt;
            

            // H�mtar aktuellt avsnitt
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

            //JAG HAR INTE LAGT TILL N�GON KONTROLL T.EX. "�R DU S�KER P� ATT DU VILL RADERA DENNA PODCAST?" /DENIS
        {
            try
            {
                if (gridPodcasts.SelectedRows.Count > 0)
                {
                    // H�mta den valda podcasten fr�n gridPodcasts : DataGridView
                    Podcast selectedPodcast = gridPodcasts.SelectedRows[0].DataBoundItem as Podcast;

                    // Anropa PodcastController f�r att radera podcasten baserat p� dess ID
                    podcastController.DeletePodcast(selectedPodcast.ID);

                    // Uppdatera gridPodcasts : DataGridView efter radering
                    gridPodcasts.DataSource = null; // Ta bort datak�llan
                    gridPodcasts.DataSource = podcastController.GetAllPodcasts(); // Fyll p� igen med uppdaterad data

                    MessageBox.Show("Den valda Podcasten har nu raderats!");
                }
                else
                {
                    MessageBox.Show("V�nligen v�lj en podcast att radera.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}