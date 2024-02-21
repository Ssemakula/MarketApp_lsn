using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketApp_lsn
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void exitToolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void M1_toolstripButton_Click(object sender, EventArgs e)
        {
            MarketApp_lsn.Method1 method1 = new MarketApp_lsn.Method1();
            method1.Show();
            method1.BringToFront();
        }

        private void M2_toolstripButton_Click(object sender, EventArgs e)
        {
            MarketApp_lsn.Method2.Method2Main method2 = new Method2.Method2Main();
            method2.Show();
            method2.BringToFront();
        }

        private void M3_toolstripButton_Click(object sender, EventArgs e)
        {
            MarketApp_lsn.Method3.Method3Main method3 = new Method3.Method3Main();
            method3.Show();
            method3.BringToFront();
        }
    }
}
