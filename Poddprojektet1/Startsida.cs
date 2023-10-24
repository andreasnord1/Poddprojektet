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
        private ListBox listPodcasts; // Ny ListBox f�r att visa podcasts
        private PodcastController podcastController = new PodcastController();


        public Startsida()
        {
            InitializeComponent();
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

            // L�gg till kontroller till formul�ret
            Controls.Add(rssFeedTextBox);
            Controls.Add(addFeedButton);
            Controls.Add(label1);
            Controls.Add(listPodcasts); // L�gg till ListBoxen till formul�ret
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // H�ndelsehanterare f�r klick p� label1
        }

        private void AddFeedButton_Click(object? sender, EventArgs e)
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
                podcastController.AddPodcast(newPodcast); // Anv�nd instansen ist�llet f�r klassnamnet

                MessageBox.Show("Fl�det lades till!");

                // Uppdatera ListBox med nytt podcast-fl�de
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

        private void btnLaggTillPodcast_Click(object sender, EventArgs e)
        {

        }
    }
}