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
    public partial class isciverileri : Form
    {
        public isciverileri()
        {
            InitializeComponent();
        }
        SqlConnection bg = new SqlConnection("Data Source=DESKTOP-ILFSL21\\MEHMETSERVER;Initial Catalog=isyeriverileri;Integrated Security=True");

        void Showme()
        {
            bg.Open();
            SqlCommand sqlCommand = new SqlCommand("Select *from isciverileri", bg);
            SqlDataReader oku = sqlCommand.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem list = new ListViewItem();
                list.Text = oku[0].ToString().Trim();
                list.SubItems.Add(oku[1].ToString().Trim());
                list.SubItems.Add(oku[2].ToString().Trim());
                list.SubItems.Add(oku[3].ToString().Trim());
                list.SubItems.Add(oku[4].ToString().Trim());
                list.SubItems.Add(oku[5].ToString().Trim());

                listView1.Items.Add(list);

            }
            bg.Close();
        }

        private void isciverileri_Load(object sender, EventArgs e)
        {
            Showme();
        }
    }
}
