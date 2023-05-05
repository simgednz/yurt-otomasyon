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
    public partial class frmpersonellıstesı : Form
    {
        public frmpersonellıstesı()
        {
            InitializeComponent();
        }

        private void frmpersonellıstesı_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_194603017DataSet11.personell' table. You can move, or remove it, as needed.
            this.personellTableAdapter.Fill(this._194603017DataSet11.personell);

        }
    }
}
