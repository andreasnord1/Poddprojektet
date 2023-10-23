using System;
using System.Windows.Forms;
using System.Drawing;
using BusinessLogicLayer.Controllers;

namespace Poddprojektet1
{
    public partial class Startsida : Form
    {

        private TextBox rssFeedTextBox;
        private Button addFeedButton;
        private Label label1;


        public Startsida()
        {
            InitializeComponent();
        }

        private void InitializeComponents()
        {
            label1 = new Label();
            rssFeedTextBox = new TextBox();
            addFeedButton = new Button();

            // Konfigurerar TextBox för RSS-flödet
            rssFeedTextBox.Location = new Point(20, 20);  // Exempelposition
            rssFeedTextBox.Size = new Size(250, 30);       // Exempelstorlek
            rssFeedTextBox.PlaceholderText = "Ange RSS-flödets URL här..."; // Instruktionstext

            // Konfigurera knappen för att lägga till flöde
            addFeedButton.Text = "Lägg till flöde";
            addFeedButton.Location = new Point(280, 20); // Exempelposition bredvid TextBox
            addFeedButton.Click += AddFeedButton_Click;  // Händelsehanterare

            // Lägg till kontroller till formuläret
            Controls.Add(rssFeedTextBox);
            Controls.Add(addFeedButton);
            Controls.Add(label1);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Händelsehanterare för klick på label1
        }

        private void AddFeedButton_Click(object? sender, EventArgs e)
        {
            // Hämta URL från TextBox
            bool success = PodcastController.AddFeed(rssFeedTextBox.Text); // jobba vidare i PodcastController sen

            if (success)
            {
                MessageBox.Show("Flödet lades till!");
            }
            else
            {
                MessageBox.Show("Ett fel uppstod.");
            }


         }

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}