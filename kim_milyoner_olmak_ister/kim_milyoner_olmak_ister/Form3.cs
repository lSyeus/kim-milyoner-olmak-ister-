using System;
using System.Data.OleDb;
using System.Drawing;//www.gorselprogramlama.com
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=Yeni Microsoft Access Veritabanı.accdb");
        public OleDbCommand kmt = new OleDbCommand();
        int[] sayilar = new int[13];
        int[] secenekSayilar = new int[2];
        Random r = new Random();
        int randomSayac = 0, soruSayac = 1, kazanilanPara = 0, uretilmeyecekSayi = 0;
        string dogruCevap, yarismaciCevap, resimyolu;

        void radioButonlarıGoster()//www.gorselprogramlama.com
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
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
            while (randomSayac < 13)
            {
                rastgele = r.Next(1, 17);//1 ile 50 arasında rastgele sayı üretiliyor
                if (Array.IndexOf(sayilar, rastgele) == -1) //dizinin içinde aynı sayı yoksa 
                {
                    sayilar[randomSayac] = rastgele;
                    randomSayac++;
                }//www.gorselprogramlama.com
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
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select  * from sorular where soruId=" + sayilar[a];
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                label13.Text = oku[2].ToString();//www.gorselprogramlama.com
                radioButton1.Text = oku[3].ToString();
                radioButton2.Text = oku[4].ToString();
                radioButton3.Text = oku[5].ToString();
                radioButton4.Text = oku[6].ToString();
                radioButton5.Text = oku[8].ToString();
                dogruCevap = oku[7].ToString();
                resimyolu = oku[9].ToString();
            }
            oku.Dispose();
            bag.Close();
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
            labelRenklendir(soruSayac);
            rastgeleSayi();
            soruAl(soruSayac);
            timer1.Enabled = true;//www.gorselprogramlama.com

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

        public SoundPlayer dogru = new SoundPlayer();
        public SoundPlayer yanlis = new SoundPlayer();

        private void btnCevapla_Click(object sender, EventArgs e)
        {

            if (soruSayac < 13)
            {
                DialogResult cevap, cevap2, cevap3;
                cevap = MessageBox.Show("Son Kararın Mı ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
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
                        string path = "dogru.wav";
                        dogru.SoundLocation = path;
                        dogru.Play();
                        if (soruSayac == 12)
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
                        string path = "yanlis.wav";
                        yanlis.SoundLocation = path;
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
            }//www.gorselprogramlama.com
            else
            {
                //if (soruSayac <= 2) label14.Text = "Süre Doldu. 0 TL Kazandınız ...";
                //if (soruSayac > 2 && soruSayac < 7) label14.Text = "Süre Doldu. 1000 TL Kazandınız ...";
                //if (soruSayac >= 7) label14.Text = "Süre Doldu. 15.000 TL Kazandınız ...";
                timer1.Enabled = false;
                btnCevapla.Visible = false;
                btnTekrarOyna.Visible = true;

            }
        }


        private void btnTekrarOyna_Click(object sender, EventArgs e)
        {
            DialogResult tekraroyna = MessageBox.Show("Yarışmaya tekrar başlamayı onaylıyor musunuz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (tekraroyna == DialogResult.Yes)
            {
                Array.Clear(secenekSayilar, 0, 2);
                btnCevapla.Visible = true;
                btnTekrarOyna.Visible = true;
                soruSayac = 1;
                labelRenkSifirla();
                labelRenklendir(soruSayac);
                rastgeleSayi();
                soruAl(soruSayac);
                timer1.Enabled = true;
                btnCevapla.Enabled = true;
                radioButonlarıSecme();
                radioButonlarıGoster();
                btnElli.Visible = true;
                btnSeyirci.Visible = true;
                btnTelefon.Visible = true;           //www.gorselprogramlama.com
                dak = 60;
                //label14.Text = "";
            }
            else if (tekraroyna == DialogResult.No)
            {

            }


        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

            /*
                        protected override void OnResize(EventArgs e)
                    {
                        base.OnResize(e);
                    }

                        base.OnResize(e);
                        GraphicsPath gp = new GraphicsPath();
                        gp.AddEllipse(new System.Drawing.Rectangle(new System.Drawing.Point(), this.Size));
                        this.Region = new System.Drawing.Region(gp);
            */
            // Application.Exit();
            DialogResult cikis = MessageBox.Show("Programdan çıkmak istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (cikis == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else if (cikis == DialogResult.No)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                MessageBox.Show("Aiç'in Vermiş Olduğu Cevap -- " + dogruCevap + " -- seçeneğidir.", "Aiç'in Cevabı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSeyirci.Visible = false;
                timer1.Start();
                //SendKeys.Send(dogruCevap);
            }
            else if (seyirci == DialogResult.No)
            {
                timer1.Start();
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        /*
        private void label14_Click(object sender, EventArgs e)
        {

        }
        */

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }



        //33333 = ("jokerleri düzenle seyirci yerine aiç jokeri ekle    çift  cevap joker hakkı ekle. 
        // "ilk soruda elenenler instagram memesi olsun. 1M kazanana arda çıksın")
        private void btnTelefon_Click(object sender, EventArgs e)
        {

            timer1.Stop();
            DialogResult telefon = MessageBox.Show("Halil'e sorma jokerini kullanmak istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (telefon == DialogResult.Yes)
            {
                string path = "beeeeeee.wav";
                yanlis.SoundLocation = path;
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

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Ana Menüye dönmek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (cikis == DialogResult.Yes)
            {
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
            else if (cikis == DialogResult.No)
            {

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }



        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
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