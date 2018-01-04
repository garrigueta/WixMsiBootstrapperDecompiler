namespace MSIBootstrapperDecompiler
{
    partial class FormPral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPral));
            this.panelRequirements = new System.Windows.Forms.Panel();
            this.labelInstalled = new System.Windows.Forms.Label();
            this.labelRequirements = new System.Windows.Forms.Label();
            this.linkLabelWixToolsetInstallLink = new System.Windows.Forms.LinkLabel();
            this.labelWixInstalled = new System.Windows.Forms.Label();
            this.openFileDialogMSI = new System.Windows.Forms.OpenFileDialog();
            this.buttonFindFile = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.labelResults = new System.Windows.Forms.Label();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.GridViewColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridViewColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLabelOutputFolder = new System.Windows.Forms.LinkLabel();
            this.panelRequirements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRequirements
            // 
            this.panelRequirements.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelRequirements.Controls.Add(this.labelInstalled);
            this.panelRequirements.Controls.Add(this.labelRequirements);
            this.panelRequirements.Controls.Add(this.linkLabelWixToolsetInstallLink);
            this.panelRequirements.Controls.Add(this.labelWixInstalled);
            this.panelRequirements.Location = new System.Drawing.Point(12, 10);
            this.panelRequirements.Name = "panelRequirements";
            this.panelRequirements.Size = new System.Drawing.Size(308, 23);
            this.panelRequirements.TabIndex = 0;
            // 
            // labelInstalled
            // 
            this.labelInstalled.AutoSize = true;
            this.labelInstalled.Location = new System.Drawing.Point(219, 3);
            this.labelInstalled.Name = "labelInstalled";
            this.labelInstalled.Size = new System.Drawing.Size(60, 17);
            this.labelInstalled.TabIndex = 3;
            this.labelInstalled.Text = "Installed";
            this.labelInstalled.Visible = false;
            // 
            // labelRequirements
            // 
            this.labelRequirements.AutoSize = true;
            this.labelRequirements.Location = new System.Drawing.Point(3, 3);
            this.labelRequirements.Name = "labelRequirements";
            this.labelRequirements.Size = new System.Drawing.Size(108, 17);
            this.labelRequirements.TabIndex = 2;
            this.labelRequirements.Text = "Requirements : ";
            // 
            // linkLabelWixToolsetInstallLink
            // 
            this.linkLabelWixToolsetInstallLink.AutoSize = true;
            this.linkLabelWixToolsetInstallLink.Location = new System.Drawing.Point(218, 3);
            this.linkLabelWixToolsetInstallLink.Name = "linkLabelWixToolsetInstallLink";
            this.linkLabelWixToolsetInstallLink.Size = new System.Drawing.Size(66, 17);
            this.linkLabelWixToolsetInstallLink.TabIndex = 1;
            this.linkLabelWixToolsetInstallLink.TabStop = true;
            this.linkLabelWixToolsetInstallLink.Text = "Install wix";
            this.linkLabelWixToolsetInstallLink.Visible = false;
            this.linkLabelWixToolsetInstallLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWixToolsetInstallLink_LinkClicked);
            // 
            // labelWixInstalled
            // 
            this.labelWixInstalled.AutoSize = true;
            this.labelWixInstalled.Location = new System.Drawing.Point(117, 3);
            this.labelWixInstalled.Name = "labelWixInstalled";
            this.labelWixInstalled.Size = new System.Drawing.Size(83, 17);
            this.labelWixInstalled.TabIndex = 0;
            this.labelWixInstalled.Text = "Wix Installer";
            // 
            // openFileDialogMSI
            // 
            this.openFileDialogMSI.FileName = "openFileDialogMSIFile";
            // 
            // buttonFindFile
            // 
            this.buttonFindFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindFile.Location = new System.Drawing.Point(694, 40);
            this.buttonFindFile.Name = "buttonFindFile";
            this.buttonFindFile.Size = new System.Drawing.Size(101, 47);
            this.buttonFindFile.TabIndex = 1;
            this.buttonFindFile.Text = "Pick File";
            this.buttonFindFile.UseVisualStyleBackColor = true;
            this.buttonFindFile.Click += new System.EventHandler(this.buttonFindFile_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFileName.Location = new System.Drawing.Point(12, 41);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(676, 30);
            this.textBoxFileName.TabIndex = 2;
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(15, 74);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(63, 17);
            this.labelResults.TabIndex = 3;
            this.labelResults.Text = "Results :";
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.AllowUserToAddRows = false;
            this.dataGridViewResults.AllowUserToDeleteRows = false;
            this.dataGridViewResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridViewColumnName,
            this.GridViewColumnValue});
            this.dataGridViewResults.Location = new System.Drawing.Point(12, 94);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.ReadOnly = true;
            this.dataGridViewResults.RowHeadersVisible = false;
            this.dataGridViewResults.RowTemplate.Height = 24;
            this.dataGridViewResults.Size = new System.Drawing.Size(783, 189);
            this.dataGridViewResults.TabIndex = 4;
            this.dataGridViewResults.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewResults_MouseClick);
            // 
            // GridViewColumnName
            // 
            this.GridViewColumnName.HeaderText = "Name";
            this.GridViewColumnName.Name = "GridViewColumnName";
            this.GridViewColumnName.ReadOnly = true;
            // 
            // GridViewColumnValue
            // 
            this.GridViewColumnValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GridViewColumnValue.HeaderText = "Value";
            this.GridViewColumnValue.Name = "GridViewColumnValue";
            this.GridViewColumnValue.ReadOnly = true;
            // 
            // linkLabelOutputFolder
            // 
            this.linkLabelOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelOutputFolder.AutoSize = true;
            this.linkLabelOutputFolder.Location = new System.Drawing.Point(700, 289);
            this.linkLabelOutputFolder.Name = "linkLabelOutputFolder";
            this.linkLabelOutputFolder.Size = new System.Drawing.Size(95, 17);
            this.linkLabelOutputFolder.TabIndex = 5;
            this.linkLabelOutputFolder.TabStop = true;
            this.linkLabelOutputFolder.Text = "Output Folder";
            this.linkLabelOutputFolder.Visible = false;
            this.linkLabelOutputFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOutputFolder_LinkClicked);
            // 
            // FormPral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 315);
            this.Controls.Add(this.linkLabelOutputFolder);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.buttonFindFile);
            this.Controls.Add(this.panelRequirements);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 300);
            this.Name = "FormPral";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSI Decompiler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPral_FormClosing);
            this.Load += new System.EventHandler(this.FormPral_Load);
            this.panelRequirements.ResumeLayout(false);
            this.panelRequirements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRequirements;
        private System.Windows.Forms.Label labelWixInstalled;
        private System.Windows.Forms.LinkLabel linkLabelWixToolsetInstallLink;
        private System.Windows.Forms.Label labelInstalled;
        private System.Windows.Forms.Label labelRequirements;
        private System.Windows.Forms.OpenFileDialog openFileDialogMSI;
        private System.Windows.Forms.Button buttonFindFile;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.LinkLabel linkLabelOutputFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridViewColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridViewColumnValue;
    }
}

