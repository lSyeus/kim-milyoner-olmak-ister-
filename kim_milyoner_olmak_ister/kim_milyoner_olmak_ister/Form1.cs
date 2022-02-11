using Microsoft.Win32;
using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace kim_milyoner_olmak_ister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public SQLiteConnection bag = new SQLiteConnection("Data Source = database/lyesql.s3db");
        public SQLiteCommand kmt = new SQLiteCommand();


        //public SoundPlayer player = new SoundPlayer();


        void CreateDB()

        {

            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated security=true");

            //Aşağıdaki sorgu SQLEXPRESS üzerinde bizim veritabanımızın (SETUPPROJESI) olup olmadığını kontrol ediyor ve eğer yoksa böyle bir veritabanı oluşturuyor.

            SqlCommand cmd = new SqlCommand("if not exists(select * from sys.databases where name = 'SETUPPROJESI') begin CREATE DATABASE SETUPPROJESI ON PRIMARY (NAME = SETUPPROJESI_Data,FILENAME = 'C:\\SETUPPROJESI.mdf',SIZE = 3MB,MAXSIZE = 10MB, FILEGROWTH = 10%) LOG ON (NAME = SETUPPROJESI_Log,FILENAME = 'C:\\SETUPPROJESI.ldf',SIZE = 1MB,MAXSIZE = 5MB,FILEGROWTH = 10%) end");

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();



            //Şimdi de veritabanımız içerisinde tablomuzun olup olmadığına bakalım ve eğer tablomuz yoksa tablomuzu oluşturalım ve verilerimizi atalım.

            con.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SETUPPROJESI;Integrated security=true";

            //Aşağıdaki sorgu Kullanicilar tablosunun olup olmadığına bakmakta ve eğer yoksa oluşturarak içerisine kayıtları eklemektedir.

            cmd.CommandText = "if not exists(select * from sys.tables where name = 'Kullanicilar') begin create table Kullanicilar(ID int identity(1,1) primary key,Ad varchar(20),Soyad varchar(20) ) insert into Kullanicilar (Ad,Soyad) values('Erol','ORTATEPE') insert into Kullanicilar (Ad,Soyad) values('Elvan','EFE') insert into Kullanicilar (Ad,Soyad) values('Yasin','YILMAZ') insert into Kullanicilar (Ad,Soyad) values('İbrahim','ELMAS') insert into Kullanicilar (Ad,Soyad) values('Yasin','YILMAZ') insert into Kullanicilar (Ad,Soyad) values('Cengiz','EFE') insert into Kullanicilar (Ad,Soyad) values('Olcay','BÜYÜKÇAPAR') end";

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            /*

            //HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names

            //Eğer bu bilgisayarda SQL SERVER veya SQLSERVEREXPRESS sürümü yüklendi ise yukarıda regedit bölümünde yüklü SQL SERVER instance'leri yer alacaktır.           
            
            string[] yuklusqller = (string[])Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Microsoft").OpenSubKey("Microsoft SQL Server").GetValue("InstalledInstances");

            //Eğer kullanıcının bilgisayarında SQLExpress yüklü değilse

            var yukluozellikler = (from s in yuklusqller

                                   where s.Contains("SQLEXPRESS")

                                   select s).FirstOrDefault();

            if (yukluozellikler == null)

            {

                DialogResult sonuc1 = MessageBox.Show("Programı kullanabilmek için SQLEXPRESS yüklenmelidir. Yüklemek istiyor musunuz?", "UYARI", MessageBoxButtons.YesNo);

                if (sonuc1 == DialogResult.Yes)

                {

                    string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SQLEXPR.exe";

                    Process p = new Process();

                    p.StartInfo.FileName = path;

                    //Aşağıdaki argumanları (parametreleri) SQLEXPRESS setup dosyama göndererek kurulumu başlatırsam kullanıcıya kurulum yeri v.s gibi bilgileri sormayacak ve doğrudan kuruluma geçecektir.

                    p.StartInfo.Arguments = "/qb INSTANCENAME=\"SQLEXPRESS\" INSTALLSQLDIR=\"C:\\Program Files\\Microsoft SQL Server\" INSTALLSQLSHAREDDIR=\"C:\\Program Files\\Microsoft SQL Server\" INSTALLSQLDATADIR=\"C:\\Program Files\\Microsoft SQL Server\" ADDLOCAL=\"All\" SQLAUTOSTART=1 SQLBROWSERAUTOSTART=0 SQLBROWSERACCOUNT=\"NT AUTHORITY\\SYSTEM\" SQLACCOUNT=\"NT AUTHORITY\\SYSTEM\" SECURITYMODE=SQL SAPWD=\"\" SQLCOLLATION=\"SQL_Latin1_General_Cp1_CS_AS\" DISABLENETWORKPROTOCOLS=0 ERRORREPORTING=1 ENABLERANU=0";

                    //Process için pencere oluşturma.

                    p.StartInfo.CreateNoWindow = true;

                    //Process gizli çalışsın.

                    p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                    p.Start();

                    //İşlem bitene kadar bekle

                    p.WaitForExit();

                }

                else

                {

                    //Eğer SQLEXPRESS'i kurmak istemiyorsa programı sonlandırıyorum.

                    this.Close();

                }

            }
            else { }

        */


        //string path = Application.StartupPath + @"\sounds\milyon.wav";
        //player.SoundLocation = path;//www.gorselprogramlama.com
        //player.Play();
        openChildForm(new Form4());

            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from TytSoruSay where Id=1";
            //kmt.CommandText = "Insert into sorusayi (sayi1, sayi2) values (@sayi1,@sayi2)";
            kmt.Parameters.AddWithValue("@sayi1", label1.Text);
            kmt.Parameters.AddWithValue("@sayi2", label2.Text);
            //kmt.ExecuteNonQuery();

            SQLiteDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {

                label1.Text = read["sayi1"].ToString();
                label2.Text = read["sayi2"].ToString();

            }
            read.Close();
            read.Dispose();
            bag.Close();


            Settings1.Default.sayi1 = label1.Text;
            Settings1.Default.sayi2 = label2.Text;


            //Properties.Settings.Default.Save();

            int sayi11, sayi22, sonuc;

            string x = label1.Text;
            string y = label2.Text;

            sayi11 = Convert.ToInt32(x);
            sayi22 = Convert.ToInt32(y);

            sonuc = sayi22 - sayi11;

            Settings1.Default.sayifark = sonuc;

            if (sonuc > 8)
            {
                label5.Text = sonuc.ToString();
                //Settings1.Default.sayifark = label5.Text;
            }
            else
            {
                label5.Text = ("!!!\n\nSeçmiş olduğunuz soru aralığı değeri 8'den büyük olmalıdır.");
            }


            Properties.Settings.Default.Save();



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


        private void button3_Click(object sender, EventArgs e)
        {

            int t = Settings1.Default.sayifark;

            DialogResult telefon = MessageBox.Show("Kim Milyoner Olmak İster TYT'ye Başlamak Üzeresiniz", "Kim Milyoner Olmak İster TYT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (telefon == DialogResult.Yes)
            {

                if (t > 8)
                {
                    Form2 frm2 = new Form2();
                    frm2.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Seçmiş olduğunuz soru aralığı 8'den büyük olmalıdır. \nAksi taktirde program açılmayacaktır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }

            }
            else if (telefon == DialogResult.No)
            {

            }
        }

        /*
        Form2 frm2 = new Form2();
        frm2.Show();
        this.Hide();
        player.Stop();
        */


        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult telefon = MessageBox.Show("Kim Milyoner Olmak İster AYT'ye Başlamak Üzeresiniz", "Kim Milyoner Olmak İster AYT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (telefon == DialogResult.Yes)
            {

                //openChildForm(new Form3());


                Form3 frm3 = new Form3();
                frm3.Show();
                this.Hide();
                //player.Stop();


            }
            else if (telefon == DialogResult.No)
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult telefon = MessageBox.Show("Admin Paneline Yönlendirileceksiniz.", "Admin Paneli", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (telefon == DialogResult.Yes)
            {

                openChildForm(new Form6());
                panelSideMenu.BackColor = Color.DarkGray;


            }
            else if (telefon == DialogResult.No)
            {

            }
        }


        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form10());
        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
            panelSideMenu.BackColor = Color.DarkGray;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form11());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form12());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //CreateDB();
        }
    }
}
