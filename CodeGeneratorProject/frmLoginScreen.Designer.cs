namespace CodeGenerator
{
    partial class frmLoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginScreen));
            this.cbDataBaseNames = new ReaLTaiizor.Controls.HopeComboBox();
            this.btLogin = new ReaLTaiizor.Controls.ChatButtonLeft();
            this.cbDatabases = new ReaLTaiizor.Controls.HopeComboBox();
            this.SuspendLayout();
            // 
            // cbDataBaseNames
            // 
            this.cbDataBaseNames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDataBaseNames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDataBaseNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBaseNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDataBaseNames.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDataBaseNames.FormattingEnabled = true;
            this.cbDataBaseNames.ItemHeight = 30;
            this.cbDataBaseNames.Items.AddRange(new object[] {
            "Microsoft SQL Server",
            "MySQL",
            "Oracle",
            "PostgreSQL"});
            this.cbDataBaseNames.Location = new System.Drawing.Point(291, 125);
            this.cbDataBaseNames.Name = "cbDataBaseNames";
            this.cbDataBaseNames.Size = new System.Drawing.Size(256, 36);
            this.cbDataBaseNames.Sorted = true;
            this.cbDataBaseNames.TabIndex = 0;
            this.cbDataBaseNames.SelectedIndexChanged += new System.EventHandler(this.cbDataBaseNames_SelectedIndexChanged);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.Transparent;
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btLogin.Image = null;
            this.btLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogin.InactiveColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btLogin.InactiveColorB = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btLogin.Location = new System.Drawing.Point(340, 259);
            this.btLogin.Name = "btLogin";
            this.btLogin.PressedColorA = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btLogin.PressedColorB = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btLogin.PressedContourColorA = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btLogin.PressedContourColorB = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btLogin.Size = new System.Drawing.Size(166, 40);
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "Login";
            this.btLogin.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btLogin.Visible = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // cbDatabases
            // 
            this.cbDatabases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDatabases.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatabases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDatabases.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.ItemHeight = 30;
            this.cbDatabases.Location = new System.Drawing.Point(313, 181);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(219, 36);
            this.cbDatabases.Sorted = true;
            this.cbDatabases.TabIndex = 4;
            // 
            // frmLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CodeGenerator.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(575, 401);
            this.Controls.Add(this.cbDatabases);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.cbDataBaseNames);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLoginScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Screen";
            this.Load += new System.EventHandler(this.frmDataBaseLoginScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.HopeComboBox cbDataBaseNames;
        private ReaLTaiizor.Controls.ChatButtonLeft btLogin;
        private ReaLTaiizor.Controls.HopeComboBox cbDatabases;
    }
}