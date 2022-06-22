using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Araç_Takip_Sistemi
{
    class ModernDataGridView : DataGridView
    {
        public ModernDataGridView()
        {
            this.BorderStyle = BorderStyle.None;
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            this.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            this.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            this.BackgroundColor = Color.FromArgb(30, 30, 30);
            this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.EnableHeadersVisualStyles = false;
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
