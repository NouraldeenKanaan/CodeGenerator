using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGenerator
{
    public partial class frmMain : Form
    {
        private frmLoginScreen _frm;
        public frmMain(frmLoginScreen frm)
        {
            InitializeComponent();

            _frm = frm;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            _frm.Close();
            this.Close();
        }
        private void btSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            _frm.Show();
        }

        private void frmCRUDOperationsGenerator_Load(object sender, EventArgs e)
        {
            lbTitle.Text = $"{clsGlobal.CurrentDatabaseName} Database";
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            frmGenerateCRUDOperations frm = new frmGenerateCRUDOperations();
            frm.ShowDialog();
        }
    }
}
