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
namespace takvim
{
    public partial class stoktakip : Form
    {
        public stoktakip()
        {
            InitializeComponent();
        }
        SqlConnection bg = new SqlConnection("Data Source=DESKTOP-ILFSL21\\MEHMETSERVER;Initial Catalog=isyeriverileri;Integrated Security=True");
        public void goster()
        {
            bg.Open();
            SqlCommand kmt = new SqlCommand("Select *from depoverileri", bg);
            SqlDataReader oku = kmt.ExecuteReader();

            while (oku.Read())
            {
                chart1.Series.Add(oku[0].ToString());
                
                
               
                
                
            }
            bg.Close();
        }
        
        private void stoktakip_Load(object sender, EventArgs e)
        {
            goster();

           
            
        }
    }
}
