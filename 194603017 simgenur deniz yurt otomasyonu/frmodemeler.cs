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
    public partial class frmodemeler : Form
    {
        public frmodemeler()
        {
            InitializeComponent();
        }
        sqlcnn bgl = new sqlcnn();
        private void frmodemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_194603017DataSet2.odemeler' table. You can move, or remove it, as needed.
            this.odemelerTableAdapter.Fill(this._194603017DataSet2.odemeler);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secılen;
            string ogr_ıd,  kalan;
            secılen = dataGridView1.SelectedCells[0].RowIndex;
            ogr_ıd = dataGridView1.Rows[secılen].Cells[0].Value.ToString();
            kalan = dataGridView1.Rows[secılen].Cells[3].Value.ToString();

            txtogr_ıd.Text = ogr_ıd;
              txtkalan.Text = kalan;
        }

        private void btnodemeal_Click(object sender, EventArgs e)
        {
            int odenen, kalan, sonhalı;
            odenen = Convert.ToInt32(txtodenen.Text);
            kalan = Convert.ToInt32(txtkalan.Text);
            sonhalı = kalan - odenen;
            txtkalan.Text = sonhalı.ToString();
            SqlCommand komut = new SqlCommand("update odemeler set @p1= ogrencı_borc where ogrencı_ıd=@p2",bgl.baglantıı());
            komut.Parameters.AddWithValue("@p2", txtogr_ıd.Text);
            komut.Parameters.AddWithValue("@p1",txtkalan.Text);
            komut.ExecuteNonQuery();
            bgl.baglantıı().Close();
            MessageBox.Show("borc odendı");
        }
    }
}
