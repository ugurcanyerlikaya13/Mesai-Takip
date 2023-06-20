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

namespace ToDoPomodoro
{
    public partial class Form1 : Form
    {
        public static SqlConnection connection = new SqlConnection("Data Source= DESKTOP-UIC54B1\\SQLEXPRESS; Initial Catalog=test; Integrated Security=TRUE");

        public Form1()
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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);

            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text=="Kullanıcı Adı")
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

        bool isThere;
        public static string username;
        private void button1_Click(object sender, EventArgs e)
        {
            username = textBox1.Text;
            string pass = textBox2.Text;
            connection.Open();
            SqlCommand command = new SqlCommand("select*from Uyeler",connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (username == Cryptology.Decryption(reader["username"].ToString().TrimEnd(), 2) && pass == Cryptology.Decryption(reader["pass"].ToString().TrimEnd(), 2))
                {
                    isThere = true;
                    break;
                }
                else
                {
                    isThere = false;
                }
            }
            connection.Close();
            if (isThere)
            {
                MessageBox.Show("Başarıyla Giriş Yaptınız !", "ToDoPomodoro");
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ya da Şifreniz Yanlış !", "ToDoPomodoro");

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:uyrlky@gmail.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void yuvarlakButon2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
