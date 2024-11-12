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
using System.Collections;
using System.Xml;


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
            kayıt.Parameters.AddWithValue("@1", decimal.Parse(elektriktxt.Text));
            kayıt.Parameters.AddWithValue("@2", decimal.Parse(sutxt.Text));
            kayıt.Parameters.AddWithValue("@3", decimal.Parse(dogalgaztxt.Text));
            kayıt.Parameters.AddWithValue("@4", decimal.Parse(internettxt.Text));
            kayıt.Parameters.AddWithValue("@5", decimal.Parse(maaslartxt.Text));
            kayıt.Parameters.AddWithValue("@6", decimal.Parse(ekstratxt.Text));
            kayıt.Parameters.AddWithValue("@7", notlartxt.Text);
            kayıt.Parameters.AddWithValue("@8", aytxt.Text);
            kayıt.Parameters.AddWithValue("@9", yiltxt.Text);
            kayıt.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("kayıt eklendi");
            listele();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand sil =new SqlCommand("delete from TBL_GIDERLER WHERE ID=@1",sql.baglanti());
            sil.Parameters.AddWithValue("@1", idtext.Text); sil.ExecuteNonQuery();sql.baglanti().Close(); MessageBox.Show("Silindi");listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            idtext.Text = dr["ID"].ToString();
            elektriktxt.Text = dr["ELEKTRIK"].ToString();
            sutxt.Text = dr["SU"].ToString();
            dogalgaztxt.Text = dr["DOGALGAZ"].ToString();
            internettxt.Text = dr["INTERNET"].ToString();
            maaslartxt.Text = dr["MAASLAR"].ToString();
            ekstratxt.Text = dr["EKSTRA"].ToString();
            notlartxt.Text = dr["NOTLAR"].ToString();
            aytxt.Text = dr["AY"].ToString();
            yiltxt.Text = dr["YIL"].ToString();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update  TBL_GIDERLER set ELEKTRIK=@1,SU=@2,DOGALGAZ=@3,INTERNET=@4,MAASLAR=@5,EKSTRA=@6,NOTLAR=@7,AY=@8,YIL=@9 where ID="+idtext.Text+" ", sql.baglanti());
            guncelle.Parameters.AddWithValue("@1", decimal.Parse(elektriktxt.Text));
            guncelle.Parameters.AddWithValue("@2", decimal.Parse(sutxt.Text));
            guncelle.Parameters.AddWithValue("@3", decimal.Parse(dogalgaztxt.Text));
            guncelle.Parameters.AddWithValue("@4", decimal.Parse(internettxt.Text));
            guncelle.Parameters.AddWithValue("@5", decimal.Parse(maaslartxt.Text));
            guncelle.Parameters.AddWithValue("@6", decimal.Parse(ekstratxt.Text));
            guncelle.Parameters.AddWithValue("@7", notlartxt.Text);
            guncelle.Parameters.AddWithValue("@8", aytxt.Text);
            guncelle.Parameters.AddWithValue("@9", yiltxt.Text);
            guncelle.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("güncellendi");
            listele();
        }
    }
}
