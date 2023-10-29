﻿using System;
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

        public RedigeraNamn(Podcast selectedPodcast)
        {
            InitializeComponent();

            _podcastToEdit = selectedPodcast;

            // Om man vill visa podcastens nuvarande namn i ett textfält kan du göra det här:
            txtPodcastName.Text = _podcastToEdit.Namn;

        }

        public Podcast UpdatedPodcast
        {
            get
            {
                // Om man vill hämta det uppdaterade namnet från ett textfält:
                _podcastToEdit.Namn = txtPodcastName.Text;

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

            // Antag att din dropdown-lista heter 'dropdownKategorier':
            comboBox1.Items.Clear();
            foreach (var kategori in kategoriLista.Categories)
            {
                comboBox1.Items.Add(kategori);
            }
        }



        private void KategoriVald(object sender, EventArgs e)
        {
            // TODO: När en kategori är vald, hämta det nuvarande namnet på podcasten.
        }

        private void btnBekraftaAndringar_Click(object sender, EventArgs e)
        {
            // TODO: Spara det nya namnet och uppdatera det i din datakälla.
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            // Stänger formuläret utan att göra några ändringar.
            this.Close();
        }

    }
}