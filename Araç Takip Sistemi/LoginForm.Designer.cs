
namespace Araç_Takip_Sistemi
{
    partial class loginForm
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
            this.isimTextBox = new System.Windows.Forms.TextBox();
            this.isimLabel = new System.Windows.Forms.Label();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.girisYapButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // isimTextBox
            // 
            this.isimTextBox.Location = new System.Drawing.Point(111, 25);
            this.isimTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.isimTextBox.Name = "isimTextBox";
            this.isimTextBox.Size = new System.Drawing.Size(261, 26);
            this.isimTextBox.TabIndex = 0;
            // 
            // isimLabel
            // 
            this.isimLabel.AutoSize = true;
            this.isimLabel.ForeColor = System.Drawing.Color.White;
            this.isimLabel.Location = new System.Drawing.Point(12, 28);
            this.isimLabel.Name = "isimLabel";
            this.isimLabel.Size = new System.Drawing.Size(93, 20);
            this.isimLabel.TabIndex = 1;
            this.isimLabel.Text = "Kullanıcı Adı";
            // 
            // sifreLabel
            // 
            this.sifreLabel.AutoSize = true;
            this.sifreLabel.ForeColor = System.Drawing.Color.White;
            this.sifreLabel.Location = new System.Drawing.Point(51, 65);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(54, 20);
            this.sifreLabel.TabIndex = 2;
            this.sifreLabel.Text = "Parola";
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(111, 62);
            this.sifreTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(261, 26);
            this.sifreTextBox.TabIndex = 3;
            // 
            // girisYapButton
            // 
            this.girisYapButton.Location = new System.Drawing.Point(111, 95);
            this.girisYapButton.Name = "girisYapButton";
            this.girisYapButton.Size = new System.Drawing.Size(126, 36);
            this.girisYapButton.TabIndex = 4;
            this.girisYapButton.Text = "Giriş Yap";
            this.girisYapButton.UseVisualStyleBackColor = true;
            this.girisYapButton.Click += new System.EventHandler(this.girisYapButton_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(384, 141);
            this.Controls.Add(this.girisYapButton);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.isimLabel);
            this.Controls.Add(this.isimTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.Text = "Araç Takip Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox isimTextBox;
        private System.Windows.Forms.Label isimLabel;
        private System.Windows.Forms.Label sifreLabel;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.Button girisYapButton;
    }
}