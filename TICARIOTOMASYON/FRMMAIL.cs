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
    public partial class FRMMAIL : Form
    {
        public string maill;
        public FRMMAIL()
        {
            InitializeComponent();
           
        }

        public void FRM()
        {
            mail.Text = maill;
        }
        private void FRMMAIL_Load(object sender, EventArgs e)
        {
            
        }
    }
}
