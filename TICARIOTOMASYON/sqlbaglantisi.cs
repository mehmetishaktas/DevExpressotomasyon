using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace TICARIOTOMASYON
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-4BD7KS9\MSSQL;Initial Catalog=dbootomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
