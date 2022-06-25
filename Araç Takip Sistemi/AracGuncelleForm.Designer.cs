
namespace Araç_Takip_Sistemi
{
    partial class AracGuncelleForm
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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.guncelleButton = new System.Windows.Forms.Button();
            this.yilTextBox = new System.Windows.Forms.TextBox();
            this.sorgulaPanel = new System.Windows.Forms.Panel();
            this.sorgulaButton = new System.Windows.Forms.Button();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.yilLabel = new System.Windows.Forms.Label();
            this.turComboBox = new System.Windows.Forms.ComboBox();
            this.renkTextBox = new System.Windows.Forms.TextBox();
            this.markaLabel = new System.Windows.Forms.Label();
            this.yakitTipiComboBox = new System.Windows.Forms.ComboBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.renkLabel = new System.Windows.Forms.Label();
            this.markaComboBox = new System.Windows.Forms.ComboBox();
            this.yakitTipiLabel = new System.Windows.Forms.Label();
            this.turLabel = new System.Windows.Forms.Label();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resimEkleButton = new System.Windows.Forms.Button();
            this.aracGoruntuPictureBox = new System.Windows.Forms.PictureBox();
            this.aracGuncelleOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.sidePanel.SuspendLayout();
            this.sorgulaPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aracGoruntuPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidePanel.Controls.Add(this.guncelleButton);
            this.sidePanel.Controls.Add(this.yilTextBox);
            this.sidePanel.Controls.Add(this.sorgulaPanel);
            this.sidePanel.Controls.Add(this.yilLabel);
            this.sidePanel.Controls.Add(this.turComboBox);
            this.sidePanel.Controls.Add(this.renkTextBox);
            this.sidePanel.Controls.Add(this.markaLabel);
            this.sidePanel.Controls.Add(this.yakitTipiComboBox);
            this.sidePanel.Controls.Add(this.modelLabel);
            this.sidePanel.Controls.Add(this.renkLabel);
            this.sidePanel.Controls.Add(this.markaComboBox);
            this.sidePanel.Controls.Add(this.yakitTipiLabel);
            this.sidePanel.Controls.Add(this.turLabel);
            this.sidePanel.Controls.Add(this.modelComboBox);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(275, 561);
            this.sidePanel.TabIndex = 0;
            // 
            // guncelleButton
            // 
            this.guncelleButton.Enabled = false;
            this.guncelleButton.Location = new System.Drawing.Point(12, 503);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(251, 46);
            this.guncelleButton.TabIndex = 30;
            this.guncelleButton.Text = "Güncelle";
            this.guncelleButton.UseVisualStyleBackColor = true;
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // yilTextBox
            // 
            this.yilTextBox.Enabled = false;
            this.yilTextBox.Location = new System.Drawing.Point(92, 251);
            this.yilTextBox.Name = "yilTextBox";
            this.yilTextBox.Size = new System.Drawing.Size(175, 26);
            this.yilTextBox.TabIndex = 29;
            // 
            // sorgulaPanel
            // 
            this.sorgulaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sorgulaPanel.Controls.Add(this.sorgulaButton);
            this.sorgulaPanel.Controls.Add(this.IDTextBox);
            this.sorgulaPanel.Controls.Add(this.IDLabel);
            this.sorgulaPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sorgulaPanel.Location = new System.Drawing.Point(0, 0);
            this.sorgulaPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sorgulaPanel.Name = "sorgulaPanel";
            this.sorgulaPanel.Size = new System.Drawing.Size(273, 96);
            this.sorgulaPanel.TabIndex = 0;
            // 
            // sorgulaButton
            // 
            this.sorgulaButton.Location = new System.Drawing.Point(55, 44);
            this.sorgulaButton.Name = "sorgulaButton";
            this.sorgulaButton.Size = new System.Drawing.Size(212, 39);
            this.sorgulaButton.TabIndex = 2;
            this.sorgulaButton.Text = "Sorgula";
            this.sorgulaButton.UseVisualStyleBackColor = true;
            this.sorgulaButton.Click += new System.EventHandler(this.sorgulaButton_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(55, 12);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(212, 26);
            this.IDTextBox.TabIndex = 1;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(7, 15);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(26, 20);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID";
            // 
            // yilLabel
            // 
            this.yilLabel.AutoSize = true;
            this.yilLabel.Location = new System.Drawing.Point(59, 254);
            this.yilLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yilLabel.Name = "yilLabel";
            this.yilLabel.Size = new System.Drawing.Size(26, 20);
            this.yilLabel.TabIndex = 28;
            this.yilLabel.Text = "Yıl";
            // 
            // turComboBox
            // 
            this.turComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.turComboBox.Enabled = false;
            this.turComboBox.FormattingEnabled = true;
            this.turComboBox.Items.AddRange(new object[] {
            "SUV",
            "SEDAN"});
            this.turComboBox.Location = new System.Drawing.Point(92, 104);
            this.turComboBox.Name = "turComboBox";
            this.turComboBox.Size = new System.Drawing.Size(175, 28);
            this.turComboBox.TabIndex = 21;
            // 
            // renkTextBox
            // 
            this.renkTextBox.Enabled = false;
            this.renkTextBox.Location = new System.Drawing.Point(92, 300);
            this.renkTextBox.Name = "renkTextBox";
            this.renkTextBox.Size = new System.Drawing.Size(175, 26);
            this.renkTextBox.TabIndex = 27;
            // 
            // markaLabel
            // 
            this.markaLabel.AutoSize = true;
            this.markaLabel.Location = new System.Drawing.Point(32, 156);
            this.markaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.markaLabel.Name = "markaLabel";
            this.markaLabel.Size = new System.Drawing.Size(53, 20);
            this.markaLabel.TabIndex = 20;
            this.markaLabel.Text = "Marka";
            // 
            // yakitTipiComboBox
            // 
            this.yakitTipiComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yakitTipiComboBox.Enabled = false;
            this.yakitTipiComboBox.FormattingEnabled = true;
            this.yakitTipiComboBox.Items.AddRange(new object[] {
            "Motorin",
            "Dizel",
            "Hybrid",
            "Elektrikli"});
            this.yakitTipiComboBox.Location = new System.Drawing.Point(92, 349);
            this.yakitTipiComboBox.Name = "yakitTipiComboBox";
            this.yakitTipiComboBox.Size = new System.Drawing.Size(175, 28);
            this.yakitTipiComboBox.TabIndex = 26;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(33, 205);
            this.modelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(52, 20);
            this.modelLabel.TabIndex = 19;
            this.modelLabel.Text = "Model";
            // 
            // renkLabel
            // 
            this.renkLabel.AutoSize = true;
            this.renkLabel.Location = new System.Drawing.Point(38, 303);
            this.renkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.renkLabel.Name = "renkLabel";
            this.renkLabel.Size = new System.Drawing.Size(47, 20);
            this.renkLabel.TabIndex = 25;
            this.renkLabel.Text = "Renk";
            // 
            // markaComboBox
            // 
            this.markaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.markaComboBox.Enabled = false;
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
            this.markaComboBox.Location = new System.Drawing.Point(92, 153);
            this.markaComboBox.Name = "markaComboBox";
            this.markaComboBox.Size = new System.Drawing.Size(175, 28);
            this.markaComboBox.TabIndex = 22;
            this.markaComboBox.SelectedIndexChanged += new System.EventHandler(this.markaComboBox_SelectedIndexChanged);
            // 
            // yakitTipiLabel
            // 
            this.yakitTipiLabel.AutoSize = true;
            this.yakitTipiLabel.Location = new System.Drawing.Point(12, 352);
            this.yakitTipiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yakitTipiLabel.Name = "yakitTipiLabel";
            this.yakitTipiLabel.Size = new System.Drawing.Size(73, 20);
            this.yakitTipiLabel.TabIndex = 24;
            this.yakitTipiLabel.Text = "Yakıt Tipi";
            // 
            // turLabel
            // 
            this.turLabel.AutoSize = true;
            this.turLabel.Location = new System.Drawing.Point(53, 107);
            this.turLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.turLabel.Name = "turLabel";
            this.turLabel.Size = new System.Drawing.Size(32, 20);
            this.turLabel.TabIndex = 18;
            this.turLabel.Text = "Tür";
            // 
            // modelComboBox
            // 
            this.modelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelComboBox.Enabled = false;
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(92, 202);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(175, 28);
            this.modelComboBox.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.resimEkleButton);
            this.panel2.Controls.Add(this.aracGoruntuPictureBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(275, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 561);
            this.panel2.TabIndex = 10;
            // 
            // resimEkleButton
            // 
            this.resimEkleButton.Enabled = false;
            this.resimEkleButton.Location = new System.Drawing.Point(7, 362);
            this.resimEkleButton.Name = "resimEkleButton";
            this.resimEkleButton.Size = new System.Drawing.Size(126, 29);
            this.resimEkleButton.TabIndex = 1;
            this.resimEkleButton.Text = "Resim Seç";
            this.resimEkleButton.UseVisualStyleBackColor = true;
            this.resimEkleButton.Click += new System.EventHandler(this.resimEkleButton_Click);
            // 
            // aracGoruntuPictureBox
            // 
            this.aracGoruntuPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.aracGoruntuPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aracGoruntuPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.aracGoruntuPictureBox.Location = new System.Drawing.Point(0, 0);
            this.aracGoruntuPictureBox.Name = "aracGoruntuPictureBox";
            this.aracGoruntuPictureBox.Size = new System.Drawing.Size(669, 355);
            this.aracGoruntuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aracGoruntuPictureBox.TabIndex = 0;
            this.aracGoruntuPictureBox.TabStop = false;
            // 
            // aracGuncelleOpenFileDialog
            // 
            this.aracGuncelleOpenFileDialog.FileName = "openFileDialog1";
            // 
            // AracGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sidePanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AracGuncelleForm";
            this.Text = "AracGuncelleForm";
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.sorgulaPanel.ResumeLayout(false);
            this.sorgulaPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aracGoruntuPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel sorgulaPanel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Button sorgulaButton;
        private System.Windows.Forms.TextBox yilTextBox;
        private System.Windows.Forms.Label yilLabel;
        private System.Windows.Forms.TextBox renkTextBox;
        private System.Windows.Forms.ComboBox yakitTipiComboBox;
        private System.Windows.Forms.Label renkLabel;
        private System.Windows.Forms.Label yakitTipiLabel;
        private System.Windows.Forms.ComboBox turComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.Label turLabel;
        private System.Windows.Forms.ComboBox markaComboBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label markaLabel;
        private System.Windows.Forms.Button guncelleButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button resimEkleButton;
        private System.Windows.Forms.PictureBox aracGoruntuPictureBox;
        private System.Windows.Forms.OpenFileDialog aracGuncelleOpenFileDialog;
    }
}