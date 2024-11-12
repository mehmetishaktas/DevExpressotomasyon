﻿using System;
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
    public partial class FRMBANKALAR : Form
    {
        public FRMBANKALAR()
        {
            InitializeComponent();
            listele();
             
            
        }
        sqlbaglantisi sql= new sqlbaglantisi();
        void listele()
        {
    
            DataTable dt = new DataTable();
            SqlDataAdapter da =new SqlDataAdapter("exec BankaBilgileri",sql.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;

            DataTable dtt = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter("select * from TBL_FIRMALAR", sql.baglanti());
            daa.Fill(dtt);
            gridControl1.DataSource = dtt;
        }


            
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void FRMBANKALAR_Load(object sender, EventArgs e)
        {
      
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert  TLB_BANKALAR VALUES (@1,@2,@3,@4,@5,@6,@7,@8)", sql.baglanti());
            ekle.Parameters.AddWithValue("@1", bankaid.Text);
            ekle.Parameters.AddWithValue("@2", sube.Text);
            ekle.Parameters.AddWithValue("@3", iban.Text);
            ekle.Parameters.AddWithValue("@4", hesap.Text);
            ekle.Parameters.AddWithValue("@5", yetkili.Text);
            ekle.Parameters.AddWithValue("@6", Convert.ToDateTime(tarih.Text));
            ekle.Parameters.AddWithValue("@7", hesapt.Text);
            ekle.Parameters.AddWithValue("@8", firmaid.Text);
            ekle.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("eklendi");
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("delete from TLB_BANKALAR WHERE ID="+idtext.Text+"",sql.baglanti());
            sil.ExecuteNonQuery();
            MessageBox.Show("silindi");
            listele();

        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            idtext.Text = dr["ID"].ToString();
            bankaid.Text = dr["BANKAADI"].ToString();
            sube.Text = dr["SUBE"].ToString();
            iban.Text = dr["IBAN"].ToString();
            hesap.Text = dr["HESAPNO"].ToString();
            yetkili.Text = dr["YETKILI"].ToString();
            tarih.Text = dr["TARIH"].ToString();
            hesapt.Text = dr["HESAPTURU"].ToString();
            firmaid.Text = dr["FIRMAID"].ToString();           
        }
    }
}
