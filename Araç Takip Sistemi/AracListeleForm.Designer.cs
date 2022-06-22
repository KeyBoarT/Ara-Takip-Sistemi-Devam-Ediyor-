
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
            this.aracListeleTopPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aramaButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.aracListeleFillPanel = new System.Windows.Forms.Panel();
            this.aracListeleDataGridView = new Araç_Takip_Sistemi.ModernDataGridView();
            this.aracListeleTopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.aracListeleFillPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aracListeleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aracListeleTopPanel
            // 
            this.aracListeleTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(175)))));
            this.aracListeleTopPanel.Controls.Add(this.panel1);
            this.aracListeleTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.aracListeleTopPanel.Location = new System.Drawing.Point(0, 0);
            this.aracListeleTopPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aracListeleTopPanel.Name = "aracListeleTopPanel";
            this.aracListeleTopPanel.Size = new System.Drawing.Size(784, 90);
            this.aracListeleTopPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.aramaButton);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(535, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 90);
            this.panel1.TabIndex = 3;
            // 
            // aramaButton
            // 
            this.aramaButton.Location = new System.Drawing.Point(127, 44);
            this.aramaButton.Name = "aramaButton";
            this.aramaButton.Size = new System.Drawing.Size(111, 39);
            this.aramaButton.TabIndex = 1;
            this.aramaButton.Text = "Ara";
            this.aramaButton.UseVisualStyleBackColor = true;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.ForeColor = System.Drawing.Color.White;
            this.idLabel.Location = new System.Drawing.Point(3, 15);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(26, 20);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(35, 12);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(203, 26);
            this.idTextBox.TabIndex = 0;
            // 
            // aracListeleFillPanel
            // 
            this.aracListeleFillPanel.Controls.Add(this.aracListeleDataGridView);
            this.aracListeleFillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aracListeleFillPanel.Location = new System.Drawing.Point(0, 90);
            this.aracListeleFillPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aracListeleFillPanel.Name = "aracListeleFillPanel";
            this.aracListeleFillPanel.Size = new System.Drawing.Size(784, 471);
            this.aracListeleFillPanel.TabIndex = 1;
            // 
            // aracListeleDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.aracListeleDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.aracListeleDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.aracListeleDataGridView.Size = new System.Drawing.Size(784, 471);
            this.aracListeleDataGridView.TabIndex = 0;
            // 
            // AracListeleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.aracListeleFillPanel);
            this.Controls.Add(this.aracListeleTopPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AracListeleForm";
            this.Text = "AracListeleForm";
            this.Load += new System.EventHandler(this.AracListeleForm_Load);
            this.aracListeleTopPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.aracListeleFillPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aracListeleDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel aracListeleTopPanel;
        private System.Windows.Forms.Panel aracListeleFillPanel;
        private ModernDataGridView aracListeleDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button aramaButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
    }
}