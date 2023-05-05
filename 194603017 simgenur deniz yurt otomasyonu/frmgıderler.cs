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
    public partial class frmgıderler : Form
    {
        public frmgıderler()
        {
            InitializeComponent();
        }
        sqlcnn bgl = new sqlcnn();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmgıderler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_194603017DataSet5.gıderler' table. You can move, or remove it, as needed.
            this.gıderlerTableAdapter.Fill(this._194603017DataSet5.gıderler);

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into gıderler(elektırık, dogalgaz,su ,mutfak , temızlık, personel " +
                ",tadılat, dıger_odemeler)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglantıı());
                komut.Parameters.AddWithValue("@p1", txtelektırık.Text);
                komut.Parameters.AddWithValue("@p2", txtgaz.Text);
                komut.Parameters.AddWithValue("@p3", txtsu.Text);
                komut.Parameters.AddWithValue("@p4", txtmutfak.Text);
                komut.Parameters.AddWithValue("@p5", txttemizlik.Text);
                komut.Parameters.AddWithValue("@p6", txtpersonel.Text);
                komut.Parameters.AddWithValue("@p7", txttadılat.Text);
                komut.Parameters.AddWithValue("@p8", txtd_odeme.Text);
                komut.ExecuteNonQuery();
                bgl.baglantıı().Close();
                MessageBox.Show("kayıt basarılı");
            }
            catch (Exception)
            {

                MessageBox.Show("kayıt yapılamadı");
            }
            
        }
      
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("update bolumler set elektırık = @p1,dogalgaz = @p2, su= @p3, " +
                "mutfak= p@4, temızlık = @p5, personel= @p6, tadılat= @p7, dıger_odemeler = @p8", bgl.baglantıı());
            komut3.Parameters.AddWithValue("@p1", txtelektırık.Text);
            komut3.Parameters.AddWithValue("@p2", txtgaz.Text);
            komut3.Parameters.AddWithValue("@p3", txtsu.Text);
            komut3.Parameters.AddWithValue("@p4", txtmutfak.Text);
            komut3.Parameters.AddWithValue("@p5", txttemizlik.Text);
            komut3.Parameters.AddWithValue("@p6", txtpersonel.Text);
            komut3.Parameters.AddWithValue("@p7", txttadılat.Text);
            komut3.Parameters.AddWithValue("@p8", txtd_odeme.Text);

            komut3.ExecuteNonQuery();
            bgl.baglantıı().Close();
        }
        int secılen;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string el, d, s, m, te, p, ta, dı;
               
            secılen = dataGridView1.SelectedCells[0].RowIndex;
            el = dataGridView1.Rows[secılen].Cells[0].Value.ToString();
            d = dataGridView1.Rows[secılen].Cells[1].Value.ToString();
           s = dataGridView1.Rows[secılen].Cells[2].Value.ToString();
            m= dataGridView1.Rows[secılen].Cells[3].Value.ToString();
            te = dataGridView1.Rows[secılen].Cells[4].Value.ToString();
            p = dataGridView1.Rows[secılen].Cells[5].Value.ToString();
            ta = dataGridView1.Rows[secılen].Cells[6].Value.ToString();
            dı= dataGridView1.Rows[secılen].Cells[7].Value.ToString();

            txtelektırık.Text = el;
            txtgaz.Text = d;
            txtsu.Text = s;
            txtmutfak.Text = m;
            txttemizlik.Text = te;
            txtpersonel.Text = p;
            txttadılat.Text = ta;
            txtd_odeme.Text = dı;


        }
    }
}
