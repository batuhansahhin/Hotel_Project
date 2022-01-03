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

namespace Hotel_Project
{
    public partial class Form3 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        void Ekle()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog = Hotel; Integrated Security=SSPI");

            string sorgu = "Insert into MüsteriTablosu (tc,Ad,Soyad,Ülke,Telefon,Email,Cinsiyet,DoğumTarihi,GirişTarihi,ÇıkışTarihi)  values     (@tc,@Ad,@Soyad,@Ülke,@Telefon,@Email,@Cinsiyet,@DoğumTarihi,@GirişTarihi,@ÇıkışTarihi) ";

            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@tc", textBox1.Text);
            komut.Parameters.AddWithValue("@Ad", textBox2.Text);
            komut.Parameters.AddWithValue("@Soyad", textBox3.Text);
            komut.Parameters.AddWithValue("@Ülke",textBox4.Text);
            komut.Parameters.AddWithValue("@Telefon", textBox5.Text);
            komut.Parameters.AddWithValue("@Email", textBox6.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", textBox7.Text);
            komut.Parameters.AddWithValue("@DoğumTarihi", dateTimePicker3.Value.ToString("dd/MM/yyyy"));
            komut.Parameters.AddWithValue("@GirişTarihi", dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            komut.Parameters.AddWithValue("@ÇıkışTarihi", dateTimePicker2.Value.ToString("dd/MM/yyyy"));

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        void EkleOdeme()
        {

            baglanti = new SqlConnection("server=.; Initial Catalog=Hotel; Integrated Security=SSPI");

            string z = " Insert into OdemeTablosu (ödemeTürü,ödemeTarihi,ödemeTutari) values  (@ödemeTürü,@ödemeTarihi,@ödemeTutari) ";
            komut = new SqlCommand(z, baglanti);
            komut.Parameters.AddWithValue("ödemeTürü", textBox12.Text);
            komut.Parameters.AddWithValue("ödemeTarihi", dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            komut.Parameters.AddWithValue("ödemeTutari", textBox11.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();







        }


        public Form3()
        {
            InitializeComponent();
        }
        
            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //tablo.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
        //    //dataGridView1.DataSource = tablo;

        //    verilerigöster();

        //}

       
       

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    baglan.Open();
        //    SqlCommand komut = new SqlCommand("Insert into MüsteriKayit(tc,ad,soyad,ülke,telefon,email,cinsiyet,yas,giristarihi,cikistarihi) Values ('" + textBox1.Text.ToString() + "' ,'" + textBox2.Text.ToString() + "')", baglan);
        //    komut.ExecuteNonQuery();
        //    baglan.Close(); 
        //    verilerigöster();
        //}

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //Form5 frm = new Form5();

            //frm.label2.Text = textBox1.Text;

            //frm.Show();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Ekle();
            EkleOdeme();
           
              Form5 frm = new Form5();
            frm.label2.Text = textBox1.Text;
            frm.label3.Text = textBox2.Text;
            frm.label4.Text = textBox3.Text;
            frm.label5.Text = dateTimePicker1.Text;
            frm.label6.Text = textBox11.Text;



           
            frm.Show();
            //komut.ExecuteNonQuery();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            
          

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            //int y = textBox10.Text;

            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {





            DateTime gTarih = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime cTarih = Convert.ToDateTime(dateTimePicker2.Text);
            TimeSpan Sonuc = cTarih - gTarih;

            double a=Sonuc.TotalDays;

            double c = (Form1.d) * a;

           textBox11.Text = c.ToString();


            //double a= (fark.TotalDays) * (Form1.d) ;
            // textBox11.Text = a.ToString();


            //DateTime dt = DateTime.Parse(dateTimePicker2.Text);
            //TimeSpan fark = DateTime.Today - dt;
            //double a = fark.TotalDays;



            //int c= (-a) *(Form1.d)



            //textBox11.Text = c.ToString();




            //double a = (fark.TotalDays) * (Form1.d);
            //textBox11.Text = a.ToString();
            //double a = (fark.TotalDays) * (Form1.d);
            //textBox11.Text = a.ToString();

            //textBox11.Text=  Convert.ToString( Form1.d*fark.TotalDays);

            // TimeSpan fark = Convert.ToDateTime(dateTimePicker2.Value) - Convert.ToDateTime(dateTimePicker1.Value);

            // TimeSpan fark;
            // fark = DateTime.Parse(dateTimePicker2.Text) - DateTime.Parse(dateTimePicker1.Text);

            //double a= (fark.TotalDays) * (Form1.d) ;
            // textBox11.Text = a.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
