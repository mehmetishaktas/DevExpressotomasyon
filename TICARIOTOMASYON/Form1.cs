﻿using System;
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
    }
}