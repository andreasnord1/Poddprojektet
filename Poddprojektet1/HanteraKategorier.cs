using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.Controllers;
using Models;


namespace Poddprojektet1
{
    public partial class HanteraKategorier : Form
    {
        KategoriController kategoriController;
        public HanteraKategorier()
        {
            InitializeComponent();
            kategoriController = new KategoriController();
            fyllMedKategorier();
        }

        private void fyllMedKategorier()
        {
            var kategorier = kategoriController.GetAllKategorier();

            foreach (var item in kategorier)
            {
                listBoxKategorier.Items.Add(item);

            }
        }

        private void btnLaggTillKategori_Click(object sender, EventArgs e)
        {
            kategoriController.AddKategori("Komedi");
        }

        private void btnAndraNamnKategori_Click(object sender, EventArgs e)
        {

            // Här ska den valda kategorin hämtas
            string kategori = "Komedi";

            textBoxNyEllerAndra.Text = kategori;
            textBoxNyEllerAndra.Visible = true;

            btnAndraNamnKategori.Visible = true;

        }

        private void btnBekraftaAndradKategori_Click(object sender, EventArgs e)
        {
            string nyttNamnPaKategori = textBoxNyEllerAndra.Text;

            // Här ska den tidigare valda kategorins namn hämtas
            string kategori = "Komedi";


        }
    }
}
