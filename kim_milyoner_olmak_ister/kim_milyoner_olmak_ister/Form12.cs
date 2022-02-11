using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;//www.gorselprogramlama.com
using System.Windows.Forms;

namespace kim_milyoner_olmak_ister
{
    public partial class Form12 : Form
    {
        public Form12()
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
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }


        SQLiteConnection baglanti;
        SQLiteCommand komut;



        private void profilGetir()
        {
            komut = new SQLiteCommand();
            baglanti = new SQLiteConnection(lyesql.sqlconnection);
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM Admin where Id='" + Settings1.Default.Id.ToString() + "'";
            SQLiteDataReader dr = komut.ExecuteReader();
            if (dr.Read() == true)
            {

                label2.Text = dr["Id"].ToString();
                textBox5.Text = dr["AdSoyad"].ToString();
                textBox6.Text = dr["UserName"].ToString();
                textBox7.Text = dr["Password"].ToString();
                textBox8.Text = dr["Unvan"].ToString();
                //baglanti.Close();
            }
 
            dr.Close();
            dr.Dispose();
            baglanti.Close();
        }


        private void Form10_Load(object sender, EventArgs e)
        {

            profilGetir();

            /*
            textBox4.Text = Settings1.Default.Id.ToString();
            textBox5.Text = Settings1.Default.AdSoyad.ToString();
            textBox6.Text = Settings1.Default.user.ToString();
            textBox7.Text = Settings1.Default.pass.ToString();
            textBox8.Text = Settings1.Default.Unvan.ToString();
        */
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into Admin (Id,UserName,Password,AdSoyad,Unvan) values (@Id,@UserName,@Password,@AdSoyad,@Unvan)";
            baglanti = new SQLiteConnection(lyesql.sqlconnection);
            komut = new SQLiteCommand(sorgu, baglanti);
            //komut.Parameters.AddWithValue("@Id", label2.Text);
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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string sorgu = "update TytSorular set Soru = '" + textBox3.Text + "',a = '" + textBox4.Text + "',b = '" + textBox5.Text + "',c = '" + textBox6.Text + "',d = '" + textBox7.Text + "',e = '" + textBox8.Text + "',cevap = '" + textBox9.Text + "',resimyolu = '" + textBox10.Text + "'where Id = '" + textBox2.Text + "'";
            //baglanti = new SQLiteConnection("Data Source = database/lyesqlite.s3db");
            //komut = new SQLiteCommand(sorgu, baglanti);
            //komut.Parameters.AddWithValue("@Id", textBox2.Text);
            //komut.Parameters.AddWithValue("@soru", textBox3.Text);
            //komut.Parameters.AddWithValue("@a", textBox4.Text);
            //komut.Parameters.AddWithValue("@b", textBox5.Text);
            //komut.Parameters.AddWithValue("@c", textBox6.Text);
            //komut.Parameters.AddWithValue("@d", textBox7.Text);
            //komut.Parameters.AddWithValue("@e", textBox8.Text);
            //komut.Parameters.AddWithValue("@cevap", textBox9.Text);
            //komut.Parameters.AddWithValue("@resimyolu", textBox10.Text);
            ////komut.Parameters.AddWithValue("@Id", (dataGridView1.CurrentRow.Cells[1].Value));
            //baglanti.Open();
            //komut.ExecuteNonQuery();
            //baglanti.Close();
            //KisiListele();


            string sorgu = "update Admin set AdSoyad = '" + textBox5.Text + "',UserName = '" + textBox6.Text + "',Password = '" + textBox7.Text + "',Unvan = '" + textBox8.Text + "'where Id = '" + label2.Text + "'";
            baglanti = new SQLiteConnection(lyesql.sqlconnection);
            komut = new SQLiteCommand(sorgu, baglanti);
            //komut.Parameters.AddWithValue("@Id", textBox4.Text);
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
                baglanti = new SQLiteConnection(lyesql.sqlconnection);
                string sorgu = "Delete From Admin Where Id=@Id";
                komut = new SQLiteCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Id", Settings1.Default.Id.ToString());
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();



                /*
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
                {
                    int numara = Convert.ToInt32(drow.Cells[0].Value);
                    KayıtSil(numara);
                }
                */
            }
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //www.gorselprogramlama.com
            //Application.Exit();
            /*
               DialogResult cikis = MessageBox.Show("Profil Ayarlaından Çıkmak İstediğinize Emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
               if (cikis == DialogResult.Yes)
               {
                   this.Hide();
               }
               else if (cikis == DialogResult.No)
               {
            */
            this.Hide();
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
            //textBox4.Clear();
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
            //textBox4.ForeColor = Color.Black;
            //if (textBox4.Text == "Id")
            //{
            //    textBox4.Text = "";
            //}
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            //if (textBox4.Text == "")
            //{
            //    textBox4.Text = "Id";
            //    textBox4.ForeColor = Color.DarkGray;
            //}
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            textBox5.ForeColor = Color.Black;
            if (textBox5.Text == "Ad Soyad")
            {
                textBox5.Text = "";
            }
        }
        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Ad Soyad";
                textBox5.ForeColor = Color.DarkGray;
            }
        }


        private void textBox6_Enter(object sender, EventArgs e)
        {
            textBox6.ForeColor = Color.Black;
            if (textBox6.Text == "e-posta")
            {
                textBox6.Text = "";
            }
        }
        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "e-posta";
                textBox6.ForeColor = Color.DarkGray;

            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            textBox7.ForeColor = Color.Black;
            if (textBox7.Text == "Password")
            {
                textBox7.Text = "";
            }
        }
        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "Password";
                textBox7.ForeColor = Color.DarkGray;
            }
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            textBox8.ForeColor = Color.Black;
            if (textBox8.Text == "Unvan")
            {
                textBox8.Text = "";
            }
        }
        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "Unvan";
                textBox8.ForeColor = Color.DarkGray;
            }
        }
        int Move1;
        int Mouse_X;
        int Mouse_Y;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move1 = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move1 = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move1 == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
