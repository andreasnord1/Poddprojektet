using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
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
            // Exempelkod: Du beh�ver h�r hitta det valda podcast-objektet och sedan 
            // redigera det baserat p� anv�ndarens inmatning.
            if (listPodcasts?.SelectedItem != null)
            {
                string url = (string)listPodcasts.SelectedItem;
                // H�r kan du till exempel �ppna en dialogruta d�r anv�ndaren kan redigera 
                // podcast-information och sedan spara �ndringarna.
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
                }
            }
            else
            {
                MessageBox.Show("V�nligen v�lj en podcast att radera.");
            }
        }



        private void fyllPodcastinformation()
        {
            
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
                string podcastensNamn = gridPodcasts.SelectedCells[0].Value.ToString();
                // Podcast valdPodcast = podcastController.GetAllPodcasts().Where(p => p.Namn == podcastensNamn);



            }
        }
    }
}