namespace CodeGenerator
{
    partial class frmGenerateCRUDOperations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTitle = new ReaLTaiizor.Controls.BigLabel();
            this.lbTableName = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lbTableSingleName = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.dgvTableColumns = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIsNull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIsPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbColumns = new ReaLTaiizor.Controls.CrownGroupBox();
            this.rbNotNull = new ReaLTaiizor.Controls.AloneRadioButton();
            this.rbNull = new ReaLTaiizor.Controls.AloneRadioButton();
            this.rbPK = new ReaLTaiizor.Controls.AloneRadioButton();
            this.btAdd = new ReaLTaiizor.Controls.DungeonButtonLeft();
            this.cbDataTypes = new ReaLTaiizor.Controls.HopeComboBox();
            this.lbDataType = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.tbColumnName = new ReaLTaiizor.Controls.PoisonTextBox();
            this.lbColumnName = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.tbTableName = new ReaLTaiizor.Controls.DungeonTextBox();
            this.tbSingleTableName = new ReaLTaiizor.Controls.DungeonTextBox();
            this.btGenerate = new ReaLTaiizor.Controls.DungeonButtonLeft();
            this.lbSaveTo = new System.Windows.Forms.Label();
            this.lbSaveToValue = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableColumns)).BeginInit();
            this.gbColumns.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.lbTitle.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbTitle.Location = new System.Drawing.Point(136, 30);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(496, 57);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Business And Data Layers";
            // 
            // lbTableName
            // 
            this.lbTableName.AutoSize = true;
            this.lbTableName.BackColor = System.Drawing.Color.Transparent;
            this.lbTableName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbTableName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lbTableName.Location = new System.Drawing.Point(24, 128);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(120, 25);
            this.lbTableName.TabIndex = 1;
            this.lbTableName.Text = "Table Name:";
            // 
            // lbTableSingleName
            // 
            this.lbTableSingleName.AutoSize = true;
            this.lbTableSingleName.BackColor = System.Drawing.Color.Transparent;
            this.lbTableSingleName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbTableSingleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lbTableSingleName.Location = new System.Drawing.Point(24, 175);
            this.lbTableSingleName.Name = "lbTableSingleName";
            this.lbTableSingleName.Size = new System.Drawing.Size(180, 25);
            this.lbTableSingleName.TabIndex = 2;
            this.lbTableSingleName.Text = "Table Single Name:";
            // 
            // dgvTableColumns
            // 
            this.dgvTableColumns.AllowUserToAddRows = false;
            this.dgvTableColumns.AllowUserToDeleteRows = false;
            this.dgvTableColumns.AllowUserToOrderColumns = true;
            this.dgvTableColumns.AllowUserToResizeRows = false;
            this.dgvTableColumns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTableColumns.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTableColumns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTableColumns.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTableColumns.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableColumns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTableColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvName,
            this.dgvDataType,
            this.dgvIsNull,
            this.dgvIsPK});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTableColumns.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTableColumns.EnableHeadersVisualStyles = false;
            this.dgvTableColumns.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvTableColumns.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTableColumns.Location = new System.Drawing.Point(29, 222);
            this.dgvTableColumns.Name = "dgvTableColumns";
            this.dgvTableColumns.ReadOnly = true;
            this.dgvTableColumns.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableColumns.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTableColumns.RowHeadersWidth = 51;
            this.dgvTableColumns.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTableColumns.RowTemplate.Height = 26;
            this.dgvTableColumns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableColumns.Size = new System.Drawing.Size(408, 222);
            this.dgvTableColumns.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Teal;
            this.dgvTableColumns.TabIndex = 5;
            // 
            // dgvName
            // 
            this.dgvName.HeaderText = "Name";
            this.dgvName.MinimumWidth = 6;
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvDataType
            // 
            this.dgvDataType.HeaderText = "Data Type";
            this.dgvDataType.MinimumWidth = 6;
            this.dgvDataType.Name = "dgvDataType";
            this.dgvDataType.ReadOnly = true;
            // 
            // dgvIsNull
            // 
            this.dgvIsNull.HeaderText = "Is Null";
            this.dgvIsNull.MinimumWidth = 6;
            this.dgvIsNull.Name = "dgvIsNull";
            this.dgvIsNull.ReadOnly = true;
            // 
            // dgvIsPK
            // 
            this.dgvIsPK.HeaderText = "PK";
            this.dgvIsPK.MinimumWidth = 6;
            this.dgvIsPK.Name = "dgvIsPK";
            this.dgvIsPK.ReadOnly = true;
            // 
            // gbColumns
            // 
            this.gbColumns.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gbColumns.Controls.Add(this.rbNotNull);
            this.gbColumns.Controls.Add(this.rbNull);
            this.gbColumns.Controls.Add(this.rbPK);
            this.gbColumns.Controls.Add(this.btAdd);
            this.gbColumns.Controls.Add(this.cbDataTypes);
            this.gbColumns.Controls.Add(this.lbDataType);
            this.gbColumns.Controls.Add(this.tbColumnName);
            this.gbColumns.Controls.Add(this.lbColumnName);
            this.gbColumns.Location = new System.Drawing.Point(456, 222);
            this.gbColumns.Name = "gbColumns";
            this.gbColumns.Size = new System.Drawing.Size(289, 222);
            this.gbColumns.TabIndex = 6;
            this.gbColumns.TabStop = false;
            this.gbColumns.Text = "Add Columns";
            // 
            // rbNotNull
            // 
            this.rbNotNull.BackColor = System.Drawing.Color.Transparent;
            this.rbNotNull.Checked = false;
            this.rbNotNull.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbNotNull.EnabledCalc = false;
            this.rbNotNull.ForeColor = System.Drawing.Color.White;
            this.rbNotNull.Location = new System.Drawing.Point(110, 133);
            this.rbNotNull.Name = "rbNotNull";
            this.rbNotNull.Size = new System.Drawing.Size(101, 17);
            this.rbNotNull.TabIndex = 5;
            this.rbNotNull.Text = "Not Null";
            // 
            // rbNull
            // 
            this.rbNull.BackColor = System.Drawing.Color.Transparent;
            this.rbNull.Checked = false;
            this.rbNull.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbNull.EnabledCalc = false;
            this.rbNull.ForeColor = System.Drawing.Color.White;
            this.rbNull.Location = new System.Drawing.Point(217, 133);
            this.rbNull.Name = "rbNull";
            this.rbNull.Size = new System.Drawing.Size(66, 17);
            this.rbNull.TabIndex = 6;
            this.rbNull.Text = "Null";
            // 
            // rbPK
            // 
            this.rbPK.BackColor = System.Drawing.Color.Transparent;
            this.rbPK.Checked = true;
            this.rbPK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPK.EnabledCalc = true;
            this.rbPK.ForeColor = System.Drawing.Color.White;
            this.rbPK.Location = new System.Drawing.Point(47, 133);
            this.rbPK.Name = "rbPK";
            this.rbPK.Size = new System.Drawing.Size(57, 17);
            this.rbPK.TabIndex = 4;
            this.rbPK.Text = "PK";
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Transparent;
            this.btAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btAdd.Image = null;
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdd.InactiveColorA = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btAdd.InactiveColorB = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.btAdd.Location = new System.Drawing.Point(77, 168);
            this.btAdd.Name = "btAdd";
            this.btAdd.PressedColorA = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btAdd.PressedColorB = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btAdd.PressedContourColorA = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btAdd.PressedContourColorB = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btAdd.Size = new System.Drawing.Size(188, 30);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "Add";
            this.btAdd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // cbDataTypes
            // 
            this.cbDataTypes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDataTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDataTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataTypes.Enabled = false;
            this.cbDataTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDataTypes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbDataTypes.FormattingEnabled = true;
            this.cbDataTypes.ItemHeight = 30;
            this.cbDataTypes.Items.AddRange(new object[] {
            "byte",
            "short",
            "int",
            "long",
            "float",
            "double",
            "decimal",
            "bool",
            "string"});
            this.cbDataTypes.Location = new System.Drawing.Point(110, 81);
            this.cbDataTypes.Name = "cbDataTypes";
            this.cbDataTypes.Size = new System.Drawing.Size(155, 36);
            this.cbDataTypes.TabIndex = 3;
            // 
            // lbDataType
            // 
            this.lbDataType.AutoSize = true;
            this.lbDataType.BackColor = System.Drawing.Color.Transparent;
            this.lbDataType.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataType.ForeColor = System.Drawing.Color.White;
            this.lbDataType.Location = new System.Drawing.Point(18, 89);
            this.lbDataType.Name = "lbDataType";
            this.lbDataType.Size = new System.Drawing.Size(86, 23);
            this.lbDataType.TabIndex = 9;
            this.lbDataType.Text = "Data Type:";
            // 
            // tbColumnName
            // 
            // 
            // 
            // 
            this.tbColumnName.CustomButton.Image = null;
            this.tbColumnName.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.tbColumnName.CustomButton.Name = "";
            this.tbColumnName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbColumnName.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.tbColumnName.CustomButton.TabIndex = 1;
            this.tbColumnName.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.tbColumnName.CustomButton.UseSelectable = true;
            this.tbColumnName.CustomButton.Visible = false;
            this.tbColumnName.Lines = new string[0];
            this.tbColumnName.Location = new System.Drawing.Point(77, 47);
            this.tbColumnName.MaxLength = 32767;
            this.tbColumnName.Name = "tbColumnName";
            this.tbColumnName.PasswordChar = '\0';
            this.tbColumnName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbColumnName.SelectedText = "";
            this.tbColumnName.SelectionLength = 0;
            this.tbColumnName.SelectionStart = 0;
            this.tbColumnName.ShortcutsEnabled = true;
            this.tbColumnName.Size = new System.Drawing.Size(188, 23);
            this.tbColumnName.TabIndex = 2;
            this.tbColumnName.UseSelectable = true;
            this.tbColumnName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbColumnName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbColumnName
            // 
            this.lbColumnName.AutoSize = true;
            this.lbColumnName.BackColor = System.Drawing.Color.Transparent;
            this.lbColumnName.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColumnName.ForeColor = System.Drawing.Color.White;
            this.lbColumnName.Location = new System.Drawing.Point(18, 47);
            this.lbColumnName.Name = "lbColumnName";
            this.lbColumnName.Size = new System.Drawing.Size(57, 23);
            this.lbColumnName.TabIndex = 7;
            this.lbColumnName.Text = "Name:";
            // 
            // tbTableName
            // 
            this.tbTableName.BackColor = System.Drawing.Color.Transparent;
            this.tbTableName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbTableName.EdgeColor = System.Drawing.Color.White;
            this.tbTableName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbTableName.ForeColor = System.Drawing.Color.DimGray;
            this.tbTableName.Location = new System.Drawing.Point(210, 128);
            this.tbTableName.MaxLength = 32767;
            this.tbTableName.Multiline = false;
            this.tbTableName.Name = "tbTableName";
            this.tbTableName.ReadOnly = false;
            this.tbTableName.Size = new System.Drawing.Size(227, 33);
            this.tbTableName.TabIndex = 0;
            this.tbTableName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbTableName.UseSystemPasswordChar = false;
            // 
            // tbSingleTableName
            // 
            this.tbSingleTableName.BackColor = System.Drawing.Color.Transparent;
            this.tbSingleTableName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbSingleTableName.EdgeColor = System.Drawing.Color.White;
            this.tbSingleTableName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbSingleTableName.ForeColor = System.Drawing.Color.DimGray;
            this.tbSingleTableName.Location = new System.Drawing.Point(210, 175);
            this.tbSingleTableName.MaxLength = 32767;
            this.tbSingleTableName.Multiline = false;
            this.tbSingleTableName.Name = "tbSingleTableName";
            this.tbSingleTableName.ReadOnly = false;
            this.tbSingleTableName.Size = new System.Drawing.Size(227, 33);
            this.tbSingleTableName.TabIndex = 1;
            this.tbSingleTableName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSingleTableName.UseSystemPasswordChar = false;
            // 
            // btGenerate
            // 
            this.btGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btGenerate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGenerate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btGenerate.Image = null;
            this.btGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGenerate.InactiveColorA = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btGenerate.InactiveColorB = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.btGenerate.Location = new System.Drawing.Point(456, 450);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.PressedColorA = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btGenerate.PressedColorB = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btGenerate.PressedContourColorA = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btGenerate.PressedContourColorB = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btGenerate.Size = new System.Drawing.Size(289, 46);
            this.btGenerate.TabIndex = 10;
            this.btGenerate.Text = "Generate";
            this.btGenerate.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // lbSaveTo
            // 
            this.lbSaveTo.AutoSize = true;
            this.lbSaveTo.Location = new System.Drawing.Point(33, 459);
            this.lbSaveTo.Name = "lbSaveTo";
            this.lbSaveTo.Size = new System.Drawing.Size(63, 17);
            this.lbSaveTo.TabIndex = 11;
            this.lbSaveTo.Text = "Save To:";
            // 
            // lbSaveToValue
            // 
            this.lbSaveToValue.AutoSize = true;
            this.lbSaveToValue.Location = new System.Drawing.Point(102, 459);
            this.lbSaveToValue.Name = "lbSaveToValue";
            this.lbSaveToValue.Size = new System.Drawing.Size(15, 17);
            this.lbSaveToValue.TabIndex = 12;
            this.lbSaveToValue.Text = "?";
            // 
            // frmGenerateCRUDOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(753, 505);
            this.Controls.Add(this.lbSaveToValue);
            this.Controls.Add(this.lbSaveTo);
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.tbSingleTableName);
            this.Controls.Add(this.tbTableName);
            this.Controls.Add(this.gbColumns);
            this.Controls.Add(this.dgvTableColumns);
            this.Controls.Add(this.lbTableSingleName);
            this.Controls.Add(this.lbTableName);
            this.Controls.Add(this.lbTitle);
            this.MaximizeBox = false;
            this.Name = "frmGenerateCRUDOperations";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate CRUD Operations";
            this.Load += new System.EventHandler(this.frmGenerateCRUDOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableColumns)).EndInit();
            this.gbColumns.ResumeLayout(false);
            this.gbColumns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel lbTitle;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lbTableName;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lbTableSingleName;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvTableColumns;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIsNull;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIsPK;
        private ReaLTaiizor.Controls.CrownGroupBox gbColumns;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lbColumnName;
        private ReaLTaiizor.Controls.HopeComboBox cbDataTypes;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lbDataType;
        private ReaLTaiizor.Controls.PoisonTextBox tbColumnName;
        private ReaLTaiizor.Controls.DungeonButtonLeft btAdd;
        private ReaLTaiizor.Controls.DungeonTextBox tbTableName;
        private ReaLTaiizor.Controls.DungeonTextBox tbSingleTableName;
        private ReaLTaiizor.Controls.DungeonButtonLeft btGenerate;
        private System.Windows.Forms.Label lbSaveTo;
        private System.Windows.Forms.Label lbSaveToValue;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private ReaLTaiizor.Controls.AloneRadioButton rbNotNull;
        private ReaLTaiizor.Controls.AloneRadioButton rbNull;
        private ReaLTaiizor.Controls.AloneRadioButton rbPK;
    }
}