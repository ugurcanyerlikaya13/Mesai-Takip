using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace ToDoPomodoro
{
    public partial class Form3 : Form
    {
        SqlConnection connection = Form1.connection;
        public Form3()
        {
            InitializeComponent();
        }

        private void yuvarlakButon1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool move;  //public değişken olması için burada tanımladık
        int mouse_x;
        int mouse_y;
        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);

            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Kullanıcı Adı")
            {
                textBox1.Text = "";
            }
            textBox1.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Kullanıcı Adı";
            }
            textBox1.ForeColor = Color.Silver;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Sifre")
            {
                textBox2.Text = "";
            }
            textBox2.ForeColor = Color.Black;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Sifre";
            }
            textBox2.ForeColor = Color.Silver;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Sifre Tekrar")
            {
                textBox3.Text = "";
            }
            textBox3.ForeColor = Color.Black;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Sifre Tekrar";
            }
            textBox3.ForeColor = Color.Silver;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "E Mail")
            {
                textBox4.Text = "";
            }
            textBox4.ForeColor = Color.Black;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "E Mail";
            }
            textBox4.ForeColor = Color.Silver;
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Telefon Numarası")
            {
                textBox5.Text = "";
            }
            textBox5.ForeColor = Color.Black;
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Telefon Numarası";
            }
            textBox5.ForeColor = Color.Silver;
        }
        private static Regex email_validation() //mail kontrol fonksiyonu
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
       static Regex validate_emailaddress = email_validation();//fonskiyon çağırma
        private void button1_Click(object sender, EventArgs e)
        {        
            

            if (validate_emailaddress.IsMatch(textBox4.Text) != true)
            {
                MessageBox.Show("Geçersiz Mail Adresi", "ToDoPomodoro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox4.Focus();
                return;
            }
            else
            {
                
            }
            if (textBox2.Text==textBox3.Text)
            {

            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor", "ToDoPomodoro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox2.Focus();
                return;
            }
            connection.Open();
            SqlCommand command = new SqlCommand("Insert into Uyeler (username,pass,re_pass,e_mail,phone) values('"+Cryptology.Encryption(textBox1.Text,2)+ "','" + Cryptology.Encryption(textBox2.Text, 2) + "','" + Cryptology.Encryption(textBox3.Text, 2) + "','" + Cryptology.Encryption(textBox4.Text, 2) + "','" + Cryptology.Encryption(textBox5.Text, 2) + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Başarıyla Kayıt Oldunuz. Giriş Yapmaya Yönlendiriliyorsunuz", "ToDoPomodoro");
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void yuvarlakButon2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
