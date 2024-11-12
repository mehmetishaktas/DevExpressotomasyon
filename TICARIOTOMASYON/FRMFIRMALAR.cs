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
    public partial class FRMFIRMALAR : Form
    {
        sqlbaglantisi sql = new sqlbaglantisi();
        void connect()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from TBL_FIRMALAR",sql.baglanti());
            dataAdapter.Fill(dt);
            gridControl1.DataSource= dt;
        }
        public FRMFIRMALAR()
        {
            InitializeComponent();
            connect();
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
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert TBL_FIRMALAR values (@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12)", sql.baglanti());
            //  ekle.Parameters.AddWithValue("@1", idtext.Text);
            ekle.Parameters.AddWithValue("@2", adtext.Text);
            ekle.Parameters.AddWithValue("@3", yetkilitxt.Text);
            ekle.Parameters.AddWithValue("@4", yetkiliadtxt.Text);
            ekle.Parameters.AddWithValue("@5", teltext.Text);
            ekle.Parameters.AddWithValue("@6", telefonikitxt.Text);
            ekle.Parameters.AddWithValue("@7", txtmail.Text);
            ekle.Parameters.AddWithValue("@8", FAXTXT.Text);
            ekle.Parameters.AddWithValue("@9", iltxt.Text);
            ekle.Parameters.AddWithValue("@10", ilcetxt.Text);
            ekle.Parameters.AddWithValue("@11", vergitxt.Text);
            ekle.Parameters.AddWithValue("@12", adrestxt.Text);
            ekle.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("ürün eklendi");
            connect();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("delete  from TBL_FIRMALAR where ID=@1", sql.baglanti());
            sil.Parameters.AddWithValue("@1", idtext.Text);
            sil.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show(idtext.Text + " " + "silindi", "silindi", MessageBoxButtons.OK);
            connect();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update TBL_FIRMALAR set AD=@2,YETKILI=@3,YETKILIADSOYAD=@4,TELEFON=@5,TELEFON2=@6,MAIL=@7,FAX=@8,IL=@9,ILCE=@10,VERGIDAIRE=@11,ADRES=@12 where ID=" + idtext.Text+"", sql.baglanti());
            guncelle.Parameters.AddWithValue("@2", adtext.Text);
            guncelle.Parameters.AddWithValue("@3", yetkilitxt.Text);
            guncelle.Parameters.AddWithValue("@4", yetkiliadtxt.Text);
            guncelle.Parameters.AddWithValue("@5", teltext.Text);
            guncelle.Parameters.AddWithValue("@6", telefonikitxt.Text);
            guncelle.Parameters.AddWithValue("@7", txtmail.Text);
            guncelle.Parameters.AddWithValue("@8", FAXTXT.Text);
            guncelle.Parameters.AddWithValue("@9", iltxt.Text);
            guncelle.Parameters.AddWithValue("@10", ilcetxt.Text);
            guncelle.Parameters.AddWithValue("@11", vergitxt.Text);
            guncelle.Parameters.AddWithValue("@12", adrestxt.Text);
            guncelle.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("güncellendi");
            connect();
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            idtext.Text = dr["ID"].ToString();
            adtext.Text = dr["AD"].ToString();
            yetkilitxt.Text = dr["YETKILI"].ToString();
            yetkiliadtxt.Text = dr["YETKILIADSOYAD"].ToString();
            teltext.Text = dr["TELEFON"].ToString();
            telefonikitxt.Text = dr["TELEFON2"].ToString();
            txtmail.Text = dr["MAIL"].ToString();
            FAXTXT.Text = dr["FAX"].ToString();    
            iltxt.Text = dr["IL"].ToString();
            ilcetxt.Text = dr["ILCE"].ToString();
            adrestxt.Text = dr["ADRES"].ToString();
            vergitxt.Text = dr["VERGIDAIRE"].ToString();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
