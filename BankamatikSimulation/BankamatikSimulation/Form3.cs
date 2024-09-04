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

namespace BankamatikSimulation
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-BC3LOP2\SQLEXPRESS01;Initial Catalog=DbBankaTest;Integrated Security=True;Connect Timeout=30;");    
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into TBLKISILER (AD,SOYAD,TC,TELEFON,HESAPNO,SIFRE) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl );
            sqlCommand.Parameters.AddWithValue("@p1", txtAd.Text) ;
            sqlCommand.Parameters.AddWithValue("@p2",txtSoyAd .Text);
            sqlCommand.Parameters.AddWithValue("@p3", mskTc .Text);
            sqlCommand.Parameters.AddWithValue("@p4", mskTelefon.Text);
            sqlCommand.Parameters.AddWithValue("@p5", mskHesapNo.Text);
            sqlCommand.Parameters.AddWithValue("@p6", txtSifre.Text);
            sqlCommand.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Kayıt tamamlandı");


        }

        private void btnRand_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(100000, 1000000);
            mskHesapNo.Text = sayi.ToString();

        }
    }
}
