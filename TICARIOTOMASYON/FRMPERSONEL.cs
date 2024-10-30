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
namespace TICARIOTOMASYON
{
    public partial class FRMPERSONEL : Form
    {
        sqlbaglantisi sql = new sqlbaglantisi();
        void connect()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select* from TBL_PERSONELLER",
            sql.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        public FRMPERSONEL()
        {
            InitializeComponent();
            connect();
        }
        
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kaydet = new SqlCommand("insert TBL_PERSONELLER values (@1,@2,@3,@4,@5,@6,@7,@8,@9)", sql.baglanti());
            kaydet.Parameters.AddWithValue("@1", adtext.Text);
            kaydet.Parameters.AddWithValue("@2", soytxt.Text);
            kaydet.Parameters.AddWithValue("@9", teltext.Text);
            kaydet.Parameters.AddWithValue("@3", tctext.Text);
            kaydet.Parameters.AddWithValue("@4", txtmail.Text);
            kaydet.Parameters.AddWithValue("@5", iltxt.Text);
            kaydet.Parameters.AddWithValue("@6", ilcetxt.Text);
            kaydet.Parameters.AddWithValue("@7", adrestxt.Text);
            kaydet.Parameters.AddWithValue("@8", gorevtxt.Text);
            kaydet.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("eklendi");
            connect();
 
        }
    }
}
