using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace takvim
{
    public partial class UserControldays : UserControl
    {
        public static string static_days;
        public UserControldays()
        {
            InitializeComponent();
        }

        private void UserControldays_Load(object sender, EventArgs e)
        {
            
        }
        public void days(int numday)
        {
            label1.Text = numday + "";
        }

        private void UserControldays_Click(object sender, EventArgs e)
        {
            static_days = label1.Text;
            iscimesaiekle iscimesaiekle = new iscimesaiekle();
            iscimesaiekle.Show();
        }

        private void UserControldays_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.PaleTurquoise;
           
            

            label1.Dock = DockStyle.Fill;
        }

        private void UserControldays_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
