namespace Poddprojektet1
{
    partial class BekraftaTaBortKategori
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
            lblTaBortKategori = new Label();
            btnBekraftaTaBort = new Button();
            btnAvbryt = new Button();
            SuspendLayout();
            // 
            // lblTaBortKategori
            // 
            lblTaBortKategori.AutoSize = true;
            lblTaBortKategori.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTaBortKategori.Location = new Point(29, 50);
            lblTaBortKategori.Name = "lblTaBortKategori";
            lblTaBortKategori.Size = new Size(403, 24);
            lblTaBortKategori.TabIndex = 0;
            lblTaBortKategori.Text = "Är du säker på att du vill ta bort vald kategori?";
            // 
            // btnBekraftaTaBort
            // 
            btnBekraftaTaBort.Font = new Font("Corbel", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnBekraftaTaBort.Location = new Point(122, 147);
            btnBekraftaTaBort.Name = "btnBekraftaTaBort";
            btnBekraftaTaBort.Size = new Size(94, 29);
            btnBekraftaTaBort.TabIndex = 1;
            btnBekraftaTaBort.Text = "Ja";
            btnBekraftaTaBort.UseVisualStyleBackColor = true;
            btnBekraftaTaBort.Click += btnBekraftaTaBort_Click;
            // 
            // btnAvbryt
            // 
            btnAvbryt.Font = new Font("Corbel", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAvbryt.Location = new Point(328, 147);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(94, 29);
            btnAvbryt.TabIndex = 2;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = true;
            btnAvbryt.Click += btnAvbryt_Click;
            // 
            // BekraftaTaBortKategori
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 253);
            Controls.Add(btnAvbryt);
            Controls.Add(btnBekraftaTaBort);
            Controls.Add(lblTaBortKategori);
            Name = "BekraftaTaBortKategori";
            Text = "BekraftaTaBortKategori";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTaBortKategori;
        private Button btnBekraftaTaBort;
        private Button btnAvbryt;
    }
}