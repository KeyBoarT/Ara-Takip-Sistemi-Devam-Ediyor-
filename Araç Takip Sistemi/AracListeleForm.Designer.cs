
namespace Araç_Takip_Sistemi
{
    partial class AracListeleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.aracListeleFillPanel = new System.Windows.Forms.Panel();
            this.aracListeleDataGridView = new Araç_Takip_Sistemi.ModernDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakit_tipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resim = new System.Windows.Forms.DataGridViewImageColumn();
            this.aracListeleFillPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aracListeleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aracListeleFillPanel
            // 
            this.aracListeleFillPanel.Controls.Add(this.aracListeleDataGridView);
            this.aracListeleFillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aracListeleFillPanel.Location = new System.Drawing.Point(0, 0);
            this.aracListeleFillPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aracListeleFillPanel.Name = "aracListeleFillPanel";
            this.aracListeleFillPanel.Size = new System.Drawing.Size(944, 561);
            this.aracListeleFillPanel.TabIndex = 1;
            // 
            // aracListeleDataGridView
            // 
            this.aracListeleDataGridView.AllowUserToAddRows = false;
            this.aracListeleDataGridView.AllowUserToDeleteRows = false;
            this.aracListeleDataGridView.AllowUserToResizeColumns = false;
            this.aracListeleDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.aracListeleDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.aracListeleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aracListeleDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.aracListeleDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aracListeleDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.aracListeleDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.aracListeleDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.aracListeleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aracListeleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.tur,
            this.marka,
            this.model,
            this.yil,
            this.renk,
            this.yakit_tipi,
            this.durum,
            this.resim});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.aracListeleDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.aracListeleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aracListeleDataGridView.EnableHeadersVisualStyles = false;
            this.aracListeleDataGridView.Location = new System.Drawing.Point(0, 0);
            this.aracListeleDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aracListeleDataGridView.Name = "aracListeleDataGridView";
            this.aracListeleDataGridView.ReadOnly = true;
            this.aracListeleDataGridView.RowHeadersVisible = false;
            this.aracListeleDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.aracListeleDataGridView.RowTemplate.Height = 100;
            this.aracListeleDataGridView.Size = new System.Drawing.Size(944, 561);
            this.aracListeleDataGridView.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tur
            // 
            this.tur.DataPropertyName = "tur";
            this.tur.HeaderText = "tur";
            this.tur.Name = "tur";
            this.tur.ReadOnly = true;
            this.tur.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // marka
            // 
            this.marka.DataPropertyName = "marka";
            this.marka.HeaderText = "marka";
            this.marka.Name = "marka";
            this.marka.ReadOnly = true;
            this.marka.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // model
            // 
            this.model.DataPropertyName = "model";
            this.model.HeaderText = "model";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            this.model.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // yil
            // 
            this.yil.DataPropertyName = "yil";
            this.yil.HeaderText = "yil";
            this.yil.Name = "yil";
            this.yil.ReadOnly = true;
            this.yil.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // renk
            // 
            this.renk.DataPropertyName = "renk";
            this.renk.HeaderText = "renk";
            this.renk.Name = "renk";
            this.renk.ReadOnly = true;
            this.renk.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // yakit_tipi
            // 
            this.yakit_tipi.DataPropertyName = "yakit_tipi";
            this.yakit_tipi.HeaderText = "yakit_tipi";
            this.yakit_tipi.Name = "yakit_tipi";
            this.yakit_tipi.ReadOnly = true;
            this.yakit_tipi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // durum
            // 
            this.durum.DataPropertyName = "durum";
            this.durum.HeaderText = "durum";
            this.durum.Name = "durum";
            this.durum.ReadOnly = true;
            this.durum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // resim
            // 
            this.resim.DataPropertyName = "resim";
            this.resim.HeaderText = "resim";
            this.resim.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.resim.Name = "resim";
            this.resim.ReadOnly = true;
            this.resim.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AracListeleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.aracListeleFillPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AracListeleForm";
            this.Text = "AracListeleForm";
            this.Load += new System.EventHandler(this.AracListeleForm_Load);
            this.aracListeleFillPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aracListeleDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel aracListeleFillPanel;
        private ModernDataGridView aracListeleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn yil;
        private System.Windows.Forms.DataGridViewTextBoxColumn renk;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakit_tipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn durum;
        private System.Windows.Forms.DataGridViewImageColumn resim;
    }
}