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
using System.Data.Common;

namespace TICARIOTOMASYON
{
    public partial class FRMFATURALAR : Form
    {
        public FRMFATURALAR()
        {
            InitializeComponent();
            listele();
            listelebilgi();
        }

        sqlbaglantisi sql = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter("select * from TBL_FATURABILGI", sql.baglanti());
            data.Fill(dt);
            gridControl1.DataSource = dt;        
        }
        void listelebilgi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter("select * from TBL_FATURADETAY", sql.baglanti());
            data.Fill(dt);
            gridControl2.DataSource = dt;
        }


        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into TBL_FATURABILGI values()", sql.baglanti();
        }
    }
}
