namespace TICARIOTOMASYON
{
    partial class FRMMAIL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMMAIL));
            this.gereksiz = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mailtxt = new DevExpress.XtraEditors.TextEdit();
            this.konutxt = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.iceriktxt = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.mailtxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konutxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gereksiz
            // 
            this.gereksiz.AutoSize = true;
            this.gereksiz.Location = new System.Drawing.Point(162, 296);
            this.gereksiz.Name = "gereksiz";
            this.gereksiz.Size = new System.Drawing.Size(35, 13);
            this.gereksiz.TabIndex = 1;
            this.gereksiz.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "MAİIL ADRESI :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mailtxt
            // 
            this.mailtxt.Location = new System.Drawing.Point(103, 120);
            this.mailtxt.Name = "mailtxt";
            this.mailtxt.Size = new System.Drawing.Size(164, 20);
            this.mailtxt.TabIndex = 3;
            // 
            // konutxt
            // 
            this.konutxt.Location = new System.Drawing.Point(103, 156);
            this.konutxt.Name = "konutxt";
            this.konutxt.Size = new System.Drawing.Size(164, 20);
            this.konutxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "KONU :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iceriktxt
            // 
            this.iceriktxt.Location = new System.Drawing.Point(103, 182);
            this.iceriktxt.Name = "iceriktxt";
            this.iceriktxt.Size = new System.Drawing.Size(164, 96);
            this.iceriktxt.TabIndex = 6;
            this.iceriktxt.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "İÇERİK :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 100);
            this.panel1.TabIndex = 8;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(103, 312);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(164, 62);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "GONDER ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FRMMAIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 448);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iceriktxt);
            this.Controls.Add(this.konutxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mailtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gereksiz);
            this.Name = "FRMMAIL";
            this.Text = "FRMMAIL";
            ((System.ComponentModel.ISupportInitialize)(this.mailtxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konutxt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label gereksiz;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit mailtxt;
        private DevExpress.XtraEditors.TextEdit konutxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox iceriktxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}