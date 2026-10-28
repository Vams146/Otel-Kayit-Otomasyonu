using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OtelKayit
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form a = new kayıt();
            a.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form a = new sifremiunuttum();
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otelkayit;Uid=root;pwd=root");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("Select*from uyelik where k_adi=@kad and sifre=@sif", baglanti);
            komut.Parameters.AddWithValue("@kad", textBox1.Text);
            komut.Parameters.AddWithValue("@sif", textBox2.Text);
            MySqlDataReader oku = komut.ExecuteReader();
            if (oku.HasRows == true)
            {
                Form a = new anamenu();
                a.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!");
        }
    }
}
