
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
            this.SuspendLayout();
            // 
            // turLabel
            // 
            this.turLabel.AutoSize = true;
            this.turLabel.Location = new System.Drawing.Point(33, 112);
            this.turLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.turLabel.Name = "turLabel";
            this.turLabel.Size = new System.Drawing.Size(32, 20);
            this.turLabel.TabIndex = 0;
            this.turLabel.Text = "Tür";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(13, 179);
            this.modelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(52, 20);
            this.modelLabel.TabIndex = 2;
            this.modelLabel.Text = "Model";
            // 
            // markaLabel
            // 
            this.markaLabel.AutoSize = true;
            this.markaLabel.Location = new System.Drawing.Point(13, 145);
            this.markaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.markaLabel.Name = "markaLabel";
            this.markaLabel.Size = new System.Drawing.Size(53, 20);
            this.markaLabel.TabIndex = 4;
            this.markaLabel.Text = "Marka";
            // 
            // turComboBox
            // 
            this.turComboBox.FormattingEnabled = true;
            this.turComboBox.Items.AddRange(new object[] {
            "SUV",
            "SEDAN"});
            this.turComboBox.Location = new System.Drawing.Point(72, 109);
            this.turComboBox.Name = "turComboBox";
            this.turComboBox.Size = new System.Drawing.Size(175, 28);
            this.turComboBox.TabIndex = 5;
            // 
            // markaComboBox
            // 
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
            this.markaComboBox.Location = new System.Drawing.Point(72, 145);
            this.markaComboBox.Name = "markaComboBox";
            this.markaComboBox.Size = new System.Drawing.Size(175, 28);
            this.markaComboBox.TabIndex = 6;
            this.markaComboBox.SelectedIndexChanged += new System.EventHandler(this.markaComboBox_SelectedIndexChanged);
            // 
            // modelComboBox
            // 
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(72, 179);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(175, 28);
            this.modelComboBox.TabIndex = 7;
            // 
            // AracEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.markaComboBox);
            this.Controls.Add(this.turComboBox);
            this.Controls.Add(this.markaLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.turLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AracEkleForm";
            this.Text = "AracEkleForm";
            this.Load += new System.EventHandler(this.AracEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label turLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label markaLabel;
        private System.Windows.Forms.ComboBox turComboBox;
        private System.Windows.Forms.ComboBox markaComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
    }
}