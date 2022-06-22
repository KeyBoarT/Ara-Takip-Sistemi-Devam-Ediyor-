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

namespace Araç_Takip_Sistemi
{
    public partial class AracEkleForm : Form
    {
        public AracEkleForm()
        {
            InitializeComponent();
        }
        private void AracEkleForm_Load(object sender, EventArgs e)
        {
        }

        #region DataBase Stuffs
        static string constring = "Data Source=DESKTOP-S8TSQQK;Initial Catalog=Cars;Integrated Security=True";
        SqlConnection con = new SqlConnection(constring);
        
        private void ComboBoxDoldur(string marka, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Text = "";
            comboBox.SelectedIndex = -1;
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = $"Select model from Araclar where marka = '{marka}'";
            try
            {
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    comboBox.Items.Add(dr[0]);
                }
                dr.Close();
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

        private void markaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxDoldur(markaComboBox.Text, modelComboBox);
        }
    }
}
