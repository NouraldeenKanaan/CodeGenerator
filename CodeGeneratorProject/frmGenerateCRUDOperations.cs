using GeneratorLogic;
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
    public partial class frmGenerateCRUDOperations : Form
    {
        public frmGenerateCRUDOperations()
        {
            InitializeComponent();
        }

        private void frmGenerateCRUDOperations_Load(object sender, EventArgs e)
        {
            cbDataTypes.SelectedIndex = 2;
        }


        private void btAdd_Click(object sender, EventArgs e)
        {
            
            if(tbColumnName.Text == string.Empty)
            {
                MessageBox.Show("Column Name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvTableColumns.Rows.Add(tbColumnName.Text.Trim(), cbDataTypes.Text, rbNull.Checked, rbPK.Checked);

            rbPK.Enabled = false;
            rbPK.Checked = false;

            rbNull.Enabled = true;
            rbNotNull.Enabled = true;
            cbDataTypes.Enabled = true;

            rbNull.Checked = true;
            rbNotNull.Checked = false;

            tbTableName.Enabled = false;
            tbSingleTableName.Enabled = false;

            tbColumnName.Clear();
        }


        private void _GenerateDataAccessLayer(string TableName,string SingleTableName,List<clsColumn> Columns)
        {
            clsGenerateDataAccessLayer generateDataAccessLayer = new clsGenerateDataAccessLayer(clsGlobal.ConnectionString, clsGlobal.CurrentDatabaseName,
                TableName, SingleTableName, Columns);
            
            generateDataAccessLayer.Generate();
        }
        private void _GenerateBusinessLogicLayer(string TableName, string SingleTableName, List<clsColumn> Columns)
        {
            clsGenerateBusinessLogicLayer generateBusinessLogicLayer = new clsGenerateBusinessLogicLayer(
                clsGlobal.CurrentDatabaseName, TableName,SingleTableName,Columns);

            generateBusinessLogicLayer.Generate();
        }


        private void btGenerate_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields should be added. Please add them.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<clsColumn> _Columns = new List<clsColumn>();

            foreach(DataGridViewRow row in dgvTableColumns.Rows)
            {
                _Columns.Add(new clsColumn(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), (bool)row.Cells[2].Value, (bool)row.Cells[3].Value));
            }

            _GenerateDataAccessLayer(tbTableName.Text.Trim(),tbSingleTableName.Text.Trim(),_Columns);
            _GenerateBusinessLogicLayer(tbTableName.Text.Trim(), tbSingleTableName.Text.Trim(), _Columns);

        }
    }
}
