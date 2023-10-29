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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            btnBekraftaAndringar = new Button();
            btnAvbryt = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(312, 77);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 23);
            comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(312, 113);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 1;
            // 
            // btnBekraftaAndringar
            // 
            btnBekraftaAndringar.Location = new Point(312, 158);
            btnBekraftaAndringar.Name = "btnBekraftaAndringar";
            btnBekraftaAndringar.Size = new Size(129, 23);
            btnBekraftaAndringar.TabIndex = 2;
            btnBekraftaAndringar.Text = "Bekräfta ändringar";
            btnBekraftaAndringar.UseVisualStyleBackColor = true;
            btnBekraftaAndringar.Click += btnBekraftaAndringar_Click;
            // 
            // btnAvbryt
            // 
            btnAvbryt.Location = new Point(337, 187);
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
            label1.Location = new Point(289, 30);
            label1.Name = "label1";
            label1.Size = new Size(167, 15);
            label1.TabIndex = 5;
            label1.Text = "Ändra namn (Podcastens titel)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 80);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 6;
            label2.Text = "Välj kategori";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 116);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "Namn";
            // 
            // RedigeraNamn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 337);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAvbryt);
            Controls.Add(btnBekraftaAndringar);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Name = "RedigeraNamn";
            Text = "RedigeraNamn";
            Load += RedigeraNamn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button btnBekraftaAndringar;
        private Button btnAvbryt;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}