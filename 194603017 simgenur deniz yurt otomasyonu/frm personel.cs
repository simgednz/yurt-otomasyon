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
    public partial class frm_personel : Form
    {
        public frm_personel()
        {
            InitializeComponent();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }
        sqlcnn bgl = new sqlcnn();
        private void frm_personel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_194603017DataSet10.personell' table. You can move, or remove it, as needed.
            this.personellTableAdapter.Fill(this._194603017DataSet10.personell);

        }



        private void btnkaydet_Click(object sender, EventArgs e)
        {
            
                SqlCommand komut = new SqlCommand("insert into personell (personel_Ad ,personel_departman) values" +
                    " (@p1,@p2,@p3)",bgl.baglantıı());
                komut.Parameters.AddWithValue("@p1", txtad.Text);
                komut.Parameters.AddWithValue("@p2", txtgorev.Text);
                komut.ExecuteNonQuery();
                bgl.baglantıı().Close();
                MessageBox.Show("kayıt eklendı");
             
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("delete from personell where personel_ıd =@p1,", bgl.baglantıı());
            komut1.Parameters.AddWithValue("@p1", txtıd.Text);
            komut1.ExecuteNonQuery();
            bgl.baglantıı().Close();
            MessageBox.Show("kayıt sılındı");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut5 = new SqlCommand("update personell set personel_Ad =@p1, personel_departman =@p2 where" +
                " personel_ıd=@p3",bgl.baglantıı());
            komut5.Parameters.AddWithValue("@p1", txtad.Text);
            komut5.Parameters.AddWithValue("@p2", txtgorev.Text);
            komut5.Parameters.AddWithValue("@p3", txtıd.Text);
            komut5.ExecuteNonQuery();
            bgl.baglantıı().Close();
            MessageBox.Show("guncelleme yapıldı");
        }
    }
}
