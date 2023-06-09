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
    public partial class musteriislemleri : Form
    {
        public musteriislemleri()
        {
            InitializeComponent();
        }
        SqlConnection bfg = new SqlConnection("Data Source=DESKTOP-ILFSL21\\MEHMETSERVER;Initial Catalog=isyeriverileri;Integrated Security=True");
        void goster()
        {
            bfg.Open();
            SqlCommand kmt = new SqlCommand("Select *from musteriverileri",bfg);
            SqlDataReader read = kmt.ExecuteReader();

            while (read.Read())
            {
                ListViewItem list = new ListViewItem();
                list.Text = read[0].ToString();
                list.SubItems.Add(read[1].ToString());
                list.SubItems.Add(read[2].ToString());
                list.SubItems.Add(read[3].ToString());

                listView1.Items.Add(list);
            }
            bfg.Close();
        }
        private void musteriislemleri_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Tüm Alanları Doldurunuz");
            }
            else { 
                 bfg.Open();
                 SqlCommand kmt = new SqlCommand("Insert into musteriverileri (adsoyad,TelefonNo,AdresBilgileri,EpostaHesabi) Values ('" +  textBox1.Text.ToString().Trim() + "','" + textBox2.Text.ToString().Trim() +  "','" + textBox4.Text.ToString().Trim() + "','" + textBox3.Text.ToString() + "')", bfg);
                 kmt.ExecuteNonQuery();
                bfg.Close();
                MessageBox.Show("Müşteri Başarılı Bir Şekilde Kaydedildi");
                panel1.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                MessageBox.Show("Müşteri Kayıt Ekranı Açık!!!");
            }
            else
            {
                goster();
            }
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainmenu newmenu = new mainmenu();
            newmenu.Show();
            this.Close();
        }
    }
}
