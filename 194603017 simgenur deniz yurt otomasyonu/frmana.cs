using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _194603017_yurtotomasyon
{
    public partial class frmana : Form
    {
        public frmana()
        {
            InitializeComponent();
        }

        private void frmana_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_194603017DataSet1.ogrencı' table. You can move, or remove it, as needed.
            this.ogrencıTableAdapter.Fill(this._194603017DataSet1.ogrencı);

        }

        private void öGRENCİEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }

        private void bÖLÜMLERToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbolumler fr = new frmbolumler();
            fr.Show();
        }

        private void ödemeİşlemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmodemeler fr = new frmodemeler();
            fr.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgıderler fr = new frmgıderler();
            fr.Show();
        }

        private void giderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgıderlistesi fr = new frmgıderlistesi();
            fr.Show();
        }

        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_personel fr = new frm_personel();
            fr.Show();
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmogrencılısteleme fr = new frmogrencılısteleme();
            fr.Show();
        }

        private void personelListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmpersonellıstesı fr = new frmpersonellıstesı();
            fr.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
