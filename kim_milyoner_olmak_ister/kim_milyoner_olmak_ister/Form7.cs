using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace kim_milyoner_olmak_ister
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        //OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=Yeni Microsoft Access Veritabanı.accdb");



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

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Form8());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form15());
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Form10());
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
            openChildForm(new Form6());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form11());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form12());
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form14());
        }

        private void Form7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //button1.PerformClick();
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form11());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new Form12());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label1.Text = Settings1.Default.Unvan.ToString() + " => " + Settings1.Default.AdSoyad.ToString();
            string admin = Settings1.Default.Unvan.ToString();
            if (admin != "Kurucu" && admin != "AİÇ")
            {
                button7.Visible = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form12 frm12 = new Form12();
            frm12.ShowDialog();
        }
    }
}