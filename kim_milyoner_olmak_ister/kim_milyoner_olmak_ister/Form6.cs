using System;
using System.Data.SqlClient;
using System.Drawing;//www.gorselprogramlama.com
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace kim_milyoner_olmak_ister
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            Init_Data();
        }

        SQLiteConnection baglanti = new SQLiteConnection(lyesql.sqlconnection);
        SQLiteCommand cmd;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Giriş yapmak için lütfen boş alanları doldurunuz!");
            }
            else
            {
                cmd = new SQLiteCommand();
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "SELECT * FROM Admin where UserName='" + textBox1.Text + "' AND Password='" + textBox2.Text + "'";
                SQLiteDataReader Okuyucu = cmd.ExecuteReader();
                if (Okuyucu.Read() == true)
                {
                    //MessageBox.Show("Hoş Geldiniz!\n\n" + Okuyucu["Unvan"].ToString() + " => " + Okuyucu["AdSoyad"].ToString());

                    Settings1.Default.Id = Okuyucu["Id"].ToString();
                    Settings1.Default.AdSoyad = Okuyucu["AdSoyad"].ToString();
                    Settings1.Default.user = Okuyucu["UserName"].ToString();
                    Settings1.Default.pass = Okuyucu["Password"].ToString();
                    Settings1.Default.Unvan = Okuyucu["Unvan"].ToString();
                    Settings1.Default.Save();

                    Save_Data();
                    openChildForm(new Form7());
                }
                else
                {
                    MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Okuyucu.Close();
                Okuyucu.Dispose();
                baglanti.Close();
            }
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());

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

        private void Init_Data()
        {
            if (Settings1.Default.UserName != string.Empty)
            {
                if (Settings1.Default.Remember == true)
                {
                    textBox1.Text = Settings1.Default.UserName;
                    textBox2.Text = Settings1.Default.Password;
                    checkBox1.Checked = true;
                }
                else
                {
                    textBox1.Text = Settings1.Default.UserName;
                    textBox2.Text = Settings1.Default.UserName;
                }
            }
        }

        private void Save_Data()
        {
            if (checkBox1.Checked == true)
            {
                Settings1.Default.UserName = textBox1.Text;
                Settings1.Default.Password = textBox2.Text;
                Settings1.Default.Remember = true;
                Settings1.Default.Save();
            }
            else
            {
                Settings1.Default.UserName = "";
                Settings1.Default.Password = "";
                Settings1.Default.Remember = false;
                Settings1.Default.Save();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Settings1.Default.UserName = textBox1.Text;

        }

        private void Form6_Load(object sender, EventArgs e)
        {

            button3.BackgroundImage = ımageList1.Images[0];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox2.Checked ? '\0' : '*';
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //textBox1.PasswordChar = checkBox3.Checked ? '\0' : '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //groupBox2.Visible = true;

            if (groupBox2.Visible == false)
            {
                groupBox2.Visible = true;
            }
            else if (groupBox2.Visible == true)
            {
                groupBox2.Visible = false;
            }

            //openChildForm(new Form13());
            //Form13 form13 = new Form13();
            //form13.Show();
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.ForeColor = Color.Black;
            if (textBox4.Text == "e-posta")
            {
                textBox4.Text = "";
            }
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "e-posta";
                textBox4.ForeColor = Color.DarkGray;
            }
        }



        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.PasswordChar = checkBox5.Checked ? '*' : '\0';
        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Şifrenizi unuttuğunuz taktirde giriş yaptığınız mail adresine bir şifre gönderilmektedir. Gönderilen şifre ile giriş yaptıktan sonra uygulama içinden şifrenizi değiştirebilirsiniz.");
        }


        /*
        public class Rastgele
        {
            Random rnd;
            public Rastgele()
            {
                rnd = new Random();
            }

            // rastgele sayı üret 
            public int RastgeleSayi(int min, int max)
            {
                return rnd.Next(min, max);
            }

            //rastgele harf üretme
            public string RasteleHarf(int boyut, bool kucukHarf)
            {
                string harfler = "";
                int sayi, min = 65;
                char harf;

                if (kucukHarf)
                {
                    min = 97;
                }

                for (int i = 0; i < boyut; i++)
                {
                    sayi = rnd.Next(min, min + 25); //sayi değişkenine rastgele bir sayı atar.
                    harf = Convert.ToChar(sayi);//rastgele bir harf üretir
                    harfler += harf;
                }
                return harfler;
            }

            //şifre üretme
            public string sifreUret()
            {

                Random rnd = new Random();
                StringBuilder builder = new StringBuilder();
                builder.Append(RasteleHarf(3, true));
                builder.Append(rnd.Next(100, 999));
                //builder.Append(RasteleHarf(2, false));
                return builder.ToString();
            }
        }
        */
        private void button2_Click(object sender, EventArgs e)
        {
            Random Rnd = new Random();
            StringBuilder StrBuild = new StringBuilder();
            for (int i = 0; i < 6; i++)
            {
                int ASCII = Rnd.Next(65, 91);
                char Karakter = Convert.ToChar(ASCII);
                StrBuild.Append(Karakter);
            }


            string cmd1 = StrBuild.ToString();
            string mailim, sifre;
            mailim = "omercagdas2004@gmail.com";
            sifre = "master793DF";
            if (textBox4.Text == "")
            {
                MessageBox.Show("Lütfen Mail Adresinizi Giriniz!");
            }
            else
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(textBox4.Text);

                mail.From = new MailAddress(mailim, "Bilgi Yarışması");
                mail.Subject = "C# Bilgi Yarışması Şifremi Unuttum";
                mail.Body = "C# Bilgi Yarışması Şifreniz: " + cmd1;
                //mail.Attachments.Add(new Attachment(adres));
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Credentials = new System.Net.NetworkCredential(mailim, sifre),
                    Port = 587,
                    EnableSsl = true
                };
                smtp.Send(mail);
                mail.Dispose();
            }
            

            
            cmd = new SQLiteCommand("select *from Admin where UserName ='" + textBox4.Text + "'", baglanti);
            baglanti.Open();
            SQLiteDataReader oku;
            oku = cmd.ExecuteReader();
            if (oku.Read() == true)
            {
                if (textBox4.Text == oku["UserName"].ToString())
                {
                    oku.Close();
                    oku.Dispose();
                    baglanti.Close();
                    cmd = new SQLiteCommand("update Admin set Password ='" + StrBuild.ToString() + "' where UserName ='" + textBox4.Text + "'", baglanti);
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
/*
            oku.Close();
            oku.Dispose();
 

            /*
            baglanti.Open();
            cmd = new SqlCommand("select *from Admin where Id ='" + label7.Text + "'", baglanti);
            SqlDataReader oku;
            oku = cmd.ExecuteReader();
            if (oku.Read() == true)
            {

                label3.Text = oku["UserName"].ToString();
                label4.Text = oku["Password"].ToString();
                label5.Text = oku["AdSoyad"].ToString();
                label6.Text = oku["Unvan"].ToString();
                label7.Text = oku["Id"].ToString();


                MessageBox.Show("t");

                if (textBox4.Text == oku["UserName"].ToString())
                {
                    baglanti.Close();

                    textBox1.Text = StrBuild.ToString();

                    cmd = new SqlCommand("update Admin set UserName ='" + label3.Text + "',Password ='" + textBox1.Text + "',AdSoyad ='" + label5.Text + "',Unvan ='" + label6.Text + "'where Id = '" + label7.Text + "'",baglanti);
                    
                    cmd.Parameters.AddWithValue("@Password", StrBuild.ToString());
                    
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("tt");
                }
                MessageBox.Show("");
                baglanti.Close();
            }
            MessageBox.Show("s");
            baglanti.Close();

            */











            /*
            string kayit = "Select * From Admin where UserName=@UserName";
            SqlCommand cmd = new SqlCommand(kayit, baglanti);
            cmd.Parameters.AddWithValue("@UserName",textBox4.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            baglanti.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["Password"].ToString();
            }

            baglanti.Close();
            /*
            if (textBox4.Text == "@UserName")
            {
                cmd.Parameters.AddWithValue("@Password", StrBuild);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
            }
            //cmd.Parameters.AddWithValue("@Id",);

            else
            {
                MessageBox.Show("");
            }


            /*
            Rastgele rastgele = new Rastgele();
            //int sayi = rastgele.RastgeleSayi(10, 100);//10-100 arasında sayı üretir.
            //string yazi = rastgele.RasteleHarf(5, true);//5 tane rastgele küçük harf üretir.
            string sifre = rastgele.sifreUret(); //8 haneli rastgele şifre üretir (aaa111AA şeklinde)


            //MessageBox.Show("Rastgele Sayı:" + sayi);
            //MessageBox.Show("Rastgele Harf:" + yazi);
            MessageBox.Show("Rastgele Şifre: " + sifre);

        }





        //private void button2_MouseDown(object sender, MouseEventArgs e)
        //{
        //    textBox2.PasswordChar = (char)0;
        //}

        //private void button2_MouseUp(object sender, MouseEventArgs e)
        //{
        //    textBox2.PasswordChar = (char)'*';
        //}



        /*
    private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
    {
    textBoxPassword.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '*';
    }
    */
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.DarkSlateBlue;
        }
        private void linkLabel1_MouseEnter(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.White;
        }


        private void linkLabel2_MouseLeave(object sender, EventArgs e)
        {
            linkLabel2.LinkColor = Color.DarkSlateBlue;
        }
        private void linkLabel2_MouseEnter(object sender, EventArgs e)
        {
            linkLabel2.LinkColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.PasswordChar == '*')
            {
                textBox1.PasswordChar = '\0';
                button3.BackgroundImage = ımageList1.Images[1];
            }
            else if (textBox1.PasswordChar == '\0')
            {
                textBox1.PasswordChar = '*';
                button3.BackgroundImage = ımageList1.Images[0];
            }
        }



        private void Form6_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    button1.PerformClick();
            //}
        }



    }
}
