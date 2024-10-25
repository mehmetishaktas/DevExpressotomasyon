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
    public partial class FRMURUNLER : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select* from TBL_URUNLER",
            bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        public FRMURUNLER()
        {
            InitializeComponent();
            listele();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FRMURUNLER_Load(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            //veri ekleme   
            SqlCommand sqlCommand = new SqlCommand("insert TBL_URUNLER values (@p8,@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            sqlCommand.Parameters.AddWithValue("@p8", idtext.Text);
            sqlCommand.Parameters.AddWithValue("@p1", adtext.Text);
            sqlCommand.Parameters.AddWithValue("@p2", markatext.Text);
            sqlCommand.Parameters.AddWithValue("@p3", modeltext.Text);
            sqlCommand.Parameters.AddWithValue("@p4", yılltext.Text);
            sqlCommand.Parameters.AddWithValue("@p5", decimal.Parse(txtalis.Text));
            sqlCommand.Parameters.AddWithValue("@p6", decimal.Parse(txtsatis.Text));
            sqlCommand.Parameters.AddWithValue("@p7", detaytext.Text);
            sqlCommand.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("ürün eklendi");
            listele();


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //sil 
            
            SqlCommand sil = new SqlCommand("delete from TBL_URUNLER WHERE ID="+idtext.Text+"",bgl.baglanti());
           // sil.Parameters.AddWithValue("@p1", idtext.Text);
            sil.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            
        }
    }
}
