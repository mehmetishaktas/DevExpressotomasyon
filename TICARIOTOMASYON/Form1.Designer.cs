namespace TICARIOTOMASYON
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BTNURUNLER = new DevExpress.XtraBars.BarButtonItem();
            this.BTNSTOKLAR = new DevExpress.XtraBars.BarButtonItem();
            this.BTNMUSTERILER = new DevExpress.XtraBars.BarButtonItem();
            this.BTNFIRMALAR = new DevExpress.XtraBars.BarButtonItem();
            this.BTNPERSONELLER = new DevExpress.XtraBars.BarButtonItem();
            this.BTNGIDERLER = new DevExpress.XtraBars.BarButtonItem();
            this.BTNKASA = new DevExpress.XtraBars.BarButtonItem();
            this.BTNNOTLAR = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.BTNBANKALAR = new DevExpress.XtraBars.BarButtonItem();
            this.BTNREHBER = new DevExpress.XtraBars.BarButtonItem();
            this.BTNANASAYFA = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem16 = new DevExpress.XtraBars.BarButtonItem();
            this.BTNFATURALAR = new DevExpress.XtraBars.BarButtonItem();
            this.BTNAYARLAR = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.BTNURUNLER,
            this.BTNSTOKLAR,
            this.BTNMUSTERILER,
            this.BTNFIRMALAR,
            this.BTNPERSONELLER,
            this.BTNGIDERLER,
            this.BTNKASA,
            this.BTNNOTLAR,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12,
            this.BTNBANKALAR,
            this.BTNREHBER,
            this.BTNANASAYFA,
            this.barButtonItem16,
            this.BTNFATURALAR,
            this.BTNAYARLAR});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 19;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1008, 150);
            // 
            // BTNURUNLER
            // 
            this.BTNURUNLER.Caption = "ÜRÜNLER";
            this.BTNURUNLER.Id = 1;
            this.BTNURUNLER.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNURUNLER.ImageOptions.LargeImage")));
            this.BTNURUNLER.Name = "BTNURUNLER";
            this.BTNURUNLER.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.BTNURUNLER.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BTNURUNLER_ItemClick);
            // 
            // BTNSTOKLAR
            // 
            this.BTNSTOKLAR.Caption = "STOKLAR";
            this.BTNSTOKLAR.Id = 2;
            this.BTNSTOKLAR.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNSTOKLAR.ImageOptions.LargeImage")));
            this.BTNSTOKLAR.Name = "BTNSTOKLAR";
            this.BTNSTOKLAR.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BTNSTOKLAR_ItemClick);
            // 
            // BTNMUSTERILER
            // 
            this.BTNMUSTERILER.Caption = "MÜSTERİLER";
            this.BTNMUSTERILER.Id = 3;
            this.BTNMUSTERILER.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNMUSTERILER.ImageOptions.LargeImage")));
            this.BTNMUSTERILER.Name = "BTNMUSTERILER";
            this.BTNMUSTERILER.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BTNMUSTERILER_ItemClick);
            // 
            // BTNFIRMALAR
            // 
            this.BTNFIRMALAR.Caption = "FİRMALAR";
            this.BTNFIRMALAR.Id = 4;
            this.BTNFIRMALAR.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNFIRMALAR.ImageOptions.LargeImage")));
            this.BTNFIRMALAR.Name = "BTNFIRMALAR";
            this.BTNFIRMALAR.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BTNFIRMALAR_ItemClick);
            // 
            // BTNPERSONELLER
            // 
            this.BTNPERSONELLER.Caption = "PERSONELLER";
            this.BTNPERSONELLER.Id = 5;
            this.BTNPERSONELLER.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNPERSONELLER.ImageOptions.LargeImage")));
            this.BTNPERSONELLER.Name = "BTNPERSONELLER";
            // 
            // BTNGIDERLER
            // 
            this.BTNGIDERLER.Caption = "GİDERLER";
            this.BTNGIDERLER.Id = 6;
            this.BTNGIDERLER.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNGIDERLER.ImageOptions.LargeImage")));
            this.BTNGIDERLER.Name = "BTNGIDERLER";
            // 
            // BTNKASA
            // 
            this.BTNKASA.Caption = "KASA";
            this.BTNKASA.Id = 7;
            this.BTNKASA.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNKASA.ImageOptions.LargeImage")));
            this.BTNKASA.Name = "BTNKASA";
            // 
            // BTNNOTLAR
            // 
            this.BTNNOTLAR.Caption = "NOTLAR";
            this.BTNNOTLAR.Id = 8;
            this.BTNNOTLAR.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNNOTLAR.ImageOptions.LargeImage")));
            this.BTNNOTLAR.Name = "BTNNOTLAR";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "barButtonItem9";
            this.barButtonItem9.Id = 9;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "barButtonItem10";
            this.barButtonItem10.Id = 10;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "barButtonItem11";
            this.barButtonItem11.Id = 11;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "barButtonItem12";
            this.barButtonItem12.Id = 12;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // BTNBANKALAR
            // 
            this.BTNBANKALAR.Caption = "BANKALAR";
            this.BTNBANKALAR.Id = 13;
            this.BTNBANKALAR.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNBANKALAR.ImageOptions.LargeImage")));
            this.BTNBANKALAR.Name = "BTNBANKALAR";
            // 
            // BTNREHBER
            // 
            this.BTNREHBER.Caption = "REHBER";
            this.BTNREHBER.Id = 14;
            this.BTNREHBER.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNREHBER.ImageOptions.LargeImage")));
            this.BTNREHBER.Name = "BTNREHBER";
            // 
            // BTNANASAYFA
            // 
            this.BTNANASAYFA.Caption = "ANASAYFA";
            this.BTNANASAYFA.Id = 15;
            this.BTNANASAYFA.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNANASAYFA.ImageOptions.LargeImage")));
            this.BTNANASAYFA.Name = "BTNANASAYFA";
            // 
            // barButtonItem16
            // 
            this.barButtonItem16.Caption = "barButtonItem16";
            this.barButtonItem16.Id = 16;
            this.barButtonItem16.Name = "barButtonItem16";
            // 
            // BTNFATURALAR
            // 
            this.BTNFATURALAR.Caption = "FATURALAR";
            this.BTNFATURALAR.Id = 17;
            this.BTNFATURALAR.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNFATURALAR.ImageOptions.LargeImage")));
            this.BTNFATURALAR.Name = "BTNFATURALAR";
            // 
            // BTNAYARLAR
            // 
            this.BTNAYARLAR.Caption = "AYARLAR";
            this.BTNAYARLAR.Id = 18;
            this.BTNAYARLAR.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BTNAYARLAR.ImageOptions.LargeImage")));
            this.BTNAYARLAR.Name = "BTNAYARLAR";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "TİCARİ OTOMASYON ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNANASAYFA);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNURUNLER);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNSTOKLAR);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNMUSTERILER);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNFIRMALAR);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNPERSONELLER);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNGIDERLER);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNKASA);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNNOTLAR);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNBANKALAR);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNREHBER);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNFATURALAR);
            this.ribbonPageGroup1.ItemLinks.Add(this.BTNAYARLAR);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BTNURUNLER;
        private DevExpress.XtraBars.BarButtonItem BTNSTOKLAR;
        private DevExpress.XtraBars.BarButtonItem BTNMUSTERILER;
        private DevExpress.XtraBars.BarButtonItem BTNFIRMALAR;
        private DevExpress.XtraBars.BarButtonItem BTNPERSONELLER;
        private DevExpress.XtraBars.BarButtonItem BTNGIDERLER;
        private DevExpress.XtraBars.BarButtonItem BTNKASA;
        private DevExpress.XtraBars.BarButtonItem BTNNOTLAR;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem BTNBANKALAR;
        private DevExpress.XtraBars.BarButtonItem BTNREHBER;
        private DevExpress.XtraBars.BarButtonItem BTNANASAYFA;
        private DevExpress.XtraBars.BarButtonItem barButtonItem16;
        private DevExpress.XtraBars.BarButtonItem BTNFATURALAR;
        private DevExpress.XtraBars.BarButtonItem BTNAYARLAR;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

