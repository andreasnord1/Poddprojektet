using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poddprojektet1
{
    partial class Startsida
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPodcasts = new Label();
            btnHanteraPodcast = new Button();
            btnLaggTillPodcast = new Button();
            btnHanteraKategorier = new Button();
            listboxAvsnitt = new ListBox();
            lblPodcastNamn = new Label();
            lblPodcastTitel = new Label();
            lblKategori = new Label();
            lblAvsnittsTitel = new Label();
            lblPubDate = new Label();
            picBoxPodcastBild = new PictureBox();
            label2 = new Label();
            gridPodcasts = new DataGridView();
            podcastNamn = new DataGridViewTextBoxColumn();
            podcastTitel = new DataGridViewTextBoxColumn();
            kategori = new DataGridViewTextBoxColumn();
            senasteAvsnitt = new DataGridViewTextBoxColumn();
            checkBoxFiltrera = new CheckBox();
            cmbFiltreraKategori = new ComboBox();
            txtBoxAvsnittsBeskrivning = new TextBox();
            txtBoxPodcastBeskrivning = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picBoxPodcastBild).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridPodcasts).BeginInit();
            SuspendLayout();
            // 
            // lblPodcasts
            // 
            lblPodcasts.AutoSize = true;
            lblPodcasts.Font = new Font("Corbel", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblPodcasts.Location = new Point(249, 19);
            lblPodcasts.Name = "lblPodcasts";
            lblPodcasts.Size = new Size(261, 73);
            lblPodcasts.TabIndex = 0;
            lblPodcasts.Text = "Podcasts";
            // 
            // btnHanteraPodcast
            // 
            btnHanteraPodcast.Location = new Point(57, 643);
            btnHanteraPodcast.Name = "btnHanteraPodcast";
            btnHanteraPodcast.Size = new Size(156, 34);
            btnHanteraPodcast.TabIndex = 2;
            btnHanteraPodcast.Text = "Hantera Podcast";
            btnHanteraPodcast.UseVisualStyleBackColor = true;
            btnHanteraPodcast.Click += btnHanteraPodcast_Click;
            // 
            // btnLaggTillPodcast
            // 
            btnLaggTillPodcast.BackColor = Color.Khaki;
            btnLaggTillPodcast.Location = new Point(57, 117);
            btnLaggTillPodcast.Name = "btnLaggTillPodcast";
            btnLaggTillPodcast.Size = new Size(186, 46);
            btnLaggTillPodcast.TabIndex = 3;
            btnLaggTillPodcast.Text = "Lägg till ny Podcast";
            btnLaggTillPodcast.UseVisualStyleBackColor = false;
            btnLaggTillPodcast.Click += btnLaggTillPodcast_Click;
            // 
            // btnHanteraKategorier
            // 
            btnHanteraKategorier.Location = new Point(271, 117);
            btnHanteraKategorier.Name = "btnHanteraKategorier";
            btnHanteraKategorier.Size = new Size(186, 46);
            btnHanteraKategorier.TabIndex = 4;
            btnHanteraKategorier.Text = "Hantera Kategorier";
            btnHanteraKategorier.UseVisualStyleBackColor = true;
            btnHanteraKategorier.Click += btnHanteraKategorier_Click;
            // 
            // listboxAvsnitt
            // 
            listboxAvsnitt.FormattingEnabled = true;
            listboxAvsnitt.ItemHeight = 20;
            listboxAvsnitt.Location = new Point(732, 535);
            listboxAvsnitt.Name = "listboxAvsnitt";
            listboxAvsnitt.Size = new Size(549, 204);
            listboxAvsnitt.TabIndex = 7;
            listboxAvsnitt.SelectedIndexChanged += listboxAvsnitt_SelectedIndexChanged;
            // 
            // lblPodcastNamn
            // 
            lblPodcastNamn.BackColor = SystemColors.Control;
            lblPodcastNamn.Font = new Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPodcastNamn.Location = new Point(732, 28);
            lblPodcastNamn.MaximumSize = new Size(320, 50);
            lblPodcastNamn.Name = "lblPodcastNamn";
            lblPodcastNamn.Size = new Size(320, 50);
            lblPodcastNamn.TabIndex = 8;
            lblPodcastNamn.Text = "PodcastNamn";
            // 
            // lblPodcastTitel
            // 
            lblPodcastTitel.Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPodcastTitel.Location = new Point(732, 78);
            lblPodcastTitel.MaximumSize = new Size(549, 50);
            lblPodcastTitel.Name = "lblPodcastTitel";
            lblPodcastTitel.Size = new Size(549, 50);
            lblPodcastTitel.TabIndex = 9;
            lblPodcastTitel.Text = "PodcastTitel";
            // 
            // lblKategori
            // 
            lblKategori.Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblKategori.Location = new Point(1060, 28);
            lblKategori.MaximumSize = new Size(221, 50);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(221, 50);
            lblKategori.TabIndex = 10;
            lblKategori.Text = "Kategori";
            // 
            // lblAvsnittsTitel
            // 
            lblAvsnittsTitel.Font = new Font("Corbel", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblAvsnittsTitel.Location = new Point(732, 295);
            lblAvsnittsTitel.MaximumSize = new Size(363, 42);
            lblAvsnittsTitel.Name = "lblAvsnittsTitel";
            lblAvsnittsTitel.Size = new Size(363, 42);
            lblAvsnittsTitel.TabIndex = 13;
            lblAvsnittsTitel.Text = "AvsnittsTitel";
            // 
            // lblPubDate
            // 
            lblPubDate.Font = new Font("Corbel", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPubDate.Location = new Point(1101, 295);
            lblPubDate.MaximumSize = new Size(180, 42);
            lblPubDate.Name = "lblPubDate";
            lblPubDate.Size = new Size(180, 42);
            lblPubDate.TabIndex = 14;
            lblPubDate.Text = "Publiceringsdatum";
            // 
            // picBoxPodcastBild
            // 
            picBoxPodcastBild.Location = new Point(1101, 349);
            picBoxPodcastBild.Name = "picBoxPodcastBild";
            picBoxPodcastBild.Size = new Size(180, 180);
            picBoxPodcastBild.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxPodcastBild.TabIndex = 16;
            picBoxPodcastBild.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(57, 181);
            label2.Name = "label2";
            label2.Size = new Size(270, 49);
            label2.TabIndex = 17;
            label2.Text = "Mina Podcasts";
            // 
            // gridPodcasts
            // 
            gridPodcasts.AllowUserToAddRows = false;
            gridPodcasts.AllowUserToDeleteRows = false;
            gridPodcasts.AllowUserToResizeColumns = false;
            gridPodcasts.AllowUserToResizeRows = false;
            gridPodcasts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gridPodcasts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPodcasts.Columns.AddRange(new DataGridViewColumn[] { podcastNamn, podcastTitel, kategori, senasteAvsnitt });
            gridPodcasts.Location = new Point(57, 240);
            gridPodcasts.MaximumSize = new Size(642, 380);
            gridPodcasts.MultiSelect = false;
            gridPodcasts.Name = "gridPodcasts";
            gridPodcasts.ReadOnly = true;
            gridPodcasts.RowHeadersWidth = 40;
            gridPodcasts.RowTemplate.Height = 29;
            gridPodcasts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridPodcasts.Size = new Size(642, 380);
            gridPodcasts.TabIndex = 18;
            gridPodcasts.CellContentClick += gridPodcasts_CellContentClick;
            // 
            // podcastNamn
            // 
            podcastNamn.HeaderText = "Namn";
            podcastNamn.MinimumWidth = 6;
            podcastNamn.Name = "podcastNamn";
            podcastNamn.ReadOnly = true;
            podcastNamn.Width = 150;
            // 
            // podcastTitel
            // 
            podcastTitel.HeaderText = "Titel";
            podcastTitel.MinimumWidth = 6;
            podcastTitel.Name = "podcastTitel";
            podcastTitel.ReadOnly = true;
            podcastTitel.Width = 150;
            // 
            // kategori
            // 
            kategori.HeaderText = "Kategori";
            kategori.MinimumWidth = 6;
            kategori.Name = "kategori";
            kategori.ReadOnly = true;
            kategori.Width = 150;
            // 
            // senasteAvsnitt
            // 
            senasteAvsnitt.HeaderText = "Senaste Avsnitt";
            senasteAvsnitt.MinimumWidth = 6;
            senasteAvsnitt.Name = "senasteAvsnitt";
            senasteAvsnitt.ReadOnly = true;
            senasteAvsnitt.Width = 150;
            // 
            // checkBoxFiltrera
            // 
            checkBoxFiltrera.AutoSize = true;
            checkBoxFiltrera.Location = new Point(548, 170);
            checkBoxFiltrera.Name = "checkBoxFiltrera";
            checkBoxFiltrera.Size = new Size(77, 24);
            checkBoxFiltrera.TabIndex = 20;
            checkBoxFiltrera.Text = "Filtrera";
            checkBoxFiltrera.UseVisualStyleBackColor = true;
            checkBoxFiltrera.CheckedChanged += checkBoxFiltrera_CheckedChanged;
            // 
            // cmbFiltreraKategori
            // 
            cmbFiltreraKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltreraKategori.FormattingEnabled = true;
            cmbFiltreraKategori.Location = new Point(548, 200);
            cmbFiltreraKategori.Name = "cmbFiltreraKategori";
            cmbFiltreraKategori.Size = new Size(151, 28);
            cmbFiltreraKategori.TabIndex = 21;
            cmbFiltreraKategori.SelectedIndexChanged += cmbFiltreraKategori_SelectedIndexChanged;
            // 
            // txtBoxAvsnittsBeskrivning
            // 
            txtBoxAvsnittsBeskrivning.Font = new Font("Corbel", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxAvsnittsBeskrivning.Location = new Point(732, 350);
            txtBoxAvsnittsBeskrivning.Multiline = true;
            txtBoxAvsnittsBeskrivning.Name = "txtBoxAvsnittsBeskrivning";
            txtBoxAvsnittsBeskrivning.ScrollBars = ScrollBars.Vertical;
            txtBoxAvsnittsBeskrivning.Size = new Size(363, 179);
            txtBoxAvsnittsBeskrivning.TabIndex = 22;
            txtBoxAvsnittsBeskrivning.Text = "Avsnittsbeskrivning";
            // 
            // txtBoxPodcastBeskrivning
            // 
            txtBoxPodcastBeskrivning.Font = new Font("Corbel", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPodcastBeskrivning.Location = new Point(732, 135);
            txtBoxPodcastBeskrivning.Multiline = true;
            txtBoxPodcastBeskrivning.Name = "txtBoxPodcastBeskrivning";
            txtBoxPodcastBeskrivning.ScrollBars = ScrollBars.Vertical;
            txtBoxPodcastBeskrivning.Size = new Size(549, 151);
            txtBoxPodcastBeskrivning.TabIndex = 23;
            txtBoxPodcastBeskrivning.Text = "Podcastbeskrivning";
            // 
            // Startsida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1330, 767);
            Controls.Add(txtBoxPodcastBeskrivning);
            Controls.Add(txtBoxAvsnittsBeskrivning);
            Controls.Add(cmbFiltreraKategori);
            Controls.Add(checkBoxFiltrera);
            Controls.Add(gridPodcasts);
            Controls.Add(label2);
            Controls.Add(picBoxPodcastBild);
            Controls.Add(lblPubDate);
            Controls.Add(lblAvsnittsTitel);
            Controls.Add(lblKategori);
            Controls.Add(lblPodcastTitel);
            Controls.Add(lblPodcastNamn);
            Controls.Add(listboxAvsnitt);
            Controls.Add(btnHanteraKategorier);
            Controls.Add(btnLaggTillPodcast);
            Controls.Add(btnHanteraPodcast);
            Controls.Add(lblPodcasts);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Startsida";
            ((System.ComponentModel.ISupportInitialize)picBoxPodcastBild).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridPodcasts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPodcasts;
        private Button btnHanteraPodcast;
        private Button btnLaggTillPodcast;
        private Button btnHanteraKategorier;
        private ListBox listboxAvsnitt;
        private Label lblPodcastNamn;
        private Label lblPodcastTitel;
        private Label lblKategori;
        private Label lblAvsnittsTitel;
        private Label lblPubDate;
        private PictureBox picBoxPodcastBild;
        private Label label2;
        private DataGridView gridPodcasts;
        private DataGridViewTextBoxColumn podcastNamn;
        private DataGridViewTextBoxColumn podcastTitel;
        private DataGridViewTextBoxColumn kategori;
        private DataGridViewTextBoxColumn senasteAvsnitt;
        private CheckBox checkBoxFiltrera;
        private ComboBox cmbFiltreraKategori;
        private TextBox txtBoxAvsnittsBeskrivning;
        private TextBox txtBoxPodcastBeskrivning;
    }
}