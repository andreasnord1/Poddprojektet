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
            textBoxNyEllerAndra = new TextBox();
            btnBekraftaNyKategori = new Button();
            btnBekraftaAndradKategori = new Button();
            lblValjKategori = new Label();
            btnAngra = new Button();
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
            listBoxKategorier.SelectedIndexChanged += listBoxKategorier_SelectedIndexChanged;
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
            btnAndraNamnKategori.Visible = false;
            btnAndraNamnKategori.Click += btnAndraNamnKategori_Click;
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
            btnTaBortKategori.Visible = false;
            btnTaBortKategori.Click += btnTaBortKategori_Click;
            // 
            // btnLaggTillKategori
            // 
            btnLaggTillKategori.Font = new Font("Corbel", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLaggTillKategori.Location = new Point(429, 81);
            btnLaggTillKategori.Name = "btnLaggTillKategori";
            btnLaggTillKategori.Size = new Size(209, 38);
            btnLaggTillKategori.TabIndex = 4;
            btnLaggTillKategori.Text = "Lägg till en ny kategori";
            btnLaggTillKategori.UseVisualStyleBackColor = true;
            btnLaggTillKategori.Click += btnLaggTillKategori_Click;
            // 
            // textBoxNyEllerAndra
            // 
            textBoxNyEllerAndra.ForeColor = SystemColors.InfoText;
            textBoxNyEllerAndra.Location = new Point(429, 168);
            textBoxNyEllerAndra.Name = "textBoxNyEllerAndra";
            textBoxNyEllerAndra.Size = new Size(209, 27);
            textBoxNyEllerAndra.TabIndex = 5;
            textBoxNyEllerAndra.Visible = false;
            textBoxNyEllerAndra.TextChanged += textBoxNyEllerAndra_TextChanged;
            // 
            // btnBekraftaNyKategori
            // 
            btnBekraftaNyKategori.Font = new Font("Corbel", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnBekraftaNyKategori.Location = new Point(429, 211);
            btnBekraftaNyKategori.Name = "btnBekraftaNyKategori";
            btnBekraftaNyKategori.Size = new Size(98, 54);
            btnBekraftaNyKategori.TabIndex = 6;
            btnBekraftaNyKategori.Text = "Lägg till ny kategori";
            btnBekraftaNyKategori.UseVisualStyleBackColor = true;
            btnBekraftaNyKategori.Visible = false;
            btnBekraftaNyKategori.Click += btnBekraftaNyKategori_Click;
            // 
            // btnBekraftaAndradKategori
            // 
            btnBekraftaAndradKategori.Font = new Font("Corbel", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnBekraftaAndradKategori.Location = new Point(540, 211);
            btnBekraftaAndradKategori.Name = "btnBekraftaAndradKategori";
            btnBekraftaAndradKategori.Size = new Size(98, 54);
            btnBekraftaAndradKategori.TabIndex = 7;
            btnBekraftaAndradKategori.Text = "Bekräfta nytt namn";
            btnBekraftaAndradKategori.UseVisualStyleBackColor = true;
            btnBekraftaAndradKategori.Visible = false;
            btnBekraftaAndradKategori.Click += btnBekraftaAndradKategori_Click;
            // 
            // lblValjKategori
            // 
            lblValjKategori.AutoSize = true;
            lblValjKategori.Font = new Font("Corbel", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            lblValjKategori.ForeColor = SystemColors.HotTrack;
            lblValjKategori.Location = new Point(51, 334);
            lblValjKategori.Name = "lblValjKategori";
            lblValjKategori.Size = new Size(173, 21);
            lblValjKategori.TabIndex = 8;
            lblValjKategori.Text = "Var god välj en kategori!";
            lblValjKategori.Visible = false;
            lblValjKategori.Click += label1_Click;
            // 
            // btnAngra
            // 
            btnAngra.Font = new Font("Corbel", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAngra.Location = new Point(540, 277);
            btnAngra.Name = "btnAngra";
            btnAngra.Size = new Size(98, 31);
            btnAngra.TabIndex = 9;
            btnAngra.Text = "Ångra";
            btnAngra.UseVisualStyleBackColor = true;
            btnAngra.Visible = false;
            btnAngra.Click += btnAngra_Click;
            // 
            // HanteraKategorier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 373);
            Controls.Add(btnAngra);
            Controls.Add(lblValjKategori);
            Controls.Add(btnBekraftaAndradKategori);
            Controls.Add(btnBekraftaNyKategori);
            Controls.Add(textBoxNyEllerAndra);
            Controls.Add(btnLaggTillKategori);
            Controls.Add(btnTaBortKategori);
            Controls.Add(btnAndraNamnKategori);
            Controls.Add(listBoxKategorier);
            Controls.Add(lblKategorier);
            Name = "HanteraKategorier";
            Text = "Hantera Kategorier";
            FormClosing += HanteraKategorier_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKategorier;
        private ListBox listBoxKategorier;
        private Button btnAndraNamnKategori;
        private Button btnTaBortKategori;
        private Button btnLaggTillKategori;
        private TextBox textBoxNyEllerAndra;
        private Button btnBekraftaNyKategori;
        private Button btnBekraftaAndradKategori;
        private Label lblValjKategori;
        private Button btnAngra;
    }
}