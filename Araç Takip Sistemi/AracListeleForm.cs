using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Araç_Takip_Sistemi
{
    public partial class AracListeleForm : Form
    {
        #region Araç Listele Form
        public AracListeleForm()
        {
            InitializeComponent();
        }
        private void AracListeleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
        #endregion
        #region DataBase Stuffs
        static string constring = "Data Source=DESKTOP-S8TSQQK;Initial Catalog=Cars;Integrated Security=True";
        SqlConnection con = new SqlConnection(constring);
        string sorguCumlesi = "Select * from KayitliArabalar";
        #endregion
        #region DataGridView
        private void Listele()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand command = new SqlCommand(sorguCumlesi, con);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                aracListeleDataGridView.DataSource = dataSet.Tables[0];
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

    }
}
