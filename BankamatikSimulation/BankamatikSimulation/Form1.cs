using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankamatikSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-BC3LOP2\SQLEXPRESS01;Initial Catalog=DbBankaTest;Integrated Security=True;Connect Timeout=30;");

        private void btn_giriş_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * From TBLKISILER WHERE HESAPNO=@P1 AND SIFRE=@P2", bgl);
            sqlCommand.Parameters.AddWithValue("@p1", mskHesap.Text);
            sqlCommand.Parameters.AddWithValue("@p2",txtŞifre.Text);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            if(dr.Read())
            {
                Form2 fr = new Form2();
                fr.hesap = mskHesap.Text;   
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatalı bilgi");
                
            }
            bgl.Close();
        }

        private void lnkKayıtOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
