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
    public partial class AracSilForm : Form
    {
        #region Araç Sil Form
        public AracSilForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Database Stuffs
        static string constring = "Data Source=DESKTOP-S8TSQQK;Initial Catalog=Cars;Integrated Security=True";
        SqlConnection con = new SqlConnection(constring);
        #endregion

        private void silButton_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrEmpty(IDTextBox.Text) || !int.TryParse(IDTextBox.Text, out id))
            {
                MessageBox.Show("Lütfen geçerli bir ID numarası giriniz !");
                return;
            }
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                DataSet ds = new DataSet();
                SqlCommand command = new SqlCommand("Select * from KayitliArabalar where ID = @id", con);
                command.Parameters.AddWithValue("@id", id);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Zaten bu ID numarasına sahip bir araç yok");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally { con.Close(); }

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand command = new SqlCommand("delete from KayitliArabalar where ID = @id", con);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                MessageBox.Show(id + "ID numarasına sahip araç başarıyla silindi !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally { con.Close(); }
        }
    }
}
