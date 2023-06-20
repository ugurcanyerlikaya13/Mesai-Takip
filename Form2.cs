using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace ToDoPomodoro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection connection = Form1.connection;
        

        bool move;  //public değişken olması için burada tanımladık
        int mouse_x;
        int mouse_y;
        private void yuvarlakButon2_Click(object sender, EventArgs e)
        {
            if (saat2==0||dakika2==0) //9 saatlik mesai tamamlanmadan uygulama kapanmaması için 
            {
                mesai = true;
            }
            else
            {
                mesai = false;
            }
            if (mesai)
            {
              Application.Exit();
            }
            else
            {
                MessageBox.Show("Mesai saatini tamamlamadan kapatamazsınız.", "ToDoPomodoro");
            }
             

        }
        //mouse up move ve down ile borderı olmayan formu haraket ettirdim
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        
        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            say.ForeColor = Color.Black;
            try
            {
                if (saat.Checked == true || dakika.Checked == true || saniye.Checked == true)
                {
                    if (sure.Text != "")//işaterli checkboxa göre zamanı saniye cinsinden hesapladım
                    {
                        if (saat.Checked == true)
                        {
                            say.Text = ((int.Parse(sure.Text)) * 60 * 60).ToString();
                        }
                        else if (dakika.Checked == true)
                        {
                            say.Text = ((int.Parse(sure.Text)) * 60).ToString();
                        }
                        else if (saniye.Checked == true)
                        {
                            say.Text = ((int.Parse(sure.Text))).ToString();
                        }
                        timer1.Start();
                        sure.Clear();
                        
                        sure.Text = "Sayaç İşliyor!";
                        
                     
                    }
                    else
                    {
                        MessageBox.Show("Süreyi girin.", "Hata");
                    }
                }
                else
                {
                    MessageBox.Show("Süre tipini seçin.", "Hata");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Hata");
            }
            bool pomodoro;
            
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            timer1.Stop();           //timer değerini sıfırlayarak tekrar süre girdirmemizi sağlıyor
            sure.Enabled = true;
            sure.Text = "";
            saat.Enabled = true;
            dakika.Enabled = true;
            saniye.Enabled = true;
            say.Text = "";
            saat.Checked = false;
            dakika.Checked = false;
            saniye.Checked = false;
            btnBasla.Enabled = true;
            btnSifirla.Enabled = false;
           
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty && textBox1.Text != " ")
            {
                listYapilacak.Items.Add(textBox1.Text); //listbox'a yapılacak görev eklemek için olan kısım
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Eklenecek Görev Bulunamadı!", "ToDoPomodoro", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listYapilacak.SelectedIndex != -1 || listYapildi.SelectedIndex != -1) //eklenen görevi listbox'tan silen kısım
            {
                if (listYapilacak.SelectedIndex != -1)
                {
                    listYapilacak.Items.RemoveAt(listYapilacak.SelectedIndex);
                }
                else
                {
                    listYapildi.Items.RemoveAt(listYapildi.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Silinecek Görev Bulunamadı!", "ToDoPomodoro", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnTamamlandi_Click(object sender, EventArgs e)
        {
            for (int i = listYapilacak.SelectedIndices.Count - 1; i >= 0; i--) //eklenen görevi tamamlandı listbox'ına çekme kısmı
            {
                listYapildi.Items.Add(listYapilacak.SelectedItems[i]);
                listYapilacak.Items.RemoveAt(listYapilacak.SelectedIndices[i]);
            }
        }

        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            for (int i = listYapildi.SelectedIndices.Count - 1; i >= 0; i--) //tamamlanan görevi geri yapılacak listbox'ına alan kısım
            {
                listYapilacak.Items.Add(listYapildi.SelectedItems[i]);
                listYapildi.Items.RemoveAt(listYapildi.SelectedIndices[i]);
            }
        }
        int sayaç = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            say.Text = ((int.Parse(say.Text) - 1).ToString()); //geri sayım için olan timer ın gerekli kodları
            if (int.Parse(say.Text) < 10)
            {
                say.ForeColor = Color.Red;
            }
            else
            {
                say.ForeColor = Color.Black;
            }
            if (int.Parse(say.Text) < 1)
            {
                timer1.Stop();
                MessageBox.Show("Süre doldu 10 dakika ara verebilirsiniz", "ToDoPomodoro");
                sayaç++;
                sure.Enabled = true;
                sure.Text = "";
                saat.Enabled = true;
                dakika.Enabled = true;
                saniye.Enabled = true;
                say.Text = "";
                saat.Checked = false;
                dakika.Checked = false;
                saniye.Checked = false;
                
            }
            

        }

        
        int saniye2 = 60;
        int dakika2 = 60;
        int saat2 = 9;
        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1000;

            saniye2 = saniye2 - 1;
            
            lblSaniye.Text = Convert.ToString(saniye2);
            lblDakika.Text = Convert.ToString(dakika2 - 1);
            lblSaat.Text = Convert.ToString(saat2 - 1);

            if (saniye2 == 0)
            {

                dakika2 = dakika2 - 1;
                lblDakika.Text = Convert.ToString(dakika2);
                saniye2 = 60;
            }

            if (dakika2 == 0)
            {
                saat2 = saat2 - 1;
                lblSaat.Text = Convert.ToString(saat2);
                dakika2 = 60;
                
            }
            if (saat2==0)
            {
                dakika2 = dakika2 - 1;
                lblDakika.Text = Convert.ToString(dakika2);
                saniye2 = 60;
            }
            if (lblDakika.Text == "-1")
            {
                timer2.Stop();
                lblDakika.Text = "00";
                lblSaniye.Text = "00";
                
            }
        }
        bool mesai;
        private void raporAl_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int RastgeleSayi1 = rnd.Next(1,100);
            
            
            string yol = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dosyadi = yol + "/ToDoPomodoro Rapor.txt";

            StreamWriter sw = new StreamWriter(dosyadi);
            if (mesai)
            {
                
                sw.WriteLine("9 saatlik mesai tamamlandı! \n");

            }
            else
            {
                
                sw.WriteLine("Henüz mesaiyi tamamlamadan rapor oluşturdunuz \n");

            }
            sw.WriteLine("Yapılan Pomodoro Sayısı: \n");
            sw.WriteLine(""+sayaç+"\n");
            
            sw.WriteLine("Yapılan Görevler: \n");
            for (int i = 0; i < listYapildi.Items.Count; i++)
            {
                sw.WriteLine(Convert.ToString(listYapildi.Items[i]));
               
            }
            sw.WriteLine("KEY: \n");
            sw.WriteLine("" + RastgeleSayi1 + "\n");
            sw.Close();
            
            MessageBox.Show("Raporunuz masaüstüne kaydedildi! Lütfen bölüm şefinize mail atmayı unutmayınız", "ToDoPomodoro", MessageBoxButtons.OK, MessageBoxIcon.None);


            string yoll = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dosyadii = yol + "/database.txt";

            StreamWriter sww = new StreamWriter(dosyadi);
            sww.Write( "" + Form1.username + ""+",");
            if (mesai)
            {

                sww.Write("9 saatlik mesai tamamlandı!,");

            }
            else
            {

                sww.Write("Henüz mesaiyi tamamlamadan rapor oluşturdunuz,");

            }
            sww.Write("" + sayaç + ""+",");

            
            for (int i = 0; i < listYapildi.Items.Count; i++)
            {
                sww.Write(Convert.ToString(listYapildi.Items[i])+" ");

            }
            
            sww.Write(","+"" + RastgeleSayi1 + ""+","); 
            sww.Write( "" + DateTime.Now.ToLongDateString() + "" + ";");
            sww.Close();

            
        }

        private void yuvarlakButon1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
