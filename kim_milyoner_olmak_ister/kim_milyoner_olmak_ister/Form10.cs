using FastReport;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace kim_milyoner_olmak_ister
{
    public partial class Form10 : Form
    {
        public Form10()
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
        DataSet ds;


        void KisiListele()
        {
            baglanti = new SQLiteConnection(lyesql.sqlconnection);//"Data Source=DESKTOP-D8U9370;Initial Catalog=lyesql;Integrated Security=True");
            baglanti.Open();
            da = new SQLiteDataAdapter("Select * From TytSorular Order By Id", baglanti);
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog
            {
                //dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
                Filter = "PNG Dosyaları(*.png)|*.png|JPG Dosyaları (*.jpg)|*.jpg|Jpeg Dosyaları (*.jpeg) |*.jpeg|Bitmap Dosyaları(*.bmp)|*.bmp|Tüm Dosyalar |*.*"
            };
            dosya.ShowDialog();


            string dosyayolu = dosya.FileName;
            textBox10.Text = @"img\" + textBox2.Text + ".png";
            pictureBox1.ImageLocation = dosyayolu;
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            KisiListele();
            //textBox1.Enabled = false;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            //textBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            pictureBox1.ImageLocation = textBox10.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string sorgu = "Insert into TytSorular (Id,Soru,A,B,C,D,E,Cevap,ResimYolu) values (@Id,@Soru,@A,@B,@C,@D,@E,@Cevap,@ResimYolu)";
            SQLiteConnection baglanti1 = new SQLiteConnection(lyesql.sqlconnection);
            SQLiteCommand komut1 = new SQLiteCommand(sorgu, baglanti1);
            komut1.Parameters.AddWithValue("@Id", textBox2.Text);
            komut1.Parameters.AddWithValue("@Soru", textBox3.Text);
            komut1.Parameters.AddWithValue("@A", textBox4.Text);
            komut1.Parameters.AddWithValue("@B", textBox5.Text);
            komut1.Parameters.AddWithValue("@C", textBox6.Text);
            komut1.Parameters.AddWithValue("@D", textBox7.Text);
            komut1.Parameters.AddWithValue("@E", textBox8.Text);
            komut1.Parameters.AddWithValue("@Cevap", textBox9.Text);
            komut1.Parameters.AddWithValue("@ResimYolu", textBox10.Text);
            baglanti1.Open();
            komut1.ExecuteNonQuery();
            baglanti1.Close();
            KisiListele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "update tytSorular set soru = '" + textBox3.Text + "',a = '" + textBox4.Text + "',b = '" + textBox5.Text + "',c = '" + textBox6.Text + "',d = '" + textBox7.Text + "',e = '" + textBox8.Text + "',cevap = '" + textBox9.Text + "',resimyolu = '" + textBox10.Text + "'where Id = '" + textBox2.Text + "'";
            SQLiteConnection baglanti = new SQLiteConnection(lyesql.sqlconnection);
            SQLiteCommand komut = new SQLiteCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Id", textBox2.Text);
            komut.Parameters.AddWithValue("@soru", textBox3.Text);
            komut.Parameters.AddWithValue("@a", textBox4.Text);
            komut.Parameters.AddWithValue("@b", textBox5.Text);
            komut.Parameters.AddWithValue("@c", textBox6.Text);
            komut.Parameters.AddWithValue("@d", textBox7.Text);
            komut.Parameters.AddWithValue("@e", textBox8.Text);
            komut.Parameters.AddWithValue("@cevap", textBox9.Text);
            komut.Parameters.AddWithValue("@resimyolu", textBox10.Text);
            //komut.Parameters.AddWithValue("@Id", (dataGridView1.CurrentRow.Cells[1].Value));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisiListele();
        }

        void KayıtSil(int numara)
        {

            string sql = "Delete from tytSorular where Id=@Id";
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

            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int numara = Convert.ToInt32(drow.Cells[0].Value);
                KayıtSil(numara);
            }
            KisiListele();

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.Text = textBox1.Text;

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
            textBox2.Text = "Id";
            textBox3.Text = "Soru";
            textBox4.Text = "A)";
            textBox5.Text = "B)";
            textBox6.Text = "C)";
            textBox7.Text = "D)";
            textBox8.Text = "E)";
            textBox9.Text = "Cevap";




            //textBox3.Clear();
            //textBox4.Clear();
            //textBox5.Clear();
            //textBox6.Clear();
            //textBox7.Clear();
            //textBox8.Clear();
            //textBox9.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            string imagefile = Path.GetFileName(textBox2.Text + ".png");
            string imagepath = Path.Combine(Application.StartupPath + @"\img\" + imagefile);
            File.Copy(pictureBox1.ImageLocation, imagepath, true);
            MessageBox.Show("İşlem Başarılı! \n\nDosya İsmi : " + imagefile + "\n\nDosya Yolu : \n" + imagepath);

            /*
            string resimisim;
            resimisim = textBox10.Text;
            string path = Application.StartupPath.ToString();
            string resim = path + "\\resimler\\"+resimisim;
            */
            //var filename = $"image{DateTime.Now.ToString("yyyyMMddhhmmss")}.png";
            //pictureBox1.Image.Save(Path.Combine(@"C:\", resimisim, filename), ImageFormat.Png);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*
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
        */
        ////DateTime.Now.ToString("dd.MM.yyyy  HH.mm.ss");
        //////string fater = Hour();
        //////string faters = Minute();
        //////string faterss = Second();
        //////string fatersss = Millisecond();

        //////string fate = Day();
        //////string fates = Month();
        //////int fatess = DateTime.Now.Year;

        //////string savefile = Settings1.Default.savefile.ToString();
        //////string savepdf = Settings1.Default.savepdf.ToString();

        //////Directory.CreateDirectory(/*@"C:\Users\CASPER\Documents\" + "Kim Milyoner Olmak İster PDF"*/ savefile + @"\Kim Milyoner Olmak İster\PDF");

        //////PdfWriter.GetInstance(document, new FileStream(/*@"C:\Users\CASPER\Documents\Kim Milyoner Olmak İster PDF\"*/ savepdf + @"\Sorular PDF " + fate + fates + fatess + "0" + fater + faters + faterss + fatersss + ".pdf", FileMode.Create));


        private void button10_Click(object sender, EventArgs e)
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

                foreach (DataGridViewColumn column in dataGridView1.SelectedColumns)
                {
                    //PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    //cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240); // hücre arka plan rengi
                    //pdfTable.AddCell(cell);
                    //document.Add(img);
                    //document.Add(new Paragraph(c));
                    //document.Open();
                }
                try
                {
                    document.Open();
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        //string resimyolu1 = Convert.ToString(row.Cells[9].Value);
                        //document.Add(new Paragraph(c));
                        string resimyolu = "";
                        //resimyolu = Application.StartupPath + @"\" + dataGridView1.CurrentRow.Cells[9].Value.ToString();
                        resimyolu = Application.StartupPath + @"\" + row.Cells[8].Value.ToString();
                        iTextSharp.text.Image img = null;
                        img = iTextSharp.text.Image.GetInstance(resimyolu);
                        img.ScaleToFit(140f, 120f);
                        //document.Add(img);
                        //c.Append("\n");
                        //byte [] imageByte = (byte[])row.Cells[9].Value;
                        //iTextSharp.text.Image myImage = iTextSharp.text.Image.GetInstance(imageByte);

                        //document.Add(myImage);

                        //c.Append(Convert.ToString(row.Cells[9].Value) + "\n");

                        string metin = Convert.ToString(row.Cells[1].Value) + "\n" + Convert.ToString(row.Cells[2].Value) + "\n" + Convert.ToString(row.Cells[3].Value) + "\n" + Convert.ToString(row.Cells[4].Value) + "\n" + Convert.ToString(row.Cells[5].Value) + "\n" + Convert.ToString(row.Cells[6].Value) + "\n\n\n";
                        Paragraph paragraph = new Paragraph(metin, f);
                        document.Add(img);
                        document.Add(new Paragraph("\n"));
                        document.Add(paragraph);


                        //c.Append(Convert.ToString(row.Cells[3].Value) + "\n");
                        //c.Append(Convert.ToString(row.Cells[4].Value) + "\n");
                        //c.Append(Convert.ToString(row.Cells[5].Value) + "\n");
                        //c.Append(Convert.ToString(row.Cells[6].Value) + "\n");
                        //c.Append(Convert.ToString(row.Cells[7].Value) + "\n\n\n");

                        //c.Append(Convert.ToString(row.Cells[9].Value));





                        //Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(1.0F, 100.0F, new BaseColor(0, 0, 0), Element.ALIGN_CENTER, -60)));

                        //document.Add(line);




                        //foreach (DataGridViewCell cell in row.Cells)
                        //{

                        //    document.Open();
                        //    c.Append(dataGridView1.CurrentRow.Cells[0].Value.ToString()); Z
                        //    document.Add(img);
                        //    c.Append(cell.Value.ToString() + "\n\n");


                        //}
                        //document.Add(new Paragraph(c));
                        //c.Append(Convert.ToString(row.Cells[0].Value);
                    }
                    document.Add(new Paragraph(c));

                    //document.Add(img);

                    document.Close();
                }
                catch (NullReferenceException)
                {
                }
            }
        }

        public static void PDF_Disa_Aktar1(DataGridView dataGridView1)
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
                PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);

                // Bu alanlarla oynarak tasarımı iyileştirebilirsiniz.
                pdfTable.DefaultCell.Padding = 3; // hücre duvarı ve veri arasında mesafe
                pdfTable.WidthPercentage = 80; // hücre genişliği
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT; // yazı hizalaması
                pdfTable.DefaultCell.BorderWidth = 1; // kenarlık kalınlığı
                // Bu alanlarla oynarak tasarımı iyileştirebilirsiniz.

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText))
                    {
                        BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240) // hücre arka plan rengi
                    };
                    pdfTable.AddCell(cell);
                }
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.ColumnIndex == 8)
                            {
                                if (cell.Value != null)
                                {
                                    string resimyolu = "";
                                    resimyolu = Application.StartupPath + @"\" + cell.Value.ToString();
                                    iTextSharp.text.Image img = null;
                                    img = iTextSharp.text.Image.GetInstance(resimyolu);
                                    img.ScaleToFit(100f, 80f);
                                    pdfTable.AddCell(img);
                                }
                            }
                            else
                            {
                                if (cell.Value != null)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }

                            }

                        }
                    }
                }
                catch (NullReferenceException)
                {
                }
                using (FileStream stream = new FileStream(save.FileName + ".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);// sayfa boyutu.
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            PDF_Disa_Aktar1(dataGridView1);
        }


        private void button11_Click(object sender, EventArgs e)
        {
            using (Report report = new Report())
            {
                report.Load(Application.StartupPath + "\\deneme.frx");//program içerisinde raporadi.frx raporunu gösterdik                        
                //report.SetParameterValue("YIL", cboxYil.SelectedItem.ToString());
                //report.SetParameterValue("Id", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                report.Design();
            }
        }
        private void CreateDataSet()
        {
            ds = new DataSet();
            DataTable table = new DataTable();
            table.TableName = "ABCD";
            ds.Tables.Add(table);
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    table.Columns.Add(dataGridView1.Columns[i].HeaderText);
                }
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    table.Rows.Add(dataGridView1.Rows[j].Cells[0].FormattedValue.ToString(), dataGridView1.Rows[j].Cells[1].FormattedValue.ToString(), dataGridView1.Rows[j].Cells[2].FormattedValue.ToString(), dataGridView1.Rows[j].Cells[0].FormattedValue.ToString(), dataGridView1.Rows[j].Cells[4].FormattedValue.ToString(), dataGridView1.Rows[j].Cells[5].FormattedValue.ToString());
                }
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            using (Report report = new Report())
            {
                report.Load(Application.StartupPath + "\\deneme.frx");
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn cl in dataGridView1.Columns)
                {
                    dt.Columns.Add();
                }

                object[] clvl = new object[dataGridView1.Columns.Count];
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    { clvl[i] = row.Cells[i].Value; }
                    dt.Rows.Add(clvl);
                }
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                report.Dictionary.RegisterData(ds.Tables[0], "test", true);


                //report.SetParameterValue("date", dateTimePicker1.Value.ToString("dd.MM.yyyy"));
                report.SetParameterValue("date", DateTime.Now.ToString("yyyy.MM.dd HH.mm.ss"));
                report.Show();
            }



            /*
            using (Report report = new Report())
            {
                report.Load(Application.StartupPath + "\\deneme.frx");//program içerisinde raporadi.frx raporunu gösterdik                        
                //report.SetParameterValue("YIL", cboxYil.SelectedItem.ToString());
                //report.SetParameterValue("TARIH2", dateEditBitis.Text);
                report.RegisterData(dataGridView1.CurrentRow.Cells, "dataset");
                report.Show();
            }
            */
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            //textBox2.ForeColor = Color.Black;
            if (textBox2.Text == "Id")
            {
                textBox2.Text = "";
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Id";
                //textBox8.ForeColor = Color.DarkGray;

            }
        }



        private void textBox3_Enter(object sender, EventArgs e)
        {
            //textBox3.ForeColor = Color.White;
            if (textBox3.Text == "Soru")
            {
                textBox3.Text = "";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Soru";
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "A) ")
            {
                //textBox4.Text = "";
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "A) ";
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "B) ")
            {
                //textBox5.Text = "";
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "B) ";
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "C) ")
            {
                //textBox6.Text = "";
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "C) ";
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "D) ")
            {
                //textBox7.Text = "";
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "D) ";
            }
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            //textBox8.ForeColor = Color.Black;
            if (textBox8.Text == "E) ")
            {
                //textBox8.Text = "";
            }
        }
        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "E) ";
                //textBox8.ForeColor = Color.DarkGray;
            }
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Cevap")
            {
                textBox9.Text = "";
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "Cevap";
            }
        }

        private void Form10_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.D)
            //{
            //    button2.PerformClick();
            //}
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

