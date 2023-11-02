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
            textBox1 = new TextBox();
            btnBekraftaAndringar = new Button();
            btnAvbryt = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            bindingSource1 = new BindingSource(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(235, 128);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 27);
            textBox1.TabIndex = 1;
            // 
            // btnBekraftaAndringar
            // 
            btnBekraftaAndringar.Location = new Point(234, 218);
            btnBekraftaAndringar.Margin = new Padding(3, 4, 3, 4);
            btnBekraftaAndringar.Name = "btnBekraftaAndringar";
            btnBekraftaAndringar.Size = new Size(147, 30);
            btnBekraftaAndringar.TabIndex = 2;
            btnBekraftaAndringar.Text = "Bekräfta ändringar";
            btnBekraftaAndringar.UseVisualStyleBackColor = true;
            btnBekraftaAndringar.Click += btnBekraftaAndringar_Click;
            // 
            // btnAvbryt
            // 
            btnAvbryt.Location = new Point(262, 270);
            btnAvbryt.Margin = new Padding(3, 4, 3, 4);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(86, 30);
            btnAvbryt.TabIndex = 4;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = true;
            btnAvbryt.Click += btnAvbryt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 63);
            label1.Name = "label1";
            label1.Size = new Size(254, 20);
            label1.TabIndex = 5;
            label1.Text = "Välj en podcast och ändra dess namn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 128);
            label3.Name = "label3";
            label3.Size = new Size(216, 20);
            label3.TabIndex = 7;
            label3.Text = "Nuvarande namn på podcasten";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 166);
            label4.Name = "label4";
            label4.Size = new Size(172, 20);
            label4.TabIndex = 8;
            label4.Text = "Nytt namn på podcasten";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(234, 166);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(147, 27);
            textBox2.TabIndex = 9;
            // 
            // RedigeraNamn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 355);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnAvbryt);
            Controls.Add(btnBekraftaAndringar);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RedigeraNamn";
            Text = "Uppdatera Podcast-namn";
            Load += RedigeraNamn_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button btnBekraftaAndringar;
        private Button btnAvbryt;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}