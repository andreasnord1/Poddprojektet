using System;
using System.Windows.Forms;
using System.Drawing;

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

        private void InitializeComponent()
        {
            label1 = new Label();
            rssFeedTextBox = new TextBox();
            addFeedButton = new Button();

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
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // H�ndelsehanterare f�r klick p� label1
        }

        private void AddFeedButton_Click(object sender, EventArgs e)
        {
            // H�mta URL fr�n TextBox
            string rssFeedUrl = rssFeedTextBox.Text;

            // TODO: Bearbeta URL:en f�r att h�mta RSS-fl�det
            // (h�r kan du anv�nda ett extern bibliotek eller n�got API)

            // TODO: Spara RSS-fl�det p� l�mpligt s�tt (t.ex. i en lista, en databas, eller en fil)

            // TODO: Visa feedback till anv�ndaren, t.ex. genom att uppdatera label1 eller visa en MessageBox
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