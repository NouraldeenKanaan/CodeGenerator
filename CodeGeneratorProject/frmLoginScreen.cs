using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GeneratorLogic;

namespace CodeGenerator
{
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void frmDataBaseLoginScreen_Load(object sender, EventArgs e)
        {
            cbDataBaseNames.SelectedIndex = 0;

            _GetAllMSQLServerDatabases();
        }

        private void _GetAllMSQLServerDatabases()
        {
            DataTable dtDatabases = clsDataBaseAndTables.GetAllMSQLServerDatabases();

            foreach (DataRow row in dtDatabases.Rows)
            {
                cbDatabases.Items.Add(row["Name"]);
            }

            cbDatabases.SelectedIndex = 0;
        }
     
        private void cbDataBaseNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbDataBaseNames.SelectedIndex != 0)
            {
                cbDatabases.Visible = false;
                btLogin.Visible = false;

                MessageBox.Show("Not available yet", "Soon");

                return;
            }

            cbDatabases.Visible = true;
            btLogin.Visible = true;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentDatabase(cbDatabases.SelectedItem.ToString());

            frmMain frmCRUDOperationsGenerator = new frmMain(this);
            this.Hide();
            frmCRUDOperationsGenerator.ShowDialog();

        }
    }
}
