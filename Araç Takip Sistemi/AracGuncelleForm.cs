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
    public partial class AracGuncelleForm : Form
    {
        #region Arac Guncelle Form
        public AracGuncelleForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Database Stuffs
        static string constring = "Data Source=DESKTOP-S8TSQQK;Initial Catalog=Cars;Integrated Security=True";
        SqlConnection con = new SqlConnection(constring);
        #endregion

        int _id;
        private void sorgulaButton_Click(object sender, EventArgs e)

        {
            int localID;
            if (!int.TryParse(IDTextBox.Text, out localID))
            {
                MessageBox.Show("Lütfen geçerli bir ID giriniz !");
                return;
            }

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("Select * from KayitliArabalar where ID = " + localID, con);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Aradığınız ID bulunamadı !");
                    turComboBox.SelectedIndex = -1;
                    markaComboBox.SelectedIndex = -1;
                    modelComboBox.SelectedIndex = -1;
                    yilTextBox.Text = "";
                    renkTextBox.Text = "";
                    yakitTipiComboBox.SelectedIndex = -1;
                    turComboBox.Enabled = false;
                    markaComboBox.Enabled = false;
                    modelComboBox.Enabled = false;
                    yilTextBox.Enabled = false;
                    renkTextBox.Enabled = false;
                    yakitTipiComboBox.Enabled = false;
                    resimEkleButton.Enabled = false;
                    aracGoruntuPictureBox.Image = null;
                    guncelleButton.Enabled = false;
                    return;
                }

                else
                {
                    turComboBox.Enabled = true;
                    markaComboBox.Enabled = true;
                    modelComboBox.Enabled = true;
                    yilTextBox.Enabled = true;
                    renkTextBox.Enabled = true;
                    yakitTipiComboBox.Enabled = true;
                    resimEkleButton.Enabled = true;
                    guncelleButton.Enabled = true;
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
                SqlCommand com = new SqlCommand("Select * from KayitliArabalar where ID = " + localID, con);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    turComboBox.Text = reader["tur"].ToString();
                    markaComboBox.Text = reader["marka"].ToString();
                    modelComboBox.Text = reader["model"].ToString();
                    yilTextBox.Text = reader["yil"].ToString();
                    renkTextBox.Text = reader["renk"].ToString();
                    yakitTipiComboBox.Text = reader["yakit_tipi"].ToString();
                    byte[] resim = new byte[0];
                    resim = (byte[])reader["resim"];
                    MemoryStream memoryStream = new MemoryStream(resim);
                    aracGoruntuPictureBox.Image = Image.FromStream(memoryStream);
                    _id = localID;
                }
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

        //Combobox
        private void ComboBoxDoldur(string marka, ComboBox comboBox)
        {
            SqlConnection localCon = new SqlConnection(constring);
            comboBox.Items.Clear();
            comboBox.Text = "";
            comboBox.SelectedIndex = -1;
            SqlCommand command = new SqlCommand();
            command.Connection = localCon;
            command.CommandText = $"Select model from Araclar where marka = '{marka}'";
            try
            {
                if (localCon.State == ConnectionState.Closed)
                    localCon.Open();
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
                localCon.Close();
            }

        }

        private void markaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxDoldur(markaComboBox.Text, modelComboBox);
        }


        private string imagePath;

        private void Guncelle(string tur, string marka, string model, int yil, string renk, string yakit_tipi, string imagePath)
        {
            FileStream fileStream;
            BinaryReader binaryReader;
            byte[] resim = null;
            //Image Importing
            if (!string.IsNullOrEmpty(imagePath))
            {
                fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                binaryReader = new BinaryReader(fileStream);
                resim = binaryReader.ReadBytes((int)fileStream.Length);
                binaryReader.Close();
                fileStream.Close();
            }
            //Saving
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand command;
                if (string.IsNullOrEmpty(imagePath))
                {
                    command = command = new SqlCommand($"update KayitliArabalar set tur = @tur, marka = @marka, model = @model, yil = @yil, renk = @renk, durum = @durum, yakit_tipi = @yakit_tipi where ID = " + _id, con);
                }
                else
                {
                    command = new SqlCommand($"update KayitliArabalar set tur = @tur, marka = @marka, model = @model, yil = @yil, renk = @renk, durum = @durum, yakit_tipi = @yakit_tipi, resim = @resim where ID = " + _id, con);
                    command.Parameters.Add("@resim", SqlDbType.Image, resim.Length).Value = resim;
                }
                command.Parameters.AddWithValue("@tur", tur);
                command.Parameters.AddWithValue("@marka", marka);
                command.Parameters.AddWithValue("@model", model);
                command.Parameters.AddWithValue("@yil", yil);
                command.Parameters.AddWithValue("@renk", renk);
                command.Parameters.AddWithValue("@durum", "Boşta");
                command.Parameters.AddWithValue("@yakit_tipi", yakit_tipi);
                command.ExecuteNonQuery();
                imagePath = null;
                MessageBox.Show("Araç Başarıyla güncellendi !");
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

        private void guncelleButton_Click(object sender, EventArgs e)
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

            Guncelle(turComboBox.Text, markaComboBox.Text, modelComboBox.Text, Convert.ToInt32(yilTextBox.Text), renkTextBox.Text, yakitTipiComboBox.Text, imagePath);
        }

        private void resimEkleButton_Click(object sender, EventArgs e)
        {
            if (aracGuncelleOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                aracGoruntuPictureBox.Image = Image.FromFile(aracGuncelleOpenFileDialog.FileName);
                imagePath = aracGuncelleOpenFileDialog.FileName;
            }
        }
    }
}
