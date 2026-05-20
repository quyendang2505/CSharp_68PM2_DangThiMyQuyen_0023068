using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windownform_App
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
 
            UCQLSV ucQlsv = new UCQLSV();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(ucQlsv);
        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCQLLH Qllh = new UCQLLH();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(Qllh);
        }

        private void pnl_main_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
