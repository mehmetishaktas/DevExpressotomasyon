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
    public partial class FRMGIDERLER : Form
    {
        sqlbaglantisi sql = new sqlbaglantisi();
        public FRMGIDERLER()
        {
            InitializeComponent();
            listele();
        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT  *, (select sum(ELEKTRIK+SU+DOGALGAZ+INTERNET+MAASLAR+EKSTRA) from TBL_GIDERLER)as toplam FROM TBL_GIDERLER", sql.baglanti());
            dataAdapter.Fill(dt);   
            gridControl1.DataSource = dt;  
        }

        private void FRMGIDERLER_Load(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kayıt=new SqlCommand("insert TBL_GIDERLER values (@1,@2,@3,@4,@5,@6,@7,@8,@9)", sql.baglanti());
            kayıt.Parameters.AddWithValue("@1", elektriktxt.Text);
            kayıt.Parameters.AddWithValue("@2", sutxt.Text);
            kayıt.Parameters.AddWithValue("@3", dogalgaztxt.Text);
            kayıt.Parameters.AddWithValue("@4", internettxt.Text);
            kayıt.Parameters.AddWithValue("@5", maaslartxt.Text);
            kayıt.Parameters.AddWithValue("@6", ekstratxt.Text);
            kayıt.Parameters.AddWithValue("@7", notlartxt.Text);
            kayıt.Parameters.AddWithValue("@8", aytxt.Text);
            kayıt.Parameters.AddWithValue("@9", yiltxt.Text);
            kayıt.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("kayıt eklendi");
            listele();

        }
    }
}
