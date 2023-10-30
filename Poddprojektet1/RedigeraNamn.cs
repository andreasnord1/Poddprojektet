using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

// Business och Data Access Layers
using BusinessLogicLayer.Controllers;
using BusinessLogicLayer;
using DataAccessLayer.Repositories;
using Models;
using DataAccessLayer;

// Andra
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using static System.Resources.ResXFileRef;


namespace Poddprojektet1
{
    public partial class RedigeraNamn : Form
    {
        private Podcast _podcastToEdit;
        public event Action? PodcastUpdated;

        public RedigeraNamn(Podcast selectedPodcast)
        {
            // Grundläggande kontroll: om selectedPodcast är null kasta ett undantag.
            if (selectedPodcast == null)
            {
                throw new ArgumentNullException(nameof(selectedPodcast), "Podcast kan inte vara null.");
            }

            InitializeComponent();

            // Tilldela podcast för redigering.
            _podcastToEdit = selectedPodcast;

            // Visa podcastens nuvarande namn i textBox1.
            textBox1.Text = _podcastToEdit.Namn;

        }

        public Podcast UpdatedPodcast
        {
            get
            {
                // Om man vill hämta det uppdaterade namnet från ett textfält:
                _podcastToEdit.Namn = textBox2.Text;

                return _podcastToEdit;
            }
        }


        private void RedigeraNamn_Load(object sender, EventArgs e)
        {
            LaddaKategorier();
        }

        private void LaddaKategorier()
        {
            var kategoriRepository = new KategoriRepository();
            var kategoriLista = kategoriRepository.LoadCategoryList();

            
        }



        private void KategoriVald(object sender, EventArgs e)
        {
            // TODO: När en kategori är vald, hämta det nuvarande namnet på podcasten.
        }

        private void btnBekraftaAndringar_Click(object sender, EventArgs e)
        {
            // Kontrollera att det nya namnet inte är tomt.
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Ange ett nytt namn för podcasten.");
                return;
            }

            // Spara det nya namnet och uppdatera det i din datakälla.
            _podcastToEdit.Namn = textBox2.Text;

            var podcastController = new PodcastController();
            podcastController.UpdatePodcast(_podcastToEdit.ID, _podcastToEdit);

            PodcastUpdated?.Invoke();

            MessageBox.Show("Podcastnamnet har uppdaterats framgångsrikt!");
            this.Close();
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            // Stänger formuläret utan att göra några ändringar.
            this.Close();
        }

    }
}
