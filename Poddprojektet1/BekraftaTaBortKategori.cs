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
    public partial class BekraftaTaBortKategori : Form
    {
        Kategori kategoriAttTaBort;
        KategoriController kategoriControllern;

        public BekraftaTaBortKategori(Kategori kategori, KategoriController kategoriController)
        {
            InitializeComponent();
            kategoriAttTaBort = kategori;
            setTextToLabel(kategoriAttTaBort);
            kategoriControllern = kategoriController;

        }

        private void setTextToLabel(Kategori kategoriAttTaBort)
        {
            lblTaBortKategori.Text = "Är du säker på att du vill ta bort kategorin " + kategoriAttTaBort.Namn + "?";
        }


        private void btnBekraftaTaBort_Click(object sender, EventArgs e)
        {
            kategoriControllern.DeleteKategori(kategoriAttTaBort.ID);
            MessageBox.Show("Kategorin har tagits bort!");
            HanteraKategorier hanteraKategorier = new HanteraKategorier();
            hanteraKategorier.Visible = true;
            this.Dispose();
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            HanteraKategorier hanteraKategorier = new HanteraKategorier();
            hanteraKategorier.Visible = true;
            this.Dispose();
        }
    }
}
