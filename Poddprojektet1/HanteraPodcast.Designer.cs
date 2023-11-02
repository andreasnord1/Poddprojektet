namespace Poddprojektet1
{
    partial class HanteraPodcast
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
            components = new System.ComponentModel.Container();
            gridPodcasts = new DataGridView();
            podcastBindingSource1 = new BindingSource(components);
            podcastBindingSource = new BindingSource(components);
            avsnittBindingSource = new BindingSource(components);
            btnRadera = new Button();
            btnAndraKategori = new Button();
            cmbKategori = new ComboBox();
            lblEller = new Label();
            lblMarkera = new Label();
            btnRedigeraNamn = new Button();
            label1 = new Label();
            btnAvbryt = new Button();
            titelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            namnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            KategoriNamn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridPodcasts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)podcastBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)podcastBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avsnittBindingSource).BeginInit();
            SuspendLayout();
            // 
            // gridPodcasts
            // 
            gridPodcasts.AutoGenerateColumns = false;
            gridPodcasts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPodcasts.Columns.AddRange(new DataGridViewColumn[] { titelDataGridViewTextBoxColumn, namnDataGridViewTextBoxColumn, KategoriNamn });
            gridPodcasts.DataSource = podcastBindingSource1;
            gridPodcasts.Location = new Point(182, 25);
            gridPodcasts.Name = "gridPodcasts";
            gridPodcasts.RowHeadersWidth = 51;
            gridPodcasts.RowTemplate.Height = 29;
            gridPodcasts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridPodcasts.Size = new Size(429, 188);
            gridPodcasts.TabIndex = 0;
            // 
            // podcastBindingSource1
            // 
            podcastBindingSource1.DataSource = typeof(Models.Podcast);
            // 
            // podcastBindingSource
            // 
            podcastBindingSource.DataSource = typeof(Models.Podcast);
            // 
            // avsnittBindingSource
            // 
            avsnittBindingSource.DataMember = "Avsnitt";
            avsnittBindingSource.DataSource = podcastBindingSource;
            // 
            // btnRadera
            // 
            btnRadera.Location = new Point(398, 331);
            btnRadera.Name = "btnRadera";
            btnRadera.Size = new Size(158, 29);
            btnRadera.TabIndex = 1;
            btnRadera.Text = "Radera";
            btnRadera.UseVisualStyleBackColor = true;
            btnRadera.Click += btnRadera_Click;
            // 
            // btnAndraKategori
            // 
            btnAndraKategori.Location = new Point(399, 282);
            btnAndraKategori.Name = "btnAndraKategori";
            btnAndraKategori.Size = new Size(158, 29);
            btnAndraKategori.TabIndex = 2;
            btnAndraKategori.Text = "Ändra kategori";
            btnAndraKategori.UseVisualStyleBackColor = true;
            btnAndraKategori.Click += btnAndraKategori_Click;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(235, 282);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(158, 28);
            cmbKategori.TabIndex = 3;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // lblEller
            // 
            lblEller.AutoSize = true;
            lblEller.Location = new Point(347, 331);
            lblEller.Name = "lblEller";
            lblEller.Size = new Size(47, 20);
            lblEller.TabIndex = 4;
            lblEller.Text = "Eller...";
            // 
            // lblMarkera
            // 
            lblMarkera.AutoSize = true;
            lblMarkera.Location = new Point(260, 238);
            lblMarkera.Name = "lblMarkera";
            lblMarkera.Size = new Size(277, 20);
            lblMarkera.TabIndex = 5;
            lblMarkera.Text = "Markera en podcast i listan ovan för att...";
            // 
            // btnRedigeraNamn
            // 
            btnRedigeraNamn.Location = new Point(399, 382);
            btnRedigeraNamn.Name = "btnRedigeraNamn";
            btnRedigeraNamn.Size = new Size(158, 29);
            btnRedigeraNamn.TabIndex = 6;
            btnRedigeraNamn.Text = "Byt namn";
            btnRedigeraNamn.UseVisualStyleBackColor = true;
            btnRedigeraNamn.Click += btnRedigeraNamn_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 382);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 7;
            label1.Text = "Eller...";
            // 
            // btnAvbryt
            // 
            btnAvbryt.Location = new Point(653, 382);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(109, 29);
            btnAvbryt.TabIndex = 8;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = true;
            btnAvbryt.Click += btnAvbryt_Click;
            // 
            // titelDataGridViewTextBoxColumn
            // 
            titelDataGridViewTextBoxColumn.DataPropertyName = "Titel";
            titelDataGridViewTextBoxColumn.HeaderText = "Titel";
            titelDataGridViewTextBoxColumn.MinimumWidth = 6;
            titelDataGridViewTextBoxColumn.Name = "titelDataGridViewTextBoxColumn";
            titelDataGridViewTextBoxColumn.Width = 125;
            // 
            // namnDataGridViewTextBoxColumn
            // 
            namnDataGridViewTextBoxColumn.DataPropertyName = "Namn";
            namnDataGridViewTextBoxColumn.HeaderText = "Namn";
            namnDataGridViewTextBoxColumn.MinimumWidth = 6;
            namnDataGridViewTextBoxColumn.Name = "namnDataGridViewTextBoxColumn";
            namnDataGridViewTextBoxColumn.Width = 125;
            // 
            // KategoriNamn
            // 
            KategoriNamn.DataPropertyName = "KategoriNamn";
            KategoriNamn.HeaderText = "KategoriNamn";
            KategoriNamn.MinimumWidth = 6;
            KategoriNamn.Name = "KategoriNamn";
            KategoriNamn.ReadOnly = true;
            KategoriNamn.Width = 125;
            // 
            // HanteraPodcast
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAvbryt);
            Controls.Add(label1);
            Controls.Add(btnRedigeraNamn);
            Controls.Add(lblMarkera);
            Controls.Add(lblEller);
            Controls.Add(cmbKategori);
            Controls.Add(btnAndraKategori);
            Controls.Add(btnRadera);
            Controls.Add(gridPodcasts);
            Name = "HanteraPodcast";
            Text = "HanteraPodcast";
            FormClosing += HanteraPodcast_FormClosing;
            ((System.ComponentModel.ISupportInitialize)gridPodcasts).EndInit();
            ((System.ComponentModel.ISupportInitialize)podcastBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)podcastBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)avsnittBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridPodcasts;
        private BindingSource podcastBindingSource1;
        private BindingSource podcastBindingSource;
        private BindingSource avsnittBindingSource;
        private Button btnRadera;
        private Button btnAndraKategori;
        private ComboBox cmbKategori;
        private Label lblEller;
        private Label lblMarkera;
        private Button btnRedigeraNamn;
        private Label label1;
        private Button btnAvbryt;
        private DataGridViewTextBoxColumn titelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn namnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn KategoriNamn;
    }
}