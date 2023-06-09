using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace takvim
{
    public partial class mainmenu : Form
    {
         
        

        void renklerone()

        {
            panel1.BackColor=Color.FromArgb(234,186,136);
            panelmenu.BackColor=Color.FromArgb( 218, 165, 87);
            panellogo.BackColor=Color.FromArgb(190, 113, 31);
            button4.BackColor=Color.FromArgb( 128, 80, 31);
        }void renklertwo()
        {
            panel1.BackColor=Color.FromArgb(154, 152, 217);
            panelmenu.BackColor=Color.FromArgb( 133, 138, 219);
            panellogo.BackColor=Color.FromArgb( 108, 119, 201);
            button4.BackColor=Color.FromArgb( 140, 117, 197);
        }void renklerthree()

        {
            panel1.BackColor=Color.FromArgb(193, 229, 201);
            panelmenu.BackColor=Color.FromArgb( 149, 193, 142);
            panellogo.BackColor=Color.FromArgb( 123, 173, 124);
            button4.BackColor=Color.FromArgb( 91, 142, 99);
        }void renklerfour()
        {
            panel1.BackColor=Color.FromArgb(0227, 223, 222);
            panelmenu.BackColor=Color.FromArgb( 208, 205, 200);
            panellogo.BackColor=Color.FromArgb( 193, 183, 184);
            button4.BackColor=Color.FromArgb(160, 155, 149);
        }
        public mainmenu()
        {
            InitializeComponent();
            
        }
        void formbaslagici()
        {
            pictureBox2.BackColor = Color.Transparent;
            panel1.Visible = true;
            panel1.Dock = DockStyle.Fill;
            this.Size = new Size(836,499);
        }
        void btnbk(Button button)
        {
            button.BackColor = panel1.BackColor;
            button.ForeColor = Color.White;
           
        }
        void btnleavebk(Button button)
        {
            button.BackColor=Color.Transparent;
            button.ForeColor = Color.Black;
           
        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            btnbk(button1);
         
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnleavebk(button1);
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            btnbk(button2);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            btnleavebk(button2);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            btnleavebk(button3);
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            btnbk(button3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            formbaslagici();

            isciverileri isciveriler = new isciverileri();
            isciveriler.MdiParent = this;
            
            panel1.Controls.Add(isciveriler);
            isciveriler.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formbaslagici();
            Form1 puant = new Form1();
            puant.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }       

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            btnbk(button5);
        }  

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            btnleavebk(button5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formbaslagici();
            iscikayit saveworker = new iscikayit();
            saveworker.Show();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            formbaslagici();
            musteriislemleri musteriler = new musteriislemleri();
            musteriler.Show();
            this.Visible = false;
        }

        private void mainmenu_Load(object sender, EventArgs e)
        {
           // renklerone();
            renklertwo();
            //renklerthree();
            //renklerfour();
           
            timer1.Enabled = false;
        }
        int a = 0;
        int kl = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((DateTime.Now.Second % 5 == 0))
            {
                panel1.Controls.Remove(pictureBox1);
                panellogo.Controls.Remove(pictureBox2);
                panellogo.Controls.Add(pictureBox1);
            }
            else
            {
                
                panellogo.Controls.Remove(pictureBox1);
                panellogo.Controls.Add(pictureBox2);
            }

              
            if (timer1.Enabled==true)
            {
                a++;
               
                if (a < 20)
                {
                    renklerone();
                }
                if (a > 20)
                {
                    renklertwo();
                }if (a > 40)
                {
                    renklerthree();
                }if (a > 60)
                {
                    renklerfour();
                }
                if (a > 80)
                {
                    a = 0;
                }

            }
            
          
               
            
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/dev.emka");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/dev.emka");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            stoktakip newsdf = new stoktakip();
            newsdf.Show();
            this.Hide();
        }
    }
}
