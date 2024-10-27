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
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;

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
            sehirlistele();
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
            ekle.Parameters.AddWithValue("@8", ilcetxt.Text);
            ekle.Parameters.AddWithValue("@9", adrestxt.Text);
            ekle.Parameters.AddWithValue("@10",vergitxt.Text);
            ekle.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("ürün eklendi");
            conenct();
        }

        private void iltxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        void sehirlistele()
        {
            SqlCommand komut = new SqlCommand("select ad from TBL_IL", sql.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                iltxt.Properties.Items.Add(dr[0]);
            }
            sql.baglanti().Close();
        }
        private void iltxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilcetxt.Clear();         
            SqlCommand komutt = new SqlCommand("select IL_AD from TBL_ILCE where AD =@p1", sql.baglanti());
            komutt.Parameters.AddWithValue("@p1", iltxt.SelectedIndex + 1);
            SqlDataReader dr = komutt.ExecuteReader();
            while (dr.Read())
            {
                ilcetxt.Properties.Items.Add(dr[0]);
            }
            sql.baglanti().Close();
        }

        private void İilcetxt_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update TBL_MUSTERILER SET AD=@2,SOYAD=@3,TELEFON=@4,TC=@5,MAIL=@6,IL=@7,ILCE=@8,ADRES=@9,VERGİDAİRESİ=@10 where ID="+idtext.Text+" ", sql.baglanti());

            guncelle.Parameters.AddWithValue("@2", adtext.Text);
            guncelle.Parameters.AddWithValue("@3", soytxt.Text);
            guncelle.Parameters.AddWithValue("@4", teltext.Text);
            guncelle.Parameters.AddWithValue("@5", tctext.Text);
            guncelle.Parameters.AddWithValue("@6", txtmail.Text);
            guncelle.Parameters.AddWithValue("@7", iltxt.Text);
            guncelle.Parameters.AddWithValue("@8", ilcetxt.Text);
            guncelle.Parameters.AddWithValue("@9", adrestxt.Text);
            guncelle.Parameters.AddWithValue("@10", vergitxt.Text);
            guncelle.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("GÜNCELLENDİ");
            conenct();
        }   

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            idtext.Text = dr["ID"].ToString();
            adtext.Text = dr["AD"].ToString();
            soytxt.Text = dr["SOYAD"].ToString();
            teltext.Text = dr["TELEFON"].ToString();
            tctext.Text = dr["TC"].ToString();
            txtmail.Text = dr["MAIL"].ToString();
            iltxt.Text = dr["IL"].ToString();
            ilcetxt.Text = dr["IL"].ToString();
            adrestxt.Text = dr["ADRES"].ToString();
            vergitxt.Text = dr["VERGİDAİRESİ"].ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("delete from TBL_MUSTERILER where ID=@1", sql.baglanti());
            sil.Parameters.AddWithValue("@1", idtext.Text);
            sil.Parameters.AddWithValue("@2", adtext.Text);
            sil.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show(idtext.Text +" "+ "silindi", "silindi", MessageBoxButtons.OK);
            conenct();
        }
    }
}
