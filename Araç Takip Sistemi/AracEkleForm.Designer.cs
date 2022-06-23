
namespace Araç_Takip_Sistemi
{
    partial class AracEkleForm
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
            this.turLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.markaLabel = new System.Windows.Forms.Label();
            this.turComboBox = new System.Windows.Forms.ComboBox();
            this.markaComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resimEkleButton = new System.Windows.Forms.Button();
            this.aracEkleOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.aracGoruntuPictureBox = new System.Windows.Forms.PictureBox();
            this.kaydetButton = new System.Windows.Forms.Button();
            this.yakitTipiLabel = new System.Windows.Forms.Label();
            this.renkLabel = new System.Windows.Forms.Label();
            this.yakitTipiComboBox = new System.Windows.Forms.ComboBox();
            this.renkTextBox = new System.Windows.Forms.TextBox();
            this.yilLabel = new System.Windows.Forms.Label();
            this.yilTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aracGoruntuPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // turLabel
            // 
            this.turLabel.AutoSize = true;
            this.turLabel.Location = new System.Drawing.Point(65, 114);
            this.turLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.turLabel.Name = "turLabel";
            this.turLabel.Size = new System.Drawing.Size(32, 20);
            this.turLabel.TabIndex = 0;
            this.turLabel.Text = "Tür";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(45, 212);
            this.modelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(52, 20);
            this.modelLabel.TabIndex = 2;
            this.modelLabel.Text = "Model";
            // 
            // markaLabel
            // 
            this.markaLabel.AutoSize = true;
            this.markaLabel.Location = new System.Drawing.Point(44, 163);
            this.markaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.markaLabel.Name = "markaLabel";
            this.markaLabel.Size = new System.Drawing.Size(53, 20);
            this.markaLabel.TabIndex = 4;
            this.markaLabel.Text = "Marka";
            // 
            // turComboBox
            // 
            this.turComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.turComboBox.FormattingEnabled = true;
            this.turComboBox.Items.AddRange(new object[] {
            "SUV",
            "SEDAN"});
            this.turComboBox.Location = new System.Drawing.Point(104, 111);
            this.turComboBox.Name = "turComboBox";
            this.turComboBox.Size = new System.Drawing.Size(175, 28);
            this.turComboBox.TabIndex = 5;
            // 
            // markaComboBox
            // 
            this.markaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.markaComboBox.FormattingEnabled = true;
            this.markaComboBox.Items.AddRange(new object[] {
            "Toyota",
            "Honda",
            "Wolkvagen",
            "Mitsubishi",
            "Audi",
            "Bentley",
            "BMW",
            "Bugatti",
            "Cadillac",
            "Chevrolet",
            "Fiat",
            "Ford"});
            this.markaComboBox.Location = new System.Drawing.Point(104, 160);
            this.markaComboBox.Name = "markaComboBox";
            this.markaComboBox.Size = new System.Drawing.Size(175, 28);
            this.markaComboBox.TabIndex = 6;
            this.markaComboBox.SelectedIndexChanged += new System.EventHandler(this.markaComboBox_SelectedIndexChanged);
            // 
            // modelComboBox
            // 
            this.modelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(104, 209);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(175, 28);
            this.modelComboBox.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.yilTextBox);
            this.panel1.Controls.Add(this.yilLabel);
            this.panel1.Controls.Add(this.renkTextBox);
            this.panel1.Controls.Add(this.yakitTipiComboBox);
            this.panel1.Controls.Add(this.renkLabel);
            this.panel1.Controls.Add(this.yakitTipiLabel);
            this.panel1.Controls.Add(this.kaydetButton);
            this.panel1.Controls.Add(this.turComboBox);
            this.panel1.Controls.Add(this.modelComboBox);
            this.panel1.Controls.Add(this.turLabel);
            this.panel1.Controls.Add(this.markaComboBox);
            this.panel1.Controls.Add(this.modelLabel);
            this.panel1.Controls.Add(this.markaLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 561);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.resimEkleButton);
            this.panel2.Controls.Add(this.aracGoruntuPictureBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(303, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 561);
            this.panel2.TabIndex = 9;
            // 
            // resimEkleButton
            // 
            this.resimEkleButton.Location = new System.Drawing.Point(7, 362);
            this.resimEkleButton.Name = "resimEkleButton";
            this.resimEkleButton.Size = new System.Drawing.Size(126, 29);
            this.resimEkleButton.TabIndex = 1;
            this.resimEkleButton.Text = "Resim Seç";
            this.resimEkleButton.UseVisualStyleBackColor = true;
            this.resimEkleButton.Click += new System.EventHandler(this.resimEkleButton_Click);
            // 
            // aracEkleOpenFileDialog
            // 
            this.aracEkleOpenFileDialog.Filter = "Jpeg Dosyaları (*.jpeg)|*.jpeg| Jpg Dosyaları(*.jpg)|*.jpg| Png Dosyaları(*.png)|" +
    "*.png";
            // 
            // aracGoruntuPictureBox
            // 
            this.aracGoruntuPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.aracGoruntuPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aracGoruntuPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.aracGoruntuPictureBox.Location = new System.Drawing.Point(0, 0);
            this.aracGoruntuPictureBox.Name = "aracGoruntuPictureBox";
            this.aracGoruntuPictureBox.Size = new System.Drawing.Size(641, 355);
            this.aracGoruntuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aracGoruntuPictureBox.TabIndex = 0;
            this.aracGoruntuPictureBox.TabStop = false;
            // 
            // kaydetButton
            // 
            this.kaydetButton.Location = new System.Drawing.Point(54, 512);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(192, 37);
            this.kaydetButton.TabIndex = 8;
            this.kaydetButton.Text = "Kaydet";
            this.kaydetButton.UseVisualStyleBackColor = true;
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // yakitTipiLabel
            // 
            this.yakitTipiLabel.AutoSize = true;
            this.yakitTipiLabel.Location = new System.Drawing.Point(24, 359);
            this.yakitTipiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yakitTipiLabel.Name = "yakitTipiLabel";
            this.yakitTipiLabel.Size = new System.Drawing.Size(73, 20);
            this.yakitTipiLabel.TabIndex = 11;
            this.yakitTipiLabel.Text = "Yakıt Tipi";
            // 
            // renkLabel
            // 
            this.renkLabel.AutoSize = true;
            this.renkLabel.Location = new System.Drawing.Point(50, 310);
            this.renkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.renkLabel.Name = "renkLabel";
            this.renkLabel.Size = new System.Drawing.Size(47, 20);
            this.renkLabel.TabIndex = 12;
            this.renkLabel.Text = "Renk";
            // 
            // yakitTipiComboBox
            // 
            this.yakitTipiComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yakitTipiComboBox.FormattingEnabled = true;
            this.yakitTipiComboBox.Items.AddRange(new object[] {
            "Motorin",
            "Dizel",
            "Hybrid",
            "Elektrikli"});
            this.yakitTipiComboBox.Location = new System.Drawing.Point(104, 356);
            this.yakitTipiComboBox.Name = "yakitTipiComboBox";
            this.yakitTipiComboBox.Size = new System.Drawing.Size(175, 28);
            this.yakitTipiComboBox.TabIndex = 14;
            // 
            // renkTextBox
            // 
            this.renkTextBox.Location = new System.Drawing.Point(104, 307);
            this.renkTextBox.Name = "renkTextBox";
            this.renkTextBox.Size = new System.Drawing.Size(175, 26);
            this.renkTextBox.TabIndex = 15;
            // 
            // yilLabel
            // 
            this.yilLabel.AutoSize = true;
            this.yilLabel.Location = new System.Drawing.Point(71, 261);
            this.yilLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yilLabel.Name = "yilLabel";
            this.yilLabel.Size = new System.Drawing.Size(26, 20);
            this.yilLabel.TabIndex = 16;
            this.yilLabel.Text = "Yıl";
            // 
            // yilTextBox
            // 
            this.yilTextBox.Location = new System.Drawing.Point(104, 258);
            this.yilTextBox.Name = "yilTextBox";
            this.yilTextBox.Size = new System.Drawing.Size(175, 26);
            this.yilTextBox.TabIndex = 17;
            // 
            // AracEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AracEkleForm";
            this.Text = "AracEkleForm";
            this.Load += new System.EventHandler(this.AracEkleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aracGoruntuPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label turLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label markaLabel;
        private System.Windows.Forms.ComboBox turComboBox;
        private System.Windows.Forms.ComboBox markaComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button resimEkleButton;
        private System.Windows.Forms.OpenFileDialog aracEkleOpenFileDialog;
        private System.Windows.Forms.PictureBox aracGoruntuPictureBox;
        private System.Windows.Forms.Label yakitTipiLabel;
        private System.Windows.Forms.Button kaydetButton;
        private System.Windows.Forms.TextBox renkTextBox;
        private System.Windows.Forms.ComboBox yakitTipiComboBox;
        private System.Windows.Forms.Label renkLabel;
        private System.Windows.Forms.Label yilLabel;
        private System.Windows.Forms.TextBox yilTextBox;
    }
}