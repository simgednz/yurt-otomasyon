using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _194603017_yurtotomasyon
{
    public class sqlcnn
    {
        public SqlConnection baglantıı()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=.;Initial Catalog=194603017;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
    
