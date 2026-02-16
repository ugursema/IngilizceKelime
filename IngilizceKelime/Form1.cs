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

namespace IngilizceKelime
{
    public partial class Form1 : Form
    {
        int aktifUyeId; // login yapan kullanıcının Id’si

        public Form1(int gelenUyeId)
        {
            InitializeComponent();
            aktifUyeId = gelenUyeId;
        }
        
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-OD8JBL6\SQLEXPRESS;Initial Catalog=SU_Project;Integrated Security=True");

        Random rastgele = new Random();
        int sure = 90;

        int kelime = 0;

        int pas = 0;



        private void Form1_Load(object sender, EventArgs e)
        {
          
            IngKelime();
            timer1.Start();
        }

        private void IngKelime()
        {

            int sayi;
            sayi = rastgele.Next(1, 2490);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("  SELECT * FROM kelimeler where id=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            SqlDataReader dr = komut.ExecuteReader();

           while(dr.Read())
            {
                txtIng.Text = dr[1].ToString();
                lblCevap.Text = dr[2].ToString();
                lblCevap.Text = lblCevap.Text.ToLower();
            }
            baglanti.Close();
        }

        private void txtTurkce_TextChanged(object sender, EventArgs e)
        {
            if(txtTurkce.Text == lblCevap.Text)
            {
                kelime++;
                lblKelime.Text = kelime.ToString();
                IngKelime();
                txtTurkce.Clear();
            }
            else if (txtTurkce.Text == lblPas.Text)
            {
                pas++;
                LabelPas.Text = pas.ToString();
                IngKelime();
                txtTurkce.Clear();


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();
            if(sure == 0)
            {
                txtTurkce.Enabled = false;
                txtIng.Enabled = false;
                timer1.Stop();
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("INSERT INTO Tbl_Skor_Kelime (Skor, UyeId) VALUES(@Skor, @UyeId)",baglanti);
                komut1.Parameters.AddWithValue("@Skor", kelime);
                komut1.Parameters.AddWithValue("UyeId", aktifUyeId);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Skor kaydedildi: " + kelime ,"Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmScore score = new FrmScore();
            score.Show();
        }
    }
}
