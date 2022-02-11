using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;//www.gorselprogramlama.com
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace kim_milyoner_olmak_ister
{

    partial class Form14
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnCevapla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.radioButton19 = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton21 = new System.Windows.Forms.RadioButton();
            this.radioButton22 = new System.Windows.Forms.RadioButton();
            this.radioButton23 = new System.Windows.Forms.RadioButton();
            this.radioButton24 = new System.Windows.Forms.RadioButton();
            this.radioButton25 = new System.Windows.Forms.RadioButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton26 = new System.Windows.Forms.RadioButton();
            this.radioButton27 = new System.Windows.Forms.RadioButton();
            this.radioButton28 = new System.Windows.Forms.RadioButton();
            this.radioButton29 = new System.Windows.Forms.RadioButton();
            this.radioButton30 = new System.Windows.Forms.RadioButton();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton31 = new System.Windows.Forms.RadioButton();
            this.radioButton32 = new System.Windows.Forms.RadioButton();
            this.radioButton33 = new System.Windows.Forms.RadioButton();
            this.radioButton34 = new System.Windows.Forms.RadioButton();
            this.radioButton35 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton1.FlatAppearance.BorderSize = 0;
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(22, 187);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(139, 39);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton2.FlatAppearance.BorderSize = 0;
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(22, 224);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(139, 39);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton3.FlatAppearance.BorderSize = 0;
            this.radioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(22, 261);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(139, 39);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            this.radioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton4.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton4.FlatAppearance.BorderSize = 0;
            this.radioButton4.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton4.ForeColor = System.Drawing.Color.White;
            this.radioButton4.Location = new System.Drawing.Point(22, 299);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(139, 39);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            this.radioButton5.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton5.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton5.FlatAppearance.BorderSize = 0;
            this.radioButton5.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton5.ForeColor = System.Drawing.Color.White;
            this.radioButton5.Location = new System.Drawing.Point(22, 337);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(139, 39);
            this.radioButton5.TabIndex = 9;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "0-Percent-icon.png");
            this.ımageList1.Images.SetKeyName(1, "audience-icon.png");
            this.ımageList1.Images.SetKeyName(2, "phone-icon.png");
            this.ımageList1.Images.SetKeyName(3, "delete.png");
            this.ımageList1.Images.SetKeyName(4, "mail_reply_sender.png");
            this.ımageList1.Images.SetKeyName(5, "stock_repeat.png");
            this.ımageList1.Images.SetKeyName(6, "answer.png");
            this.ımageList1.Images.SetKeyName(7, "redo.png");
            this.ımageList1.Images.SetKeyName(8, "50-percent.png");
            this.ımageList1.Images.SetKeyName(9, "spectator.png");
            this.ımageList1.Images.SetKeyName(10, "phone.png");
            this.ımageList1.Images.SetKeyName(11, "exit (2).png");
            this.ımageList1.Images.SetKeyName(12, "log-out.png");
            this.ımageList1.Images.SetKeyName(13, "left-arrow.png");
            this.ımageList1.Images.SetKeyName(14, "random (1).png");
            this.ımageList1.Images.SetKeyName(15, "random.png");
            this.ımageList1.Images.SetKeyName(16, "printer.png");
            this.ımageList1.Images.SetKeyName(17, "random (2).png");
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(22, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 39);
            this.label13.TabIndex = 9;
            this.label13.Text = "label13";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(19, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 29;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.BlueViolet;
            this.btnCikis.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Cambria", 14F);
            this.btnCikis.ForeColor = System.Drawing.Color.Black;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.ImageIndex = 12;
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(953, 521);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(127, 67);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnCevapla
            // 
            this.btnCevapla.BackColor = System.Drawing.Color.BlueViolet;
            this.btnCevapla.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnCevapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCevapla.Font = new System.Drawing.Font("Cambria", 13F);
            this.btnCevapla.ForeColor = System.Drawing.Color.White;
            this.btnCevapla.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCevapla.ImageIndex = 17;
            this.btnCevapla.ImageList = this.ımageList1;
            this.btnCevapla.Location = new System.Drawing.Point(109, 521);
            this.btnCevapla.Name = "btnCevapla";
            this.btnCevapla.Size = new System.Drawing.Size(127, 67);
            this.btnCevapla.TabIndex = 0;
            this.btnCevapla.Text = "Rastgele Soru ";
            this.btnCevapla.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCevapla.UseVisualStyleBackColor = false;
            this.btnCevapla.Click += new System.EventHandler(this.btnCevapla_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkViolet;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.ImageLocation = "resimyolu";
            this.pictureBox1.InitialImage = global::kim_milyoner_olmak_ister.Properties.Resources.kim_milyoner_olmak_ister;
            this.pictureBox1.Location = new System.Drawing.Point(32, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.BlueViolet;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.ImageIndex = 13;
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(803, 521);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 67);
            this.button4.TabIndex = 32;
            this.button4.Text = "Geri Dön";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkViolet;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.ImageLocation = "resimyolu";
            this.pictureBox2.InitialImage = global::kim_milyoner_olmak_ister.Properties.Resources.kim_milyoner_olmak_ister;
            this.pictureBox2.Location = new System.Drawing.Point(181, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(171, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 39);
            this.label1.TabIndex = 47;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButton6
            // 
            this.radioButton6.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton6.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton6.FlatAppearance.BorderSize = 0;
            this.radioButton6.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton6.ForeColor = System.Drawing.Color.White;
            this.radioButton6.Location = new System.Drawing.Point(171, 337);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(139, 39);
            this.radioButton6.TabIndex = 48;
            this.radioButton6.Text = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = false;
            // 
            // radioButton7
            // 
            this.radioButton7.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton7.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton7.FlatAppearance.BorderSize = 0;
            this.radioButton7.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton7.ForeColor = System.Drawing.Color.White;
            this.radioButton7.Location = new System.Drawing.Point(171, 299);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(139, 39);
            this.radioButton7.TabIndex = 46;
            this.radioButton7.Text = "radioButton7";
            this.radioButton7.UseVisualStyleBackColor = false;
            // 
            // radioButton8
            // 
            this.radioButton8.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton8.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton8.FlatAppearance.BorderSize = 0;
            this.radioButton8.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton8.ForeColor = System.Drawing.Color.White;
            this.radioButton8.Location = new System.Drawing.Point(171, 261);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(139, 39);
            this.radioButton8.TabIndex = 45;
            this.radioButton8.Text = "radioButton8";
            this.radioButton8.UseVisualStyleBackColor = false;
            // 
            // radioButton9
            // 
            this.radioButton9.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton9.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton9.FlatAppearance.BorderSize = 0;
            this.radioButton9.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton9.ForeColor = System.Drawing.Color.White;
            this.radioButton9.Location = new System.Drawing.Point(171, 224);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(139, 39);
            this.radioButton9.TabIndex = 44;
            this.radioButton9.Text = "radioButton9";
            this.radioButton9.UseVisualStyleBackColor = false;
            // 
            // radioButton10
            // 
            this.radioButton10.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton10.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton10.FlatAppearance.BorderSize = 0;
            this.radioButton10.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton10.ForeColor = System.Drawing.Color.White;
            this.radioButton10.Location = new System.Drawing.Point(171, 187);
            this.radioButton10.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(139, 39);
            this.radioButton10.TabIndex = 43;
            this.radioButton10.Text = "radioButton10";
            this.radioButton10.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkViolet;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.ImageLocation = "resimyolu";
            this.pictureBox3.InitialImage = global::kim_milyoner_olmak_ister.Properties.Resources.kim_milyoner_olmak_ister;
            this.pictureBox3.Location = new System.Drawing.Point(330, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(127, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(320, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 39);
            this.label2.TabIndex = 54;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButton11
            // 
            this.radioButton11.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton11.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton11.FlatAppearance.BorderSize = 0;
            this.radioButton11.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton11.ForeColor = System.Drawing.Color.White;
            this.radioButton11.Location = new System.Drawing.Point(320, 337);
            this.radioButton11.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(139, 39);
            this.radioButton11.TabIndex = 55;
            this.radioButton11.Text = "radioButton11";
            this.radioButton11.UseVisualStyleBackColor = false;
            // 
            // radioButton12
            // 
            this.radioButton12.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton12.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton12.FlatAppearance.BorderSize = 0;
            this.radioButton12.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton12.ForeColor = System.Drawing.Color.White;
            this.radioButton12.Location = new System.Drawing.Point(320, 299);
            this.radioButton12.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(139, 39);
            this.radioButton12.TabIndex = 53;
            this.radioButton12.Text = "radioButton12";
            this.radioButton12.UseVisualStyleBackColor = false;
            // 
            // radioButton13
            // 
            this.radioButton13.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton13.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton13.FlatAppearance.BorderSize = 0;
            this.radioButton13.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton13.ForeColor = System.Drawing.Color.White;
            this.radioButton13.Location = new System.Drawing.Point(320, 261);
            this.radioButton13.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(139, 39);
            this.radioButton13.TabIndex = 52;
            this.radioButton13.Text = "radioButton13";
            this.radioButton13.UseVisualStyleBackColor = false;
            // 
            // radioButton14
            // 
            this.radioButton14.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton14.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton14.FlatAppearance.BorderSize = 0;
            this.radioButton14.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton14.ForeColor = System.Drawing.Color.White;
            this.radioButton14.Location = new System.Drawing.Point(320, 224);
            this.radioButton14.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(139, 39);
            this.radioButton14.TabIndex = 51;
            this.radioButton14.Text = "radioButton14";
            this.radioButton14.UseVisualStyleBackColor = false;
            // 
            // radioButton15
            // 
            this.radioButton15.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton15.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton15.FlatAppearance.BorderSize = 0;
            this.radioButton15.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton15.ForeColor = System.Drawing.Color.White;
            this.radioButton15.Location = new System.Drawing.Point(320, 187);
            this.radioButton15.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(139, 39);
            this.radioButton15.TabIndex = 50;
            this.radioButton15.Text = "radioButton15";
            this.radioButton15.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DarkViolet;
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.ImageLocation = "resimyolu";
            this.pictureBox4.InitialImage = global::kim_milyoner_olmak_ister.Properties.Resources.kim_milyoner_olmak_ister;
            this.pictureBox4.Location = new System.Drawing.Point(476, 31);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(127, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 63;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(469, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 39);
            this.label3.TabIndex = 61;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButton16
            // 
            this.radioButton16.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton16.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton16.FlatAppearance.BorderSize = 0;
            this.radioButton16.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton16.ForeColor = System.Drawing.Color.White;
            this.radioButton16.Location = new System.Drawing.Point(469, 337);
            this.radioButton16.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(139, 39);
            this.radioButton16.TabIndex = 62;
            this.radioButton16.Text = "radioButton16";
            this.radioButton16.UseVisualStyleBackColor = false;
            // 
            // radioButton17
            // 
            this.radioButton17.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton17.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton17.FlatAppearance.BorderSize = 0;
            this.radioButton17.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton17.ForeColor = System.Drawing.Color.White;
            this.radioButton17.Location = new System.Drawing.Point(469, 299);
            this.radioButton17.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(139, 39);
            this.radioButton17.TabIndex = 60;
            this.radioButton17.Text = "radioButton17";
            this.radioButton17.UseVisualStyleBackColor = false;
            // 
            // radioButton18
            // 
            this.radioButton18.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton18.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton18.FlatAppearance.BorderSize = 0;
            this.radioButton18.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton18.ForeColor = System.Drawing.Color.White;
            this.radioButton18.Location = new System.Drawing.Point(469, 261);
            this.radioButton18.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(139, 39);
            this.radioButton18.TabIndex = 59;
            this.radioButton18.Text = "radioButton18";
            this.radioButton18.UseVisualStyleBackColor = false;
            // 
            // radioButton19
            // 
            this.radioButton19.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton19.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton19.FlatAppearance.BorderSize = 0;
            this.radioButton19.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton19.ForeColor = System.Drawing.Color.White;
            this.radioButton19.Location = new System.Drawing.Point(469, 224);
            this.radioButton19.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.Size = new System.Drawing.Size(139, 39);
            this.radioButton19.TabIndex = 58;
            this.radioButton19.Text = "radioButton19";
            this.radioButton19.UseVisualStyleBackColor = false;
            // 
            // radioButton20
            // 
            this.radioButton20.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton20.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton20.FlatAppearance.BorderSize = 0;
            this.radioButton20.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton20.ForeColor = System.Drawing.Color.White;
            this.radioButton20.Location = new System.Drawing.Point(469, 187);
            this.radioButton20.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(139, 39);
            this.radioButton20.TabIndex = 57;
            this.radioButton20.Text = "radioButton20";
            this.radioButton20.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DarkViolet;
            this.pictureBox5.ErrorImage = null;
            this.pictureBox5.ImageLocation = "resimyolu";
            this.pictureBox5.InitialImage = global::kim_milyoner_olmak_ister.Properties.Resources.kim_milyoner_olmak_ister;
            this.pictureBox5.Location = new System.Drawing.Point(628, 31);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(127, 100);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 70;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(618, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 39);
            this.label4.TabIndex = 68;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButton21
            // 
            this.radioButton21.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton21.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton21.FlatAppearance.BorderSize = 0;
            this.radioButton21.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton21.ForeColor = System.Drawing.Color.White;
            this.radioButton21.Location = new System.Drawing.Point(618, 337);
            this.radioButton21.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton21.Name = "radioButton21";
            this.radioButton21.Size = new System.Drawing.Size(139, 39);
            this.radioButton21.TabIndex = 69;
            this.radioButton21.Text = "radioButton21";
            this.radioButton21.UseVisualStyleBackColor = false;
            // 
            // radioButton22
            // 
            this.radioButton22.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton22.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton22.FlatAppearance.BorderSize = 0;
            this.radioButton22.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton22.ForeColor = System.Drawing.Color.White;
            this.radioButton22.Location = new System.Drawing.Point(618, 299);
            this.radioButton22.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton22.Name = "radioButton22";
            this.radioButton22.Size = new System.Drawing.Size(139, 39);
            this.radioButton22.TabIndex = 67;
            this.radioButton22.Text = "radioButton22";
            this.radioButton22.UseVisualStyleBackColor = false;
            // 
            // radioButton23
            // 
            this.radioButton23.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton23.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton23.FlatAppearance.BorderSize = 0;
            this.radioButton23.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton23.ForeColor = System.Drawing.Color.White;
            this.radioButton23.Location = new System.Drawing.Point(618, 261);
            this.radioButton23.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton23.Name = "radioButton23";
            this.radioButton23.Size = new System.Drawing.Size(139, 39);
            this.radioButton23.TabIndex = 66;
            this.radioButton23.Text = "radioButton23";
            this.radioButton23.UseVisualStyleBackColor = false;
            // 
            // radioButton24
            // 
            this.radioButton24.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton24.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton24.FlatAppearance.BorderSize = 0;
            this.radioButton24.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton24.ForeColor = System.Drawing.Color.White;
            this.radioButton24.Location = new System.Drawing.Point(618, 224);
            this.radioButton24.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton24.Name = "radioButton24";
            this.radioButton24.Size = new System.Drawing.Size(139, 39);
            this.radioButton24.TabIndex = 65;
            this.radioButton24.Text = "radioButton24";
            this.radioButton24.UseVisualStyleBackColor = false;
            // 
            // radioButton25
            // 
            this.radioButton25.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton25.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton25.FlatAppearance.BorderSize = 0;
            this.radioButton25.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton25.ForeColor = System.Drawing.Color.White;
            this.radioButton25.Location = new System.Drawing.Point(618, 187);
            this.radioButton25.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton25.Name = "radioButton25";
            this.radioButton25.Size = new System.Drawing.Size(139, 39);
            this.radioButton25.TabIndex = 64;
            this.radioButton25.Text = "radioButton25";
            this.radioButton25.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.DarkViolet;
            this.pictureBox6.ErrorImage = null;
            this.pictureBox6.ImageLocation = "resimyolu";
            this.pictureBox6.InitialImage = global::kim_milyoner_olmak_ister.Properties.Resources.kim_milyoner_olmak_ister;
            this.pictureBox6.Location = new System.Drawing.Point(777, 31);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(127, 100);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 77;
            this.pictureBox6.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(767, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 39);
            this.label5.TabIndex = 75;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButton26
            // 
            this.radioButton26.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton26.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton26.FlatAppearance.BorderSize = 0;
            this.radioButton26.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton26.ForeColor = System.Drawing.Color.White;
            this.radioButton26.Location = new System.Drawing.Point(767, 337);
            this.radioButton26.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton26.Name = "radioButton26";
            this.radioButton26.Size = new System.Drawing.Size(139, 39);
            this.radioButton26.TabIndex = 76;
            this.radioButton26.Text = "radioButton26";
            this.radioButton26.UseVisualStyleBackColor = false;
            // 
            // radioButton27
            // 
            this.radioButton27.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton27.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton27.FlatAppearance.BorderSize = 0;
            this.radioButton27.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton27.ForeColor = System.Drawing.Color.White;
            this.radioButton27.Location = new System.Drawing.Point(767, 299);
            this.radioButton27.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton27.Name = "radioButton27";
            this.radioButton27.Size = new System.Drawing.Size(139, 39);
            this.radioButton27.TabIndex = 74;
            this.radioButton27.Text = "radioButton27";
            this.radioButton27.UseVisualStyleBackColor = false;
            // 
            // radioButton28
            // 
            this.radioButton28.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton28.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton28.FlatAppearance.BorderSize = 0;
            this.radioButton28.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton28.ForeColor = System.Drawing.Color.White;
            this.radioButton28.Location = new System.Drawing.Point(767, 261);
            this.radioButton28.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton28.Name = "radioButton28";
            this.radioButton28.Size = new System.Drawing.Size(139, 39);
            this.radioButton28.TabIndex = 73;
            this.radioButton28.Text = "radioButton28";
            this.radioButton28.UseVisualStyleBackColor = false;
            // 
            // radioButton29
            // 
            this.radioButton29.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton29.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton29.FlatAppearance.BorderSize = 0;
            this.radioButton29.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton29.ForeColor = System.Drawing.Color.White;
            this.radioButton29.Location = new System.Drawing.Point(767, 224);
            this.radioButton29.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton29.Name = "radioButton29";
            this.radioButton29.Size = new System.Drawing.Size(139, 39);
            this.radioButton29.TabIndex = 72;
            this.radioButton29.Text = "radioButton29";
            this.radioButton29.UseVisualStyleBackColor = false;
            // 
            // radioButton30
            // 
            this.radioButton30.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton30.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton30.FlatAppearance.BorderSize = 0;
            this.radioButton30.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton30.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton30.ForeColor = System.Drawing.Color.White;
            this.radioButton30.Location = new System.Drawing.Point(767, 187);
            this.radioButton30.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton30.Name = "radioButton30";
            this.radioButton30.Size = new System.Drawing.Size(139, 39);
            this.radioButton30.TabIndex = 71;
            this.radioButton30.Text = "radioButton30";
            this.radioButton30.UseVisualStyleBackColor = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.DarkViolet;
            this.pictureBox7.ErrorImage = null;
            this.pictureBox7.ImageLocation = "resimyolu";
            this.pictureBox7.InitialImage = global::kim_milyoner_olmak_ister.Properties.Resources.kim_milyoner_olmak_ister;
            this.pictureBox7.Location = new System.Drawing.Point(926, 31);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(127, 100);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 84;
            this.pictureBox7.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(916, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 39);
            this.label6.TabIndex = 82;
            this.label6.Text = "label6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButton31
            // 
            this.radioButton31.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton31.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton31.FlatAppearance.BorderSize = 0;
            this.radioButton31.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton31.ForeColor = System.Drawing.Color.White;
            this.radioButton31.Location = new System.Drawing.Point(916, 337);
            this.radioButton31.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton31.Name = "radioButton31";
            this.radioButton31.Size = new System.Drawing.Size(139, 39);
            this.radioButton31.TabIndex = 83;
            this.radioButton31.Text = "radioButton31";
            this.radioButton31.UseVisualStyleBackColor = false;
            // 
            // radioButton32
            // 
            this.radioButton32.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton32.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton32.FlatAppearance.BorderSize = 0;
            this.radioButton32.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton32.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton32.ForeColor = System.Drawing.Color.White;
            this.radioButton32.Location = new System.Drawing.Point(916, 299);
            this.radioButton32.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton32.Name = "radioButton32";
            this.radioButton32.Size = new System.Drawing.Size(139, 39);
            this.radioButton32.TabIndex = 81;
            this.radioButton32.Text = "radioButton32";
            this.radioButton32.UseVisualStyleBackColor = false;
            // 
            // radioButton33
            // 
            this.radioButton33.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton33.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton33.FlatAppearance.BorderSize = 0;
            this.radioButton33.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton33.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton33.ForeColor = System.Drawing.Color.White;
            this.radioButton33.Location = new System.Drawing.Point(916, 261);
            this.radioButton33.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton33.Name = "radioButton33";
            this.radioButton33.Size = new System.Drawing.Size(139, 39);
            this.radioButton33.TabIndex = 80;
            this.radioButton33.Text = "radioButton33";
            this.radioButton33.UseVisualStyleBackColor = false;
            // 
            // radioButton34
            // 
            this.radioButton34.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton34.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton34.FlatAppearance.BorderSize = 0;
            this.radioButton34.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton34.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton34.ForeColor = System.Drawing.Color.White;
            this.radioButton34.Location = new System.Drawing.Point(916, 224);
            this.radioButton34.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton34.Name = "radioButton34";
            this.radioButton34.Size = new System.Drawing.Size(139, 39);
            this.radioButton34.TabIndex = 79;
            this.radioButton34.Text = "radioButton34";
            this.radioButton34.UseVisualStyleBackColor = false;
            // 
            // radioButton35
            // 
            this.radioButton35.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton35.BackColor = System.Drawing.Color.BlueViolet;
            this.radioButton35.FlatAppearance.BorderSize = 0;
            this.radioButton35.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.radioButton35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton35.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold);
            this.radioButton35.ForeColor = System.Drawing.Color.White;
            this.radioButton35.Location = new System.Drawing.Point(916, 187);
            this.radioButton35.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton35.Name = "radioButton35";
            this.radioButton35.Size = new System.Drawing.Size(139, 39);
            this.radioButton35.TabIndex = 78;
            this.radioButton35.Text = "radioButton35";
            this.radioButton35.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.BlueViolet;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cambria", 13F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.ImageIndex = 16;
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(277, 521);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 67);
            this.button3.TabIndex = 92;
            this.button3.Text = "Yazdır";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(22, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 39);
            this.label8.TabIndex = 93;
            this.label8.Text = "label8";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(171, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 39);
            this.label9.TabIndex = 94;
            this.label9.Text = "label9";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(320, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 39);
            this.label10.TabIndex = 95;
            this.label10.Text = "label10";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(469, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 39);
            this.label11.TabIndex = 96;
            this.label11.Text = "label11";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(618, 381);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 39);
            this.label12.TabIndex = 97;
            this.label12.Text = "label12";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(767, 381);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 39);
            this.label15.TabIndex = 98;
            this.label15.Text = "label15";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(916, 381);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(139, 39);
            this.label20.TabIndex = 99;
            this.label20.Text = "label20";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radioButton31);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnCevapla);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.radioButton32);
            this.panel1.Controls.Add(this.radioButton10);
            this.panel1.Controls.Add(this.radioButton33);
            this.panel1.Controls.Add(this.radioButton9);
            this.panel1.Controls.Add(this.radioButton34);
            this.panel1.Controls.Add(this.radioButton8);
            this.panel1.Controls.Add(this.radioButton35);
            this.panel1.Controls.Add(this.radioButton7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.radioButton6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButton26);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.radioButton27);
            this.panel1.Controls.Add(this.radioButton15);
            this.panel1.Controls.Add(this.radioButton28);
            this.panel1.Controls.Add(this.radioButton14);
            this.panel1.Controls.Add(this.radioButton29);
            this.panel1.Controls.Add(this.radioButton13);
            this.panel1.Controls.Add(this.radioButton30);
            this.panel1.Controls.Add(this.radioButton12);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.radioButton11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radioButton21);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.radioButton22);
            this.panel1.Controls.Add(this.radioButton20);
            this.panel1.Controls.Add(this.radioButton23);
            this.panel1.Controls.Add(this.radioButton19);
            this.panel1.Controls.Add(this.radioButton24);
            this.panel1.Controls.Add(this.radioButton18);
            this.panel1.Controls.Add(this.radioButton25);
            this.panel1.Controls.Add(this.radioButton17);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.radioButton16);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 624);
            this.panel1.TabIndex = 100;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(425, 512);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Soru Sayısı Başlangıç";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(425, 525);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Soru Sayısı Bitiş";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(546, 525);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(12, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "y";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(546, 512);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(12, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "x";
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(1100, 624);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kim Milyoner Olmak İster TYT";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button btnCevapla;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ImageList ımageList1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private Button button4;
        private PictureBox pictureBox2;
        private Label label1;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private RadioButton radioButton10;
        private PictureBox pictureBox3;
        private Label label2;
        private RadioButton radioButton11;
        private RadioButton radioButton12;
        private RadioButton radioButton13;
        private RadioButton radioButton14;
        private RadioButton radioButton15;
        private PictureBox pictureBox4;
        private Label label3;
        private RadioButton radioButton16;
        private RadioButton radioButton17;
        private RadioButton radioButton18;
        private RadioButton radioButton19;
        private RadioButton radioButton20;
        private PictureBox pictureBox5;
        private Label label4;
        private RadioButton radioButton21;
        private RadioButton radioButton22;
        private RadioButton radioButton23;
        private RadioButton radioButton24;
        private RadioButton radioButton25;
        private PictureBox pictureBox6;
        private Label label5;
        private RadioButton radioButton26;
        private RadioButton radioButton27;
        private RadioButton radioButton28;
        private RadioButton radioButton29;
        private RadioButton radioButton30;
        private PictureBox pictureBox7;
        private Label label6;
        private RadioButton radioButton31;
        private RadioButton radioButton32;
        private RadioButton radioButton33;
        private RadioButton radioButton34;
        private RadioButton radioButton35;
        private Button button3;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label15;
        private Label label20;
        private Panel panel1;
        private Label label17;
        private Label label16;
        private Label label19;
        private Label label18;
    }
}