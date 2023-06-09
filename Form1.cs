using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace takvim
{
    
    public partial class Form1 : Form
    {
        int year, month;
        
        public static int yıl, ay;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displaDays();
        }

        private void displaDays()
        {
            DateTime now = DateTime.Now;
            year = now.Year;
            month = now.Month;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthname + " " + year;
            yıl = year;
            ay = month;

            DateTime ayinbaslangici = new DateTime(year,month, 1);

            int days = DateTime.DaysInMonth(year,month);

            int dayoftheweek = Convert.ToInt32(ayinbaslangici.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlblank uchblank = new UserControlblank();
                flowLayoutPanel1.Controls.Add(uchblank);
            }
            for (int i = 1; i <= days; i++)
            {     
                    UserControldays ucdays = new UserControldays();
                    ucdays.days(i);
                    flowLayoutPanel1.Controls.Add(ucdays);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainmenu back = new mainmenu();
            back.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            month--;
            yıl = year;
            ay = month;
            if (month < 1)
            {
                year -= 1;
                month = 12;
            }

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthname + " " + year;

            DateTime now = DateTime.Now;

            DateTime ayinbaslangici = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(ayinbaslangici.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlblank uchblank = new UserControlblank();
                flowLayoutPanel1.Controls.Add(uchblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControldays ucdays = new UserControldays();
                ucdays.days(i);
                
                flowLayoutPanel1.Controls.Add(ucdays);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            month++;
            yıl = year;
            ay = month;
            if (month > 12)
            {
                year += 1;
                month = 1;
            }

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthname + " " + year;

            DateTime now = DateTime.Now;

            DateTime ayinbaslangici = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(ayinbaslangici.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlblank uchblank = new UserControlblank();
                flowLayoutPanel1.Controls.Add(uchblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControldays ucdays = new UserControldays();
                ucdays.days(i);
                flowLayoutPanel1.Controls.Add(ucdays);
            }
        }
    }
}
