namespace CodeGenerator
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btClose = new System.Windows.Forms.Button();
            this.btSignOut = new System.Windows.Forms.Button();
            this.MainPanel = new ReaLTaiizor.Controls.ExtendedPanel();
            this.btGenerate = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(17, 118);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(186, 43);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSignOut
            // 
            this.btSignOut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignOut.Location = new System.Drawing.Point(17, 69);
            this.btSignOut.Name = "btSignOut";
            this.btSignOut.Size = new System.Drawing.Size(186, 43);
            this.btSignOut.TabIndex = 1;
            this.btSignOut.Text = "Sign Out";
            this.btSignOut.UseVisualStyleBackColor = true;
            this.btSignOut.Click += new System.EventHandler(this.btSignOut_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.btGenerate);
            this.MainPanel.Controls.Add(this.btClose);
            this.MainPanel.Controls.Add(this.btSignOut);
            this.MainPanel.DrawMode = ReaLTaiizor.Controls.ExtendedPanel.Drawer.Default;
            this.MainPanel.Location = new System.Drawing.Point(21, 59);
            this.MainPanel.MostInterval = 100;
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Opacity = 50;
            this.MainPanel.Size = new System.Drawing.Size(222, 179);
            this.MainPanel.TabIndex = 7;
            this.MainPanel.TopMost = true;
            // 
            // btGenerate
            // 
            this.btGenerate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenerate.Location = new System.Drawing.Point(17, 20);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(186, 43);
            this.btGenerate.TabIndex = 0;
            this.btGenerate.Text = "Generate";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(17, 22);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(203, 28);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "CRUD Generator";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 256);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.lbTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Generator";
            this.Load += new System.EventHandler(this.frmCRUDOperationsGenerator_Load);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSignOut;
        private ReaLTaiizor.Controls.ExtendedPanel MainPanel;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btGenerate;
    }
}