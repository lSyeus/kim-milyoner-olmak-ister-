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

    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.button14);
            this.panelChildForm.Controls.Add(this.button12);
            this.panelChildForm.Controls.Add(this.button11);
            this.panelChildForm.Controls.Add(this.button10);
            this.panelChildForm.Controls.Add(this.button8);
            this.panelChildForm.Controls.Add(this.button7);
            this.panelChildForm.Controls.Add(this.button6);
            this.panelChildForm.Controls.Add(this.button5);
            this.panelChildForm.Controls.Add(this.textBox10);
            this.panelChildForm.Controls.Add(this.textBox9);
            this.panelChildForm.Controls.Add(this.textBox8);
            this.panelChildForm.Controls.Add(this.textBox7);
            this.panelChildForm.Controls.Add(this.textBox6);
            this.panelChildForm.Controls.Add(this.textBox5);
            this.panelChildForm.Controls.Add(this.textBox4);
            this.panelChildForm.Controls.Add(this.dataGridView1);
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Controls.Add(this.button4);
            this.panelChildForm.Controls.Add(this.button3);
            this.panelChildForm.Controls.Add(this.button2);
            this.panelChildForm.Controls.Add(this.button1);
            this.panelChildForm.Controls.Add(this.textBox3);
            this.panelChildForm.Controls.Add(this.textBox2);
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1116, 663);
            this.panelChildForm.TabIndex = 1;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // button14
            // 
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button14.ImageIndex = 10;
            this.button14.ImageList = this.ımageList1;
            this.button14.Location = new System.Drawing.Point(562, 266);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(127, 42);
            this.button14.TabIndex = 23;
            this.button14.Text = "Yazdır Tablo ";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "log-out.png");
            this.ımageList1.Images.SetKeyName(1, "left-arrow.png");
            this.ımageList1.Images.SetKeyName(2, "eraser.png");
            this.ımageList1.Images.SetKeyName(3, "delete.png");
            this.ımageList1.Images.SetKeyName(4, "edit.png");
            this.ımageList1.Images.SetKeyName(5, "plus.png");
            this.ımageList1.Images.SetKeyName(6, "diskette.png");
            this.ımageList1.Images.SetKeyName(7, "counting.png");
            this.ımageList1.Images.SetKeyName(8, "register.png");
            this.ımageList1.Images.SetKeyName(9, "pdf.png");
            this.ımageList1.Images.SetKeyName(10, "table.png");
            this.ımageList1.Images.SetKeyName(11, "file.png");
            this.ımageList1.Images.SetKeyName(12, "writing.png");
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button12.ImageIndex = 11;
            this.button12.ImageList = this.ımageList1;
            this.button12.Location = new System.Drawing.Point(562, 218);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(127, 42);
            this.button12.TabIndex = 21;
            this.button12.Text = "Rapor Görüntüle";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button11.ImageIndex = 12;
            this.button11.ImageList = this.ımageList1;
            this.button11.Location = new System.Drawing.Point(562, 170);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(127, 42);
            this.button11.TabIndex = 20;
            this.button11.Text = "Rapor Düzenle";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.ImageIndex = 9;
            this.button10.ImageList = this.ımageList1;
            this.button10.Location = new System.Drawing.Point(828, 170);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(127, 42);
            this.button10.TabIndex = 19;
            this.button10.Text = "Yazdır PDF";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.ImageIndex = 8;
            this.button8.ImageList = this.ımageList1;
            this.button8.Location = new System.Drawing.Point(695, 170);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(127, 42);
            this.button8.TabIndex = 11;
            this.button8.Text = "Resim Kaydet";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.ImageIndex = 2;
            this.button7.ImageList = this.ımageList1;
            this.button7.Location = new System.Drawing.Point(695, 266);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(127, 42);
            this.button7.TabIndex = 14;
            this.button7.Text = "Temizle";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.ImageIndex = 1;
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(828, 266);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 42);
            this.button6.TabIndex = 15;
            this.button6.Text = "Geri Dön";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.ImageIndex = 0;
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(961, 264);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 42);
            this.button5.TabIndex = 16;
            this.button5.Text = "Çıkış";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.BlueViolet;
            this.textBox10.Location = new System.Drawing.Point(631, 12);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(272, 60);
            this.textBox10.TabIndex = 9;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.BlueViolet;
            this.textBox9.Location = new System.Drawing.Point(107, 10);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(448, 38);
            this.textBox9.TabIndex = 8;
            this.textBox9.Text = "Cevap";
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            this.textBox9.Enter += new System.EventHandler(this.textBox9_Enter);
            this.textBox9.Leave += new System.EventHandler(this.textBox9_Leave);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.BlueViolet;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox8.Location = new System.Drawing.Point(290, 264);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(265, 54);
            this.textBox8.TabIndex = 7;
            this.textBox8.Text = "E) ";
            this.textBox8.Enter += new System.EventHandler(this.textBox8_Enter);
            this.textBox8.Leave += new System.EventHandler(this.textBox8_Leave);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.BlueViolet;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox7.Location = new System.Drawing.Point(290, 211);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(265, 54);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "D) ";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.textBox7.Enter += new System.EventHandler(this.textBox7_Enter);
            this.textBox7.Leave += new System.EventHandler(this.textBox7_Leave);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.BlueViolet;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox6.Location = new System.Drawing.Point(290, 158);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(265, 54);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "C) ";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.textBox6.Enter += new System.EventHandler(this.textBox6_Enter);
            this.textBox6.Leave += new System.EventHandler(this.textBox6_Leave);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.BlueViolet;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox5.Location = new System.Drawing.Point(290, 105);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(265, 54);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "B) ";
            this.textBox5.Enter += new System.EventHandler(this.textBox5_Enter);
            this.textBox5.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.BlueViolet;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox4.Location = new System.Drawing.Point(290, 52);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(265, 54);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "A) ";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.Enter += new System.EventHandler(this.textBox4_Enter);
            this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridView1.GridColor = System.Drawing.Color.BlueViolet;
            this.dataGridView1.Location = new System.Drawing.Point(12, 323);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1076, 289);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 47;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Soru";
            this.Column2.HeaderText = "Soru";
            this.Column2.Name = "Column2";
            this.Column2.Width = 197;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "A";
            this.Column3.HeaderText = "A";
            this.Column3.Name = "Column3";
            this.Column3.Width = 115;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "B";
            this.Column4.HeaderText = "B";
            this.Column4.Name = "Column4";
            this.Column4.Width = 115;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "C";
            this.Column5.HeaderText = "C";
            this.Column5.Name = "Column5";
            this.Column5.Width = 115;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "D";
            this.Column6.HeaderText = "D";
            this.Column6.Name = "Column6";
            this.Column6.Width = 115;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "E";
            this.Column7.HeaderText = "E";
            this.Column7.Name = "Column7";
            this.Column7.Width = 115;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Cevap";
            this.Column8.HeaderText = "Cevap";
            this.Column8.Name = "Column8";
            this.Column8.Width = 115;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "ResimYolu";
            this.Column9.HeaderText = "ResimYolu";
            this.Column9.Name = "Column9";
            this.Column9.Width = 80;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(909, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.ImageIndex = 3;
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(961, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 42);
            this.button4.TabIndex = 13;
            this.button4.Text = "Sil";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.ImageIndex = 4;
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(828, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 42);
            this.button3.TabIndex = 12;
            this.button3.Text = "Düzenle";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.ImageIndex = 5;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(695, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 42);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ekle";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.ImageIndex = 7;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(961, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Resim Seç";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.BlueViolet;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.textBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(12, 52);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(272, 265);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Soru";
            this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.BlueViolet;
            this.textBox2.Location = new System.Drawing.Point(12, 10);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 36);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Id";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(1100, 624);
            this.Controls.Add(this.panelChildForm);
            this.KeyPreview = true;
            this.Name = "Form10";
            this.Text = "Kim Milyoner Olmak İster TYT";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form10_KeyUp);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelChildForm;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox10;
        private TextBox textBox9;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button10;
        private Button button11;
        private Button button12;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private Button button14;
        private ImageList ımageList1;
    }
}