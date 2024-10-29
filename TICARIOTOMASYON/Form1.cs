using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TICARIOTOMASYON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FRMURUNLER frmurunlar;
        private void BTNURUNLER_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmurunlar == null)
            {
                frmurunlar = new FRMURUNLER();
                frmurunlar.MdiParent = this;
                frmurunlar.Show();
            }
            
        }

        private void BTNSTOKLAR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        FRMMUSTERILER musteri;
        private void BTNMUSTERILER_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(musteri == null)
            {
                musteri=new FRMMUSTERILER();
                musteri.MdiParent = this; musteri.Show();
            }
        }
        FRMFIRMALAR firmalar;
        private void BTNFIRMALAR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(firmalar == null)
            {
                firmalar = new FRMFIRMALAR();
                firmalar.MdiParent = this;
                firmalar.Show();
            }
        }
    }
}
