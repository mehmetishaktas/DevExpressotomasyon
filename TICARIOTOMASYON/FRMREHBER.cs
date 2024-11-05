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
    public partial class FRMREHBER : Form
    {
        public FRMREHBER()
        {
            InitializeComponent();
            baglanti();

        }
        sqlbaglantisi sql = new sqlbaglantisi();
        void baglanti()
        {
            //MÜŞTERİLER
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ID,AD,SOYAD,TELEFON,TC,MAIL,ADRES from TBL_MUSTERILER", sql.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
            //FİRMALAR
            DataTable dtt = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter("select ID,AD,YETKILI,YETKILIADSOYAD,TELEFON,MAIL from TBL_FIRMALAR", sql.baglanti());
            daa.Fill(dtt);
            gridControl1.DataSource = dtt;


        }
        private void FRMREHBER_Load(object sender, EventArgs e)
        {
            
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            FRMMAIL frm = new FRMMAIL();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if(dr != null)
            {
                frm.maill = dr["MAIL"].ToString();
                frm.FRM();
                
            }
            frm.Show();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FRMMAIL frm = new FRMMAIL();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                frm.maill = dr["MAIL"].ToString();
                frm.FRM();

            }
            frm.Show();
        }
    }
}

