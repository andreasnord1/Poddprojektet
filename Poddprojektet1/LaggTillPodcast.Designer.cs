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
            lblRubrik.Location = new Point(341, 68);
            lblRubrik.Margin = new Padding(4, 0, 4, 0);
            lblRubrik.Name = "lblRubrik";
            lblRubrik.Size = new Size(296, 25);
            lblRubrik.TabIndex = 0;
            lblRubrik.Text = "Lägg till en podcast till ditt bibliotek";
            // 
            // lblURL
            // 
            lblURL.AutoSize = true;
            lblURL.Location = new Point(54, 188);
            lblURL.Margin = new Padding(4, 0, 4, 0);
            lblURL.Name = "lblURL";
            lblURL.Size = new Size(207, 25);
            lblURL.TabIndex = 1;
            lblURL.Text = "Skriv in RSS-flödets URL:";
            // 
            // txtURL
            // 
            txtURL.Location = new Point(54, 230);
            txtURL.Margin = new Padding(4, 3, 4, 3);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(211, 31);
            txtURL.TabIndex = 2;
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Location = new Point(396, 188);
            lblNamn.Margin = new Padding(4, 0, 4, 0);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(172, 25);
            lblNamn.TabIndex = 3;
            lblNamn.Text = "Namnge podcasten:";
            // 
            // txtNamn
            // 
            txtNamn.Location = new Point(396, 230);
            txtNamn.Margin = new Padding(4, 3, 4, 3);
            txtNamn.Name = "txtNamn";
            txtNamn.Size = new Size(210, 31);
            txtNamn.TabIndex = 4;
            // 
            // btnLaggTill
            // 
            btnLaggTill.Location = new Point(434, 397);
            btnLaggTill.Margin = new Padding(4, 3, 4, 3);
            btnLaggTill.Name = "btnLaggTill";
            btnLaggTill.Size = new Size(117, 37);
            btnLaggTill.TabIndex = 5;
            btnLaggTill.Text = "Lägg till";
            btnLaggTill.UseVisualStyleBackColor = true;
            btnLaggTill.Click += btnLaggTill_Click_1;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(730, 188);
            lblKategori.Margin = new Padding(4, 0, 4, 0);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(113, 25);
            lblKategori.TabIndex = 6;
            lblKategori.Text = "Välj kategori:";
            // 
            // cmbPodcastKategori
            // 
            cmbPodcastKategori.FormattingEnabled = true;
            cmbPodcastKategori.Location = new Point(730, 228);
            cmbPodcastKategori.Margin = new Padding(4, 3, 4, 3);
            cmbPodcastKategori.Name = "cmbPodcastKategori";
            cmbPodcastKategori.Size = new Size(210, 33);
            cmbPodcastKategori.TabIndex = 7;
            // 
            // btnAvbryt
            // 
            btnAvbryt.Location = new Point(434, 453);
            btnAvbryt.Margin = new Padding(4, 3, 4, 3);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(117, 37);
            btnAvbryt.TabIndex = 8;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = true;
            btnAvbryt.Click += btnAvbryt_Click;
            // 
            // LaggTillPodcast
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 563);
            Controls.Add(btnAvbryt);
            Controls.Add(cmbPodcastKategori);
            Controls.Add(lblKategori);
            Controls.Add(btnLaggTill);
            Controls.Add(txtNamn);
            Controls.Add(lblNamn);
            Controls.Add(txtURL);
            Controls.Add(lblURL);
            Controls.Add(lblRubrik);
            Margin = new Padding(4, 3, 4, 3);
            Name = "LaggTillPodcast";
            Text = "LaggTillPodcast";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnLaggTill_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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