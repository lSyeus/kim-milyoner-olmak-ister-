using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace kim_milyoner_olmak_ister
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        SQLiteConnection baglanti = new SQLiteConnection(lyesql.sqlconnection);
        SQLiteCommand komut = new SQLiteCommand();

        private void verilerigoruntule()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SQLiteCommand komut = new SQLiteCommand
            {
                Connection = baglanti,
                CommandText = ("Select * from TytSorular Order By Id")
            };
            SQLiteDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                //ekle.Text = oku["soruId"].ToString();
                ekle.SubItems.Add(oku["Id"].ToString());
                ekle.SubItems.Add(oku["Soru"].ToString());
                ekle.SubItems.Add(oku["A"].ToString());
                ekle.SubItems.Add(oku["B"].ToString());
                ekle.SubItems.Add(oku["C"].ToString());
                ekle.SubItems.Add(oku["D"].ToString());
                ekle.SubItems.Add(oku["E"].ToString());
                ekle.SubItems.Add(oku["Cevap"].ToString());

                listView1.Items.Add(ekle);
            }
            oku.Close();
            baglanti.Close();
            

            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * from TytSoruSay where Id=1");
            SQLiteDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textBox2.Text = read["sayi1"].ToString();
                textBox3.Text = read["sayi2"].ToString();
            }
            read.Close();
            read.Dispose();
            baglanti.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoruntule();
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
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }


        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form7());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kayitSayisi = listView1.Items.Count;
            MessageBox.Show(kayitSayisi + " adet kayıt bilgisi var.");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Delete from TytSorular where Id = '" + textBox1.Text + "'";
            komut.ExecuteNonQuery();
            textBox1.Clear();
            baglanti.Close();
            verilerigoruntule();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Programdan çıkmak istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (cikis == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else if (cikis == DialogResult.No)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sorgu = "update TytSoruSay set sayi1 = '" + textBox2.Text + "',sayi2= '" + textBox3.Text + "'where Id = 1";
            komut = new SQLiteCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@sayi1", textBox2.Text);
            komut.Parameters.AddWithValue("@sayi2", textBox3.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Application.Exit();
            Application.Restart();
        }

        /*
        private void HKSil_Click(object sender, EventArgs e)
        {
            {
                int secimSayisi = listView1.SelectedItems.Count;

                foreach (ListViewItem bilgi in listView1.SelectedItems)
                {
                    bilgi.Remove();
                }
                MessageBox.Show(secimSayisi + " adet kayıt silindi.");
            }
        }
        */

        /*
        private void HKTemizle_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            MessageBox.Show("Kayıtlar Temizlendi.");
        }
        */



    }
}