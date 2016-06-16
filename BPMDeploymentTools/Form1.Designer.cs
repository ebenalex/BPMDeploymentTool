namespace BPMDeploymentTools
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSourceDirectory = new System.Windows.Forms.TextBox();
            this.btnSelectSourceDirectory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chkProcess = new System.Windows.Forms.CheckBox();
            this.chkWeb = new System.Windows.Forms.CheckBox();
            this.chkService = new System.Windows.Forms.CheckBox();
            this.chkReports = new System.Windows.Forms.CheckBox();
            this.txtDestDirectory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeploy = new System.Windows.Forms.Button();
            this.lvResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSelectDestDirectory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "开发目录：";
            // 
            // txtSourceDirectory
            // 
            this.txtSourceDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceDirectory.Location = new System.Drawing.Point(90, 18);
            this.txtSourceDirectory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSourceDirectory.Name = "txtSourceDirectory";
            this.txtSourceDirectory.Size = new System.Drawing.Size(520, 25);
            this.txtSourceDirectory.TabIndex = 1;
            this.txtSourceDirectory.Text = "\\\\rca113va\\d$\\Program Files\\FlowPortal.net";
            // 
            // btnSelectSourceDirectory
            // 
            this.btnSelectSourceDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectSourceDirectory.Location = new System.Drawing.Point(617, 16);
            this.btnSelectSourceDirectory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectSourceDirectory.Name = "btnSelectSourceDirectory";
            this.btnSelectSourceDirectory.Size = new System.Drawing.Size(87, 33);
            this.btnSelectSourceDirectory.TabIndex = 2;
            this.btnSelectSourceDirectory.Text = "选择目录";
            this.btnSelectSourceDirectory.UseVisualStyleBackColor = true;
            this.btnSelectSourceDirectory.Click += new System.EventHandler(this.btnSelectSourceDirectory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "开发时间：";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(91, 79);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(233, 25);
            this.dtpDate.TabIndex = 4;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(331, 79);
            this.txtTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(139, 25);
            this.txtTime.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(476, 76);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(146, 33);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "搜索开发相关的文件";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chkProcess
            // 
            this.chkProcess.AutoSize = true;
            this.chkProcess.Checked = true;
            this.chkProcess.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkProcess.Location = new System.Drawing.Point(12, 51);
            this.chkProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkProcess.Name = "chkProcess";
            this.chkProcess.Size = new System.Drawing.Size(69, 21);
            this.chkProcess.TabIndex = 7;
            this.chkProcess.Text = "Process";
            this.chkProcess.UseVisualStyleBackColor = true;
            // 
            // chkWeb
            // 
            this.chkWeb.AutoSize = true;
            this.chkWeb.Checked = true;
            this.chkWeb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWeb.Location = new System.Drawing.Point(96, 51);
            this.chkWeb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkWeb.Name = "chkWeb";
            this.chkWeb.Size = new System.Drawing.Size(52, 21);
            this.chkWeb.TabIndex = 8;
            this.chkWeb.Text = "Web";
            this.chkWeb.UseVisualStyleBackColor = true;
            // 
            // chkService
            // 
            this.chkService.AutoSize = true;
            this.chkService.Checked = true;
            this.chkService.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkService.Location = new System.Drawing.Point(160, 51);
            this.chkService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkService.Name = "chkService";
            this.chkService.Size = new System.Drawing.Size(96, 21);
            this.chkService.TabIndex = 9;
            this.chkService.Text = "FormService";
            this.chkService.UseVisualStyleBackColor = true;
            // 
            // chkReports
            // 
            this.chkReports.AutoSize = true;
            this.chkReports.Location = new System.Drawing.Point(272, 51);
            this.chkReports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkReports.Name = "chkReports";
            this.chkReports.Size = new System.Drawing.Size(71, 21);
            this.chkReports.TabIndex = 10;
            this.chkReports.Text = "Reports";
            this.chkReports.UseVisualStyleBackColor = true;
            // 
            // txtDestDirectory
            // 
            this.txtDestDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestDirectory.Location = new System.Drawing.Point(90, 117);
            this.txtDestDirectory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDestDirectory.Name = "txtDestDirectory";
            this.txtDestDirectory.Size = new System.Drawing.Size(429, 25);
            this.txtDestDirectory.TabIndex = 12;
            this.txtDestDirectory.Text = "\\\\rca064\\c$\\Program Files (x86)\\FlowPortal.net";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "部署目录：";
            // 
            // btnDeploy
            // 
            this.btnDeploy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeploy.Location = new System.Drawing.Point(628, 113);
            this.btnDeploy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeploy.Name = "btnDeploy";
            this.btnDeploy.Size = new System.Drawing.Size(87, 33);
            this.btnDeploy.TabIndex = 13;
            this.btnDeploy.Text = "部署";
            this.btnDeploy.UseVisualStyleBackColor = true;
            this.btnDeploy.Click += new System.EventHandler(this.btnDeploy_Click);
            // 
            // lvResult
            // 
            this.lvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvResult.CheckBoxes = true;
            this.lvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvResult.FullRowSelect = true;
            this.lvResult.GridLines = true;
            this.lvResult.Location = new System.Drawing.Point(16, 154);
            this.lvResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(698, 432);
            this.lvResult.TabIndex = 14;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.View = System.Windows.Forms.View.Details;
            this.lvResult.ItemActivate += new System.EventHandler(this.lvResult_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "变更文件路径";
            this.columnHeader1.Width = 1000;
            // 
            // btnSelectDestDirectory
            // 
            this.btnSelectDestDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectDestDirectory.Location = new System.Drawing.Point(535, 113);
            this.btnSelectDestDirectory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectDestDirectory.Name = "btnSelectDestDirectory";
            this.btnSelectDestDirectory.Size = new System.Drawing.Size(87, 33);
            this.btnSelectDestDirectory.TabIndex = 15;
            this.btnSelectDestDirectory.Text = "选择目录";
            this.btnSelectDestDirectory.UseVisualStyleBackColor = true;
            this.btnSelectDestDirectory.Click += new System.EventHandler(this.btnSelectDestDirectory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 605);
            this.Controls.Add(this.btnSelectDestDirectory);
            this.Controls.Add(this.lvResult);
            this.Controls.Add(this.btnDeploy);
            this.Controls.Add(this.txtDestDirectory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkReports);
            this.Controls.Add(this.chkService);
            this.Controls.Add(this.chkWeb);
            this.Controls.Add(this.chkProcess);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectSourceDirectory);
            this.Controls.Add(this.txtSourceDirectory);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "BPM 部署利器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSourceDirectory;
        private System.Windows.Forms.Button btnSelectSourceDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chkProcess;
        private System.Windows.Forms.CheckBox chkWeb;
        private System.Windows.Forms.CheckBox chkService;
        private System.Windows.Forms.CheckBox chkReports;
        private System.Windows.Forms.TextBox txtDestDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeploy;
        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnSelectDestDirectory;
    }
}

