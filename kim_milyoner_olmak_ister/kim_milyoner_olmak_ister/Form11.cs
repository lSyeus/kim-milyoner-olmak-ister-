using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;//www.gorselprogramlama.com
using System.Windows.Forms;

namespace kim_milyoner_olmak_ister
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
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


        SQLiteConnection baglanti;
        SQLiteCommand komut;
        SQLiteDataAdapter da;



        void KisiListele()
        {
            baglanti = new SQLiteConnection(lyesql.sqlconnection);
            baglanti.Open();
            da = new SQLiteDataAdapter("Select * From Admin Order By Id", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        /*
        void KisiListele()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=Yeni Microsoft Access Veritabanı.accdb");

            baglanti.Open();

            OleDbDataAdapter da = new OleDbDataAdapter("Select * from sorular Order By soruId", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
        */

        private void Form10_Load(object sender, EventArgs e)
        {
            KisiListele();
            //textBox1.Enabled = false;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //textBox8.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //textBox9.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            //textBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            //textBox10.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            //pictureBox1.ImageLocation = textBox10.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into Admin (Id,UserName,Password,AdSoyad,Unvan) values (@Id,@UserName,@Password,@AdSoyad,@Unvan)";
            SQLiteConnection baglanti = new SQLiteConnection(lyesql.sqlconnection);
            SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Id", textBox4.Text);
            komut.Parameters.AddWithValue("@AdSoyad", textBox5.Text);
            komut.Parameters.AddWithValue("@UserName", textBox6.Text);
            komut.Parameters.AddWithValue("@Password", textBox7.Text);
            komut.Parameters.AddWithValue("@Unvan", textBox8.Text);
            //komut.Parameters.AddWithValue("@d", textBox7.Text);
            //komut.Parameters.AddWithValue("@e", textBox8.Text);
            //komut.Parameters.AddWithValue("@cevap", textBox9.Text);
            //komut.Parameters.AddWithValue("@resimyolu", textBox10.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisiListele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "update Admin set UserName ='" + textBox6.Text + "',Password ='" + textBox7.Text + "',AdSoyad ='" + textBox5.Text + "',Unvan ='" + textBox8.Text + "'where Id = '" + textBox4.Text + "'";
            baglanti = new SQLiteConnection(lyesql.sqlconnection);
            komut = new SQLiteCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Id", textBox4.Text);
            komut.Parameters.AddWithValue("@AdSoyad", textBox5.Text);
            komut.Parameters.AddWithValue("@UserName", textBox6.Text);
            komut.Parameters.AddWithValue("@Password", textBox7.Text);
            komut.Parameters.AddWithValue("@Unvan", textBox8.Text);
            //komut.Parameters.AddWithValue("@d", textBox7.Text);
            //komut.Parameters.AddWithValue("@e", textBox8.Text);
            //komut.Parameters.AddWithValue("@cevap", textBox9.Text);
            //komut.Parameters.AddWithValue("@resimyolu", textBox10.Text);
            //komut.Parameters.AddWithValue("@Id", (dataGridView1.CurrentRow.Cells[1].Value));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisiListele();
        }

        void KayıtSil(int numara)
        {

            string sql = "Delete from Admin where Id=@Id";
            komut = new SQLiteCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@Id", numara);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
            string sorgu = "Delete From sorular Where Id=@Id";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Id", (dataGridView1.CurrentRow.Cells[0].Value));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisiListele();
            */

            DialogResult sil = MessageBox.Show("Seçili Admini Silmek İstediğinize Emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sil == DialogResult.Yes)
            {
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
                {
                    int numara = Convert.ToInt32(drow.Cells[0].Value);
                    KayıtSil(numara);
                }
                KisiListele();
            }
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //www.gorselprogramlama.com
            //Application.Exit();
            DialogResult cikis = MessageBox.Show("Programdan Çıkmak İstediğinize Emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (cikis == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else if (cikis == DialogResult.No)
            {

            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new Form7());

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //textBox1.Clear();
            //textBox2.Clear();
            //textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            //textBox9.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.ForeColor = Color.Black;
            if (textBox4.Text == "Id")
            {
                textBox4.Text = "";
            }
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Id";
                textBox4.ForeColor = Color.DarkGray;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_Leave(object sender, EventArgs e)
        {

        }
    }
}
