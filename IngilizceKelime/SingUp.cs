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

namespace IngilizceKelime
{
    public partial class SingUp : Form
    {
        public SingUp()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-OD8JBL6\SQLEXPRESS;Initial Catalog=SU_Project;Integrated Security=True");

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            try
            { 
            string sorgu = "INSERT INTO Tbl_Uyeler_Kelime (Ad,Soyad, KullaniciAdi,Sifre) values (@p1,@p2,@p3,@p4)";
            SqlCommand komut = new SqlCommand(sorgu,baglanti);
            baglanti.Open(); 
            komut.Parameters.AddWithValue("@p1",txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p4", txtPassword.Text);

            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Okeys","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

               this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("hata" + ex.Message);
            }
        }
    }
}
