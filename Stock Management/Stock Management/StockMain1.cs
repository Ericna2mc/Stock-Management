using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stock_Management
{
    public partial class StockMain1 : Form
    {
        public StockMain1()
        {
            InitializeComponent();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products pro = new Products();
            pro.MdiParent = this;
            pro.Show();
        }

        private void StockMain1_Load(object sender, EventArgs e)
        {
            //StockMain1 sm = new StockMain1();
            //sm.Close();
            //this.Close();

           
            
            
        }

        private void menuStrip_Leave(object sender, EventArgs e)
        {
            
        }

       
    }
}
