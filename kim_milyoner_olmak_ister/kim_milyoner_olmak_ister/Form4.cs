using System;
using System.Windows.Forms;

namespace kim_milyoner_olmak_ister
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnOyunaBasla_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {//www.gorselprogramlama.com
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

        private void btnHakkinda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visual C#'ta Access veri tabanı kullanılarak hazırlanmıştır.", "Program Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Settings1.Default.savefile.ToString();
            label2.Text = Settings1.Default.savepdf.ToString();
            label3.Text = Settings1.Default.savess.ToString();
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


        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form10());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form11());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form12());
        }

        private void button2_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog
            {
                Description = "Dosyayı Nereye Kaydetmek İstersiniz",
                RootFolder = Environment.SpecialFolder.Desktop,
                SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                label1.Text = dialog.SelectedPath;
            }

            Settings1.Default.savefile = label1.Text;
            label2.Text = label1.Text + @"\Kim Milyoner Olmak İster\PDF";
            label3.Text = label1.Text + @"\Kim Milyoner Olmak İster\Screenshots";

            Settings1.Default.savepdf = label2.Text;
            Settings1.Default.savess = label3.Text;
            Settings1.Default.Save();

            //label1.Text = Settings1.Default.savefile.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Form15());
        }
    }
}
