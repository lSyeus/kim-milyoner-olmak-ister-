using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;


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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        public SQLiteConnection bag = new SQLiteConnection(lyesql.sqlconnection);
        public SQLiteCommand kmt = new SQLiteCommand();
        int[] sayilar = new int[8];
        int[] secenekSayilar = new int[2];
        Random r = new Random();
        int randomSayac = 0, soruSayac = 1, uretilmeyecekSayi = 0;
        string dogruCevap, resimyolu;


        public SoundPlayer dogru = new SoundPlayer();
        public SoundPlayer yanlis = new SoundPlayer();
        public SoundPlayer milyon = new SoundPlayer();
        string dogruyolu = Application.StartupPath + @"\sounds\dogru.wav";
        string yanlisyolu = Application.StartupPath + @"\sounds\yanlis.wav";
        string milyonyolu = Application.StartupPath + @"\sounds\milyon.wav";

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


        void rastgeleSayi3()
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



        void rastgeleSayi4()
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


        void rastgeleSayi5()
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

        void rastgeleSayi6()
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

        void rastgeleSayi7()
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

        void rastgeleSayi8()
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
                    //randomSayac++;
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
                    label8.Text = oku[8].ToString();
                }
                pictureBox1.Image = System.Drawing.Image.FromFile(resimyolu);
                pictureBox1.ImageLocation = resimyolu;
                oku.Dispose();
                bag.Close();
            }
            catch
            {
                //MessageBox.Show("Bir Sorunla Karşılaşıldı. Programı Yeniden Başlatmayı deneyebilir hala sorunun devam etmesi durumunda Lyeus ile iletişime geçebilirsiniz.", "Uyarı");
                MessageBox.Show("Bir Sorunla Karşılaşıldı. Muhtemel olarak sorunun sebebi seçilen soru aralğından kaynaklanmaktadır. Görüntülenmesini istediğiniz soru aralığınında problem olmadığından emin olun. Problem olmadığını düşünüyorsanız programı yeniden başlatmayı deneyin. Problem devam ettiği taktirde Lyeus ile iletişime geçin.", "Uyarı");
            }

        }
        void SoruAl2(int b)
        {
            try
            {
                bag.Open();
                kmt.Connection = bag;
                kmt.CommandText = "Select  * from tytSorular where Id=" + sayilar[b];
                SQLiteDataReader oku;
                oku = kmt.ExecuteReader();
                while (oku.Read())
                {
                    label1.Text = oku[1].ToString();//www.gorselprogramlama.com
                    radioButton10.Text = oku[2].ToString();
                    radioButton9.Text = oku[3].ToString();
                    radioButton8.Text = oku[4].ToString();
                    radioButton7.Text = oku[5].ToString();
                    radioButton6.Text = oku[6].ToString();
                    //dogruCevap = oku[7].ToString();
                    resimyolu = oku[8].ToString();
                    label9.Text = oku[8].ToString();
                }
                pictureBox2.Image = System.Drawing.Image.FromFile(resimyolu);
                pictureBox2.ImageLocation = resimyolu;
                oku.Dispose();
                bag.Close();
            }
            catch
            {
                //MessageBox.Show("Bir Sorunla Karşılaşıldı. Programı Yeniden Başlatmayı deneyebilir hala sorunun devam etmesi durumunda Lyeus ile iletişime geçebilirsiniz.", "Uyarı");
                MessageBox.Show("Bir Sorunla Karşılaşıldı. Muhtemel olarak sorunun sebebi seçilen soru aralğından kaynaklanmaktadır. Görüntülenmesini istediğiniz soru aralığınında problem olmadığından emin olun. Problem olmadığını düşünüyorsanız programı yeniden başlatmayı deneyin. Problem devam ettiği taktirde Lyeus ile iletişime geçin.", "Uyarı");
            }
        }
        void SoruAl3(int c)
        {

            try
            {
                bag.Open();
                kmt.Connection = bag;
                kmt.CommandText = "Select  * from tytSorular where Id=" + sayilar[c];
                SQLiteDataReader oku;
                oku = kmt.ExecuteReader();
                while (oku.Read())
                {
                    label2.Text = oku[1].ToString();//www.gorselprogramlama.com
                    radioButton15.Text = oku[2].ToString();
                    radioButton14.Text = oku[3].ToString();
                    radioButton13.Text = oku[4].ToString();
                    radioButton12.Text = oku[5].ToString();
                    radioButton11.Text = oku[6].ToString();
                    //dogruCevap = oku[7].ToString();
                    resimyolu = oku[8].ToString();
                    label10.Text = oku[8].ToString();
                }
                pictureBox3.Image = System.Drawing.Image.FromFile(resimyolu);
                pictureBox3.ImageLocation = resimyolu;
                oku.Dispose();
                bag.Close();
            }
            catch
            {
                //MessageBox.Show("Bir Sorunla Karşılaşıldı. Programı Yeniden Başlatmayı deneyebilir hala sorunun devam etmesi durumunda Lyeus ile iletişime geçebilirsiniz.", "Uyarı");
                MessageBox.Show("Bir Sorunla Karşılaşıldı. Muhtemel olarak sorunun sebebi seçilen soru aralğından kaynaklanmaktadır. Görüntülenmesini istediğiniz soru aralığınında problem olmadığından emin olun. Problem olmadığını düşünüyorsanız programı yeniden başlatmayı deneyin. Problem devam ettiği taktirde Lyeus ile iletişime geçin.", "Uyarı");
            }
        }

        void SoruAl4(int d)
        {

            try
            {
                bag.Open();
                kmt.Connection = bag;
                kmt.CommandText = "Select  * from tytSorular where Id=" + sayilar[d];
                SQLiteDataReader oku;
                oku = kmt.ExecuteReader();
                while (oku.Read())
                {
                    label3.Text = oku[1].ToString();//www.gorselprogramlama.com
                    radioButton20.Text = oku[2].ToString();
                    radioButton19.Text = oku[3].ToString();
                    radioButton18.Text = oku[4].ToString();
                    radioButton17.Text = oku[5].ToString();
                    radioButton16.Text = oku[6].ToString();
                    //dogruCevap = oku[7].ToString();
                    resimyolu = oku[8].ToString();
                    label11.Text = oku[8].ToString();
                }
                pictureBox4.Image = System.Drawing.Image.FromFile(resimyolu);
                pictureBox4.ImageLocation = resimyolu;
                oku.Dispose();
                bag.Close();
            }
            catch
            {
                //MessageBox.Show("Bir Sorunla Karşılaşıldı. Programı Yeniden Başlatmayı deneyebilir hala sorunun devam etmesi durumunda Lyeus ile iletişime geçebilirsiniz.", "Uyarı");
                MessageBox.Show("Bir Sorunla Karşılaşıldı. Muhtemel olarak sorunun sebebi seçilen soru aralğından kaynaklanmaktadır. Görüntülenmesini istediğiniz soru aralığınında problem olmadığından emin olun. Problem olmadığını düşünüyorsanız programı yeniden başlatmayı deneyin. Problem devam ettiği taktirde Lyeus ile iletişime geçin.", "Uyarı");
            }
        }


        void SoruAl5(int e)
        {
            try
            {
                bag.Open();
                kmt.Connection = bag;
                kmt.CommandText = "Select  * from tytSorular where Id=" + sayilar[e];
                SQLiteDataReader oku;
                oku = kmt.ExecuteReader();
                while (oku.Read())
                {
                    label4.Text = oku[1].ToString();//www.gorselprogramlama.com
                    radioButton25.Text = oku[2].ToString();
                    radioButton24.Text = oku[3].ToString();
                    radioButton23.Text = oku[4].ToString();
                    radioButton22.Text = oku[5].ToString();
                    radioButton21.Text = oku[6].ToString();
                    //dogruCevap = oku[7].ToString();
                    resimyolu = oku[8].ToString();
                    label12.Text = oku[8].ToString();
                }
                pictureBox5.Image = System.Drawing.Image.FromFile(resimyolu);
                pictureBox5.ImageLocation = resimyolu;
                oku.Dispose();
                bag.Close();
            }
            catch
            {
                //MessageBox.Show("Bir Sorunla Karşılaşıldı. Programı Yeniden Başlatmayı deneyebilir hala sorunun devam etmesi durumunda Lyeus ile iletişime geçebilirsiniz.", "Uyarı");
                MessageBox.Show("Bir Sorunla Karşılaşıldı. Muhtemel olarak sorunun sebebi seçilen soru aralğından kaynaklanmaktadır. Görüntülenmesini istediğiniz soru aralığınında problem olmadığından emin olun. Problem olmadığını düşünüyorsanız programı yeniden başlatmayı deneyin. Problem devam ettiği taktirde Lyeus ile iletişime geçin.", "Uyarı");
            }
        }

        void SoruAl6(int f)
        {
            try
            {
                bag.Open();
                kmt.Connection = bag;
                kmt.CommandText = "Select  * from tytSorular where Id=" + sayilar[f];
                SQLiteDataReader oku;
                oku = kmt.ExecuteReader();
                while (oku.Read())
                {
                    label5.Text = oku[1].ToString();//www.gorselprogramlama.com
                    radioButton30.Text = oku[2].ToString();
                    radioButton29.Text = oku[3].ToString();
                    radioButton28.Text = oku[4].ToString();
                    radioButton27.Text = oku[5].ToString();
                    radioButton26.Text = oku[6].ToString();
                    //dogruCevap = oku[7].ToString();
                    resimyolu = oku[8].ToString();
                    label15.Text = oku[8].ToString();
                }
                pictureBox6.Image = System.Drawing.Image.FromFile(resimyolu);
                pictureBox6.ImageLocation = resimyolu;
                oku.Dispose();
                bag.Close();
            }
            catch
            {
                //MessageBox.Show("Bir Sorunla Karşılaşıldı. Programı Yeniden Başlatmayı deneyebilir hala sorunun devam etmesi durumunda Lyeus ile iletişime geçebilirsiniz.", "Uyarı");
                MessageBox.Show("Bir Sorunla Karşılaşıldı. Muhtemel olarak sorunun sebebi seçilen soru aralğından kaynaklanmaktadır. Görüntülenmesini istediğiniz soru aralığınında problem olmadığından emin olun. Problem olmadığını düşünüyorsanız programı yeniden başlatmayı deneyin. Problem devam ettiği taktirde Lyeus ile iletişime geçin.", "Uyarı");
            }

        }

        void SoruAl7(int g)
        {
            try
            {
                bag.Open();
                kmt.Connection = bag;
                kmt.CommandText = "Select  * from tytSorular where Id=" + sayilar[g];
                SQLiteDataReader oku;
                oku = kmt.ExecuteReader();
                while (oku.Read())
                {
                    label6.Text = oku[1].ToString();//www.gorselprogramlama.com
                    radioButton35.Text = oku[2].ToString();
                    radioButton34.Text = oku[3].ToString();
                    radioButton33.Text = oku[4].ToString();
                    radioButton32.Text = oku[5].ToString();
                    radioButton31.Text = oku[6].ToString();
                    //dogruCevap = oku[7].ToString();
                    resimyolu = oku[8].ToString();
                    label20.Text = oku[8].ToString();
                }
                pictureBox7.Image = System.Drawing.Image.FromFile(resimyolu);
                pictureBox7.ImageLocation = resimyolu;
                oku.Dispose();
                bag.Close();
            }
            catch
            {
                //MessageBox.Show("Bir Sorunla Karşılaşıldı. Programı Yeniden Başlatmayı deneyebilir hala sorunun devam etmesi durumunda Lyeus ile iletişime geçebilirsiniz.", "Uyarı");
                MessageBox.Show("Bir Sorunla Karşılaşıldı. Muhtemel olarak sorunun sebebi seçilen soru aralğından kaynaklanmaktadır. Görüntülenmesini istediğiniz soru aralığınında problem olmadığından emin olun. Problem olmadığını düşünüyorsanız programı yeniden başlatmayı deneyin. Problem devam ettiği taktirde Lyeus ile iletişime geçin.", "Uyarı");
            }

        }


        private void btnCevapla_Click(object sender, EventArgs e)
        {
            rastgeleSayi();
            soruAl(soruSayac);
            rastgeleSayi2();
            SoruAl2(soruSayac);
            rastgeleSayi3();
            SoruAl3(soruSayac);
            rastgeleSayi4();
            SoruAl4(soruSayac);
            rastgeleSayi5();
            SoruAl5(soruSayac);
            rastgeleSayi6();
            SoruAl6(soruSayac);
            rastgeleSayi7();
            SoruAl7(soruSayac);
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            //labelRenklendir(soruSayac);
            rastgeleSayi();
            soruAl(soruSayac);

            rastgeleSayi2();
            SoruAl2(soruSayac);

            rastgeleSayi3();
            SoruAl3(soruSayac);

            rastgeleSayi4();
            SoruAl4(soruSayac);

            rastgeleSayi5();
            SoruAl5(soruSayac);

            rastgeleSayi5();
            SoruAl5(soruSayac);

            rastgeleSayi6();
            SoruAl6(soruSayac);

            rastgeleSayi7();
            SoruAl7(soruSayac);


            //timer1.Enabled = true;
            //btnCevapla.Enabled = false;
            //button3.Enabled = false;
            //pictureBox1.ImageLocation = resimyolu;



            //pictureBox1.Image = System.Drawing.Image.FromFile(resimyolu);
        }

        /*
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

     
        */

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = System.Drawing.Image.FromFile(resimyolu);
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

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Form7());
            /*
            DialogResult cikis = MessageBox.Show("Geriye dönmek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (cikis == DialogResult.Yes)
            {
                openChildForm(new Form7());
                /*
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
                milyon.Stop();
                */
            /*}
            else if (cikis == DialogResult.No)
            {

            }
            */
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

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog
            {
                OverwritePrompt = false,
                Title = "PDF Dosyaları",
                DefaultExt = "pdf",
                Filter = "PDF Dosyaları (*.pdf)|*.pdf|Tüm Dosyalar(*.*)|*.*"
            };
            if (save.ShowDialog() == DialogResult.OK)
            {

                //iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);
                //iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 12, iTextSharp.text.Font.NORMAL);

                BaseFont bF = BaseFont.CreateFont("C:\\windows\\fonts\\arial.ttf", "windows-1254", true);
                iTextSharp.text.Font f = new iTextSharp.text.Font(bF, 12f, iTextSharp.text.Font.NORMAL);
                Chunk c = new Chunk
                {
                    Font = f
                };
                Document document = new Document();
                //    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Application.StartupPath + @"\" + resimyolu);


                //string resimyolu = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                //iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Application.StartupPath + @"\" + resimyolu);


                PdfWriter.GetInstance(document, new FileStream(save.FileName + ".pdf", FileMode.Create));


                document.Open();
                iTextSharp.text.Image img = null;
                img = iTextSharp.text.Image.GetInstance(Application.StartupPath + @"\" + label8.Text);
                img.ScaleToFit(140f, 120f);
                string metin = label13.Text + "\n" + radioButton1.Text + "\n" + radioButton2.Text + "\n" + radioButton3.Text + "\n" + radioButton4.Text + "\n" + radioButton5.Text + "\n\n\n";
                Paragraph paragraph = new Paragraph(metin, f);
                document.Add(img);
                document.Add(new Paragraph("\n"));
                document.Add(paragraph);



                iTextSharp.text.Image img2 = null;
                img2 = iTextSharp.text.Image.GetInstance(Application.StartupPath + @"\" + label9.Text);
                img2.ScaleToFit(140f, 120f);
                string metin2 = label1.Text + "\n" + radioButton10.Text + "\n" + radioButton9.Text + "\n" + radioButton8.Text + "\n" + radioButton7.Text + "\n" + radioButton6.Text + "\n\n\n";
                Paragraph paragraph2 = new Paragraph(metin2, f);
                document.Add(img2);
                document.Add(new Paragraph("\n"));
                document.Add(paragraph2);



                iTextSharp.text.Image img3 = null;
                img3 = iTextSharp.text.Image.GetInstance(Application.StartupPath + @"\" + label10.Text);
                img3.ScaleToFit(140f, 120f);
                string metin3 = label2.Text + "\n" + radioButton15.Text + "\n" + radioButton14.Text + "\n" + radioButton13.Text + "\n" + radioButton12.Text + "\n" + radioButton11.Text + "\n\n\n";
                Paragraph paragraph3 = new Paragraph(metin3, f);
                document.Add(img3);
                document.Add(new Paragraph("\n"));
                document.Add(paragraph3);


                iTextSharp.text.Image img4 = null;
                img4 = iTextSharp.text.Image.GetInstance(Application.StartupPath + @"\" + label11.Text);
                img4.ScaleToFit(140f, 120f);
                string metin4 = label2.Text + "\n" + radioButton20.Text + "\n" + radioButton19.Text + "\n" + radioButton18.Text + "\n" + radioButton17.Text + "\n" + radioButton16.Text + "\n\n\n";
                Paragraph paragraph4 = new Paragraph(metin4, f);
                document.Add(img4);
                document.Add(new Paragraph("\n"));
                document.Add(paragraph4);


                iTextSharp.text.Image img5 = null;
                img5 = iTextSharp.text.Image.GetInstance(Application.StartupPath + @"\" + label12.Text);
                img5.ScaleToFit(140f, 120f);
                string metin5 = label3.Text + "\n" + radioButton25.Text + "\n" + radioButton24.Text + "\n" + radioButton23.Text + "\n" + radioButton22.Text + "\n" + radioButton21.Text + "\n\n\n";
                Paragraph paragraph5 = new Paragraph(metin5, f);
                document.Add(img5);
                document.Add(new Paragraph("\n"));
                document.Add(paragraph3);


                iTextSharp.text.Image img6 = null;
                img6 = iTextSharp.text.Image.GetInstance(Application.StartupPath + @"\" + label15.Text);
                img6.ScaleToFit(140f, 120f);
                string metin6 = label4.Text + "\n" + radioButton30.Text + "\n" + radioButton29.Text + "\n" + radioButton28.Text + "\n" + radioButton27.Text + "\n" + radioButton26.Text + "\n\n\n";
                Paragraph paragraph6 = new Paragraph(metin6, f);
                document.Add(img6);
                document.Add(new Paragraph("\n"));
                document.Add(paragraph3);


                iTextSharp.text.Image img7 = null;
                img7 = iTextSharp.text.Image.GetInstance(Application.StartupPath + @"\" + label20.Text);
                img7.ScaleToFit(140f, 120f);
                string metin7 = label5.Text + "\n" + radioButton35.Text + "\n" + radioButton34.Text + "\n" + radioButton33.Text + "\n" + radioButton32.Text + "\n" + radioButton31.Text + "\n\n\n";
                Paragraph paragraph7 = new Paragraph(metin7, f);
                document.Add(img7);
                document.Add(new Paragraph("\n"));
                document.Add(paragraph7);


                document.Add(new Paragraph(c));
                document.Close();


            }
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


            iTextSharp.text.Document pdfDosya = new iTextSharp.text.Document();

            PdfWriter.GetInstance(pdfDosya, new FileStream("C:\\CSharpPDF" + ".pdf", FileMode.Create));
            pdfDosya.Open();

            /*
            iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);

            iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 12, iTextSharp.text.Font.NORMAL);
            */




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
            //timer1.Enabled = true;
            //dak = 1;

            var frm = Form.ActiveForm;
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height));
                Directory.CreateDirectory(@"C:\Ekran_Resimleri");
                bmp.Save(@"C:\Ekran_Resimleri\ekrangoruntusu.png");
            } /*
            {

                Directory.CreateDirectory(@"C:\Ekran_Resimleri");

                Screenshot().Save(@"C:\Ekran_Resimleri\ekrangörüntüsü.jpg", ImageFormat.Jpeg);

            }
            */
        }


        /*
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
        /*
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

//www.gorselprogramlama.com