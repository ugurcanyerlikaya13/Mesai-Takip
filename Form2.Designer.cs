
namespace ToDoPomodoro
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.say = new System.Windows.Forms.Label();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.saniye = new System.Windows.Forms.CheckBox();
            this.dakika = new System.Windows.Forms.CheckBox();
            this.saat = new System.Windows.Forms.CheckBox();
            this.sure = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGeriAl = new System.Windows.Forms.Button();
            this.btnTamamlandi = new System.Windows.Forms.Button();
            this.listYapildi = new System.Windows.Forms.ListBox();
            this.listYapilacak = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.raporAl = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDakika = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.yuvarlakButon2 = new ShapedButton.YuvarlakButon();
            this.yuvarlakButon1 = new ShapedButton.YuvarlakButon();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.say);
            this.groupBox1.Controls.Add(this.btnSifirla);
            this.groupBox1.Controls.Add(this.btnBasla);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.saniye);
            this.groupBox1.Controls.Add(this.dakika);
            this.groupBox1.Controls.Add(this.saat);
            this.groupBox1.Controls.Add(this.sure);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(152, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 197);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pomodoro";
            // 
            // say
            // 
            this.say.AutoSize = true;
            this.say.Location = new System.Drawing.Point(44, 171);
            this.say.Name = "say";
            this.say.Size = new System.Drawing.Size(0, 13);
            this.say.TabIndex = 14;
            // 
            // btnSifirla
            // 
            this.btnSifirla.BackColor = System.Drawing.Color.Transparent;
            this.btnSifirla.BackgroundImage = global::ToDoPomodoro.Properties.Resources.sıfırlabtn;
            this.btnSifirla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifirla.ForeColor = System.Drawing.Color.Transparent;
            this.btnSifirla.Location = new System.Drawing.Point(138, 129);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(85, 28);
            this.btnSifirla.TabIndex = 13;
            this.btnSifirla.UseVisualStyleBackColor = false;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.Transparent;
            this.btnBasla.BackgroundImage = global::ToDoPomodoro.Properties.Resources.baslabtn;
            this.btnBasla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBasla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasla.ForeColor = System.Drawing.Color.Transparent;
            this.btnBasla.Location = new System.Drawing.Point(47, 129);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(85, 28);
            this.btnBasla.TabIndex = 12;
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sağ Taraftan Zaman Birimi Seçiniz";
            // 
            // saniye
            // 
            this.saniye.AutoSize = true;
            this.saniye.Location = new System.Drawing.Point(211, 81);
            this.saniye.Name = "saniye";
            this.saniye.Size = new System.Drawing.Size(64, 17);
            this.saniye.TabIndex = 3;
            this.saniye.Text = "Saniye";
            this.saniye.UseVisualStyleBackColor = true;
            // 
            // dakika
            // 
            this.dakika.AutoSize = true;
            this.dakika.Location = new System.Drawing.Point(211, 58);
            this.dakika.Name = "dakika";
            this.dakika.Size = new System.Drawing.Size(66, 17);
            this.dakika.TabIndex = 2;
            this.dakika.Text = "Dakika";
            this.dakika.UseVisualStyleBackColor = true;
            // 
            // saat
            // 
            this.saat.AutoSize = true;
            this.saat.Location = new System.Drawing.Point(211, 35);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(52, 17);
            this.saat.TabIndex = 1;
            this.saat.Text = "Saat";
            this.saat.UseVisualStyleBackColor = true;
            // 
            // sure
            // 
            this.sure.Location = new System.Drawing.Point(75, 81);
            this.sure.Multiline = true;
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(130, 28);
            this.sure.TabIndex = 0;
            this.sure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnGeriAl);
            this.groupBox2.Controls.Add(this.btnTamamlandi);
            this.groupBox2.Controls.Add(this.listYapildi);
            this.groupBox2.Controls.Add(this.listYapilacak);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(466, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 290);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To Do List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "TAMAMLANANLAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "YAPILACAKLAR";
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.BackColor = System.Drawing.Color.Transparent;
            this.btnGeriAl.BackgroundImage = global::ToDoPomodoro.Properties.Resources.geri_al;
            this.btnGeriAl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeriAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriAl.ForeColor = System.Drawing.Color.Transparent;
            this.btnGeriAl.Location = new System.Drawing.Point(273, 239);
            this.btnGeriAl.Name = "btnGeriAl";
            this.btnGeriAl.Size = new System.Drawing.Size(107, 28);
            this.btnGeriAl.TabIndex = 20;
            this.btnGeriAl.UseVisualStyleBackColor = false;
            this.btnGeriAl.Click += new System.EventHandler(this.btnGeriAl_Click);
            // 
            // btnTamamlandi
            // 
            this.btnTamamlandi.BackColor = System.Drawing.Color.Transparent;
            this.btnTamamlandi.BackgroundImage = global::ToDoPomodoro.Properties.Resources.tamamlandı1;
            this.btnTamamlandi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTamamlandi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamamlandi.ForeColor = System.Drawing.Color.Transparent;
            this.btnTamamlandi.Location = new System.Drawing.Point(147, 239);
            this.btnTamamlandi.Name = "btnTamamlandi";
            this.btnTamamlandi.Size = new System.Drawing.Size(107, 28);
            this.btnTamamlandi.TabIndex = 19;
            this.btnTamamlandi.UseVisualStyleBackColor = false;
            this.btnTamamlandi.Click += new System.EventHandler(this.btnTamamlandi_Click);
            // 
            // listYapildi
            // 
            this.listYapildi.FormattingEnabled = true;
            this.listYapildi.Location = new System.Drawing.Point(269, 60);
            this.listYapildi.MultiColumn = true;
            this.listYapildi.Name = "listYapildi";
            this.listYapildi.Size = new System.Drawing.Size(120, 173);
            this.listYapildi.TabIndex = 18;
            // 
            // listYapilacak
            // 
            this.listYapilacak.FormattingEnabled = true;
            this.listYapilacak.Location = new System.Drawing.Point(143, 60);
            this.listYapilacak.MultiColumn = true;
            this.listYapilacak.Name = "listYapilacak";
            this.listYapilacak.Size = new System.Drawing.Size(120, 173);
            this.listYapilacak.TabIndex = 17;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.BackgroundImage = global::ToDoPomodoro.Properties.Resources.grvsil;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ForeColor = System.Drawing.Color.Transparent;
            this.btnSil.Location = new System.Drawing.Point(25, 181);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(78, 28);
            this.btnSil.TabIndex = 16;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.BackgroundImage = global::ToDoPomodoro.Properties.Resources.grvekle;
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.Color.Transparent;
            this.btnEkle.Location = new System.Drawing.Point(25, 137);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(78, 28);
            this.btnEkle.TabIndex = 15;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 101);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 30);
            this.textBox1.TabIndex = 0;
            // 
            // raporAl
            // 
            this.raporAl.BackColor = System.Drawing.Color.Transparent;
            this.raporAl.BackgroundImage = global::ToDoPomodoro.Properties.Resources.rapor;
            this.raporAl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.raporAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raporAl.ForeColor = System.Drawing.Color.Transparent;
            this.raporAl.Location = new System.Drawing.Point(569, 373);
            this.raporAl.Name = "raporAl";
            this.raporAl.Size = new System.Drawing.Size(185, 58);
            this.raporAl.TabIndex = 15;
            this.raporAl.UseVisualStyleBackColor = false;
            this.raporAl.Click += new System.EventHandler(this.raporAl_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lblSaniye);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblDakika);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblSaat);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(161, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 150);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mesai";
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Location = new System.Drawing.Point(171, 45);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(15, 13);
            this.lblSaniye.TabIndex = 21;
            this.lblSaniye.Text = "..";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(165, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(140, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = ":";
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.Location = new System.Drawing.Point(148, 45);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(15, 13);
            this.lblDakika.TabIndex = 18;
            this.lblDakika.Text = "..";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = ":";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(130, 45);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(15, 13);
            this.lblSaat.TabIndex = 16;
            this.lblSaat.Text = "..";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ToDoPomodoro.Properties.Resources.baslabtn;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(184, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 28);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "İyi Çalışmalar Dileriz.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "kaldı.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mesainizin bitmesine ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // yuvarlakButon2
            // 
            this.yuvarlakButon2.BackColor = System.Drawing.Color.Transparent;
            this.yuvarlakButon2.BackgroundImage = global::ToDoPomodoro.Properties.Resources.Group__2_;
            this.yuvarlakButon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yuvarlakButon2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yuvarlakButon2.Location = new System.Drawing.Point(836, 3);
            this.yuvarlakButon2.Name = "yuvarlakButon2";
            this.yuvarlakButon2.Size = new System.Drawing.Size(27, 27);
            this.yuvarlakButon2.TabIndex = 4;
            this.yuvarlakButon2.UseVisualStyleBackColor = false;
            this.yuvarlakButon2.Click += new System.EventHandler(this.yuvarlakButon2_Click);
            // 
            // yuvarlakButon1
            // 
            this.yuvarlakButon1.BackColor = System.Drawing.Color.Transparent;
            this.yuvarlakButon1.BackgroundImage = global::ToDoPomodoro.Properties.Resources.aa;
            this.yuvarlakButon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yuvarlakButon1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yuvarlakButon1.Location = new System.Drawing.Point(803, 3);
            this.yuvarlakButon1.Name = "yuvarlakButon1";
            this.yuvarlakButon1.Size = new System.Drawing.Size(27, 27);
            this.yuvarlakButon1.TabIndex = 17;
            this.yuvarlakButon1.UseVisualStyleBackColor = false;
            this.yuvarlakButon1.Click += new System.EventHandler(this.yuvarlakButon1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::ToDoPomodoro.Properties.Resources.ekran;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 456);
            this.Controls.Add(this.yuvarlakButon1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.raporAl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.yuvarlakButon2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ShapedButton.YuvarlakButon yuvarlakButon2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox saniye;
        private System.Windows.Forms.CheckBox dakika;
        private System.Windows.Forms.CheckBox saat;
        private System.Windows.Forms.TextBox sure;
        private System.Windows.Forms.Label say;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGeriAl;
        private System.Windows.Forms.Button btnTamamlandi;
        private System.Windows.Forms.ListBox listYapildi;
        private System.Windows.Forms.ListBox listYapilacak;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button raporAl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Timer timer2;
        private ShapedButton.YuvarlakButon yuvarlakButon1;
    }
}