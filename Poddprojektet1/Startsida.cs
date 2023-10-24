using System;
using System.Windows.Forms;
using System.Drawing;
using BusinessLogicLayer.Controllers;
using System.Security.Policy;
using Models;

namespace Poddprojektet1
{
    public partial class Startsida : Form
    {

        private TextBox rssFeedTextBox;
        private Button addFeedButton;
        private Label label1;
        private ListBox listPodcasts; // Ny ListBox för att visa podcasts
        private PodcastController podcastController = new PodcastController();
        private Button editFeedButton; // Ny knapp för att redigera podcast
        private Button deleteFeedButton; // Ny knapp för att radera podcast



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

            // Konfigurerar TextBox för RSS-flödet
            rssFeedTextBox.Location = new Point(20, 20);  // Exempelposition
            rssFeedTextBox.Size = new Size(250, 30);       // Exempelstorlek
            rssFeedTextBox.PlaceholderText = "Ange RSS-flödets URL här..."; // Instruktionstext

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

        private void label1_Click(object sender, EventArgs e)
        {
            // Händelsehanterare för klick på label1
        }

        private void AddFeedButton_Click(object? sender, EventArgs e)
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
                podcastController.AddPodcast(newPodcast); // Använd instansen istället för klassnamnet

                MessageBox.Show("Flödet lades till!");

                // Uppdatera ListBox med nytt podcast-flöde
                listPodcasts.Items.Add(url);
                rssFeedTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel uppstod: {ex.Message}");
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lblAuthor_Click(object sender, EventArgs e)
        {

        }

        private void lblKategori_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHanteraKategorier_Click(object sender, EventArgs e)
        {
            HanteraKategorier kategoriForm = new HanteraKategorier();
            kategoriForm.Visible = true;
        }


        private void EditFeedButton_Click(object sender, EventArgs e)
        {
            // Exempelkod: Du behöver här hitta det valda podcast-objektet och sedan 
            // redigera det baserat på användarens inmatning.
            if (listPodcasts.SelectedItem != null)
            {
                string url = listPodcasts.SelectedItem.ToString();
                // Här kan du till exempel öppna en dialogruta där användaren kan redigera 
                // podcast-information och sedan spara ändringarna.
            }
            else
            {
                MessageBox.Show("Vänligen välj en podcast att redigera.");
            }
        }

        private void DeleteFeedButton_Click(object sender, EventArgs e)
        {
            // Exempelkod: Du behöver här hitta det valda podcast-objektet och sedan radera det.
            if (listPodcasts.SelectedItem != null)
            {
                string url = listPodcasts.SelectedItem.ToString();
                // Bekräfta att användaren verkligen vill radera
                DialogResult result = MessageBox.Show($"Är du säker på att du vill radera podcasten med URL: {url}?", "Bekräfta radering", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Radera podcast och uppdatera listan
                    // (Observera att detta bara är exempelkod, och du behöver troligen 
                    // göra mer arbete här beroende på hur din applikation är uppbyggd)
                    listPodcasts.Items.Remove(url);
                }
            }
            else
            {
                MessageBox.Show("Vänligen välj en podcast att radera.");
            }
        }


    }
}