namespace TICARIOTOMASYON
{
    partial class FRMFIRMALAR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMFIRMALAR));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.ilcetxt = new DevExpress.XtraEditors.ComboBoxEdit();
            this.iltxt = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.vergitxt = new System.Windows.Forms.MaskedTextBox();
            this.telefonikitxt = new System.Windows.Forms.MaskedTextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.FAXTXT = new System.Windows.Forms.MaskedTextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.yetkiliadtxt = new System.Windows.Forms.MaskedTextBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.adrestxt = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtmail = new System.Windows.Forms.MaskedTextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.teltext = new System.Windows.Forms.MaskedTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.yetkilitxt = new System.Windows.Forms.MaskedTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.adtext = new System.Windows.Forms.MaskedTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.idtext = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilcetxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iltxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(618, 482);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ilcetxt
            // 
            this.ilcetxt.Location = new System.Drawing.Point(109, 263);
            this.ilcetxt.Name = "ilcetxt";
            this.ilcetxt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ilcetxt.Size = new System.Drawing.Size(152, 20);
            this.ilcetxt.TabIndex = 26;
            // 
            // iltxt
            // 
            this.iltxt.Location = new System.Drawing.Point(109, 242);
            this.iltxt.Name = "iltxt";
            this.iltxt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.iltxt.Size = new System.Drawing.Size(152, 20);
            this.iltxt.TabIndex = 25;
            this.iltxt.SelectedIndexChanged += new System.EventHandler(this.iltxt_SelectedIndexChanged);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(25, 401);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(81, 13);
            this.labelControl10.TabIndex = 24;
            this.labelControl10.Text = "VERGİ DARİESİ :";
            // 
            // vergitxt
            // 
            this.vergitxt.Location = new System.Drawing.Point(109, 398);
            this.vergitxt.Name = "vergitxt";
            this.vergitxt.Size = new System.Drawing.Size(152, 21);
            this.vergitxt.TabIndex = 23;
            // 
            // telefonikitxt
            // 
            this.telefonikitxt.Location = new System.Drawing.Point(109, 164);
            this.telefonikitxt.Mask = "(999) 000-0000";
            this.telefonikitxt.Name = "telefonikitxt";
            this.telefonikitxt.Size = new System.Drawing.Size(152, 21);
            this.telefonikitxt.TabIndex = 22;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.FAXTXT);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.yetkiliadtxt);
            this.groupControl1.Controls.Add(this.ilcetxt);
            this.groupControl1.Controls.Add(this.iltxt);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.vergitxt);
            this.groupControl1.Controls.Add(this.telefonikitxt);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.btnkaydet);
            this.groupControl1.Controls.Add(this.adrestxt);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtmail);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.teltext);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.yetkilitxt);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.adtext);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.idtext);
            this.groupControl1.Location = new System.Drawing.Point(620, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(364, 604);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "groupControl1";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(69, 218);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(23, 13);
            this.labelControl12.TabIndex = 30;
            this.labelControl12.Text = "FAX:";
            // 
            // FAXTXT
            // 
            this.FAXTXT.Location = new System.Drawing.Point(109, 215);
            this.FAXTXT.Name = "FAXTXT";
            this.FAXTXT.Size = new System.Drawing.Size(152, 21);
            this.FAXTXT.TabIndex = 29;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(5, 113);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(98, 13);
            this.labelControl11.TabIndex = 28;
            this.labelControl11.Text = "YETKİLİ AD SOYAD :";
            // 
            // yetkiliadtxt
            // 
            this.yetkiliadtxt.Location = new System.Drawing.Point(109, 110);
            this.yetkiliadtxt.Name = "yetkiliadtxt";
            this.yetkiliadtxt.Size = new System.Drawing.Size(152, 21);
            this.yetkiliadtxt.TabIndex = 27;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(109, 503);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(152, 30);
            this.simpleButton2.TabIndex = 21;
            this.simpleButton2.Text = "GÜNCELLE";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(109, 460);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(152, 37);
            this.simpleButton1.TabIndex = 20;
            this.simpleButton1.Text = "SİL";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(109, 425);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(152, 29);
            this.btnkaydet.TabIndex = 19;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // adrestxt
            // 
            this.adrestxt.Location = new System.Drawing.Point(109, 296);
            this.adrestxt.Name = "adrestxt";
            this.adrestxt.Size = new System.Drawing.Size(152, 93);
            this.adrestxt.TabIndex = 18;
            this.adrestxt.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(69, 194);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(31, 13);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "MAİL :";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(63, 299);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(40, 13);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "ADRES :";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(71, 271);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(29, 13);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "İLÇE :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(84, 244);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(16, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "İL :";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(109, 191);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(152, 21);
            this.txtmail.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(49, 167);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(57, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "TELEFON2 :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(49, 140);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "TELEFON :";
            // 
            // teltext
            // 
            this.teltext.Location = new System.Drawing.Point(109, 137);
            this.teltext.Mask = "(999) 000-0000";
            this.teltext.Name = "teltext";
            this.teltext.Size = new System.Drawing.Size(152, 21);
            this.teltext.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(62, 86);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "YETKİLİ:";
            // 
            // yetkilitxt
            // 
            this.yetkilitxt.Location = new System.Drawing.Point(109, 83);
            this.yetkilitxt.Name = "yetkilitxt";
            this.yetkilitxt.Size = new System.Drawing.Size(152, 21);
            this.yetkilitxt.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(50, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "FİRMA AD :";
            // 
            // adtext
            // 
            this.adtext.Location = new System.Drawing.Point(109, 56);
            this.adtext.Name = "adtext";
            this.adtext.Size = new System.Drawing.Size(152, 21);
            this.adtext.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(82, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(18, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "ID: ";
            // 
            // idtext
            // 
            this.idtext.Location = new System.Drawing.Point(109, 29);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(152, 21);
            this.idtext.TabIndex = 0;
            // 
            // FRMFIRMALAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 549);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FRMFIRMALAR";
            this.Text = "FRMFIRMALAR";
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilcetxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iltxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.ComboBoxEdit ilcetxt;
        private DevExpress.XtraEditors.ComboBoxEdit iltxt;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.MaskedTextBox vergitxt;
        private System.Windows.Forms.MaskedTextBox telefonikitxt;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private System.Windows.Forms.RichTextBox adrestxt;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.MaskedTextBox txtmail;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.MaskedTextBox teltext;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.MaskedTextBox yetkilitxt;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox adtext;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.MaskedTextBox idtext;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.MaskedTextBox yetkiliadtxt;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.MaskedTextBox FAXTXT;
    }
}