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

namespace _194603017_yurtotomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        sqlcnn bgl = new sqlcnn();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("select  bolum_adı from bolumler", bgl.baglantıı());
            SqlDataReader oku = komut.ExecuteReader(); 
            while (oku.Read())
            {
                cmbbolum.Items.Add(oku[0].ToString());
            }
            bgl.baglantıı().Close();

            
            SqlCommand komut2 = new SqlCommand("select oda_no from odalarr where oda_kapasıte != oda_aktıf ", bgl.baglantıı());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmboda.Items.Add(oku2[0].ToString());
            }
            bgl.baglantıı().Close();

            
            SqlCommand komut3 = new SqlCommand("select sınıflar from sınıflarr  ", bgl.baglantıı());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
               cmbsınıf.Items.Add(oku3[0].ToString());
            }
            bgl.baglantıı().Close();

        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand ogrencıkaydet = new SqlCommand("insert into ogrencı (ogrencı_Adı, ogrencı_soyadı, ogrencı_tc, ogrencı_odano," +
                    " ogrencı_tel ,ogrencı_bolum, ogrencı_sınıf, ogrencı_aıletel, ogrencı_aıleadı," +
                    " ogr_aıleadres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglantıı());

                ogrencıkaydet.Parameters.AddWithValue("@p1", txtad.Text);
                ogrencıkaydet.Parameters.AddWithValue("@p2", txtsoyad.Text);
                ogrencıkaydet.Parameters.AddWithValue("@p3", txttc.Text);
                ogrencıkaydet.Parameters.AddWithValue("@p4", cmboda.Text);
                ogrencıkaydet.Parameters.AddWithValue("@p5", txttel.Text);
                ogrencıkaydet.Parameters.AddWithValue("@p6", cmbbolum.Text);
                ogrencıkaydet.Parameters.AddWithValue("@p7", cmbsınıf.Text);
                ogrencıkaydet.Parameters.AddWithValue("@p8", txtvelıtel.Text);
                ogrencıkaydet.Parameters.AddWithValue("@p9", txtvelıad.Text);
                ogrencıkaydet.Parameters.AddWithValue("@p10", rchadres.Text);
                ogrencıkaydet.ExecuteNonQuery();
                bgl.baglantıı().Close();
                MessageBox.Show("kayıt yapıldı");

                
                SqlCommand komut = new SqlCommand("select ogrencı_ıd from ogrencı",bgl.baglantıı());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label11.Text = oku[0].ToString();  
                }  
                   bgl.baglantıı().Close();

                SqlCommand komutkaydet2 = new SqlCommand(" insert into odemeler ( ogrencı_ıd ,ogrencı_adı, ogencı_soyadı) " +
                    "values (@s1,@s2,@s3)",bgl.baglantıı());
                komutkaydet2.Parameters.AddWithValue("@s1", label1.Text);
                komutkaydet2.Parameters.AddWithValue("@s2", txtad.Text);
                komutkaydet2.Parameters.AddWithValue("@s3", txtsoyad.Text);
                komutkaydet2.ExecuteNonQuery();
                bgl.baglantıı().Close();
            }
            catch (Exception)
            {

                MessageBox.Show("kayıt yapılamadı");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbsınıf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbbolum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
} 
 