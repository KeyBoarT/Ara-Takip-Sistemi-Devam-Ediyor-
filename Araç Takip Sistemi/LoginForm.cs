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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        #region Database Stuffs
        public static int id = 0;
        public static string constring = "Data Source=DESKTOP-S8TSQQK;Initial Catalog=Users;Integrated Security=True";
        private SqlConnection connect = new SqlConnection(constring);
        #endregion

        private void girisYapButton_Click(object sender, EventArgs e)
        {
            //Controlling textboxes are empty or null
            if (String.IsNullOrEmpty(isimTextBox.Text) || String.IsNullOrEmpty(sifreTextBox.Text))
            {
                MessageBox.Show("Kullanıcı Adı ya da Parola boş bırakılamaz !");
                isimTextBox.Clear();
                sifreTextBox.Clear();
                connect.Close();
                return;
            }
            
            //Connecting to Database
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                SqlCommand cmd = new SqlCommand("Select * from users Where username = @ad AND password = @sifre", connect);
                cmd.Parameters.AddWithValue("@ad", isimTextBox.Text);
                cmd.Parameters.AddWithValue("@sifre", sifreTextBox.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    id = dr.GetInt32(0);
                    this.Hide();
                    mainForm main = new mainForm();
                    main.Show();
                }

                else
                {
                    MessageBox.Show("Kullanıcı adı ya da parola yanlış !");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Bir şeyler ters gitti !");
                MessageBox.Show(ex.Message);
            }

            finally
            {
                connect.Close();
                isimTextBox.Clear();
                sifreTextBox.Clear();
            }
        }
    }
}
