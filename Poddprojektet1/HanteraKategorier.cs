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
using BusinessLogicLayer;
using DataAccessLayer.Repositories;
using Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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
            IEnumerable<Kategori> kategorier = kategoriController.GetAllKategorier();

            listBoxKategorier.Items.Clear();

            foreach (Kategori item in kategorier)
            {
                string kategori = item.Namn;
                listBoxKategorier.Items.Add(kategori);
            }
        }

        private void btnLaggTillKategori_Click(object sender, EventArgs e)
        {
            textBoxNyEllerAndra.Text = "";

            textBoxNyEllerAndra.PlaceholderText = "Ange ny kategori här...";

            textBoxNyEllerAndra.Visible = true;

            btnBekraftaNyKategori.Visible = true;

            btnAngra.Visible = true;

            btnAndraNamnKategori.Visible = false;

            btnTaBortKategori.Visible = false;



            // Gör så att listboxen inte är klickbar vilket innebär att användaren inte kan byta kategori
            listBoxKategorier.Enabled = false;

            listBoxKategorier.BackColor = SystemColors.Control;
            listBoxKategorier.ForeColor = SystemColors.GrayText;
        }

        private void btnAndraNamnKategori_Click(object sender, EventArgs e)
        {

            // Kontrollerar så att ett alternativ är valt
            if (listBoxKategorier.SelectedItems.Count > 0)
            {
                string? stringKategori = listBoxKategorier.SelectedItem as string;
                if (stringKategori == null) return; // Avbryt metoden om kastningen misslyckades.




                textBoxNyEllerAndra.Text = stringKategori;
                textBoxNyEllerAndra.Visible = true;

                btnBekraftaAndradKategori.Visible = true;

                btnLaggTillKategori.Visible = false;
                btnTaBortKategori.Visible = false;
                btnAngra.Visible = true;


                // Gör så att listboxen inte är klickbar vilket innebär att användaren inte kan byta kategori
                listBoxKategorier.Enabled = false;

                listBoxKategorier.BackColor = SystemColors.Control;
                listBoxKategorier.ForeColor = SystemColors.GrayText;

                lblValjKategori.Visible = false;

            }
            else
            {
                lblValjKategori.Visible = true;
            }



        }

        private void btnBekraftaAndradKategori_Click(object sender, EventArgs e)
        {
            TryUpdateKategori();
        }

        private void TryUpdateKategori()
        {
            string valideringsTyp = "kategori";
            if (Validering.vardeFinns(listBoxKategorier, valideringsTyp) && Validering.vardeFinns(textBoxNyEllerAndra))
            {
                string? tidigareNamn = listBoxKategorier.SelectedItem as string;
                string nyttNamnPaKategori = textBoxNyEllerAndra.Text;
                int antalTeckenInput = nyttNamnPaKategori.Length;
                int antalMinTecken = 3;
                int antalMaxTecken = 20;
                string inputTyp = "ny kategori";

                if (Validering.KontrolleraTeckenAntal(antalTeckenInput, antalMinTecken, antalMaxTecken, inputTyp))
                {
                    Kategori? kategoriAttUppdatera = kategoriController.GetAllKategorier().FirstOrDefault(k => k.Namn == tidigareNamn);

                    if (kategoriAttUppdatera != null)

                        kategoriAttUppdatera.Namn = nyttNamnPaKategori;

                    if (kategoriAttUppdatera != null)

                        kategoriController.UpdateKategori(kategoriAttUppdatera.ID, kategoriAttUppdatera);

                    fyllMedKategorier();

                    UpdateUIAfterKategoriChange();
                }
            }
        }

        private void UpdateUIAfterKategoriChange()
        {
            textBoxNyEllerAndra.Visible = false;
            btnBekraftaAndradKategori.Visible = false;
            btnAngra.Visible = false;
            btnLaggTillKategori.Visible = true;

            listBoxKategorier.Enabled = true;
            listBoxKategorier.BackColor = SystemColors.Window;
            listBoxKategorier.ForeColor = SystemColors.WindowText;
        }


        private void btnBekraftaNyKategori_Click(object sender, EventArgs e)
        {

            string nyKategori = textBoxNyEllerAndra.Text;

            kategoriController.AddKategori(nyKategori);

            fyllMedKategorier();

            textBoxNyEllerAndra.Visible = false;
            btnBekraftaNyKategori.Visible = false;
            btnAngra.Visible = false;

            btnAndraNamnKategori.Visible = true;

            btnTaBortKategori.Visible = true;

            listBoxKategorier.Enabled = true;

            listBoxKategorier.BackColor = SystemColors.Window;
            listBoxKategorier.ForeColor = SystemColors.WindowText;
        }

        private void listBoxKategorier_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAndraNamnKategori.Visible = true;
            btnTaBortKategori.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAngra_Click(object sender, EventArgs e)
        {
            textBoxNyEllerAndra.Visible = false;
            btnBekraftaNyKategori.Visible = false;
            btnBekraftaAndradKategori.Visible = false;
            btnLaggTillKategori.Visible = true;
            btnAndraNamnKategori.Visible = true;

            btnTaBortKategori.Visible = true;

            btnAngra.Visible = false;

            listBoxKategorier.Enabled = true;

            listBoxKategorier.BackColor = SystemColors.Window;
            listBoxKategorier.ForeColor = SystemColors.WindowText;
        }

        private void textBoxNyEllerAndra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            // Kontrollerar så att en kategori är vald i listboxen
            if (listBoxKategorier.SelectedItems.Count > 0)
            {
                string? kategoriString = listBoxKategorier.SelectedItem as string;

                Kategori? kategoriAttTaBort = kategoriController.GetAllKategorier().FirstOrDefault(k => k.Namn == kategoriString);

                if (kategoriAttTaBort != null)
                {
                    BekraftaTaBortKategori bekraftaTaBortKategori = new BekraftaTaBortKategori(kategoriAttTaBort, kategoriController);
                    bekraftaTaBortKategori.Visible = true;
                    this.Dispose();
                }
                else
                {
                    lblValjKategori.Visible = true;
                }

            }


            //private void textBoxNyEllerAndra_GotFocus(object sender, EventArgs e)
            //{
            //    if (textBoxNyEllerAndra.Text == "Nytt kategorinamn...")
            //    {
            //        textBoxNyEllerAndra.Text = "";
            //        textBoxNyEllerAndra.ForeColor = System.Drawing.SystemColors.WindowText;
            //    }
            //}

            //private void textBoxNyEllerAndra_LostFocus(object sender, EventArgs e)
            //{
            //    if (string.IsNullOrWhiteSpace(textBoxNyEllerAndra.Text))
            //    {
            //        textBoxNyEllerAndra.Text = "Nytt kategorinamn...";
            //        textBoxNyEllerAndra.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            //    }
            //}


            //private void textBoxNyEllerAndra_Enter(object sender, EventArgs e)
            //{
            //    if (textBoxNyEllerAndra.Text == "Ny Kategori")
            //    {
            //        textBoxNyEllerAndra.Text = "";
            //        textBoxNyEllerAndra.ForeColor = Color.Black;
            //    }
            //}

            //private void textBoxNyEllerAndra_Leave(object sender, EventArgs e)
            //{
            //    if (textBoxNyEllerAndra.Text == "")
            //    {
            //        textBoxNyEllerAndra.Text = "Ny Kategori";
            //        textBoxNyEllerAndra.ForeColor = Color.LightGray;
            //    }
            //}

            //private void HanteraKategorier_Load(object sender, EventArgs e)
            //{
            //    textBoxNyEllerAndra.Text = "Ny Kategori";
            //    textBoxNyEllerAndra.ForeColor = Color.LightGray;



            //}

        }
    }
}

