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

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void btnUyeForm_Click(object sender, EventArgs e)
        {
            SingUp singUp = new SingUp();
            singUp.Show();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-OD8JBL6\SQLEXPRESS;Initial Catalog=SU_Project;Integrated Security=True");

        private void btnGrisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            //string giris = "select KullaniciAdi,Sifre From Tbl_Uyeler_Kelime where KullaniciAdi= @p1 and Sifre= @p2";
             string giris = "select Id From Tbl_Uyeler_Kelime where KullaniciAdi= @p1 and Sifre= @p2";

            SqlCommand komut = new SqlCommand(giris, baglanti);
            komut.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", txtPass.Text);
            //  komut.ExecuteScalar();
            object sonuc = komut.ExecuteScalar();
           // SqlDataReader dr = komut.ExecuteScalar();
            //if (dr.Read())
            if(sonuc != null)
            {
                int uyeId = Convert.ToInt32(sonuc);
                MessageBox.Show("Giriş başarılı ID: " + uyeId);
                //MessageBox.Show("giriş başarili");
                Form1 frm1 = new Form1(uyeId);
                frm1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Böyle bir Kullanıcı yok");
            }

            baglanti.Close();
        }
    }
}
