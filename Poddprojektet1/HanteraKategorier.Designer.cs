namespace Poddprojektet1
{
    partial class HanteraKategorier
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
            lblKategorier = new Label();
            listBoxKategorier = new ListBox();
            btnAndraNamnKategori = new Button();
            btnTaBortKategori = new Button();
            btnLaggTillKategori = new Button();
            SuspendLayout();
            // 
            // lblKategorier
            // 
            lblKategorier.AutoSize = true;
            lblKategorier.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblKategorier.Location = new Point(280, 20);
            lblKategorier.Name = "lblKategorier";
            lblKategorier.Size = new Size(112, 28);
            lblKategorier.TabIndex = 0;
            lblKategorier.Text = "Kategorier";
            // 
            // listBoxKategorier
            // 
            listBoxKategorier.Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxKategorier.FormattingEnabled = true;
            listBoxKategorier.ItemHeight = 18;
            listBoxKategorier.Location = new Point(51, 81);
            listBoxKategorier.Name = "listBoxKategorier";
            listBoxKategorier.Size = new Size(299, 184);
            listBoxKategorier.TabIndex = 1;
            // 
            // btnAndraNamnKategori
            // 
            btnAndraNamnKategori.Font = new Font("Corbel", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAndraNamnKategori.Location = new Point(51, 271);
            btnAndraNamnKategori.Name = "btnAndraNamnKategori";
            btnAndraNamnKategori.Size = new Size(144, 60);
            btnAndraNamnKategori.TabIndex = 2;
            btnAndraNamnKategori.Text = "Ändra namn på kategori";
            btnAndraNamnKategori.UseVisualStyleBackColor = true;
            // 
            // btnTaBortKategori
            // 
            btnTaBortKategori.Font = new Font("Corbel", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaBortKategori.Location = new Point(206, 271);
            btnTaBortKategori.Name = "btnTaBortKategori";
            btnTaBortKategori.Size = new Size(144, 60);
            btnTaBortKategori.TabIndex = 3;
            btnTaBortKategori.Text = "Ta bort kategori";
            btnTaBortKategori.UseVisualStyleBackColor = true;
            // 
            // btnLaggTillKategori
            // 
            btnLaggTillKategori.Font = new Font("Corbel", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLaggTillKategori.Location = new Point(419, 81);
            btnLaggTillKategori.Name = "btnLaggTillKategori";
            btnLaggTillKategori.Size = new Size(209, 65);
            btnLaggTillKategori.TabIndex = 4;
            btnLaggTillKategori.Text = "Lägg till en ny kategori";
            btnLaggTillKategori.UseVisualStyleBackColor = true;
            btnLaggTillKategori.Click += btnLaggTillKategori_Click;
            // 
            // HanteraKategorier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 373);
            Controls.Add(btnLaggTillKategori);
            Controls.Add(btnTaBortKategori);
            Controls.Add(btnAndraNamnKategori);
            Controls.Add(listBoxKategorier);
            Controls.Add(lblKategorier);
            Name = "HanteraKategorier";
            Text = "Hantera Kategorier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKategorier;
        private ListBox listBoxKategorier;
        private Button btnAndraNamnKategori;
        private Button btnTaBortKategori;
        private Button btnLaggTillKategori;
    }
}