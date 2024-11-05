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
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select AD,SOYAD,TELEFON,TC,MAIL,ADRES from TBL_MUSTERILER", sql.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }
        private void FRMREHBER_Load(object sender, EventArgs e)
        {
            
        }
    }
}
