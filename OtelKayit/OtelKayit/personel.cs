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
    public partial class personel : Form
    {
        public personel()
        {
            InitializeComponent();
        }
        private void listele()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otelkayit;Uid=root;pwd=root");
            MySqlCommand komut = new MySqlCommand("Select*from personel", baglanti);
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
            MySqlCommand ara = new MySqlCommand("Select*from personel where tc like '" + textBox8.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            MySqlDataAdapter kopru = new MySqlDataAdapter(ara);
            kopru.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otelkayit;Uid=root;pwd=root");
            baglanti.Open();
            MySqlCommand ekle = new MySqlCommand("insert into personel(tc,ad,soyad,telefon,e_posta,gorev)values(@tc,@ad,@sad,@tel,@pos,@gor)", baglanti);
            ekle.Parameters.AddWithValue("@tc", maskedTextBox1.Text);
            ekle.Parameters.AddWithValue("@ad", textBox2.Text);
            ekle.Parameters.AddWithValue("@sad", textBox3.Text);
            ekle.Parameters.AddWithValue("@tel", maskedTextBox2.Text);
            ekle.Parameters.AddWithValue("@pos", textBox5.Text);
            ekle.Parameters.AddWithValue("@gor", textBox6.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("Personel Başarıyla Eklendi");
            listele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otelkayit;Uid=root;pwd=root");
            baglanti.Open();
            MySqlCommand sil = new MySqlCommand("Delete from personel where idpersonel=@id", baglanti);
            sil.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["idpersonel"].Value.ToString());
            sil.ExecuteNonQuery();
            MessageBox.Show("Kaydınız Başarıyla Silindi");
            listele();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=otelkayit;Uid=root;pwd=root");
            baglanti.Open();
            MySqlCommand guncelle = new MySqlCommand("update personel set tc=@tc,ad=@ad,soyad=@sad,telefon=@tel,e_posta=@pos,gorev=@gor where idpersonel=@id", baglanti);
            guncelle.Parameters.AddWithValue("@tc", maskedTextBox1.Text);
            guncelle.Parameters.AddWithValue("@ad", textBox2.Text);
            guncelle.Parameters.AddWithValue("@sad", textBox3.Text);
            guncelle.Parameters.AddWithValue("@tel", maskedTextBox2.Text);
            guncelle.Parameters.AddWithValue("@pos", textBox5.Text);
            guncelle.Parameters.AddWithValue("@gor", textBox6.Text);
            guncelle.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["idpersonel"].Value.ToString());
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Kaydınız Güncellendi");
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form a = new anamenu();
            a.Show();
            this.Hide();
        }

        private void personel_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["ad"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["soyad"].Value.ToString();
            maskedTextBox2.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["e_posta"].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells["gorev"].Value.ToString();
        }
    }
}
