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
            lblPodcasts.Location = new Point(471, 30);
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
            btnHanteraKategorier.Location = new Point(543, 199);
            btnHanteraKategorier.Name = "btnHanteraKategorier";
            btnHanteraKategorier.Size = new Size(156, 29);
            btnHanteraKategorier.TabIndex = 4;
            btnHanteraKategorier.Text = "Hantera Kategorier";
            btnHanteraKategorier.UseVisualStyleBackColor = true;
            btnHanteraKategorier.Click += btnHanteraKategorier_Click;
            // 
            // listboxAvsnitt
            // 
            listboxAvsnitt.FormattingEnabled = true;
            listboxAvsnitt.ItemHeight = 20;
            listboxAvsnitt.Location = new Point(732, 369);
            listboxAvsnitt.Name = "listboxAvsnitt";
            listboxAvsnitt.Size = new Size(389, 344);
            listboxAvsnitt.TabIndex = 7;
            listboxAvsnitt.SelectedIndexChanged += listboxAvsnitt_SelectedIndexChanged;
            // 
            // lblPodcastNamn
            // 
            lblPodcastNamn.BorderStyle = BorderStyle.FixedSingle;
            lblPodcastNamn.Location = new Point(732, 117);
            lblPodcastNamn.Name = "lblPodcastNamn";
            lblPodcastNamn.Size = new Size(197, 46);
            lblPodcastNamn.TabIndex = 8;
            lblPodcastNamn.Text = "PodcastNamn";
            // 
            // lblPodcastTitel
            // 
            lblPodcastTitel.BorderStyle = BorderStyle.FixedSingle;
            lblPodcastTitel.Location = new Point(926, 117);
            lblPodcastTitel.Name = "lblPodcastTitel";
            lblPodcastTitel.Size = new Size(195, 46);
            lblPodcastTitel.TabIndex = 9;
            lblPodcastTitel.Text = "PodcastTitel";
            // 
            // lblKategori
            // 
            lblKategori.BorderStyle = BorderStyle.FixedSingle;
            lblKategori.Location = new Point(732, 163);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(142, 27);
            lblKategori.TabIndex = 10;
            lblKategori.Text = "Kategori";
            // 
            // lblPodcastBeskrivning
            // 
            lblPodcastBeskrivning.BorderStyle = BorderStyle.FixedSingle;
            lblPodcastBeskrivning.Location = new Point(873, 163);
            lblPodcastBeskrivning.Name = "lblPodcastBeskrivning";
            lblPodcastBeskrivning.Size = new Size(248, 67);
            lblPodcastBeskrivning.TabIndex = 11;
            lblPodcastBeskrivning.Text = "PodcastBeskrivningstext";
            // 
            // lblAuthor
            // 
            lblAuthor.BorderStyle = BorderStyle.FixedSingle;
            lblAuthor.Location = new Point(732, 190);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(142, 40);
            lblAuthor.TabIndex = 12;
            lblAuthor.Text = "Author";
            // 
            // lblAvsnittsTitel
            // 
            lblAvsnittsTitel.BorderStyle = BorderStyle.FixedSingle;
            lblAvsnittsTitel.Location = new Point(732, 240);
            lblAvsnittsTitel.Name = "lblAvsnittsTitel";
            lblAvsnittsTitel.Size = new Size(197, 42);
            lblAvsnittsTitel.TabIndex = 13;
            lblAvsnittsTitel.Text = "AvsnittsTitel";
            // 
            // lblPubDate
            // 
            lblPubDate.BorderStyle = BorderStyle.FixedSingle;
            lblPubDate.Location = new Point(732, 282);
            lblPubDate.Name = "lblPubDate";
            lblPubDate.Size = new Size(197, 26);
            lblPubDate.TabIndex = 14;
            lblPubDate.Text = "Publiceringsdatum";
            // 
            // lblAvsnittsBeskrivning
            // 
            lblAvsnittsBeskrivning.BorderStyle = BorderStyle.FixedSingle;
            lblAvsnittsBeskrivning.Location = new Point(732, 308);
            lblAvsnittsBeskrivning.Name = "lblAvsnittsBeskrivning";
            lblAvsnittsBeskrivning.Size = new Size(197, 58);
            lblAvsnittsBeskrivning.TabIndex = 15;
            lblAvsnittsBeskrivning.Text = "AvsnittsBeskrivningstext";
            // 
            // picBoxPodcastBild
            // 
            picBoxPodcastBild.Location = new Point(935, 240);
            picBoxPodcastBild.Name = "picBoxPodcastBild";
            picBoxPodcastBild.Size = new Size(186, 126);
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(525, 643);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(174, 28);
            comboBox1.TabIndex = 19;
            // 
            // Startsida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1182, 767);
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
            Margin = new Padding(3, 4, 3, 4);
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