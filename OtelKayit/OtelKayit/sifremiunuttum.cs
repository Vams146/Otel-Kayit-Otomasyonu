using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OtelKayit
{
    public partial class sifremiunuttum : Form
    {
        public sifremiunuttum()
        {
            InitializeComponent();
        }

        private void sifremiunuttum_Load(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otelkayit;Uid=root;pwd=root");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select guv_soru from guvenlik", baglanti);
            MySqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                comboBox1.Items.Add(okuyucu["guv_soru"].ToString());
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otelkayit;Uid=root;pwd=root");
            baglanti.Open();
            MySqlCommand goster = new MySqlCommand("select sifre from uyelik where k_adi=@kad and guv_soru=@gs and cevap=@cvp", baglanti);
            goster.Parameters.AddWithValue("@kad", textBox1.Text);
            goster.Parameters.AddWithValue("@gs", comboBox1.Text);
            goster.Parameters.AddWithValue("@cvp", textBox3.Text);
            MySqlDataReader oku = goster.ExecuteReader();
            while (oku.Read())
            {
                label5.Text = oku["sifre"].ToString();
            }
        }
    }
}
