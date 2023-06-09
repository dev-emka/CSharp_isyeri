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
    public partial class iscikayit : Form
    {
        public iscikayit()
        {
            InitializeComponent();
        }
        int no;
        SqlConnection bg = new SqlConnection("Data Source=DESKTOP-ILFSL21\\MEHMETSERVER;Initial Catalog=isyeriverileri;Integrated Security=True");
        void verilerioku()
        {
            bg.Open();
            SqlCommand kmtt = new SqlCommand("Select *from isciverileri", bg);
            SqlDataReader oko = kmtt.ExecuteReader();

            while (oko.Read())
            {
               ListViewItem list=new ListViewItem();
                list.Text = oko[0].ToString();
                no = Convert.ToInt32(list);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iscikayit_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrEmpty(textBox5.Text) || String.IsNullOrEmpty(textBox6.Text) || String.IsNullOrEmpty(textBox7.Text) || String.IsNullOrEmpty(textBox8.Text))
            {
                MessageBox.Show("Tüm Alanları Doldurunuz");
            }
            else
            {
                bg.Open();
                SqlCommand kmt = new SqlCommand("Insert into isciverileri (no,adsoyad,TCkimklikno,meslek,dogumtarihi,maas) Values ('" + "6".ToString() + "','" + textBox1.Text.ToString().Trim() + "','" + textBox2.Text.ToString().Trim() + "','" + textBox3.Text.ToString() + "','" + textBox6.Text.ToString().Trim() + "/" + textBox7.Text.ToString().Trim() + "/" + textBox8.Text.ToString().Trim() + "','" + textBox4.Text.ToString().Trim() + "')", bg);
                kmt.ExecuteNonQuery();
                bg.Close();
                MessageBox.Show("Yeni İşçi Kayıtı Başarılı Bir Şekilde Oluşturuldu");
            }
        }
 
        private void button2_Click(object sender, EventArgs e)
        {
            mainmenu anacenter = new mainmenu();
            anacenter.Show();
            this.Close();
        }
    }
}
