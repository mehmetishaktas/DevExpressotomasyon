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
        FRMPERSONEL personel;
        private void BTNPERSONELLER_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (personel == null)
            {
                personel=new FRMPERSONEL();
                personel.MdiParent= this;
                personel.Show();
            }
        }
        FRMREHBER rehber;
        private void BTNREHBER_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(rehber == null)
            {
                rehber = new FRMREHBER();
                rehber.MdiParent = this;
                rehber.Show();
            }
        }
        FRMGIDERLER giderler;
        private void BTNGIDERLER_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(giderler == null)
            {
                giderler = new FRMGIDERLER();
                giderler.MdiParent = this;
                giderler.Show();
            }

        }
        FRMBANKALAR BANKALARR;
        private void BTNBANKALAR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           if(BANKALARR == null)
            {
                BANKALARR = new FRMBANKALAR();
                BANKALARR.MdiParent = this;
                BANKALARR.Show();
            }
        }
        FRMFATURALAR FATURALAR;
        private void BTNFATURALAR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(FATURALAR == null)
            {
                FATURALAR = new FRMFATURALAR();
                FATURALAR.MdiParent = this;
                FATURALAR.Show();
            }
        }
    }
}
