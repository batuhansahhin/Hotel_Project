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


namespace Hotel_Project{
    public partial class FormLogIn : Form
    {
      
        public FormLogIn()
        {
            InitializeComponent();
      

        }

        MainPage an= new MainPage();
     




        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMinimize, "Minimize");
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "Show Password");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide, "Hide Password");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }

        //Diğer Sayfaya gitme
        private void buttonLogIn_Click(object sender, EventArgs e)
        {

            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Kullanıcı veya şifre boş geçilemez");
            }
            else 
            {
                if ((textBoxUsername.Text == "admin" || textBoxUsername.Text == "ADMİN") && textBoxPassword.Text == "326598")
                {
                    an.Show();
                }
                else if ((textBoxUsername.Text == "personel" || textBoxUsername.Text == "PERSONEL") && textBoxPassword.Text == "123456")
                {
                    an.Show();
                }

                else
                {
                    MessageBox.Show("Kullanıcı veya şifre yanlış");

                }
                
            }

        }

        private void btnsayfa2_Click(object sender, EventArgs e)
        {
            an.Show();
        }

       
    }
}
