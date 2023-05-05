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
    public partial class frmbolumler : Form
    {
        public frmbolumler()
        {
            InitializeComponent();
        }
        sqlcnn bgl = new sqlcnn();
        
       
        private void frmbolumler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_194603017DataSet.bolumler' table. You can move, or remove it, as needed.
            this.bolumlerTableAdapter.Fill(this._194603017DataSet.bolumler);

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            { 
                SqlCommand komut1 = new SqlCommand("insert into bolumler (bolum_adı) values (@p1)",bgl.baglantıı ());
                komut1.Parameters.AddWithValue("@p1", txtbolumadı.Text);
                komut1.ExecuteNonQuery();
                bgl.baglantıı().Close();
                MessageBox.Show("kayıt yapıldı");
            }
            catch (Exception)
            {

                MessageBox.Show("tekrar deneyınız");
            }
            
        }

        private void btnsıl_Click(object sender, EventArgs e)
        {
            
            try
            {
              
                SqlCommand komut2 = new SqlCommand("delete from bolumler where bolum_ıd = @p1", bgl.baglantıı());
                komut2.Parameters.AddWithValue("@p1", txtbolumıd.Text);
                komut2.ExecuteNonQuery();
                bgl.baglantıı(). Close();
                MessageBox.Show("kayıt silindi");
            }
            catch (Exception)
            {

                MessageBox.Show("silme işlemi basarısız");
            }
            

        }
        int secılen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string x, y;
            secılen = dataGridView1.SelectedCells[0].RowIndex;
            x = dataGridView1.Rows[secılen].Cells[0].Value.ToString();
            y = dataGridView1.Rows[secılen].Cells[1].Value.ToString();

             txtbolumıd.Text = x;
            txtbolumadı.Text =y;

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut3 = new SqlCommand("update bolumler set bolum_adı =@p1 where bolum_ıd=@p2", bgl.baglantıı());
                komut3.Parameters.AddWithValue("@p1", txtbolumadı.Text);
                komut3.Parameters.AddWithValue("@p2", txtbolumıd.Text);
                komut3.ExecuteNonQuery();
              bgl.baglantıı().Close();
                MessageBox.Show("kayıt güncellendı");
                bgl.baglantıı().Close();
            }
            catch (Exception)
            {

                MessageBox.Show("guncelleme basarısız");
            }
            
        }

        private void txtbolumıd_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 
