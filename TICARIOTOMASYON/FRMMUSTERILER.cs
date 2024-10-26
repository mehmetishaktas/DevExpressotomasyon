using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;

namespace TICARIOTOMASYON
{
    public partial class FRMMUSTERILER : Form
    {
        sqlbaglantisi sql = new sqlbaglantisi();
        void conenct()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select* from TBL_MUSTERILER",
            sql.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        public FRMMUSTERILER()
        {
            InitializeComponent();
            conenct();
        }
        
            

        private void FRMMUSTERILER_Load(object sender, EventArgs e)
        {
            

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            //veri ekle 
            SqlCommand ekle = new SqlCommand("insert TBL_MUSTERILER values (@2,@3,@4,@5,@6,@7,@8,@9,@10)", sql.baglanti());
          //  ekle.Parameters.AddWithValue("@1", idtext.Text);
            ekle.Parameters.AddWithValue("@2", adtext.Text);
            ekle.Parameters.AddWithValue("@3", soytxt.Text);
            ekle.Parameters.AddWithValue("@4", teltext.Text);
            ekle.Parameters.AddWithValue("@5", tctext.Text);
            ekle.Parameters.AddWithValue("@6", txtmail.Text);
            ekle.Parameters.AddWithValue("@7", iltxt.Text);
            ekle.Parameters.AddWithValue("@8", İilcetxt.Text);
            ekle.Parameters.AddWithValue("@9", adrestxt.Text);
            ekle.Parameters.AddWithValue("@10",vergitxt.Text);
            ekle.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("ürün eklendi");
            conenct();
        }
    }
}
