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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankamatikSimulation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-BC3LOP2\SQLEXPRESS01;Initial Catalog=DbBankaTest;Integrated Security=True;Connect Timeout=30;");

        public string hesap;
        private void Form2_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            lblHesapNo.Text = hesap;
            bgl.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLKISILER WHERE HESAPNO=@P1",bgl);
            komut.Parameters.AddWithValue("@p1", hesap);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[1] + " " + dr[2];
                lblKimlik.Text = dr[3].ToString();
                lblTelefon.Text = dr[4].ToString();
                lblHesapNo .Text = dr[5].ToString();
            }
            bgl.Close();
            gonderilen();
            gelen();
            bakiye();
            tarih();

            cmbliste();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                Size = new Size(347, 387);
                radioButton1.Checked = false;
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Size = new Size(828, 387);
                radioButton2.Checked = false;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                gonderilen();
                gelen();
            }
        }

        void cmbliste()
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("SELECT HESAPNO FROM TBLKISILER", bgl);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "HESAPNO";
            comboBox1.DataSource = dt;
            bgl.Close();
        }
        void gondermeislemi()
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("UPDATE TBLHESAP SET BAKIYE+=@P1 WHERE HESAPNO=@P2",bgl);
            cmd.Parameters.AddWithValue("@P1", decimal.Parse(TxtTutar .Text));
            cmd.Parameters.AddWithValue("@P2", comboBox1.Text);
            cmd.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Tutar başarıyla havale edildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void azalmaislemi()
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("UPDATE TBLHESAP SET BAKIYE-=@P1 WHERE HESAPNO=@P2", bgl);
            cmd.Parameters.AddWithValue("@P1", decimal.Parse(TxtTutar.Text));
            cmd.Parameters.AddWithValue("@P2",lblHesapNo .Text);
            cmd.ExecuteNonQuery();
            bgl.Close();
        }
        void tarih()
        {
            DateTime dt = DateTime.Now;
            lblTarih .Text = dt.ToString();
        }
        void hareketpaneli()
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBLHAREKET (GONDEREN,ALICI,TUTAR,TARIH) VALUES (@P1,@P2,@P3,@P4)",bgl);
            cmd.Parameters.AddWithValue("@P1", lblHesapNo.Text);
            cmd.Parameters.AddWithValue("@P2", comboBox1.Text);
            cmd.Parameters.AddWithValue("@P3", TxtTutar.Text);
            cmd.Parameters.AddWithValue("@P4", Convert.ToDateTime(lblTarih.Text));
            cmd.ExecuteNonQuery();
            bgl.Close();
        }
        private void btnHavalegönder_Click(object sender, EventArgs e)
        {

            gondermeislemi();
            azalmaislemi();
            hareketpaneli();
            gonderilen();
            gelen();
            bakiye();
        }
        void bakiye()
        {
            decimal deger;
            SqlCommand cmd = new SqlCommand("EXECUTE BAKIYE @DEGER=@P1", bgl);
            cmd.Parameters.AddWithValue("@P1", hesap);
            bgl.Open();
            deger = (decimal)cmd.ExecuteScalar();
            bgl.Close();
            lblBakiye.Text = deger.ToString();
        }
        void gonderilen()
        {
            SqlCommand cmd = new SqlCommand("execute GONDERILEN @DEGER=@P1", bgl);
            cmd.Parameters.AddWithValue("@P1", hesap);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void gelen()
        {
            SqlCommand cmd = new SqlCommand("execute ALICI @DEGER=@P1", bgl);
            cmd.Parameters.AddWithValue("@P1", hesap);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
    }
}
