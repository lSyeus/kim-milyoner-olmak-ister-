using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
using System.Data.SQLite;

/*
public class MyRadioButton : RadioButton
{
    public MyRadioButton()
    {
        this.Appearance = System.Windows.Forms.Appearance.Button;
        this.BackColor = Color.Transparent;
        this.TextAlign = ContentAlignment.MiddleCenter;
        this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.FlatAppearance.BorderColor = Color.RoyalBlue;
        this.FlatAppearance.BorderSize = 2;
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        this.OnPaintBackground(e);
        using (var path = new GraphicsPath())
        {
            var c = e.Graphics.ClipBounds;
            var r = this.ClientRectangle;
            r.Inflate(-FlatAppearance.BorderSize, -FlatAppearance.BorderSize);
            path.AddEllipse(r);
            e.Graphics.SetClip(path);
            base.OnPaint(e);
            e.Graphics.SetClip(c);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if (this.Checked)
            {
                using (var p = new Pen(FlatAppearance.BorderColor,
                                       FlatAppearance.BorderSize))
                {
                    e.Graphics.DrawEllipse(p, r);
                }
            }
        }
    }
}

*/
namespace kim_milyoner_olmak_ister
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public SQLiteConnection bag = new SQLiteConnection(lyesql.sqlconnection);
        public SQLiteCommand kmt = new SQLiteCommand();
        int[] sayilar = new int[8];
        int[] secenekSayilar = new int[2];
        Random r = new Random();
        int randomSayac = 0, soruSayac = 1, kazanilanPara = 0, uretilmeyecekSayi = 0;
        string dogruCevap, yarismaciCevap, resimyolu;


        public SoundPlayer dogru = new SoundPlayer();
        public SoundPlayer yanlis = new SoundPlayer();
        public SoundPlayer milyon = new SoundPlayer();
        public SoundPlayer sorugel = new SoundPlayer();
        public SoundPlayer aiç = new SoundPlayer();
        public SoundPlayer ok = new SoundPlayer();
        public SoundPlayer seçenekseç = new SoundPlayer();
        string dogruyolu = Application.StartupPath + @"\sounds\dogru.wav";
        string yanlisyolu = Application.StartupPath + @"\sounds\yanlis.wav";
        string milyonyolu = Application.StartupPath + @"\sounds\milyon.wav";
        string telefonyolu = Application.StartupPath + @"\sounds\beeeeeee.wav";
        string sorugelyolu = Application.StartupPath + @"\sounds\YeniSoru.wav";
        string aiçyolu = Application.StartupPath + @"\sounds\aiç.wav";
        string okyolu = Application.StartupPath + @"\sounds\ok2.wav";
        string seçenekseçyolu = Application.StartupPath + @"\sounds\SeçenekSeç.wav";

        //yanlis.SoundLocation = yanlisyolu;
        //yanlis.Play();


        void radioButonlarıGoster()//www.gorselprogramlama.com
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            pictureBox1.Image = System.Drawing.Image.FromFile(resimyolu);
        }
        void radioButonlarıSecme()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }


        void rastgeleSayi()
        {
            int rastgele;
            randomSayac = 0;
            while (randomSayac < 8)
            {

                label18.Text = Settings1.Default.sayi1.ToString();
                label19.Text = Settings1.Default.sayi2.ToString();


                //string x = Settings1.Default.sayi1.ToString();
                //string y = Settings1.Default.sayi2.ToString();
                string x = label18.Text;
                string y = label19.Text;



                int sayi11 = Convert.ToInt32(x);
                int sayi22 = Convert.ToInt32(y);

                rastgele = r.Next(sayi11, sayi22);//1 ile 50 arasında rastgele sayı üretiliyor
                if (Array.IndexOf(sayilar, rastgele) == -1) //dizinin içinde aynı sayı yoksa 
                {
                    sayilar[randomSayac] = rastgele;
                    randomSayac++;
                }
                //bag.Close();

                //Bende  inan bunu yapmaya çalıştım bir ara işin içinden çıkamayınca vazgeçtim çok karışık
                ////şöyle ki ben bunu başardım bi ama program içinde gecikme falan oldu, farklı bir form.cs den bu forma aktarabilirsem çalışır gibi geldi
                ///vallah dostum ben sana yardımcı olamam üzgünüm :(
                ///sağlık olsun hocam, teşekkür ederim düşündüğüünüz için
                ///Başka konularda inş. yardımcı olabilirim sana kolay gelsin
                ///eyw :))
            }
        }

        void rastgeleSayi2()
        {
            int rastgele;
            randomSayac = 0;
            while (randomSayac < 8)
            {


                string x = label18.Text;
                string y = label19.Text;



                int sayi11 = Convert.ToInt32(x);
                int sayi22 = Convert.ToInt32(y);

                rastgele = r.Next(sayi11, sayi22);//1 ile 50 arasında rastgele sayı üretiliyor
                if (Array.IndexOf(sayilar, rastgele) == -1) //dizinin içinde aynı sayı yoksa 
                {
                    sayilar[randomSayac] = rastgele;
                    randomSayac++;
                }
            }
        }

        void secenekRastgeleSayi()
        {
            int rastgele;
            randomSayac = 0;
            while (randomSayac < 2)
            {
                rastgele = r.Next(1, 5);//1 ile 50 arasında rastgele sayı üretiliyor
                if (Array.IndexOf(secenekSayilar, rastgele) == -1 && rastgele != uretilmeyecekSayi) //dizinin içinde aynı sayı yoksa 
                {
                    secenekSayilar[randomSayac] = rastgele;
                    randomSayac++;
                }
            }
        }


        void soruAl(int a)
        {
            try
            {
                bag.Open();
                kmt.Connection = bag;
                kmt.CommandText = "Select  * from tytSorular where Id=" + sayilar[a];
                SQLiteDataReader oku;
                oku = kmt.ExecuteReader();
                while (oku.Read())
                {
                    label13.Text = oku[1].ToString();//www.gorselprogramlama.com
                    radioButton1.Text = oku[2].ToString();
                    radioButton2.Text = oku[3].ToString();
                    radioButton3.Text = oku[4].ToString();
                    radioButton4.Text = oku[5].ToString();
                    radioButton5.Text = oku[6].ToString();
                    dogruCevap = oku[7].ToString();
                    resimyolu = oku[8].ToString();
                }
                pictureBox1.Image = System.Drawing.Image.FromFile(resimyolu);
                oku.Close();
                oku.Dispose();
                bag.Close();
            }
            catch
            {
                //MessageBox.Show("Bir Sorunla Karşılaşıldı. Programı Yeniden Başlatmayı deneyebilir hala sorunun devam etmesi durumunda Lyeus ile iletişime geçebilirsiniz.", "Uyarı");
                MessageBox.Show("Bir Sorunla Karşılaşıldı. Muhtemel olarak sorunun sebebi seçilen soru aralğından kaynaklanmaktadır. Görüntülenmesini istediğiniz soru aralığınında problem olmadığından emin olun. Problem olmadığını düşünüyorsanız programı yeniden başlatmayı deneyin. Problem devam ettiği taktirde Lyeus ile iletişime geçin.", "Uyarı");
            }


            if (a == 1) kazanilanPara = 500;
            if (a == 2) kazanilanPara = 1000;
            if (a == 3) kazanilanPara = 2000;
            if (a == 4) kazanilanPara = 3000;
            if (a == 5) kazanilanPara = 5000;
            if (a == 6) kazanilanPara = 7500;
            if (a == 7) kazanilanPara = 15000;
            if (a == 8) kazanilanPara = 30000;
            if (a == 9) kazanilanPara = 60000;
            if (a == 10) kazanilanPara = 125000;
            if (a == 11) kazanilanPara = 250000;
            if (a == 12) kazanilanPara = 1000000;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //labelRenklendir(soruSayac);
            //rastgeleSayi();
            //soruAl(soruSayac);
            //timer1.Enabled = true;
            //btnCevapla.Enabled = false;
            //button3.Enabled = false;
            //pictureBox1.ImageLocation = resimyolu;

            milyon.SoundLocation = milyonyolu;
            milyon.Play();

            //pictureBox1.Image = System.Drawing.Image.FromFile(resimyolu);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            milyon.Stop();
            labelRenklendir(soruSayac);
            rastgeleSayi();
            soruAl(soruSayac);
            timer1.Enabled = true;
            btnCevapla.Enabled = false;
            button3.Enabled = false;
            pictureBox1.ImageLocation = resimyolu;
            button6.Visible = false;
            label15.Visible = true;
            label13.Visible = true;
            pictureBox1.Visible = true;

            //milyon.Stop();

            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;

            btnCevapla.Visible = true;
            btnTekrarOyna.Visible = true;

            btnElli.Visible = true;
            btnSeyirci.Visible = true;
            btnTelefon.Visible = true;
            button3.Visible = true;

            button4.Visible = true;
            btnCikis.Visible = true;

            button1.Visible = true;
            button2.Visible = true;
            button5.Visible = true;

            groupBox1.Visible = true;
            //label12.Visible = true;
            //label11.Visible = true;
            //label10.Visible = true;
            //label9.Visible = true;
            //label8.Visible = true;
            label7.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label2.Visible = true;
            label1.Visible = true;


        }

        void labelRenkSifirla()
        {
            label1.ForeColor = Color.DarkOrange;
            label1.BackColor = Color.BlueViolet;
            label2.ForeColor = Color.White;
            label2.BackColor = Color.BlueViolet;
            label3.ForeColor = Color.DarkOrange;
            label3.BackColor = Color.BlueViolet;
            label4.ForeColor = Color.DarkOrange;
            label4.BackColor = Color.BlueViolet;
            label5.ForeColor = Color.DarkOrange;
            label5.BackColor = Color.BlueViolet;
            label6.ForeColor = Color.DarkOrange;
            label6.BackColor = Color.BlueViolet;
            label7.ForeColor = Color.White;
            label7.BackColor = Color.BlueViolet;
            label8.ForeColor = Color.DarkOrange;
            label8.BackColor = Color.BlueViolet;
            label9.ForeColor = Color.DarkOrange;
            label9.BackColor = Color.BlueViolet;
            label10.ForeColor = Color.DarkOrange;
            label10.BackColor = Color.BlueViolet;
            label11.ForeColor = Color.DarkOrange;
            label11.BackColor = Color.BlueViolet;
            label12.ForeColor = Color.White;
            label12.BackColor = Color.BlueViolet;
        }
        void labelRenklendir(int a)
        {
            if (a == 1)
            {
                label1.ForeColor = Color.Black;
                label1.BackColor = Color.DarkOrange;
            }
            if (a == 2)
            {
                label2.ForeColor = Color.Black;
                label2.BackColor = Color.DarkOrange;
                label1.ForeColor = Color.DarkOrange;
                label1.BackColor = Color.DarkSlateBlue;
            }
            if (a == 3)
            {
                label3.ForeColor = Color.Black;
                label3.BackColor = Color.DarkOrange;
                label2.ForeColor = Color.White;
                label2.BackColor = Color.DarkSlateBlue;
            }
            if (a == 4)
            {
                label4.ForeColor = Color.Black;//www.gorselprogramlama.com
                label4.BackColor = Color.DarkOrange;
                label3.ForeColor = Color.DarkOrange;
                label3.BackColor = Color.DarkSlateBlue;
            }
            if (a == 5)
            {
                label5.ForeColor = Color.Black;
                label5.BackColor = Color.DarkOrange;
                label4.ForeColor = Color.DarkOrange;
                label4.BackColor = Color.DarkSlateBlue;
            }
            if (a == 6)
            {
                label6.ForeColor = Color.Black;
                label6.BackColor = Color.DarkOrange;
                label5.ForeColor = Color.DarkOrange;
                label5.BackColor = Color.DarkSlateBlue;
            }
            if (a == 6)
            {
                label6.ForeColor = Color.Black;
                label6.BackColor = Color.DarkOrange;
                label5.ForeColor = Color.DarkOrange;
                label5.BackColor = Color.DarkSlateBlue;
            }
            if (a == 7)
            {
                label7.ForeColor = Color.Black;
                label7.BackColor = Color.DarkOrange;
                label6.ForeColor = Color.DarkOrange;
                label6.BackColor = Color.DarkSlateBlue;
            }
            if (a == 8)
            {
                label8.ForeColor = Color.Black;
                label8.BackColor = Color.DarkOrange;
                label7.ForeColor = Color.White;
                label7.BackColor = Color.DarkSlateBlue;
            }
            if (a == 9)
            {
                label9.ForeColor = Color.Black;
                label9.BackColor = Color.DarkOrange;
                label8.ForeColor = Color.DarkOrange;
                label8.BackColor = Color.DarkSlateBlue;
            }
            if (a == 10)
            {
                label10.ForeColor = Color.Black;
                label10.BackColor = Color.DarkOrange;
                label9.ForeColor = Color.DarkOrange;
                label9.BackColor = Color.DarkSlateBlue;
            }
            if (a == 11)
            {
                label11.ForeColor = Color.Black;
                label11.BackColor = Color.DarkOrange;
                label10.ForeColor = Color.DarkOrange;
                label10.BackColor = Color.DarkSlateBlue;
            }
            if (a == 12)
            {
                label12.ForeColor = Color.Black;
                label12.BackColor = Color.DarkOrange;
                label11.ForeColor = Color.DarkOrange;
                label11.BackColor = Color.DarkSlateBlue;
            }
        }



        private void btnCevapla_Click(object sender, EventArgs e)
        {

            if (soruSayac < 8)
            {
                DialogResult cevap, cevap2, cevap3;
                cevap = MessageBox.Show("Son Kararın Mı ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    btnCevapla.Enabled = false;
                    button3.Enabled = false;
                    timer1.Enabled = false;
                    dak = 60;
                    label15.Text = "60";
                    if (radioButton1.Checked) yarismaciCevap = radioButton1.Text;
                    if (radioButton2.Checked) yarismaciCevap = radioButton2.Text;
                    if (radioButton3.Checked) yarismaciCevap = radioButton3.Text;
                    if (radioButton4.Checked) yarismaciCevap = radioButton4.Text;
                    if (radioButton5.Checked) yarismaciCevap = radioButton5.Text;
                    if (yarismaciCevap == dogruCevap)
                    {

                        dogru.SoundLocation = dogruyolu;
                        dogru.Play();

                        if (soruSayac == 7)
                        {
                            //label14.Text = "Tebrikler " + kazanilanPara + " TL Kazandınız ...";
                            btnCevapla.Visible = false;
                            btnTekrarOyna.Visible = true;
                        }
                        else
                        {
                            cevap2 = MessageBox.Show("Yarışmaya devam etmek için Evet seçeneğine, " + kazanilanPara + " TL lik çeki almak için Hayır seçeneğine tıklayınız.", "Doğru Cevap!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (cevap2 == DialogResult.No)
                            {
                                //label14.Text = "Tebrikler " + kazanilanPara + " TL Kazandınız ...";
                                timer1.Enabled = false;
                                btnCevapla.Visible = false;
                                button3.Visible = false;
                                btnTekrarOyna.Visible = true;
                                MessageBox.Show("");
                            }
                            else
                            {
                                soruSayac++;
                                soruAl(soruSayac);
                                labelRenklendir(soruSayac);
                                timer1.Enabled = true;
                                radioButonlarıGoster();
                                radioButonlarıSecme();
                            }

                        }

                    }
                    else
                    {
                        button3.Enabled = false;

                        yanlis.SoundLocation = yanlisyolu;
                        yanlis.Play();

                        //if (soruSayac > 0 && soruSayac <= 2) label14.Text = "Sosyal medyada alay konusu oldunuz!";
                        //if (soruSayac > 2 && soruSayac <= 3) label14.Text = "Yanlış cevap 0 TL Kazandınız ..." + dogruCevap;
                        cevap3 = MessageBox.Show("Doğru Cevap: " + dogruCevap + " ! \n\nYarışmacı Cevap: " + yarismaciCevap + " !\n\n\nYarışmaya devam etmek için Tamam seçeneğine tıklayın. ", "Yanlış Cevap!");
                        if (cevap3 == DialogResult.Yes)
                        {
                            //label14.Text = "Tebrikler " + kazanilanPara + " TL Kazandınız ...";
                            timer1.Enabled = false;
                            btnCevapla.Visible = false;
                            btnTekrarOyna.Visible = true;
                        }
                        else
                        {
                            timer1.Enabled = true;
                            radioButonlarıGoster();
                            radioButonlarıSecme();
                        }

                        //if (soruSayac > 2 && soruSayac < 6) label14.Text = "Yanlış cevap 1000 TL Kazandınız ...";
                        //if (soruSayac >= 6) label14.Text = "Yanlış cevap 15.000 TL Kazandınız ...";
                        btnCevapla.Visible = false;//www.gorselprogramlama.com
                        btnTekrarOyna.Visible = true;
                        timer1.Enabled = false;
                    }
                }
            }
        }

        int dak = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dak > 0)
            {
                dak--;
                label15.Text = dak.ToString();
            }
            else
            {
                //if (soruSayac <= 2) label14.Text = "Süre Doldu. 0 TL Kazandınız ...";
                //if (soruSayac > 2 && soruSayac < 7) label14.Text = "Süre Doldu. 1000 TL Kazandınız ...";
                //if (soruSayac >= 7) label14.Text = "Süre Doldu. 15.000 TL Kazandınız ...";
                timer1.Enabled = false;
                btnCevapla.Visible = false;
                btnTekrarOyna.Visible = true;
                /*
                DialogResult time = MessageBox.Show("Süre doldu! \n\nTekrar oynamak için Evet, yarışmaya ara vermek için Hayır butonuna tıklayın.","Süre Doldu!",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
                if (time == DialogResult.Yes)
                {
                    Array.Clear(secenekSayilar, 0, 2);
                    btnCevapla.Visible = true;
                    btnTekrarOyna.Visible = true;
                    soruSayac = 1;
                    labelRenkSifirla();
                    labelRenklendir(soruSayac);
                    rastgeleSayi2();
                    soruAl(soruSayac);
                    timer1.Enabled = true;
                    btnCevapla.Enabled = false;
                    button3.Enabled = false;
                    radioButonlarıSecme();
                    radioButonlarıGoster();
                    btnElli.Visible = true;
                    btnSeyirci.Visible = true;
                    btnTelefon.Visible = true;          
                    button3.Visible = true;
                    btnElli.Enabled = true;
                    hak = 2;
                    dak = 60;
                    pictureBox1.Image = System.Drawing.Image.FromFile(resimyolu);
                }
                    */

            }
        }


        private void btnTekrarOyna_Click(object sender, EventArgs e)
        {
            DialogResult tekraroyna = MessageBox.Show("Yarışmaya tekrar başlamayı onaylıyor musunuz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (tekraroyna == DialogResult.Yes)
            {
                sorugel.SoundLocation = sorugelyolu;
                sorugel.Play();
                Array.Clear(secenekSayilar, 0, 2);
                btnCevapla.Visible = true;
                btnTekrarOyna.Visible = true;
                soruSayac = 1;
                labelRenkSifirla();
                labelRenklendir(soruSayac);
                rastgeleSayi2();
                soruAl(soruSayac);
                timer1.Enabled = true;
                btnCevapla.Enabled = false;
                button3.Enabled = false;
                radioButonlarıSecme();
                radioButonlarıGoster();
                btnElli.Visible = true;
                btnSeyirci.Visible = true;
                btnTelefon.Visible = true;           //www.gorselprogramlama.com
                button3.Visible = true;
                btnElli.Enabled = true;
                hak = 2;
                dak = 60;
                pictureBox1.Image = System.Drawing.Image.FromFile(resimyolu);

                //label14.Text = "";
            }
            else if (tekraroyna == DialogResult.No)
            {

            }


        }



        private void btnElli_Click(object sender, EventArgs e)
        {

            timer1.Stop();
            DialogResult seyirci = MessageBox.Show("%50 jokerini kullanmak istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (seyirci == DialogResult.Yes)
            {
                Random r = new Random();
                string[] secenekler = new string[5];
                if (dogruCevap == radioButton1.Text) uretilmeyecekSayi = 0;
                if (dogruCevap == radioButton2.Text) uretilmeyecekSayi = 1;
                if (dogruCevap == radioButton3.Text) uretilmeyecekSayi = 2;
                if (dogruCevap == radioButton4.Text) uretilmeyecekSayi = 3;
                if (dogruCevap == radioButton5.Text) uretilmeyecekSayi = 4;
                //eğer çift cevap açıkken elliyi kullanmak istersen ikinci bir elli ata ve ona göre ayarla, çifte tıklanınca aktif olsun
                for (int i = 1; i < 5; i++)
                {
                    if (dogruCevap != radioButton1.Text && i == 0) secenekler[i] = radioButton1.Text;
                    if (dogruCevap != radioButton2.Text && i == 1) secenekler[i] = radioButton2.Text;
                    if (dogruCevap != radioButton3.Text && i == 2) secenekler[i] = radioButton3.Text;
                    if (dogruCevap != radioButton4.Text && i == 3) secenekler[i] = radioButton4.Text;
                    if (dogruCevap != radioButton5.Text && i == 4) secenekler[i] = radioButton5.Text;
                }
                secenekRastgeleSayi();
                for (int i = 0; i < 2; i++)
                {
                    if (secenekler[secenekSayilar[i]] == radioButton1.Text) radioButton1.Visible = false;
                    if (secenekler[secenekSayilar[i]] == radioButton2.Text) radioButton2.Visible = false;
                    if (secenekler[secenekSayilar[i]] == radioButton3.Text) radioButton3.Visible = false;
                    if (secenekler[secenekSayilar[i]] == radioButton4.Text) radioButton4.Visible = false;
                    if (secenekler[secenekSayilar[i]] == radioButton5.Text) radioButton5.Visible = false;
                }
                btnElli.Visible = false;
                timer1.Start();
            }
            else if (seyirci == DialogResult.No)
            {
                timer1.Start();
            }
            /*
            Random r = new Random();
            string[] secenekler = new string[5];
            if (dogruCevap == radioButton1.Text) uretilmeyecekSayi = 0;
            if (dogruCevap == radioButton2.Text) uretilmeyecekSayi = 1;
            if (dogruCevap == radioButton3.Text) uretilmeyecekSayi = 2;
            if (dogruCevap == radioButton4.Text) uretilmeyecekSayi = 3;//www.gorselprogramlama.com
            if (dogruCevap == radioButton5.Text) uretilmeyecekSayi = 4;
            for (int i = 1; i < 5; i++)
            {
                if (dogruCevap != radioButton1.Text && i == 0) secenekler[i] = radioButton1.Text;
                if (dogruCevap != radioButton2.Text && i == 1) secenekler[i] = radioButton2.Text;
                if (dogruCevap != radioButton3.Text && i == 2) secenekler[i] = radioButton3.Text;
                if (dogruCevap != radioButton4.Text && i == 3) secenekler[i] = radioButton4.Text;
                if (dogruCevap != radioButton5.Text && i == 4) secenekler[i] = radioButton5.Text;
            }
            secenekRastgeleSayi();
            for (int i = 0; i < 2; i++)
            {
                if (secenekler[secenekSayilar[i]] == radioButton1.Text) radioButton1.Visible = false;
                if (secenekler[secenekSayilar[i]] == radioButton2.Text) radioButton2.Visible = false;
                if (secenekler[secenekSayilar[i]] == radioButton3.Text) radioButton3.Visible = false;
                if (secenekler[secenekSayilar[i]] == radioButton4.Text) radioButton4.Visible = false;
                if (secenekler[secenekSayilar[i]] == radioButton5.Text) radioButton5.Visible = false;
            }
            btnElli.Visible = false;
            */
        }

        private void btnSeyirci_Click(object sender, EventArgs e)
        {
            /*
            int rastgele;
            string seyirciCevap = "";//www.gorselprogramlama.com
            rastgele = r.Next(1, 6);
            if (rastgele == 1) seyirciCevap = radioButton1.Text;
            if (rastgele == 2) seyirciCevap = radioButton2.Text;
            if (rastgele == 3) seyirciCevap = radioButton3.Text;
            if (rastgele == 4) seyirciCevap = radioButton4.Text;
            if (rastgele == 5) seyirciCevap = radioButton5.Text;
            */

            timer1.Stop();
            DialogResult seyirci = MessageBox.Show("Aiç'e sorma jokerini kullanmak istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (seyirci == DialogResult.Yes)
            {
                aiç.SoundLocation = aiçyolu;
                aiç.Play();
                DialogResult seyirci2 = MessageBox.Show("Aiç'in Vermiş Olduğu Cevap -- " + dogruCevap + " -- seçeneğidir.", "Aiç'in Cevabı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (seyirci2 == DialogResult.OK)
                {
                    btnSeyirci.Visible = false;
                    timer1.Start();
                    aiç.Stop();
                    ok.SoundLocation = okyolu;
                    ok.Play();
                    //SendKeys.Send(dogruCevap);
                }

            }
            else if (seyirci == DialogResult.No)
            {
                timer1.Start();
            }

        }



        private void btnTelefon_Click(object sender, EventArgs e)
        {

            timer1.Stop();
            DialogResult telefon = MessageBox.Show("Halil'e sorma jokerini kullanmak istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (telefon == DialogResult.Yes)
            {

                yanlis.SoundLocation = telefonyolu;
                yanlis.Play();
                MessageBox.Show("Be,  be,  be, bee!");
                btnTelefon.Visible = false;
                timer1.Start();
            }
            else if (telefon == DialogResult.No)
            {
                timer1.Start();
            }

            /*
            int rastgele;
            string seyirciCevap = "";
            rastgele = r.Next(1, 6);
            if (rastgele == 1) seyirciCevap = radioButton1.Text;
            if (rastgele == 2) seyirciCevap = radioButton2.Text;
            if (rastgele == 3) seyirciCevap = radioButton3.Text;
            if (rastgele == 4) seyirciCevap = radioButton4.Text;
            if (rastgele == 5) seyirciCevap = radioButton5.Text;
            MessageBox.Show("Telefon ile bağlandığınız kişinin vermiş olduğu cevap -- " + seyirciCevap + " -- seçeneğidir.", "Telefon Cevabı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTelefon.Visible = false;
            */
        }



        int hak = 2;
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult cevap2, cevap3;

            DialogResult ciftCevap = MessageBox.Show("Çift cevap jokerini kullanmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ciftCevap == DialogResult.Yes)
            {
                btnCevapla.Visible = false;
                btnElli.Enabled = false;
                timer1.Stop();
                if (hak == 0)
                {
                    yanlis.SoundLocation = yanlisyolu;
                    yanlis.Play();
                    btnCevapla.Visible = false;
                    btnTekrarOyna.Visible = true;
                    timer1.Enabled = false;
                }

                if (radioButton1.Checked) yarismaciCevap = radioButton1.Text;
                if (radioButton2.Checked) yarismaciCevap = radioButton2.Text;
                if (radioButton3.Checked) yarismaciCevap = radioButton3.Text;
                if (radioButton4.Checked) yarismaciCevap = radioButton4.Text;
                if (radioButton5.Checked) yarismaciCevap = radioButton5.Text;
                if (yarismaciCevap == dogruCevap)
                {

                    dogru.SoundLocation = dogruyolu;
                    dogru.Play();
                    dak = 60;
                    btnCevapla.Visible = true;
                    button3.Visible = false;
                    btnCevapla.Enabled = false;
                    btnElli.Enabled = true;
                    if (soruSayac == 7)
                    {
                        //label14.Text = "Tebrikler " + kazanilanPara + " TL Kazandınız ...";
                        btnCevapla.Visible = false;
                        btnTekrarOyna.Visible = true;
                    }
                    else
                    {
                        cevap2 = MessageBox.Show("Yarışmaya devam etmek için Evet seçeneğine, " + kazanilanPara + " TL lik çeki almak için Hayır seçeneğine tıklayınız.", "Doğru Cevap!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (cevap2 == DialogResult.No)
                        {
                            //label14.Text = "Tebrikler " + kazanilanPara + " TL Kazandınız ...";
                            timer1.Enabled = false;
                            btnCevapla.Visible = false;
                            btnTekrarOyna.Visible = true;
                            btnElli.Enabled = true;
                        }
                        else
                        {
                            soruSayac++;
                            soruAl(soruSayac);
                            labelRenklendir(soruSayac);
                            timer1.Enabled = true;
                            radioButonlarıGoster();
                            radioButonlarıSecme();
                        }
                    }
                }
                else
                {
                    if (hak > 0)
                    {
                        hak -= 1;
                        if (radioButton1.Checked) yarismaciCevap = radioButton1.Text;
                        if (radioButton2.Checked) yarismaciCevap = radioButton2.Text;
                        if (radioButton3.Checked) yarismaciCevap = radioButton3.Text;
                        if (radioButton4.Checked) yarismaciCevap = radioButton4.Text;
                        if (radioButton5.Checked) yarismaciCevap = radioButton5.Text;
                        if (yarismaciCevap == dogruCevap)
                        {
                            dogru.SoundLocation = dogruyolu;
                            dogru.Play();
                            dak = 60;
                            btnCevapla.Visible = true;
                            button3.Visible = false;
                            if (soruSayac == 7)
                            {
                                //label14.Text = "Tebrikler " + kazanilanPara + " TL Kazandınız ...";
                                btnCevapla.Visible = false;
                                btnTekrarOyna.Visible = true;
                            }
                            else
                            {
                                cevap2 = MessageBox.Show("Yarışmaya devam etmek için Evet seçeneğine, " + kazanilanPara + " TL lik çeki almak için Hayır seçeneğine tıklayınız.", "Doğru Cevap!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (cevap2 == DialogResult.No)
                                {
                                    //label14.Text = "Tebrikler " + kazanilanPara + " TL Kazandınız ...";
                                    timer1.Enabled = false;
                                    btnCevapla.Visible = false;
                                    btnTekrarOyna.Visible = true;
                                    MessageBox.Show("asdsad");
                                }
                                else
                                {
                                    soruSayac++;
                                    soruAl(soruSayac);
                                    labelRenklendir(soruSayac);
                                    timer1.Enabled = true;
                                    radioButonlarıGoster();
                                    radioButonlarıSecme();
                                }

                            }
                        }
                    }
                    if (hak == 0)
                    {
                        yanlis.SoundLocation = yanlisyolu;
                        yanlis.Play();
                        cevap3 = MessageBox.Show("Çift Cevap Hakkınız Kalmadı\n\n\nDoğru Cevap: " + dogruCevap + " ! \n\nYarışmacı Cevap: " + yarismaciCevap + " !\n\n\nYarışmaya devam etmek için Tamam seçeneğine tıklayın. ", "Yanlış Cevap!", MessageBoxButtons.OK);
                        if (cevap3 == DialogResult.OK)
                        {
                            //label14.Text = "Tebrikler " + kazanilanPara + " TL Kazandınız ...";
                            timer1.Enabled = false;
                            btnCevapla.Visible = false;
                            btnTekrarOyna.Visible = true;
                            //btnElli.Enabled = true;
                            radioButonlarıGoster();
                        }
                        else
                        {
                            timer1.Enabled = true;
                            radioButonlarıGoster();
                            radioButonlarıSecme();
                        }
                        button3.Visible = false;
                    }

                    else
                    {
                        if (radioButton1.Checked)
                        { radioButton1.Visible = false; }
                        if (radioButton2.Checked)
                        { radioButton2.Visible = false; }
                        if (radioButton3.Checked)
                        { radioButton3.Visible = false; }
                        if (radioButton4.Checked)
                        { radioButton4.Visible = false; }
                        if (radioButton5.Checked)
                        { radioButton5.Visible = false; }

                        MessageBox.Show("Kalan Cevap Hakkınız = " + hak + "\n\nVermiş Olduğunuz Cevap = \n\n" + yarismaciCevap + "", "Yanlış Cevap", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        //33333radiobuttonlar seçiliyse cevapla ya da çift cevaba basılsın. seçili değilse uyarı verilsin
                    }

                }
            }
            /*
            else if (yarismaciCevap != dogruCevap)
            { 
                if (radioButton1.Checked) yarismaciCevap = radioButton1.Text;
                if (radioButton2.Checked) yarismaciCevap = radioButton2.Text;
                if (radioButton3.Checked) yarismaciCevap = radioButton3.Text;
                if (radioButton4.Checked) yarismaciCevap = radioButton4.Text;
                if (radioButton5.Checked) yarismaciCevap = radioButton5.Text;
                if (yarismaciCevap == dogruCevap)
                {
                    string path = "dogru.wav";
                    dogru.SoundLocation = path;
                    dogru.Play();
                    if (soruSayac == 7)
                    {
                        //label14.Text = "Tebrikler " + kazanilanPara + " TL Kazandınız ...";
                        btnCevapla.Visible = false;
                        btnTekrarOyna.Visible = true;
                    }
                    else
                    {
                        cevap2 = MessageBox.Show("Yarışmaya devam etmek için Evet seçeneğine, " + kazanilanPara + " TL lik çeki almak için Hayır seçeneğine tıklayınız.", "Doğru Cevap!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (cevap2 == DialogResult.No)
                        {
                            //label14.Text = "Tebrikler " + kazanilanPara + " TL Kazandınız ...";
                            timer1.Enabled = false;
                            btnCevapla.Visible = false;
                            btnTekrarOyna.Visible = true;
                            MessageBox.Show("");
                        }
                        else
                        {
                            soruSayac++;
                            soruAl(soruSayac);
                            labelRenklendir(soruSayac);
                            timer1.Enabled = true;
                            radioButonlarıGoster();
                            radioButonlarıSecme();
                        }

                    }
                }
                }

            */

            else if (ciftCevap == DialogResult.No)
            {
                timer1.Start();
            }
        }




        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                seçenekseç.SoundLocation = seçenekseçyolu;
                seçenekseç.Play();
                btnCevapla.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                seçenekseç.SoundLocation = seçenekseçyolu;
                seçenekseç.Play();
                btnCevapla.Enabled = true;
                button3.Enabled = true;

            }
        }
        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                seçenekseç.SoundLocation = seçenekseçyolu;
                seçenekseç.Play();
                btnCevapla.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                seçenekseç.SoundLocation = seçenekseçyolu;
                seçenekseç.Play();
                btnCevapla.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                seçenekseç.SoundLocation = seçenekseçyolu;
                seçenekseç.Play();
                btnCevapla.Enabled = true;
                button3.Enabled = true;
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = System.Drawing.Image.FromFile(resimyolu);
        }



        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Ana Menüye dönmek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (cikis == DialogResult.Yes)
            {
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
                milyon.Stop();
            }
            else if (cikis == DialogResult.No)
            {

            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

            // Application.Exit();
            DialogResult cikis = MessageBox.Show("Programdan çıkmak istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (cikis == DialogResult.Yes)
            {
                milyon.Stop();
                Environment.Exit(0);
            }
            else if (cikis == DialogResult.No)
            {

            }
        }



        public string TurkceKarakter(string text)
        {

            text = text.Replace("İ", "\u0130");

            text = text.Replace("ı", "\u0131");

            text = text.Replace("Ş", "\u015e");

            text = text.Replace("ş", "\u015f");

            text = text.Replace("Ğ", "\u011e");

            text = text.Replace("ğ", "\u011f");

            text = text.Replace("Ö", "\u00d6");

            text = text.Replace("ö", "\u00f6");

            text = text.Replace("ç", "\u00e7");

            text = text.Replace("Ç", "\u00c7");

            text = text.Replace("ü", "\u00fc");

            text = text.Replace("Ü", "\u00dc");

            return text;
        }

        private string Month()
        {


            if (DateTime.Now.Month < 10)

                return "0" + DateTime.Now.Month.ToString();
            else return DateTime.Now.Month.ToString();

        }
        private string Day()
        {


            if (DateTime.Now.Day < 10)

                return "0" + DateTime.Now.Day.ToString();
            else return DateTime.Now.Day.ToString();

        }
        private string Hour()
        {


            if (DateTime.Now.Hour < 10)

                return "0" + DateTime.Now.Hour.ToString();
            else return DateTime.Now.Hour.ToString();

        }
        private string Minute()
        {


            if (DateTime.Now.Minute < 10)

                return "0" + DateTime.Now.Minute.ToString();
            else return DateTime.Now.Minute.ToString();

        }
        private string Second()
        {


            if (DateTime.Now.Second < 10)

                return "0" + DateTime.Now.Second.ToString();
            else return DateTime.Now.Second.ToString();

        }
        private string Millisecond()
        {


            if (DateTime.Now.Millisecond < 10)

                return "0" + DateTime.Now.Millisecond.ToString();
            else return DateTime.Now.Millisecond.ToString();

        }
        private void button5_Click(object sender, EventArgs e)
        {



            BaseFont bF = BaseFont.CreateFont("C:\\windows\\fonts\\arial.ttf", "windows-1254", true);
            iTextSharp.text.Font f = new iTextSharp.text.Font(bF, 12f, iTextSharp.text.Font.NORMAL);
            Chunk c = new Chunk
            {
                Font = f
            };
            iTextSharp.text.Document document = new iTextSharp.text.Document();
            //string fate = DateTime.Now.ToShortDateString();
            string fater = Hour();
            string faters = Minute();
            string faterss = Second();
            string fatersss = Millisecond();

            string fate = Day();
            string fates = Month();
            int fatess = DateTime.Now.Year;




            string savefile = Settings1.Default.savefile.ToString();
            string savepdf = Settings1.Default.savepdf.ToString();
            Directory.CreateDirectory(/*@"C:\Users\CASPER\Documents\" + "Kim Milyoner Olmak İster PDF"*/ savefile + @"\Kim Milyoner Olmak İster\PDF");

            PdfWriter.GetInstance(document, new FileStream(/*@"C:\Users\CASPER\Documents\Kim Milyoner Olmak İster PDF\"*/ savepdf + @"\Sorular PDF " + fate + fates + fatess + "0" + fater + faters + faterss + fatersss + ".pdf", FileMode.Create));
            /*string text = "küçük harf türkçe karakterler : ç ğ ı ö ş ü \n" +
            " BÜYÜK TÜRKÇE KARAKTERLER : Ç Ğ İ Ö Ş Ü";
            c.Append(text);*/
            document.Open();
            document.Add(new Paragraph(c));


            string imagefile1 = Path.GetFileName(resimyolu);
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Application.StartupPath + "\\img\\" + imagefile1);

            document.Add(img);


            c.Append(label13.Text + "\n\n");
            c.Append(radioButton1.Text + "\n");
            c.Append(radioButton2.Text + "\n");
            c.Append(radioButton3.Text + "\n");
            c.Append(radioButton4.Text + "\n");
            c.Append(radioButton5.Text + "\n");

            document.Add(new Paragraph(c));
            document.Close();

            MessageBox.Show("Dosyanız \n" + "Sorular PDF " + fate + fates + fatess + "0" + fater + faters + faterss + fatersss + ".pdf" + " \nadıyla\n\n" + savefile + @"\Kim Milyoner Olmak İster\PDF" + " \nkonumuna kaydedilmiştir.");

            /*       
                        iTextSharp.text.Document pdfDosya = new iTextSharp.text.Document();

                        PdfWriter.GetInstance(pdfDosya, new FileStream("C:\\CSharpPDF"+".pdf", FileMode.Create));
                        pdfDosya.Open();

                    /*
                    iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);

                    iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 12, iTextSharp.text.Font.NORMAL);
                    */


            /*          

                     string imagefile = Path.GetFileName(resimyolu);
                      iTextSharp.text.Image imageFile = iTextSharp.text.Image.GetInstance(Application.StartupPath + "\\img\\" + imagefile);

                      pdfDosya.Add(imageFile);


                      //bool xet = pdfDosya.AddCreationDate();

                      //d.Add(new Paragraph("Yevmiye No. :" + label59.Text + " Cilt No. :" + label62.Text + " S"));



                      Paragraph eklenecekMetin = new Paragraph(label13.Text + "\n\n");

                      pdfDosya.Add(eklenecekMetin); //Eklenecek metinimizin Dosyaya eklenmesi

                      Paragraph eklenecekMetin1 = new Paragraph(radioButton1.Text);

                      pdfDosya.Add(eklenecekMetin1); //Eklenecek metinimizin Dosyaya eklenmesi


                      Paragraph eklenecekMetin2 = new Paragraph(radioButton2.Text);

                      pdfDosya.Add(eklenecekMetin2); //Eklenecek metinimizin Dosyaya eklenmesi

                      Paragraph eklenecekMetin3 = new Paragraph(radioButton3.Text);

                      pdfDosya.Add(eklenecekMetin3); //Eklenecek metinimizin Dosyaya eklenmesi

                      Paragraph eklenecekMetin4 = new Paragraph(radioButton4.Text);

                      pdfDosya.Add(eklenecekMetin4); //Eklenecek metinimizin Dosyaya eklenmesi

                      Paragraph eklenecekMetin5 = new Paragraph(radioButton5.Text);

                      pdfDosya.Add(eklenecekMetin5); //Eklenecek metinimizin Dosyaya eklenmesi

                      pdfDosya.Close();


                      /*
                      iTextSharp.text.Document pdfDosya = new iTextSharp.text.Document();

                      //PDF dosyamızı temsil edecek nesnemizi oluşturuyoruz

                      PdfWriter.GetInstance(pdfDosya, new FileStream("C:CSharpPDF.pdf", FileMode.Create));

                      //PDF dosyamızın yolu ” C:CSharpPDF.pdf” ve dosyanın açılış biçimi ‘Yeni yarat’

                      pdfDosya.Open();

                      pdfDosya.AddCreator(textBox2.Text); //Oluşturan kişinin isminin eklenmesi

                      pdfDosya.AddCreationDate();//Oluşturulma tarihinin eklenmesi

                      pdfDosya.AddAuthor(textBox3.Text); //Yazarın isiminin eklenmesi

                      pdfDosya.AddHeader(textBox4.Text, "PDF UYGULAMASI OLUSTUR");

                      pdfDosya.AddTitle(textBox5.Text); //Başlık ve title eklenmesi





                      if (textBox1.Text != "")

                      {

                          Uri yol = new Uri(textBox1.Text);

                          //Eklenecek resmimizin yolunun Uri tipinde nesne şeklinde elde edilmesi

                          iTextSharp.text.Jpeg resim = new iTextSharp.text.Jpeg(yol);

                          //resim nesnemizin Oluşturulması

                          resim.ScalePercent((int)numericUpDown3.Value);

                          //Resim nesnemizin ölçeklendirilmesi

                          pdfDosya.Add(resim); //Resim Nesnemizi Dosyaya eklenmesi

                      }



                      pdfDosya.Close();
                      */
        }
        private Bitmap Snapshot()
        {
            Bitmap Screenshot = new Bitmap(this.Width, this.Height);

            Graphics GFX = Graphics.FromImage(Screenshot);

            GFX.CopyFromScreen(this.Left + 8, this.Top, 16, 8, this.Size);
            return Screenshot;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string fater = Hour();
            string faters = Minute();
            string faterss = Second();
            string fatersss = Millisecond();

            string fate = Day();
            string fates = Month();
            int fatess = DateTime.Now.Year;


            string savefile = Settings1.Default.savefile.ToString();
            string savess = Settings1.Default.savess.ToString();
            Directory.CreateDirectory(/*@"C:\Users\CASPER\Documents\" + "Kim Milyoner Olmak İster PDF"*/ savefile + @"\Kim Milyoner Olmak İster\Screenshots");

            Snapshot().Save(savess + @"\Sorular Screenshots " + fate + fates + fatess + "0" + fater + faters + faterss + fatersss + ".png");


            MessageBox.Show("Dosyanız \n" + "Sorular Screenshots " + fate + fates + fatess + "0" + fater + faters + faterss + fatersss + ".pdf" + " \nadıyla\n\n" + savefile + @"\Kim Milyoner Olmak İster\Screenshots" + " \nkonumuna kaydedilmiştir.");
            // Snapshot().Save("C:\\Ekran_Resimleri\\program_goruntusu.jpg");

        }


        private


Bitmap Screenshot()

        {

            Bitmap
 Screenshot = new

Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            Graphics
 GFX = Graphics.FromImage(Screenshot);

            GFX.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
 Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size);

            return

Screenshot;

        }


        private void button2_Click(object sender, EventArgs e)
        {

            //var frm = Form.ActiveForm;
            //using (var bmp = new Bitmap(frm.Width, frm.Height))
            //{
            //    frm.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height));
            //    Directory.CreateDirectory(@"C:\Ekran_Resimleri");
            //    bmp.Save(@"C:\Ekran_Resimleri\ekrangoruntusu.png");
            //} 



            /*
            {

                Directory.CreateDirectory(@"C:\Ekran_Resimleri");

                Screenshot().Save(@"C:\Ekran_Resimleri\ekrangörüntüsü.jpg", ImageFormat.Jpeg);

            }
            */
        }



        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.T)
            {
                btnCevapla.PerformClick();
            }
            if (e.KeyCode == Keys.F)
            {
                btnTekrarOyna.PerformClick();
            }

            if (e.KeyCode == Keys.Escape)
            {
                btnCikis.PerformClick();
            }

            if (e.KeyCode == Keys.Q)
            {
                btnElli.PerformClick();
            }
            if (e.KeyCode == Keys.W)
            {
                btnSeyirci.PerformClick();
            }
            if (e.KeyCode == Keys.E)
            {
                btnTelefon.PerformClick();
            }
            if (e.KeyCode == Keys.R)
            {
                button3.PerformClick();
            }

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if (e.KeyCode == Keys.T)
            {
                btnCevapla.PerformClick();
            }
            if (e.KeyCode == Keys.R)
            {
                btnTekrarOyna.PerformClick();
            }
            

            if (e.KeyCode == Keys.Escape)
            {
                btnCikis.PerformClick();
            }
            */

            if (e.KeyCode == Keys.D1)
            {
                radioButton1.PerformClick();
            }
            if (e.KeyCode == Keys.D2)
            {
                radioButton2.PerformClick();
            }
            if (e.KeyCode == Keys.D3)
            {
                radioButton3.PerformClick();
            }
            if (e.KeyCode == Keys.D4)
            {
                radioButton4.PerformClick();
            }
            if (e.KeyCode == Keys.D5)
            {
                radioButton5.PerformClick();
            }

            /*
            if (e.KeyCode == Keys.Right )
            {
                button3.PerformClick();
            }
            if (e.KeyCode == Keys.Left)
            {
                button3.PerformClick();
            }
            if (e.KeyCode == Keys.Down)
            {
                button3.PerformClick();
            }
            if (e.KeyCode == Keys.Up)
            {
                button3.PerformClick();
            } */
        }






    }
}
//www.gorselprogramlama.com