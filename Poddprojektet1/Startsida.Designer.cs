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
            lblPodcastBeskrivning = new Label();
            lblAuthor = new Label();
            lblAvsnittsTitel = new Label();
            lblPubDate = new Label();
            lblAvsnittsBeskrivning = new Label();
            picBoxPodcastBild = new PictureBox();
            label2 = new Label();
            gridPodcasts = new DataGridView();
            podcastNamn = new DataGridViewTextBoxColumn();
            podcastTitel = new DataGridViewTextBoxColumn();
            kategori = new DataGridViewTextBoxColumn();
            senasteAvsnitt = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picBoxPodcastBild).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridPodcasts).BeginInit();
            SuspendLayout();
            // 
            // lblPodcasts
            // 
            lblPodcasts.AutoSize = true;
            lblPodcasts.Font = new Font("Corbel", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblPodcasts.Location = new Point(589, 38);
            lblPodcasts.Margin = new Padding(4, 0, 4, 0);
            lblPodcasts.Name = "lblPodcasts";
            lblPodcasts.Size = new Size(315, 88);
            lblPodcasts.TabIndex = 0;
            lblPodcasts.Text = "Podcasts";
            // 
            // btnHanteraPodcast
            // 
            btnHanteraPodcast.Location = new Point(71, 804);
            btnHanteraPodcast.Margin = new Padding(4);
            btnHanteraPodcast.Name = "btnHanteraPodcast";
            btnHanteraPodcast.Size = new Size(195, 42);
            btnHanteraPodcast.TabIndex = 2;
            btnHanteraPodcast.Text = "Hantera Podcast";
            btnHanteraPodcast.UseVisualStyleBackColor = true;
            btnHanteraPodcast.Click += btnHanteraPodcast_Click;
            // 
            // btnLaggTillPodcast
            // 
            btnLaggTillPodcast.BackColor = Color.Khaki;
            btnLaggTillPodcast.Location = new Point(71, 146);
            btnLaggTillPodcast.Margin = new Padding(4);
            btnLaggTillPodcast.Name = "btnLaggTillPodcast";
            btnLaggTillPodcast.Size = new Size(232, 58);
            btnLaggTillPodcast.TabIndex = 3;
            btnLaggTillPodcast.Text = "Lägg till ny Podcast";
            btnLaggTillPodcast.UseVisualStyleBackColor = false;
            btnLaggTillPodcast.Click += btnLaggTillPodcast_Click;
            // 
            // btnHanteraKategorier
            // 
            btnHanteraKategorier.Location = new Point(679, 249);
            btnHanteraKategorier.Margin = new Padding(4);
            btnHanteraKategorier.Name = "btnHanteraKategorier";
            btnHanteraKategorier.Size = new Size(195, 36);
            btnHanteraKategorier.TabIndex = 4;
            btnHanteraKategorier.Text = "Hantera Kategorier";
            btnHanteraKategorier.UseVisualStyleBackColor = true;
            btnHanteraKategorier.Click += btnHanteraKategorier_Click;
            // 
            // listboxAvsnitt
            // 
            listboxAvsnitt.FormattingEnabled = true;
            listboxAvsnitt.ItemHeight = 25;
            listboxAvsnitt.Location = new Point(915, 461);
            listboxAvsnitt.Margin = new Padding(4);
            listboxAvsnitt.Name = "listboxAvsnitt";
            listboxAvsnitt.Size = new Size(485, 429);
            listboxAvsnitt.TabIndex = 7;
            listboxAvsnitt.SelectedIndexChanged += listboxAvsnitt_SelectedIndexChanged;
            // 
            // lblPodcastNamn
            // 
            lblPodcastNamn.BorderStyle = BorderStyle.FixedSingle;
            lblPodcastNamn.Location = new Point(915, 146);
            lblPodcastNamn.Margin = new Padding(4, 0, 4, 0);
            lblPodcastNamn.Name = "lblPodcastNamn";
            lblPodcastNamn.Size = new Size(246, 57);
            lblPodcastNamn.TabIndex = 8;
            lblPodcastNamn.Text = "PodcastNamn";
            // 
            // lblPodcastTitel
            // 
            lblPodcastTitel.BorderStyle = BorderStyle.FixedSingle;
            lblPodcastTitel.Location = new Point(1158, 146);
            lblPodcastTitel.Margin = new Padding(4, 0, 4, 0);
            lblPodcastTitel.Name = "lblPodcastTitel";
            lblPodcastTitel.Size = new Size(243, 57);
            lblPodcastTitel.TabIndex = 9;
            lblPodcastTitel.Text = "PodcastTitel";
            // 
            // lblKategori
            // 
            lblKategori.BorderStyle = BorderStyle.FixedSingle;
            lblKategori.Location = new Point(915, 204);
            lblKategori.Margin = new Padding(4, 0, 4, 0);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(177, 33);
            lblKategori.TabIndex = 10;
            lblKategori.Text = "Kategori";
            // 
            // lblPodcastBeskrivning
            // 
            lblPodcastBeskrivning.BorderStyle = BorderStyle.FixedSingle;
            lblPodcastBeskrivning.Location = new Point(1091, 204);
            lblPodcastBeskrivning.Margin = new Padding(4, 0, 4, 0);
            lblPodcastBeskrivning.Name = "lblPodcastBeskrivning";
            lblPodcastBeskrivning.Size = new Size(310, 83);
            lblPodcastBeskrivning.TabIndex = 11;
            lblPodcastBeskrivning.Text = "PodcastBeskrivningstext";
            // 
            // lblAuthor
            // 
            lblAuthor.BorderStyle = BorderStyle.FixedSingle;
            lblAuthor.Location = new Point(915, 238);
            lblAuthor.Margin = new Padding(4, 0, 4, 0);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(177, 50);
            lblAuthor.TabIndex = 12;
            lblAuthor.Text = "Author";
            // 
            // lblAvsnittsTitel
            // 
            lblAvsnittsTitel.BorderStyle = BorderStyle.FixedSingle;
            lblAvsnittsTitel.Location = new Point(915, 300);
            lblAvsnittsTitel.Margin = new Padding(4, 0, 4, 0);
            lblAvsnittsTitel.Name = "lblAvsnittsTitel";
            lblAvsnittsTitel.Size = new Size(246, 52);
            lblAvsnittsTitel.TabIndex = 13;
            lblAvsnittsTitel.Text = "AvsnittsTitel";
            // 
            // lblPubDate
            // 
            lblPubDate.BorderStyle = BorderStyle.FixedSingle;
            lblPubDate.Location = new Point(915, 352);
            lblPubDate.Margin = new Padding(4, 0, 4, 0);
            lblPubDate.Name = "lblPubDate";
            lblPubDate.Size = new Size(246, 32);
            lblPubDate.TabIndex = 14;
            lblPubDate.Text = "Publiceringsdatum";
            // 
            // lblAvsnittsBeskrivning
            // 
            lblAvsnittsBeskrivning.BorderStyle = BorderStyle.FixedSingle;
            lblAvsnittsBeskrivning.Location = new Point(915, 385);
            lblAvsnittsBeskrivning.Margin = new Padding(4, 0, 4, 0);
            lblAvsnittsBeskrivning.Name = "lblAvsnittsBeskrivning";
            lblAvsnittsBeskrivning.Size = new Size(246, 72);
            lblAvsnittsBeskrivning.TabIndex = 15;
            lblAvsnittsBeskrivning.Text = "AvsnittsBeskrivningstext";
            // 
            // picBoxPodcastBild
            // 
            picBoxPodcastBild.Location = new Point(1169, 300);
            picBoxPodcastBild.Margin = new Padding(4);
            picBoxPodcastBild.Name = "picBoxPodcastBild";
            picBoxPodcastBild.Size = new Size(232, 158);
            picBoxPodcastBild.TabIndex = 16;
            picBoxPodcastBild.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(71, 226);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(324, 59);
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
            gridPodcasts.Location = new Point(71, 300);
            gridPodcasts.Margin = new Padding(4);
            gridPodcasts.MaximumSize = new Size(802, 475);
            gridPodcasts.MultiSelect = false;
            gridPodcasts.Name = "gridPodcasts";
            gridPodcasts.RowHeadersWidth = 40;
            gridPodcasts.RowTemplate.Height = 29;
            gridPodcasts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridPodcasts.Size = new Size(802, 475);
            gridPodcasts.TabIndex = 18;
            gridPodcasts.CellContentClick += gridPodcasts_CellContentClick;
            // 
            // podcastNamn
            // 
            podcastNamn.HeaderText = "Namn";
            podcastNamn.MinimumWidth = 6;
            podcastNamn.Name = "podcastNamn";
            podcastNamn.Width = 150;
            // 
            // podcastTitel
            // 
            podcastTitel.HeaderText = "Titel";
            podcastTitel.MinimumWidth = 6;
            podcastTitel.Name = "podcastTitel";
            podcastTitel.Width = 150;
            // 
            // kategori
            // 
            kategori.HeaderText = "Kategori";
            kategori.MinimumWidth = 6;
            kategori.Name = "kategori";
            kategori.Width = 150;
            // 
            // senasteAvsnitt
            // 
            senasteAvsnitt.HeaderText = "Senaste Avsnitt";
            senasteAvsnitt.MinimumWidth = 6;
            senasteAvsnitt.Name = "senasteAvsnitt";
            senasteAvsnitt.Width = 150;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(656, 804);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(216, 33);
            comboBox1.TabIndex = 19;
            // 
            // Startsida
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1478, 959);
            Controls.Add(comboBox1);
            Controls.Add(gridPodcasts);
            Controls.Add(label2);
            Controls.Add(picBoxPodcastBild);
            Controls.Add(lblAvsnittsBeskrivning);
            Controls.Add(lblPubDate);
            Controls.Add(lblAvsnittsTitel);
            Controls.Add(lblAuthor);
            Controls.Add(lblPodcastBeskrivning);
            Controls.Add(lblKategori);
            Controls.Add(lblPodcastTitel);
            Controls.Add(lblPodcastNamn);
            Controls.Add(listboxAvsnitt);
            Controls.Add(btnHanteraKategorier);
            Controls.Add(btnLaggTillPodcast);
            Controls.Add(btnHanteraPodcast);
            Controls.Add(lblPodcasts);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Startsida";
            Text = "Startsida";
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
        private Label lblPodcastBeskrivning;
        private Label lblAuthor;
        private Label lblAvsnittsTitel;
        private Label lblPubDate;
        private Label lblAvsnittsBeskrivning;
        private PictureBox picBoxPodcastBild;
        private Label label2;
        private DataGridView gridPodcasts;
        private DataGridViewTextBoxColumn podcastNamn;
        private DataGridViewTextBoxColumn podcastTitel;
        private DataGridViewTextBoxColumn kategori;
        private DataGridViewTextBoxColumn senasteAvsnitt;
        private ComboBox comboBox1;
    }
}