using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreProcedure08
{
    public partial class frmUpdateCost : Form
    {
        public frmUpdateCost()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
