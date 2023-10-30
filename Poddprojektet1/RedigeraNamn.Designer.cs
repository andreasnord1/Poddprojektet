namespace Poddprojektet1
{
    partial class RedigeraNamn
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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            btnBekraftaAndringar = new Button();
            btnAvbryt = new Button();
            label1 = new Label();
            lblKategori = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            bindingSource1 = new BindingSource(components);
            comboBox2 = new ComboBox();
            label5 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(205, 60);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 23);
            comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 93);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 1;
            // 
            // btnBekraftaAndringar
            // 
            btnBekraftaAndringar.Location = new Point(205, 163);
            btnBekraftaAndringar.Name = "btnBekraftaAndringar";
            btnBekraftaAndringar.Size = new Size(129, 23);
            btnBekraftaAndringar.TabIndex = 2;
            btnBekraftaAndringar.Text = "Bekräfta ändringar";
            btnBekraftaAndringar.UseVisualStyleBackColor = true;
            btnBekraftaAndringar.Click += btnBekraftaAndringar_Click;
            // 
            // btnAvbryt
            // 
            btnAvbryt.Location = new Point(229, 206);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(75, 23);
            btnAvbryt.TabIndex = 4;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = true;
            btnAvbryt.Click += btnAvbryt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 24);
            label1.Name = "label1";
            label1.Size = new Size(202, 15);
            label1.TabIndex = 5;
            label1.Text = "Välj en podcast och ändra dess namn";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(149, 63);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(51, 15);
            lblKategori.TabIndex = 6;
            lblKategori.Text = "Kategori";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 96);
            label3.Name = "label3";
            label3.Size = new Size(173, 15);
            label3.TabIndex = 7;
            label3.Text = "Nuvarande namn på podcasten";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 127);
            label4.Name = "label4";
            label4.Size = new Size(138, 15);
            label4.TabIndex = 8;
            label4.Text = "Nytt namn på podcasten";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 124);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 23);
            textBox2.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(527, 60);
            comboBox2.Margin = new Padding(2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(129, 23);
            comboBox2.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(353, 63);
            label5.Name = "label5";
            label5.Size = new Size(169, 15);
            label5.TabIndex = 11;
            label5.Text = "Podcasts som ingår i kategorin";
            // 
            // RedigeraNamn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 337);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblKategori);
            Controls.Add(label1);
            Controls.Add(btnAvbryt);
            Controls.Add(btnBekraftaAndringar);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Name = "RedigeraNamn";
            Text = "Uppdatera Podcast-namn";
            Load += RedigeraNamn_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button btnBekraftaAndringar;
        private Button btnAvbryt;
        private Label label1;
        private Label lblKategori;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private BindingSource bindingSource1;
        private ComboBox comboBox2;
        private Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}