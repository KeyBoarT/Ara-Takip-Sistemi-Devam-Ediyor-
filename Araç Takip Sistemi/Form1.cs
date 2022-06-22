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
    public partial class mainForm : Form
    {
        #region Main Form
        public mainForm()
        {
            InitializeComponent();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            //from Side Panel Region...
            customizeDesign();
            #region Image Adding
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("Select * from Users Where ID = @id", connect);
                cmd.Parameters.AddWithValue("@id", loginForm.id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    if (!String.IsNullOrEmpty(dr["image"].ToString()))
                    {
                        byte[] image = new byte[0];
                        image = (byte[])dr["image"];
                        MemoryStream memoryStream = new MemoryStream(image);
                        userPictureBox.Image = Image.FromStream(memoryStream);
                    }
                dr.Close();
                cmd.Dispose();
                connect.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            #endregion
        }
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Database Stuffs
        private static string constring = loginForm.constring;
        private SqlConnection connect = new SqlConnection(constring);
        #endregion

        #region Side Panel

        #region Customize Design
        private void customizeDesign()
        {
            araclarSubmenuPanel.Visible = false;
            musterilerSubmenuPanel.Visible = false;
        }

        private void hideSubMenu()
        {
            if (araclarSubmenuPanel.Visible == true)
                araclarSubmenuPanel.Visible = false;
            if (musterilerSubmenuPanel.Visible == true)
                musterilerSubmenuPanel.Visible = false;
        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainMenuFillPanel.Controls.Add(childForm);
            mainMenuFillPanel.Tag = childForm;
            childForm.Show();
        }
        #endregion


        #region User Panel
        private string imagePath;
        private void resimEkleButton_Click(object sender, EventArgs e)
        {
            if (resimOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                userPictureBox.Image = Image.FromFile(resimOpenFileDialog.FileName);
                imagePath = resimOpenFileDialog.FileName;
                FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                byte[] resim = binaryReader.ReadBytes((int)fileStream.Length);
                fileStream.Close();
                binaryReader.Close();
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("update users set image = @image where ID = @id", connect);
                    cmd.Parameters.Add("@image", SqlDbType.Image, resim.Length).Value = resim;
                    cmd.Parameters.AddWithValue("@id", loginForm.id);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Kayıt Eklendi !");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region Side Menu Buttons

        #region Araclar Button
        private void araclarButton_Click(object sender, EventArgs e)
        {
            showSubMenu(araclarSubmenuPanel);
        }

        private void aracListeleButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new AracListeleForm());
        }

        private void aracEkleButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new AracEkleForm());
        }

        private void aracSilButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void aracGuncelle_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        #region Musteriler Buttons
        private void musterilerButton_Click(object sender, EventArgs e)
        {
            showSubMenu(musterilerSubmenuPanel);
        }

        private void musteriListeleButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            
        }

        private void musteriEkleButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void musteriSilButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void musteriGuncelleButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        #endregion

        #endregion
    }
}
