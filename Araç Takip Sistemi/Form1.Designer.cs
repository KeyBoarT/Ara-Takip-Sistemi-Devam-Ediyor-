
namespace Araç_Takip_Sistemi
{
    partial class mainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuSidePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.islemdekiAraclar = new System.Windows.Forms.Button();
            this.musterilerSubmenuPanel = new System.Windows.Forms.Panel();
            this.musteriGuncelleButton = new System.Windows.Forms.Button();
            this.musteriSilButton = new System.Windows.Forms.Button();
            this.musteriEkleButton = new System.Windows.Forms.Button();
            this.musteriListeleButton = new System.Windows.Forms.Button();
            this.musterilerButton = new System.Windows.Forms.Button();
            this.araclarSubmenuPanel = new System.Windows.Forms.Panel();
            this.aracGuncelle = new System.Windows.Forms.Button();
            this.aracSilButton = new System.Windows.Forms.Button();
            this.aracEkleButton = new System.Windows.Forms.Button();
            this.aracListeleButton = new System.Windows.Forms.Button();
            this.araclarButton = new System.Windows.Forms.Button();
            this.mainMenuPictureBox = new System.Windows.Forms.Panel();
            this.resimEkleButton = new System.Windows.Forms.Button();
            this.userPictureBox = new Araç_Takip_Sistemi.CircularPictureBox();
            this.mainMenuFillPanel = new System.Windows.Forms.Panel();
            this.resimOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainMenuSidePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.musterilerSubmenuPanel.SuspendLayout();
            this.araclarSubmenuPanel.SuspendLayout();
            this.mainMenuPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuSidePanel
            // 
            this.mainMenuSidePanel.AutoScroll = true;
            this.mainMenuSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(250)))));
            this.mainMenuSidePanel.Controls.Add(this.panel1);
            this.mainMenuSidePanel.Controls.Add(this.islemdekiAraclar);
            this.mainMenuSidePanel.Controls.Add(this.musterilerSubmenuPanel);
            this.mainMenuSidePanel.Controls.Add(this.musterilerButton);
            this.mainMenuSidePanel.Controls.Add(this.araclarSubmenuPanel);
            this.mainMenuSidePanel.Controls.Add(this.araclarButton);
            this.mainMenuSidePanel.Controls.Add(this.mainMenuPictureBox);
            this.mainMenuSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainMenuSidePanel.Location = new System.Drawing.Point(0, 0);
            this.mainMenuSidePanel.Name = "mainMenuSidePanel";
            this.mainMenuSidePanel.Size = new System.Drawing.Size(200, 561);
            this.mainMenuSidePanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 645);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 180);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(200)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 135);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(183, 45);
            this.button3.TabIndex = 11;
            this.button3.Text = "Müşteri Güncelle";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(200)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 90);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(183, 45);
            this.button5.TabIndex = 10;
            this.button5.Text = "Müşteri Sil";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(200)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 45);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(183, 45);
            this.button6.TabIndex = 9;
            this.button6.Text = "Müşteri Ekle";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(200)))));
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(183, 45);
            this.button7.TabIndex = 8;
            this.button7.Text = "Müşteri Listele";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // islemdekiAraclar
            // 
            this.islemdekiAraclar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(175)))));
            this.islemdekiAraclar.Dock = System.Windows.Forms.DockStyle.Top;
            this.islemdekiAraclar.FlatAppearance.BorderSize = 0;
            this.islemdekiAraclar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.islemdekiAraclar.ForeColor = System.Drawing.Color.White;
            this.islemdekiAraclar.Location = new System.Drawing.Point(0, 600);
            this.islemdekiAraclar.Name = "islemdekiAraclar";
            this.islemdekiAraclar.Size = new System.Drawing.Size(183, 45);
            this.islemdekiAraclar.TabIndex = 7;
            this.islemdekiAraclar.Text = "Müşteriler";
            this.islemdekiAraclar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.islemdekiAraclar.UseVisualStyleBackColor = false;
            this.islemdekiAraclar.Visible = false;
            // 
            // musterilerSubmenuPanel
            // 
            this.musterilerSubmenuPanel.Controls.Add(this.musteriGuncelleButton);
            this.musterilerSubmenuPanel.Controls.Add(this.musteriSilButton);
            this.musterilerSubmenuPanel.Controls.Add(this.musteriEkleButton);
            this.musterilerSubmenuPanel.Controls.Add(this.musteriListeleButton);
            this.musterilerSubmenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.musterilerSubmenuPanel.Location = new System.Drawing.Point(0, 420);
            this.musterilerSubmenuPanel.Name = "musterilerSubmenuPanel";
            this.musterilerSubmenuPanel.Size = new System.Drawing.Size(183, 180);
            this.musterilerSubmenuPanel.TabIndex = 6;
            // 
            // musteriGuncelleButton
            // 
            this.musteriGuncelleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(200)))));
            this.musteriGuncelleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.musteriGuncelleButton.FlatAppearance.BorderSize = 0;
            this.musteriGuncelleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteriGuncelleButton.ForeColor = System.Drawing.Color.White;
            this.musteriGuncelleButton.Location = new System.Drawing.Point(0, 135);
            this.musteriGuncelleButton.Name = "musteriGuncelleButton";
            this.musteriGuncelleButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.musteriGuncelleButton.Size = new System.Drawing.Size(183, 45);
            this.musteriGuncelleButton.TabIndex = 11;
            this.musteriGuncelleButton.Text = "Müşteri Güncelle";
            this.musteriGuncelleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.musteriGuncelleButton.UseVisualStyleBackColor = false;
            this.musteriGuncelleButton.Click += new System.EventHandler(this.musteriGuncelleButton_Click);
            // 
            // musteriSilButton
            // 
            this.musteriSilButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(200)))));
            this.musteriSilButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.musteriSilButton.FlatAppearance.BorderSize = 0;
            this.musteriSilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteriSilButton.ForeColor = System.Drawing.Color.White;
            this.musteriSilButton.Location = new System.Drawing.Point(0, 90);
            this.musteriSilButton.Name = "musteriSilButton";
            this.musteriSilButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.musteriSilButton.Size = new System.Drawing.Size(183, 45);
            this.musteriSilButton.TabIndex = 10;
            this.musteriSilButton.Text = "Müşteri Sil";
            this.musteriSilButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.musteriSilButton.UseVisualStyleBackColor = false;
            this.musteriSilButton.Click += new System.EventHandler(this.musteriSilButton_Click);
            // 
            // musteriEkleButton
            // 
            this.musteriEkleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(200)))));
            this.musteriEkleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.musteriEkleButton.FlatAppearance.BorderSize = 0;
            this.musteriEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteriEkleButton.ForeColor = System.Drawing.Color.White;
            this.musteriEkleButton.Location = new System.Drawing.Point(0, 45);
            this.musteriEkleButton.Name = "musteriEkleButton";
            this.musteriEkleButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.musteriEkleButton.Size = new System.Drawing.Size(183, 45);
            this.musteriEkleButton.TabIndex = 9;
            this.musteriEkleButton.Text = "Müşteri Ekle";
            this.musteriEkleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.musteriEkleButton.UseVisualStyleBackColor = false;
            this.musteriEkleButton.Click += new System.EventHandler(this.musteriEkleButton_Click);
            // 
            // musteriListeleButton
            // 
            this.musteriListeleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(200)))));
            this.musteriListeleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.musteriListeleButton.FlatAppearance.BorderSize = 0;
            this.musteriListeleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteriListeleButton.ForeColor = System.Drawing.Color.White;
            this.musteriListeleButton.Location = new System.Drawing.Point(0, 0);
            this.musteriListeleButton.Name = "musteriListeleButton";
            this.musteriListeleButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.musteriListeleButton.Size = new System.Drawing.Size(183, 45);
            this.musteriListeleButton.TabIndex = 8;
            this.musteriListeleButton.Text = "Müşteri Listele";
            this.musteriListeleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.musteriListeleButton.UseVisualStyleBackColor = false;
            this.musteriListeleButton.Click += new System.EventHandler(this.musteriListeleButton_Click);
            // 
            // musterilerButton
            // 
            this.musterilerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(175)))));
            this.musterilerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.musterilerButton.FlatAppearance.BorderSize = 0;
            this.musterilerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musterilerButton.ForeColor = System.Drawing.Color.White;
            this.musterilerButton.Location = new System.Drawing.Point(0, 375);
            this.musterilerButton.Name = "musterilerButton";
            this.musterilerButton.Size = new System.Drawing.Size(183, 45);
            this.musterilerButton.TabIndex = 4;
            this.musterilerButton.Text = "Müşteriler";
            this.musterilerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.musterilerButton.UseVisualStyleBackColor = false;
            this.musterilerButton.Click += new System.EventHandler(this.musterilerButton_Click);
            // 
            // araclarSubmenuPanel
            // 
            this.araclarSubmenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(250)))));
            this.araclarSubmenuPanel.Controls.Add(this.aracGuncelle);
            this.araclarSubmenuPanel.Controls.Add(this.aracSilButton);
            this.araclarSubmenuPanel.Controls.Add(this.aracEkleButton);
            this.araclarSubmenuPanel.Controls.Add(this.aracListeleButton);
            this.araclarSubmenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.araclarSubmenuPanel.Location = new System.Drawing.Point(0, 195);
            this.araclarSubmenuPanel.Name = "araclarSubmenuPanel";
            this.araclarSubmenuPanel.Size = new System.Drawing.Size(183, 180);
            this.araclarSubmenuPanel.TabIndex = 2;
            // 
            // aracGuncelle
            // 
            this.aracGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(200)))));
            this.aracGuncelle.Dock = System.Windows.Forms.DockStyle.Top;
            this.aracGuncelle.FlatAppearance.BorderSize = 0;
            this.aracGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aracGuncelle.ForeColor = System.Drawing.Color.White;
            this.aracGuncelle.Location = new System.Drawing.Point(0, 135);
            this.aracGuncelle.Name = "aracGuncelle";
            this.aracGuncelle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.aracGuncelle.Size = new System.Drawing.Size(183, 45);
            this.aracGuncelle.TabIndex = 9;
            this.aracGuncelle.Text = "Araç Güncelle";
            this.aracGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aracGuncelle.UseVisualStyleBackColor = false;
            this.aracGuncelle.Click += new System.EventHandler(this.aracGuncelle_Click);
            // 
            // aracSilButton
            // 
            this.aracSilButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(200)))));
            this.aracSilButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.aracSilButton.FlatAppearance.BorderSize = 0;
            this.aracSilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aracSilButton.ForeColor = System.Drawing.Color.White;
            this.aracSilButton.Location = new System.Drawing.Point(0, 90);
            this.aracSilButton.Name = "aracSilButton";
            this.aracSilButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.aracSilButton.Size = new System.Drawing.Size(183, 45);
            this.aracSilButton.TabIndex = 8;
            this.aracSilButton.Text = "Araç Sil";
            this.aracSilButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aracSilButton.UseVisualStyleBackColor = false;
            this.aracSilButton.Click += new System.EventHandler(this.aracSilButton_Click);
            // 
            // aracEkleButton
            // 
            this.aracEkleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(200)))));
            this.aracEkleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.aracEkleButton.FlatAppearance.BorderSize = 0;
            this.aracEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aracEkleButton.ForeColor = System.Drawing.Color.White;
            this.aracEkleButton.Location = new System.Drawing.Point(0, 45);
            this.aracEkleButton.Name = "aracEkleButton";
            this.aracEkleButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.aracEkleButton.Size = new System.Drawing.Size(183, 45);
            this.aracEkleButton.TabIndex = 7;
            this.aracEkleButton.Text = "Araç Ekle";
            this.aracEkleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aracEkleButton.UseVisualStyleBackColor = false;
            this.aracEkleButton.Click += new System.EventHandler(this.aracEkleButton_Click);
            // 
            // aracListeleButton
            // 
            this.aracListeleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(200)))));
            this.aracListeleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.aracListeleButton.FlatAppearance.BorderSize = 0;
            this.aracListeleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aracListeleButton.ForeColor = System.Drawing.Color.White;
            this.aracListeleButton.Location = new System.Drawing.Point(0, 0);
            this.aracListeleButton.Name = "aracListeleButton";
            this.aracListeleButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.aracListeleButton.Size = new System.Drawing.Size(183, 45);
            this.aracListeleButton.TabIndex = 6;
            this.aracListeleButton.Text = "Araçları Listele";
            this.aracListeleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aracListeleButton.UseVisualStyleBackColor = false;
            this.aracListeleButton.Click += new System.EventHandler(this.aracListeleButton_Click);
            // 
            // araclarButton
            // 
            this.araclarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(175)))));
            this.araclarButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.araclarButton.FlatAppearance.BorderSize = 0;
            this.araclarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.araclarButton.ForeColor = System.Drawing.Color.White;
            this.araclarButton.Location = new System.Drawing.Point(0, 150);
            this.araclarButton.Name = "araclarButton";
            this.araclarButton.Size = new System.Drawing.Size(183, 45);
            this.araclarButton.TabIndex = 3;
            this.araclarButton.Text = "Araçlar";
            this.araclarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.araclarButton.UseVisualStyleBackColor = false;
            this.araclarButton.Click += new System.EventHandler(this.araclarButton_Click);
            // 
            // mainMenuPictureBox
            // 
            this.mainMenuPictureBox.Controls.Add(this.resimEkleButton);
            this.mainMenuPictureBox.Controls.Add(this.userPictureBox);
            this.mainMenuPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainMenuPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mainMenuPictureBox.Name = "mainMenuPictureBox";
            this.mainMenuPictureBox.Size = new System.Drawing.Size(183, 150);
            this.mainMenuPictureBox.TabIndex = 1;
            // 
            // resimEkleButton
            // 
            this.resimEkleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(175)))));
            this.resimEkleButton.FlatAppearance.BorderSize = 0;
            this.resimEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resimEkleButton.ForeColor = System.Drawing.Color.White;
            this.resimEkleButton.Location = new System.Drawing.Point(3, 114);
            this.resimEkleButton.Name = "resimEkleButton";
            this.resimEkleButton.Size = new System.Drawing.Size(140, 30);
            this.resimEkleButton.TabIndex = 2;
            this.resimEkleButton.Text = "Yeni Resim Ekle";
            this.resimEkleButton.UseVisualStyleBackColor = false;
            this.resimEkleButton.Click += new System.EventHandler(this.resimEkleButton_Click);
            // 
            // userPictureBox
            // 
            this.userPictureBox.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.userPictureBox.BorderColor2 = System.Drawing.Color.HotPink;
            this.userPictureBox.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.userPictureBox.BorderSize = 2;
            this.userPictureBox.GradientAngle = 50F;
            this.userPictureBox.Location = new System.Drawing.Point(1, 1);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(100, 100);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPictureBox.TabIndex = 1;
            this.userPictureBox.TabStop = false;
            // 
            // mainMenuFillPanel
            // 
            this.mainMenuFillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuFillPanel.Location = new System.Drawing.Point(200, 0);
            this.mainMenuFillPanel.Name = "mainMenuFillPanel";
            this.mainMenuFillPanel.Size = new System.Drawing.Size(844, 561);
            this.mainMenuFillPanel.TabIndex = 2;
            // 
            // resimOpenFileDialog
            // 
            this.resimOpenFileDialog.Filter = "Jpeg Dosyaları (*.jpeg)|*.jpeg| Jpg Dosyaları(*.jpg)|*.jpg| Png Dosyaları(*.png)|" +
    "*.png";
            this.resimOpenFileDialog.Title = "Resim Seç";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1044, 561);
            this.Controls.Add(this.mainMenuFillPanel);
            this.Controls.Add(this.mainMenuSidePanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(175)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mainForm";
            this.Text = "Araç Takip Sistemi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.mainMenuSidePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.musterilerSubmenuPanel.ResumeLayout(false);
            this.araclarSubmenuPanel.ResumeLayout(false);
            this.mainMenuPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainMenuSidePanel;
        private System.Windows.Forms.Button araclarButton;
        private System.Windows.Forms.Panel mainMenuPictureBox;
        private System.Windows.Forms.Panel araclarSubmenuPanel;
        private System.Windows.Forms.Button aracGuncelle;
        private System.Windows.Forms.Button aracSilButton;
        private System.Windows.Forms.Button aracEkleButton;
        private System.Windows.Forms.Button aracListeleButton;
        private System.Windows.Forms.Button musterilerButton;
        private System.Windows.Forms.Panel musterilerSubmenuPanel;
        private System.Windows.Forms.Button musteriListeleButton;
        private System.Windows.Forms.Panel mainMenuFillPanel;
        private System.Windows.Forms.Button musteriSilButton;
        private System.Windows.Forms.Button musteriEkleButton;
        private System.Windows.Forms.Button musteriGuncelleButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button islemdekiAraclar;
        private CircularPictureBox userPictureBox;
        private System.Windows.Forms.Button resimEkleButton;
        private System.Windows.Forms.OpenFileDialog resimOpenFileDialog;
    }
}

