using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketApp_lsn.Method2
{
    public partial class Method2Child : Form
    {
        /* Method declares a label as public
         * This is the approach the lesson takes
         * I am a bit uncomfortable with that
         * Mayhaps a different way?
         */

        public Method2Child()
        {
            InitializeComponent();
        }


        private void Method2Child_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'market.goods_list' table. You can move, or remove it, as needed.
            this.goods_listTableAdapter.FillAll(this.market.goods_list);

        }
    }
}
