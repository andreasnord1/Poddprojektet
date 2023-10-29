namespace Poddprojektet1
{
    partial class LaggTillPodcast
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblRubrik = new Label();
            lblURL = new Label();
            txtURL = new TextBox();
            lblNamn = new Label();
            txtNamn = new TextBox();
            btnLaggTill = new Button();
            lblKategori = new Label();
            cmbPodcastKategori = new ComboBox();
            btnAvbryt = new Button();
            SuspendLayout();
            // 
            // lblRubrik
            // 
            lblRubrik.AutoSize = true;
            lblRubrik.Location = new Point(273, 54);
            lblRubrik.Name = "lblRubrik";
            lblRubrik.Size = new Size(251, 20);
            lblRubrik.TabIndex = 0;
            lblRubrik.Text = "Lägg till en podcast till ditt bibliotek";
            // 
            // lblURL
            // 
            lblURL.AutoSize = true;
            lblURL.Location = new Point(43, 150);
            lblURL.Name = "lblURL";
            lblURL.Size = new Size(170, 20);
            lblURL.TabIndex = 1;
            lblURL.Text = "Skriv in RSS-flödets URL:";
            // 
            // txtURL
            // 
            txtURL.Location = new Point(43, 184);
            txtURL.Margin = new Padding(3, 2, 3, 2);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(170, 27);
            txtURL.TabIndex = 2;
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Location = new Point(317, 150);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(142, 20);
            lblNamn.TabIndex = 3;
            lblNamn.Text = "Namnge podcasten:";
            // 
            // txtNamn
            // 
            txtNamn.Location = new Point(317, 184);
            txtNamn.Margin = new Padding(3, 2, 3, 2);
            txtNamn.Name = "txtNamn";
            txtNamn.Size = new Size(169, 27);
            txtNamn.TabIndex = 4;
            // 
            // btnLaggTill
            // 
            btnLaggTill.Location = new Point(347, 318);
            btnLaggTill.Margin = new Padding(3, 2, 3, 2);
            btnLaggTill.Name = "btnLaggTill";
            btnLaggTill.Size = new Size(94, 30);
            btnLaggTill.TabIndex = 5;
            btnLaggTill.Text = "Lägg till";
            btnLaggTill.UseVisualStyleBackColor = true;
            btnLaggTill.Click += btnLaggTill_Click;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(584, 150);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(95, 20);
            lblKategori.TabIndex = 6;
            lblKategori.Text = "Välj kategori:";
            // 
            // cmbPodcastKategori
            // 
            cmbPodcastKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPodcastKategori.FormattingEnabled = true;
            cmbPodcastKategori.Location = new Point(584, 182);
            cmbPodcastKategori.Margin = new Padding(3, 2, 3, 2);
            cmbPodcastKategori.Name = "cmbPodcastKategori";
            cmbPodcastKategori.Size = new Size(169, 28);
            cmbPodcastKategori.TabIndex = 7;
            cmbPodcastKategori.SelectedIndexChanged += cmbPodcastKategori_SelectedIndexChanged;
            // 
            // btnAvbryt
            // 
            btnAvbryt.Location = new Point(347, 362);
            btnAvbryt.Margin = new Padding(3, 2, 3, 2);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(94, 30);
            btnAvbryt.TabIndex = 8;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = true;
            btnAvbryt.Click += btnAvbryt_Click;
            // 
            // LaggTillPodcast
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAvbryt);
            Controls.Add(cmbPodcastKategori);
            Controls.Add(lblKategori);
            Controls.Add(btnLaggTill);
            Controls.Add(txtNamn);
            Controls.Add(lblNamn);
            Controls.Add(txtURL);
            Controls.Add(lblURL);
            Controls.Add(lblRubrik);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LaggTillPodcast";
            Text = "LaggTillPodcast";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label lblRubrik;
        private Label lblURL;
        private TextBox txtURL;
        private Label lblNamn;
        private TextBox txtNamn;
        private Button btnLaggTill;
        private Label lblKategori;
        private ComboBox cmbPodcastKategori;
        private Button btnAvbryt;
    }
}