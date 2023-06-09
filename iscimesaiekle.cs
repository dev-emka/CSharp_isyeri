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
    public partial class iscimesaiekle : Form
    {
        string no;
        public iscimesaiekle()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-ILFSL21\\MEHMETSERVER;Initial Catalog=isyeriverileri;Integrated Security=True");

        private void verilerimigöster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From isciverileri", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                
                comboBox1.Items.Add(oku[0].ToString().Trim());
                
                
                
            }
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            if ( cmgiris.Text != "" && cmcikis.Text != "")
            {
                checkcalisti.Checked = true;
                
                

                SqlCommand kmt = new SqlCommand("insert into puantorluk (no,isim,soyisim,tarih,girissaat,cikissaat,geldimi) values('" +listView1.Items[0].Text.ToString()+"','"+listView1.Items[0].SubItems[1].Text.ToString()+"','"+
                    listView1.Items[0].SubItems[2].Text.ToString()+"','"+ txtarih.Text.ToString() + "','" + cmgiris.Text.ToString() + "','" + cmcikis.Text.ToString() +"','"+"Evet"+ "')", baglan);
                kmt.ExecuteNonQuery();
                this.Close();
            }
            baglan.Close();
            
        }

        private void iscimesaiekle_Load(object sender, EventArgs e)
        {

           
            verilerimigöster();
            txtarih.Text = UserControldays.static_days+"/"+Form1.ay.ToString()+"/"+Form1.yıl.ToString();
            
        }
        
        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        string id;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            id = comboBox1.SelectedItem.ToString();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from isciverileri where no like'" +id.ToString()+ "'", baglan);

            SqlDataReader oku = komut.ExecuteReader();
            
            while (oku.Read())
            {
                ListViewItem listeler = new ListViewItem();
                listeler.Text = oku[0].ToString().Trim();
                listeler.SubItems.Add(oku[1].ToString().Trim());
                listeler.SubItems.Add(oku[2].ToString().Trim());
                listeler.SubItems.Add(oku[3].ToString().Trim());
                listeler.SubItems.Add(oku[4].ToString().Trim());
                listView1.Items.Add(listeler);
            }
            
            baglan.Close();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
