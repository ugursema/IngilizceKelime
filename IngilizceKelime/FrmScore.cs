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
    public partial class FrmScore : Form
    {
        public FrmScore()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-OD8JBL6\SQLEXPRESS;Initial Catalog=SU_Project;Integrated Security=True");

        private void Score()
        {
            baglanti.Open();
            string sorgu= "SELECT Skor,KullaniciAdi,Ad + '' + Soyad as AdSoyad from Tbl_Skor_Kelime sk Inner join Tbl_Uyeler_Kelime uk ON uk.Id = sk.UyeId";

            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt); //dt icine verileri sıgdır
            dataGridView1.DataSource = dt;



        }

        private void FrmScore_Load(object sender, EventArgs e)
        {
            Score();
        }
    }
}
