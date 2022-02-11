using System;
using System.Data.SqlClient;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;

namespace kim_milyoner_olmak_ister
{
    public partial class Form15 : Form
    {
        public Form15()
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
        string ytarih = DateTime.Now.ToString();

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlg.SelectedPath;
                button2.Enabled = true;
            }
        }


        //string tarih;

        private void button2_Click(object sender, EventArgs e)
        {

            string CurrentDatabasePath = Environment.CurrentDirectory + @"\database\lyesql.s3db";
            string filename = "lyesql" + " " + DateTime.Now.ToString("yyyy.MM.dd HH.mm.ss") + ".s3db";

            File.Copy(CurrentDatabasePath, textBox1.Text + @"\" + filename, true);
            MessageBox.Show("Yedek Başarı İle Alındı!\n\nYedek Hakkında Bilgi Almak İçin Bilgi Butonuna Tıklayın!");


            Settings1.Default.YedeklemeAdresi = textBox1.Text;
            Settings1.Default.YedeklemeTarihi = ytarih;
            Settings1.Default.Yedeklemeİsmi = filename;
            Settings1.Default.Save();
            textBox1.Text = Settings1.Default.YedeklemeAdresi.ToString();









            //string CurrentDatabasePath = Environment.CurrentDirectory + @"\database\lyesqlite.s3db";
            //FolderBrowserDialog fbd = new FolderBrowserDialog();
            //if (fbd.ShowDialog() == DialogResult.OK)
            //{
            //    string PathtobackUp = fbd.SelectedPath.ToString();
            //    File.Copy(CurrentDatabasePath, PathtobackUp + @"\lyesqlite.s3db", true);
            //    MessageBox.Show("Yedek Başarı İle Alındı");
            //}






            /*
            
            string database = con.Database.ToString();
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter backup file location");
            }
            else
            {
                string cmd = "Backup Database [" + database + "] To Disk = '" + textBox1.Text + "\\" + "lyesql" + " " + DateTime.Now.ToString("yyyy.MM.dd HH.mm.ss") + ".bak'";
                con.Open();
                SqlCommand command = new SqlCommand(cmd, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Database backup done successfuly");
                con.Close();
                button2.Enabled = false;


                Settings1.Default.YedeklemeAdresi = textBox1.Text;
                Settings1.Default.YedeklemeTarihi = ytarih;
                Settings1.Default.Yedeklemeİsmi = "lyesql" + " " + DateTime.Now.ToString("yyyy.MM.dd HH.mm.ss");
                Settings1.Default.Save();
                textBox1.Text = Settings1.Default.YedeklemeAdresi.ToString();


            }
            */
        }


        private void Form12_Load(object sender, EventArgs e)
        {
            textBox1.Text = Settings1.Default.YedeklemeAdresi.ToString();
            textBox2.Text = Settings1.Default.GeriYüklemeAdresi.ToString();
            textBox3.Text = Settings1.Default.MailYolu.ToString();
            textBox4.Text = Settings1.Default.MailAdresi.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Form7());
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form7());
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

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "SQL SERVER Database Backup files|*.s3db|Tüm Dosyalar(*.*)|*.*",
                Title = "Database Restore"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dlg.FileName;
                Settings1.Default.GeriYüklemeİsmi = dlg.SafeFileName;
                button6.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string PathToRestoreDB = Environment.CurrentDirectory + @"\database\lyesql.s3db";
            string PathToRestoreDB1 = Environment.CurrentDirectory + @"\database\" + Settings1.Default.GeriYüklemeİsmi.ToString();

            string Filetorestore = textBox2.Text;


            DialogResult sure = MessageBox.Show("Yüklenen Veritabanı Varsayılan (Kullanımdaki) Veritabanı Üzerine Yazılacaktır.\n\nProblem Çıkmaması İçin Bu İşlemden Önce Kullanımdaki Veritabanının Yedeklenmesi Önerilir!\n\nDevam Etmek İstediğinize Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sure == DialogResult.Yes)
            {
                File.Delete(Application.StartupPath + @"\database\" + Settings1.Default.GeriYüklemeİsmiD.ToString());

                File.Copy(Filetorestore, PathToRestoreDB, true);
                File.Copy(Filetorestore, PathToRestoreDB1, true);
                
                Settings1.Default.GeriYüklemeTarihi = ytarih;
                Settings1.Default.GeriYüklemeAdresi = textBox2.Text;
                Settings1.Default.GeriYüklemeİsmiD = Settings1.Default.GeriYüklemeİsmi.ToString();
                Settings1.Default.Save();

                MessageBox.Show("YEDEKTEN GERİ DÖNÜLDÜ!\n\nYedek Yüklemesinin Bilgisi İçin Bilgi Butonuna Tıklayabilirsiniz!");
            }    



            /*

                string database = con.Database.ToString();
            con.Open();

            try
            {
                string str1 = string.Format("Alter Database [" + database + "] Set Single_User With Rollback Immediate");
                SqlCommand cmd1 = new SqlCommand(str1, con);
                cmd1.ExecuteNonQuery();

                string str2 = "Use Master Restore Database [" + database + "] from disk = '" + textBox2.Text + "' With Replace;";
                SqlCommand cmd2 = new SqlCommand(str2, con);
                cmd2.ExecuteNonQuery();

                string str3 = string.Format("Alter Database [" + database + "] Set Multi_User ");
                SqlCommand cmd3 = new SqlCommand(str3, con);
                cmd3.ExecuteNonQuery();

                Settings1.Default.GeriYüklemeTarihi = ytarih;
                Settings1.Default.GeriYüklemeAdresi = textBox2.Text;
                Settings1.Default.GeriYüklemeİsmi = database;
                Settings1.Default.Save();
                MessageBox.Show("Database restore done successfuly");
                con.Close();
            }
            catch
            {

            }
            */
        }


        string ytarihz = DateTime.Now.ToString("yyyy.MM.dd HH.mm.ss");
        private void button7_Click(object sender, EventArgs e)
        {


            string adres = Environment.CurrentDirectory + @"\database\" + Settings1.Default.GeriYüklemeİsmi.ToString();
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

                mail.From = new MailAddress(mailim, "Kim Milyoner Olmak İster");
                mail.Subject = "Veritabanı";
                mail.Body = "Kim Milyoner Olmak İster Bilgi Yarışması Veritabanı Yedeği, Yüklenme Tarihi: " + Settings1.Default.GeriYüklemeTarihi+ "";
                mail.Attachments.Add(new Attachment(adres));
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

                Settings1.Default.MailTarihi = ytarih;
                Settings1.Default.MailYolu = textBox3.Text;
                Settings1.Default.MailAdresi = textBox4.Text;
                Settings1.Default.Save();

            }



            //string database = con.Database.ToString();

            //string cmd = textBox3.Text;  //+ " 2022.01.23 02.01.00.bak";//"Backup Database [" + database + "] To Disk = '";
            //string adres = (cmd);
            //string mailim, sifre;
            //mailim = "omercagdas2004@gmail.com";
            //sifre = "master793DF";
            //if (textBox4.Text == "")
            //{
            //    MessageBox.Show("Lütfen Mail Adresinizi Giriniz!");
            //}
            //else
            //{
            //    MailMessage mail = new MailMessage();
            //    mail.To.Add(textBox4.Text);

            //    mail.From = new MailAddress(mailim, "Bilgi Yarışması");
            //    mail.Subject = "C# Bilgi Yarışması Veritabanı";
            //    mail.Body = "C# Bilgi Yarışması Veritabanı Yedeği. Tarih: " + ytarih + "";
            //    mail.Attachments.Add(new Attachment(adres));
            //    mail.IsBodyHtml = true;
            //    SmtpClient smtp = new SmtpClient
            //    {
            //        Host = "smtp.gmail.com",
            //        Credentials = new System.Net.NetworkCredential(mailim, sifre),
            //        Port = 587,
            //        EnableSsl = true
            //    };
            //    smtp.Send(mail);
            //    mail.Dispose();

            //    Settings1.Default.MailTarihi = ytarih;
            //    Settings1.Default.MailYolu = textBox3.Text;
            //    Settings1.Default.MailAdresi = textBox4.Text;
            //    Settings1.Default.Save();

            //}
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "SQL SERVER Database Backup files|*.bak|Tüm Dosyalar(*.*)|*.*",
                Title = "Database Restore"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = dlg.FileName;
                button7.Enabled = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Son Yedekleme Tarihi\n" + Settings1.Default.YedeklemeTarihi.ToString() + "\n\n\nSon Yedekleme Yolu\n" + Settings1.Default.YedeklemeAdresi.ToString() + "\n\n\nSon Yedekleme İsmi\n" + Settings1.Default.Yedeklemeİsmi.ToString());

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Son Geri Yükleme Tarihi\n" + Settings1.Default.GeriYüklemeTarihi.ToString() + "\n\n\nSon Geri Yükleme Konumu\n" + Settings1.Default.GeriYüklemeAdresi.ToString() + "\n\n\nSon Geri Yükleme İsmi\n" + Settings1.Default.GeriYüklemeİsmi.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Son Mail Gönderme Tarihi\n" + Settings1.Default.MailTarihi.ToString() + "\n\n\nSon Mail Gönderme Konumu\n" + Settings1.Default.MailYolu.ToString() + "\n\n\nSon Mail Gönderilen Alıcı\n" + Settings1.Default.MailAdresi.ToString());
        }
    }
}
