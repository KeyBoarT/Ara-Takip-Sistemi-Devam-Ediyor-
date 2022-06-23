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
        private string Table = "KayitliArabalar";
        //AracKaydet
        private void YeniKayit(string tur, string marka, string model, int yil, string renk, string yakit_tipi, string imagePath)
        {
            //Image Importing
            FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
            binaryReader.Close();
            fileStream.Close();
            //Saving
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand command = new SqlCommand($"insert into {Table}(tur, marka, model, yil, renk, durum, yakit_tipi, resim) values (@tur, @marka, @model, @yil, @renk, @durum, @yakit_tipi, @resim)", con);
                command.Parameters.AddWithValue("@tur", tur);
                command.Parameters.AddWithValue("@marka", marka);
                command.Parameters.AddWithValue("@model", model);
                command.Parameters.AddWithValue("@yil", yil);
                command.Parameters.AddWithValue("@renk", renk);
                command.Parameters.AddWithValue("@durum", "Boşta");
                command.Parameters.AddWithValue("@yakit_tipi", yakit_tipi);
                command.Parameters.Add("@resim", SqlDbType.Image, resim.Length).Value=resim;
                command.ExecuteNonQuery();
                MessageBox.Show("Araç Başarıyla Kaydedildi !");
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
        
        //ComboBox
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

        private string imagePath;
        private void resimEkleButton_Click(object sender, EventArgs e)
        {
            if (aracEkleOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                aracGoruntuPictureBox.Image = Image.FromFile(aracEkleOpenFileDialog.FileName);
                imagePath = aracEkleOpenFileDialog.FileName;
            }
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            if (turComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir tür seçiniz !");
                return;
            }
            if (markaComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir marka seçiniz !");
                return;
            }
            if (modelComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir model seçiniz !");
                return;
            }

            try
            {
                Convert.ToInt32(yilTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir yıl tanımı giriniz !");
                return;
            }

            if (string.IsNullOrEmpty(renkTextBox.Text))
            {
                MessageBox.Show("Lütfen renk alanını doldurunuz !");
                return;
            }

            if (yakitTipiComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir yakıt tipi seçiniz !");
                return;
            }

            if (string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Lütfen bir resim ekleyiniz !");
                return;
            }

            YeniKayit(turComboBox.Text, markaComboBox.Text, modelComboBox.Text, Convert.ToInt32(yilTextBox.Text), renkTextBox.Text, yakitTipiComboBox.Text, imagePath);
        }
    }
}
