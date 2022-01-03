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

    //internal class d { }
   




    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
    }

        public static int d;

        private void button1_Click(object sender, EventArgs e)
        {

            //Oda id
            Form2 frm = new Form2();
            string b;
            b = "ODA101";
            frm.label6.Text = b;


            //oda tipi

            string c;
            c = "standart oda";
            frm.label7.Text = c;

            //oda günlük fiyat 

            


             d = 400;
            frm.label8.Text = Convert.ToString(d);



            //oda  kisi sayisi


            int f = 4;
            frm.label9.Text = Convert.ToString(f);

            

            //Oda özellikleri
            string g = "deniz manzarali oda";
            frm.label10.Text = g;


            //Bitmap bmp = new Bitmap(
            //System.Reflection.Assembly.GetEntryAssembly().
            //GetManifestResourceStream("Hotel_Project.Form1.button1_Click.kapaliOda.png"));
            //Hotel_Project.Form1.button1_Click

            //Form2 frm = new Form2();

            Button btn = (sender as Button);
            frm.Show();
            btn.BackColor = Color.Red;
            //this.Hide();

            button1.Enabled = false;




        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 frm = new Form2();
            frm.Show();
            Button btn = (sender as Button);
            btn.BackColor = Color.Red;
            button2.Enabled = false;



            Form2 z = new Form2();

            string b;
            b = "ODA102";
            frm.label6.Text = b;


            //oda tipi

            string c;
            c = "standart oda";
            frm.label7.Text = c;

            //oda günlük fiyat 

             d = 400;
            frm.label8.Text = Convert.ToString(d);


            //oda  kisi sayisi

            int f = 4;
            frm.label9.Text = Convert.ToString(f);

           

            //Oda özellikleri
            string g = "deniz manzarali oda";
            frm.label10.Text = g;


            //button2.Enabled = false;
            //if (comboBox1.Items.IndexOf(textBox1.Text) != -1) MessageBox.Show("Kayıtlı Bilgi Vardır.");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            btn.BackColor = Color.Red;
            button4.Enabled = false;

            Form2 frm = new Form2();
            frm.Show();
            string b;
            b = "ODA104";
            frm.label6.Text = b;


            //oda tipi

            string c;
            c = "standart oda";
            frm.label7.Text = c;

            //oda günlük fiyat 

             d = 400;
            frm.label8.Text = Convert.ToString(d);


            //oda  kisi sayisi
            int f = 4;
            frm.label9.Text = Convert.ToString(f);

            //Oda özellikleri
            string g = "deniz manzarali oda";
            frm.label10.Text = g;





        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            string b;
            b = "ODA103";
            frm.label6.Text = b;


            //oda tipi

            string c;
            c = "standart oda";
            frm.label7.Text = c;

            //oda günlük fiyat 

            d = 400;
            frm.label8.Text = Convert.ToString(d);


            //oda  kisi sayisi
            int f = 4;
            frm.label9.Text = Convert.ToString(f);

            //Oda özellikleri
            string g = "deniz manzarali oda";
            frm.label10.Text = g;

            Button btn = (sender as Button);
            btn.BackColor = Color.Red;
            button3.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            Button btn = (sender as Button);
            btn.BackColor = Color.Red;
            button5.Enabled = false;



            Form2 z = new Form2();

            string b;
            b = "ODA105";
            frm.label6.Text = b;


            //oda tipi

            string c;
            c = "standart oda";
            frm.label7.Text = c;

            //oda günlük fiyat 
             d = 400;
            frm.label8.Text = Convert.ToString(d);


            //oda  kisi sayisi
            int f = 4;
            frm.label9.Text = Convert.ToString(f);

            //Oda özellikleri
            string g = "deniz manzarali oda";
            frm.label10.Text = g;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            Button btn = (sender as Button);
            btn.BackColor = Color.Red;
            button6.Enabled = false;



            Form2 z = new Form2();

            string b;
            b = "ODA106";
            frm.label6.Text = b;


            //oda tipi

            string c;
            c = "standart oda";
            frm.label7.Text = c;

            //oda günlük fiyat 

             d = 400;
            frm.label8.Text = Convert.ToString(d);


            //oda  kisi sayisi
            int f = 4;
            frm.label9.Text = Convert.ToString(f);

            //Oda özellikleri
            string g = "deniz manzarali oda";
            frm.label10.Text = g;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            Button btn = (sender as Button);
            btn.BackColor = Color.Red;
            //button7.Enabled = false;



            Form2 z = new Form2();

            string b;
            b = "ODA107";
            frm.label6.Text = b;


            //oda tipi

            string c;
            c = "standart oda";
            frm.label7.Text = c;

            //oda günlük fiyat 

             d = 400;
            frm.label8.Text = Convert.ToString(d);


            //oda  kisi sayisi
            int f = 4;
            frm.label9.Text = Convert.ToString(f);

            //Oda özellikleri
            string g = "deniz manzarali oda";
            frm.label10.Text = g;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            Button btn = (sender as Button);
            btn.BackColor = Color.Red;
            button8.Enabled = false;



            Form2 z = new Form2();

            string b;
            b = "ODA201";
            frm.label6.Text = b;


            //oda tipi

            string c;
            c = "Suit Oda ";
            frm.label7.Text = c;

            //oda günlük fiyat 

             d = 400;
            frm.label8.Text = Convert.ToString(d);


            //oda  kisi sayisi

            int f = 400;
            frm.label9.Text = Convert.ToString(f);
            

            //Oda özellikleri
            string g = "deniz manzarali oda + Mini bar + kahvaltı";
            frm.label10.Text = g;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            Button btn = (sender as Button);
            btn.BackColor = Color.Red;
            button9.Enabled = false;



            Form2 z = new Form2();

            string b;
            b = "ODA202";
            frm.label6.Text = b;


            //oda tipi

            string c;
            c = "Suit Oda ";
            frm.label7.Text = c;

            //oda günlük fiyat 

            
             d = 400;
            frm.label8.Text = Convert.ToString(d);


            //oda  kisi sayisi

            int f = 4;
            frm.label8.Text = Convert.ToString(f);
           

            //Oda özellikleri
            string g = "deniz manzarali oda + Mini bar + kahvaltı";
            frm.label10.Text = g;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            Button btn = (sender as Button);
            btn.BackColor = Color.Red;
            button10.Enabled = false;



            Form2 z = new Form2();

            string b;
            b = "ODA203";
            frm.label6.Text = b;


            //oda tipi

            string c;
            c = "Suit Oda ";
            frm.label7.Text = c;

            //oda günlük fiyat 

            int d = 600;
            frm.label8.Text = Convert.ToString(d);



            //oda  kisi sayisi

            int f = 4;
            frm.label10.Text = Convert.ToString(f);

            

            //Oda özellikleri
            string g = "deniz manzarali oda + Mini bar + kahvaltı";
            frm.label10.Text = g;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            Button btn = (sender as Button);
            btn.BackColor = Color.Red;
            button11.Enabled = false;



            Form2 z = new Form2();

            string b;
            b = "ODA204";
            frm.label6.Text = b;


            //oda tipi

            string c;
            c = "Suit Oda ";
            frm.label7.Text = c;

            //oda günlük fiyat 

            
            int d = 600;
            frm.label8.Text = Convert.ToString(d);



            //oda  kisi sayisi
            int f = 4;
            frm.label9.Text = Convert.ToString(f);
           

            //Oda özellikleri
            string g = "deniz manzarali oda + Mini bar + kahvaltı";
            frm.label10.Text = g;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            Button btn = (sender as Button);
            btn.BackColor = Color.Red;
            button12.Enabled = false;



            Form2 z = new Form2();

            string b;
            b = "ODA205";
            frm.label6.Text = b;


            //oda tipi

            string c;
            c = "Suit Oda ";
            frm.label7.Text = c;

            //oda günlük fiyati
            int d = 600;
            frm.label8.Text = Convert.ToString(d);




            //oda  kisi sayisi

            int f = 4;
            frm.label9.Text = Convert.ToString(f);
           

       

        //Oda özellikleri
        string g = "deniz manzarali oda + Mini bar + kahvaltı";
            frm.label10.Text = g;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            Button btn = (sender as Button);
            btn.BackColor = Color.Red;
            button13.Enabled = false;



            Form2 z = new Form2();

            string b;
            b = "ODA206";
            frm.label6.Text = b;


            //oda tipi

            string c;
            c = "Suit Oda ";
            frm.label7.Text = c;

            //oda günlük fiyat 

            int d = 600;
            frm.label8.Text = Convert.ToString(d);

           


            //oda  kisi sayisi

            int f = 4;
            frm.label9.Text = Convert.ToString(f);



            

            //Oda özellikleri
            string g = "deniz manzarali oda + Mini bar + kahvaltı";
            frm.label10.Text = g;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            Button btn = (sender as Button);
            btn.BackColor = Color.Red;
            button14.Enabled = false;



            Form2 z = new Form2();

            string b;
            b = "ODA207";
            frm.label6.Text = b;


            //oda tipi

            string c;
            c = "Suit Oda ";
            frm.label7.Text = c;

            //oda günlük fiyat 

            int d = 600;
            frm.label8.Text = Convert.ToString(d);

           


            //oda  kisi sayisi
            int f = 4;
            frm.label9.Text = Convert.ToString(f);


           

            //Oda özellikleri
            string g = "deniz manzarali oda + Mini bar + kahvaltı";
            frm.label10.Text = g;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //Oda id
            Form2 frm = new Form2();
            frm.Show();
            Button btn = (sender as Button);
            btn.BackColor = Color.Red;
            button6.Enabled = false;
            string b;
            b = "ODA301";
            frm.label6.Text = b;


            //oda tipi

            string c;
            c = "King Size";
            frm.label7.Text = c;

            //oda günlük fiyat 




            d = 800;
            frm.label8.Text = Convert.ToString(d);



            //oda  kisi sayisi


            int f = 6;
            frm.label9.Text = Convert.ToString(f);



            //Oda özellikleri
            string g = "Sınırsız Erişim";
            frm.label10.Text = g;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //Oda id
            Form2 frm = new Form2();
            frm.Show();
            Button btn = (sender as Button);
            btn.BackColor = Color.Red;
            button6.Enabled = false;
            string b;
            b = "ODA302";
            frm.label6.Text = b;


            //oda tipi

            string c;
            c = "King Size";
            frm.label7.Text = c;

            //oda günlük fiyat 




            d = 800;
            frm.label8.Text = Convert.ToString(d);



            //oda  kisi sayisi


            int f = 6;
            frm.label9.Text = Convert.ToString(f);



            //Oda özellikleri
            string g = "Sınırsız Erişim";
            frm.label10.Text = g;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Oda id
            Form2 frm = new Form2();
            frm.Show();
            Button btn = (sender as Button);
            btn.BackColor = Color.Red;
            button6.Enabled = false;

            string b;
            b = "ODA303";
            frm.label6.Text = b;


            //oda tipi

            string c;
            c = "King Size";
            frm.label7.Text = c;

            //oda günlük fiyat 




            d = 800;
            frm.label8.Text = Convert.ToString(d);



            //oda  kisi sayisi


            int f = 6;
            frm.label9.Text = Convert.ToString(f);



            //Oda özellikleri
            string g = "Sınırsız Erişim";
            frm.label10.Text = g;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Oda id
            Form2 frm = new Form2();
            frm.Show();
            Button btn = (sender as Button);
            btn.BackColor = Color.Red;
            button6.Enabled = false;

            string b;
            b = "ODA304";
            frm.label6.Text = b;


            //oda tipi

            string c;
            c = "King Size";
            frm.label7.Text = c;

            //oda günlük fiyat 




            d = 800;
            frm.label8.Text = Convert.ToString(d);



            //oda  kisi sayisi


            int f = 6;
            frm.label9.Text = Convert.ToString(f);



            //Oda özellikleri
            string g = "Sınırsız Erişim";
            frm.label10.Text = g;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Oda id
            Form2 frm = new Form2();
            frm.Show();
            Button btn = (sender as Button);
            btn.BackColor = Color.Red;
            button6.Enabled = false;

            string b;
            b = "ODA305";
            frm.label6.Text = b;


            //oda tipi

            string c;
            c = "King Size";
            frm.label7.Text = c;

            //oda günlük fiyat 




            d = 800;
            frm.label8.Text = Convert.ToString(d);



            //oda  kisi sayisi


            int f = 6;
            frm.label9.Text = Convert.ToString(f);



            //Oda özellikleri
            string g = "Sınırsız Erişim";
            frm.label10.Text = g;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Oda id
            Form2 frm = new Form2();
            frm.Show();
            Button btn = (sender as Button);
            btn.BackColor = Color.Red;
            button6.Enabled = false;

            string b;
            b = "ODA306";
            frm.label6.Text = b;


            //oda tipi

            string c;
            c = "King Size";
            frm.label7.Text = c;

            //oda günlük fiyat 




            d = 800;
            frm.label8.Text = Convert.ToString(d);



            //oda  kisi sayisi


            int f = 6;
            frm.label9.Text = Convert.ToString(f);



            //Oda özellikleri
            string g = "Sınırsız Erişim";
            frm.label10.Text = g;
        }
    }
}
