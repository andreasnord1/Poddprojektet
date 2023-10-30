namespace Poddprojektet1
{
    partial class AndraPodcastensKategori
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
            cmbAndraKategori = new ComboBox();
            btnBekraftaAndradKategori = new Button();
            lblAndraKategori = new Label();
            SuspendLayout();
            // 
            // cmbAndraKategori
            // 
            cmbAndraKategori.FormattingEnabled = true;
            cmbAndraKategori.Location = new Point(294, 163);
            cmbAndraKategori.Name = "cmbAndraKategori";
            cmbAndraKategori.Size = new Size(174, 28);
            cmbAndraKategori.TabIndex = 0;
            // 
            // btnBekraftaAndradKategori
            // 
            btnBekraftaAndradKategori.Location = new Point(374, 210);
            btnBekraftaAndradKategori.Name = "btnBekraftaAndradKategori";
            btnBekraftaAndradKategori.Size = new Size(94, 29);
            btnBekraftaAndradKategori.TabIndex = 1;
            btnBekraftaAndradKategori.Text = "Bekräfta";
            btnBekraftaAndradKategori.UseVisualStyleBackColor = true;
            btnBekraftaAndradKategori.Click += btnBekraftaAndradKategori_Click;
            // 
            // lblAndraKategori
            // 
            lblAndraKategori.AutoSize = true;
            lblAndraKategori.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAndraKategori.Location = new Point(46, 66);
            lblAndraKategori.Name = "lblAndraKategori";
            lblAndraKategori.Size = new Size(237, 24);
            lblAndraKategori.TabIndex = 2;
            lblAndraKategori.Text = "Var god välj en ny kategori";
            lblAndraKategori.Click += lblAndraKategori_Click;
            // 
            // AndraPodcastensKategori
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 367);
            Controls.Add(lblAndraKategori);
            Controls.Add(btnBekraftaAndradKategori);
            Controls.Add(cmbAndraKategori);
            Name = "AndraPodcastensKategori";
            Text = "AndraPodcastensKategori";
            FormClosing += AndraPodcastensKategori_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAndraKategori;
        private Button btnBekraftaAndradKategori;
        private Label lblAndraKategori;
    }
}