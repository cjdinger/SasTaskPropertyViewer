namespace SASPress.Examples
{
    partial class SasTaskPropertyViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SasTaskPropertyViewer));
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbProcessFlows = new System.Windows.Forms.ComboBox();
            this.lblFlows = new System.Windows.Forms.Label();
            this.lbTasks = new System.Windows.Forms.ListBox();
            this.lblTasks = new System.Windows.Forms.Label();
            this.gbProperties = new System.Windows.Forms.GroupBox();
            this.lblLastModified = new System.Windows.Forms.Label();
            this.lblModifiedBy = new System.Windows.Forms.Label();
            this.lblTaskType = new System.Windows.Forms.Label();
            this.lblInternal = new System.Windows.Forms.Label();
            this.txtInternal = new System.Windows.Forms.TextBox();
            this.btnViewXml = new System.Windows.Forms.Button();
            this.btnViewText = new System.Windows.Forms.Button();
            this.pbTaskIcon = new System.Windows.Forms.PictureBox();
            this.panelNoTask = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gbProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTaskIcon)).BeginInit();
            this.panelNoTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(442, 275);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbProcessFlows
            // 
            this.cmbProcessFlows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcessFlows.FormattingEnabled = true;
            this.cmbProcessFlows.Location = new System.Drawing.Point(12, 33);
            this.cmbProcessFlows.Name = "cmbProcessFlows";
            this.cmbProcessFlows.Size = new System.Drawing.Size(207, 21);
            this.cmbProcessFlows.TabIndex = 1;
            this.cmbProcessFlows.SelectedValueChanged += new System.EventHandler(this.OnSelectedFlowChanged);
            // 
            // lblFlows
            // 
            this.lblFlows.AutoSize = true;
            this.lblFlows.Location = new System.Drawing.Point(12, 14);
            this.lblFlows.Name = "lblFlows";
            this.lblFlows.Size = new System.Drawing.Size(102, 13);
            this.lblFlows.TabIndex = 0;
            this.lblFlows.Text = "Select process flow:";
            // 
            // lbTasks
            // 
            this.lbTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTasks.FormattingEnabled = true;
            this.lbTasks.Location = new System.Drawing.Point(12, 91);
            this.lbTasks.Name = "lbTasks";
            this.lbTasks.Size = new System.Drawing.Size(207, 173);
            this.lbTasks.TabIndex = 3;
            this.lbTasks.SelectedValueChanged += new System.EventHandler(this.OnSelectedTaskChanged);
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Location = new System.Drawing.Point(12, 72);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(72, 13);
            this.lblTasks.TabIndex = 2;
            this.lblTasks.Text = "Tasks in flow:";
            // 
            // gbProperties
            // 
            this.gbProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProperties.Controls.Add(this.lblLastModified);
            this.gbProperties.Controls.Add(this.lblModifiedBy);
            this.gbProperties.Controls.Add(this.lblTaskType);
            this.gbProperties.Controls.Add(this.lblInternal);
            this.gbProperties.Controls.Add(this.txtInternal);
            this.gbProperties.Controls.Add(this.btnViewXml);
            this.gbProperties.Controls.Add(this.btnViewText);
            this.gbProperties.Controls.Add(this.pbTaskIcon);
            this.gbProperties.Controls.Add(this.panelNoTask);
            this.gbProperties.Location = new System.Drawing.Point(225, 14);
            this.gbProperties.Name = "gbProperties";
            this.gbProperties.Size = new System.Drawing.Size(273, 250);
            this.gbProperties.TabIndex = 4;
            this.gbProperties.TabStop = false;
            this.gbProperties.Text = "Properties";
            // 
            // lblLastModified
            // 
            this.lblLastModified.AutoSize = true;
            this.lblLastModified.Location = new System.Drawing.Point(48, 16);
            this.lblLastModified.Name = "lblLastModified";
            this.lblLastModified.Size = new System.Drawing.Size(72, 13);
            this.lblLastModified.TabIndex = 0;
            this.lblLastModified.Text = "Last modified:";
            // 
            // lblModifiedBy
            // 
            this.lblModifiedBy.AutoSize = true;
            this.lblModifiedBy.Location = new System.Drawing.Point(48, 35);
            this.lblModifiedBy.Name = "lblModifiedBy";
            this.lblModifiedBy.Size = new System.Drawing.Size(64, 13);
            this.lblModifiedBy.TabIndex = 1;
            this.lblModifiedBy.Text = "Modified by:";
            // 
            // lblTaskType
            // 
            this.lblTaskType.AutoSize = true;
            this.lblTaskType.Location = new System.Drawing.Point(7, 51);
            this.lblTaskType.Name = "lblTaskType";
            this.lblTaskType.Size = new System.Drawing.Size(58, 13);
            this.lblTaskType.TabIndex = 2;
            this.lblTaskType.Text = "Task Type";
            // 
            // lblInternal
            // 
            this.lblInternal.AutoSize = true;
            this.lblInternal.Location = new System.Drawing.Point(7, 77);
            this.lblInternal.Name = "lblInternal";
            this.lblInternal.Size = new System.Drawing.Size(73, 13);
            this.lblInternal.TabIndex = 3;
            this.lblInternal.Text = "Internal State:";
            // 
            // txtInternal
            // 
            this.txtInternal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInternal.Location = new System.Drawing.Point(10, 93);
            this.txtInternal.Multiline = true;
            this.txtInternal.Name = "txtInternal";
            this.txtInternal.ReadOnly = true;
            this.txtInternal.Size = new System.Drawing.Size(257, 122);
            this.txtInternal.TabIndex = 4;
            // 
            // btnViewXml
            // 
            this.btnViewXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnViewXml.Location = new System.Drawing.Point(10, 221);
            this.btnViewXml.Name = "btnViewXml";
            this.btnViewXml.Size = new System.Drawing.Size(73, 23);
            this.btnViewXml.TabIndex = 5;
            this.btnViewXml.Text = "View XML";
            this.btnViewXml.UseVisualStyleBackColor = true;
            this.btnViewXml.Click += new System.EventHandler(this.btnViewExternal_Click);
            // 
            // btnViewText
            // 
            this.btnViewText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnViewText.Location = new System.Drawing.Point(89, 221);
            this.btnViewText.Name = "btnViewText";
            this.btnViewText.Size = new System.Drawing.Size(73, 23);
            this.btnViewText.TabIndex = 6;
            this.btnViewText.Text = "View text";
            this.btnViewText.UseVisualStyleBackColor = true;
            this.btnViewText.Click += new System.EventHandler(this.btnViewExternal_Click);
            // 
            // pbTaskIcon
            // 
            this.pbTaskIcon.Location = new System.Drawing.Point(10, 16);
            this.pbTaskIcon.Name = "pbTaskIcon";
            this.pbTaskIcon.Size = new System.Drawing.Size(32, 32);
            this.pbTaskIcon.TabIndex = 1;
            this.pbTaskIcon.TabStop = false;
            // 
            // panelNoTask
            // 
            this.panelNoTask.Controls.Add(this.label2);
            this.panelNoTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoTask.Location = new System.Drawing.Point(3, 16);
            this.panelNoTask.Name = "panelNoTask";
            this.panelNoTask.Size = new System.Drawing.Size(267, 231);
            this.panelNoTask.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 231);
            this.label2.TabIndex = 0;
            this.label2.Text = "No task selected";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Location = new System.Drawing.Point(12, 271);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh Contents";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // SasTaskPropertyViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 305);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gbProperties);
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.lbTasks);
            this.Controls.Add(this.lblFlows);
            this.Controls.Add(this.cmbProcessFlows);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "SasTaskPropertyViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Task Property Viewer";
            this.gbProperties.ResumeLayout(false);
            this.gbProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTaskIcon)).EndInit();
            this.panelNoTask.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbProcessFlows;
        private System.Windows.Forms.Label lblFlows;
        private System.Windows.Forms.ListBox lbTasks;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.GroupBox gbProperties;
        private System.Windows.Forms.PictureBox pbTaskIcon;
        private System.Windows.Forms.Label lblTaskType;
        private System.Windows.Forms.Button btnViewText;
        private System.Windows.Forms.TextBox txtInternal;
        private System.Windows.Forms.Label lblInternal;
        private System.Windows.Forms.Button btnViewXml;
        private System.Windows.Forms.Label lblModifiedBy;
        private System.Windows.Forms.Label lblLastModified;
        private System.Windows.Forms.Panel panelNoTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
    }
}