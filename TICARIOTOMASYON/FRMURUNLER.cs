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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            idtext.Text = dr["ID"].ToString();
            adtext.Text = dr["URUNAD"].ToString();         
            markatext.Text = dr["MARKA"].ToString();
            modeltext.Text = dr["MODAL"].ToString();
            yılltext.Text = dr["YIL"].ToString();
            adettext.Text = dr["ADET"].ToString();
            txtalis.Text = dr["YIL"].ToString();
            txtsatis.Text = dr["ADET"].ToString();
            detaytext.Text = dr["ALISFIYAT"].ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update TBL_URUNLER set URUNAD=@p8,MARKA=@p1,MODAL=@p2,YIL=@p3,ADET=@p4,ALISFIYAT=@p5,SATISFIYAT=@p6,DETAY=@p7 where ID="+idtext.Text+"",bgl.baglanti());     
            guncelle.Parameters.AddWithValue("@p8", adtext.Text);
            guncelle.Parameters.AddWithValue("@p1", markatext.Text);
            guncelle.Parameters.AddWithValue("@p2", modeltext.Text);
            guncelle.Parameters.AddWithValue("@p3", yılltext.Text);
            guncelle.Parameters.AddWithValue("@p4", decimal.Parse(adettext.Text));
            guncelle.Parameters.AddWithValue("@p5", txtalis.Text);
            guncelle.Parameters.AddWithValue("@p6", decimal.Parse(txtsatis.Text));
            guncelle.Parameters.AddWithValue("@p7", detaytext.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("ürün eklendi");
            listele();
        }
    }
}
