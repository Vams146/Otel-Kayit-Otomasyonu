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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void listele()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otelkayit;Uid=root;pwd=root");
            MySqlCommand komut = new MySqlCommand("Select*from musteri", baglanti);
            DataSet ds = new DataSet();
            MySqlDataAdapter kopru = new MySqlDataAdapter(komut);
            kopru.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        public void arama()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otelkayit;Uid=root;pwd=root");
            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Open();
            }
            MySqlCommand ara = new MySqlCommand("Select*from musteri where tc like '" + textBox8.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            MySqlDataAdapter kopru = new MySqlDataAdapter(ara);
            kopru.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form a = new anamenu();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otelkayit;Uid=root;pwd=root");
            baglanti.Open();
            MySqlCommand ekle = new MySqlCommand("insert into musteri(tc,ad,soyad,telefon,e_posta,bas_tar,bit_tar,y_sayi,odano)values(@tc,@ad,@sad,@tel,@pos,@bat,@bit,@ys,@on)", baglanti);
            ekle.Parameters.AddWithValue("@tc", maskedTextBox1.Text);
            ekle.Parameters.AddWithValue("@ad", textBox1.Text);
            ekle.Parameters.AddWithValue("@sad", textBox2.Text);
            ekle.Parameters.AddWithValue("@tel", maskedTextBox2.Text);
            ekle.Parameters.AddWithValue("@pos", textBox3.Text);
            ekle.Parameters.AddWithValue("@bat", dateTimePicker1.Value);
            ekle.Parameters.AddWithValue("@bit", dateTimePicker2.Value);
            ekle.Parameters.AddWithValue("@ys", numericUpDown1.Text);
            ekle.Parameters.AddWithValue("@on", comboBox1.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("Müşteri Başarıyla Eklendi");
            listele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otelkayit;Uid=root;pwd=root");
            baglanti.Open();
            MySqlCommand sil = new MySqlCommand("Delete from musteri where idmusteri=@id", baglanti);
            sil.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["idmusteri"].Value.ToString());
            sil.ExecuteNonQuery();
            MessageBox.Show("Kaydınız Başarıyla Silindi");
            listele();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otelkayit;Uid=root;pwd=root");
            baglanti.Open();
            MySqlCommand guncelle = new MySqlCommand("update musteri set tc=@tc,ad=@ad,soyad=@sad,telefon=@tel,e_posta=@pos,bas_tar=@bat,bit_tar=@bit,y_sayi=@ys,odano=@on where idmusteri=@id",baglanti);
            guncelle.Parameters.AddWithValue("@tc", maskedTextBox1.Text);
            guncelle.Parameters.AddWithValue("@ad", textBox1.Text);
            guncelle.Parameters.AddWithValue("@sad", textBox2.Text);
            guncelle.Parameters.AddWithValue("@tel", maskedTextBox2.Text);
            guncelle.Parameters.AddWithValue("@pos", textBox3.Text);
            guncelle.Parameters.AddWithValue("@bat", dateTimePicker1.Value);
            guncelle.Parameters.AddWithValue("@bit", dateTimePicker2.Value);
            guncelle.Parameters.AddWithValue("@ys", numericUpDown1.Text);
            guncelle.Parameters.AddWithValue("@on", comboBox1.Text);
            guncelle.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["idmusteri"].Value.ToString());
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Kaydınız Güncellendi");
            listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otelkayit;Uid=root;pwd=root");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select odano from odalar", baglanti);
            MySqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                comboBox1.Items.Add(okuyucu["odano"].ToString());
            }
            baglanti.Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells["ad"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["soyad"].Value.ToString();
            maskedTextBox2.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["e_posta"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["bas_tar"].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells["bit_tar"].Value.ToString();
            numericUpDown1.Text = dataGridView1.CurrentRow.Cells["y_sayi"].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells["odano"].Value.ToString();
        }
    }
}
