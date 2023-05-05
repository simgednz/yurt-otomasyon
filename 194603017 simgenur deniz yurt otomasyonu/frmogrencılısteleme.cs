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
    public partial class frmogrencılısteleme : Form
    {
        public frmogrencılısteleme()
        {
            InitializeComponent();
        }

        private void frmogrencılısteleme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_194603017DataSet3.ogrencı' table. You can move, or remove it, as needed.
            this.ogrencıTableAdapter.Fill(this._194603017DataSet3.ogrencı);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
