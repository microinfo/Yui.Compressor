namespace TintSoft
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCompressor = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEncoder = new System.Windows.Forms.ComboBox();
            this.linkadmin5 = new System.Windows.Forms.LinkLabel();
            this.ListFile = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(389, 14);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(67, 29);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(464, 12);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 29);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "加  载";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCompressor
            // 
            this.btnCompressor.Location = new System.Drawing.Point(572, 14);
            this.btnCompressor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCompressor.Name = "btnCompressor";
            this.btnCompressor.Size = new System.Drawing.Size(100, 29);
            this.btnCompressor.TabIndex = 2;
            this.btnCompressor.Text = "压 缩";
            this.btnCompressor.UseVisualStyleBackColor = true;
            this.btnCompressor.Click += new System.EventHandler(this.btnCompressor_Click);
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(16, 15);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(364, 25);
            this.txtPath.TabIndex = 3;
            // 
            // txtInfo
            // 
            this.txtInfo.Enabled = false;
            this.txtInfo.Location = new System.Drawing.Point(16, 49);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(655, 25);
            this.txtInfo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 450);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "编码类型：";
            // 
            // cbEncoder
            // 
            this.cbEncoder.FormattingEnabled = true;
            this.cbEncoder.Items.AddRange(new object[] {
            "UTF-8",
            "ASCII",
            "Default",
            "Unicode"});
            this.cbEncoder.Location = new System.Drawing.Point(111, 445);
            this.cbEncoder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEncoder.Name = "cbEncoder";
            this.cbEncoder.Size = new System.Drawing.Size(99, 23);
            this.cbEncoder.TabIndex = 6;
            this.cbEncoder.Text = "UTF-8";
            // 
            // linkadmin5
            // 
            this.linkadmin5.AutoSize = true;
            this.linkadmin5.Location = new System.Drawing.Point(489, 450);
            this.linkadmin5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkadmin5.Name = "linkadmin5";
            this.linkadmin5.Size = new System.Drawing.Size(191, 15);
            this.linkadmin5.TabIndex = 7;
            this.linkadmin5.TabStop = true;
            this.linkadmin5.Text = "http://www.tintsoft.com";
            this.linkadmin5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkadmin5_LinkClicked);
            // 
            // ListFile
            // 
            this.ListFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListFile.FullRowSelect = true;
            this.ListFile.GridLines = true;
            this.ListFile.HideSelection = false;
            this.ListFile.Location = new System.Drawing.Point(16, 82);
            this.ListFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListFile.MultiSelect = false;
            this.ListFile.Name = "ListFile";
            this.ListFile.ShowGroups = false;
            this.ListFile.Size = new System.Drawing.Size(655, 354);
            this.ListFile.TabIndex = 5;
            this.ListFile.UseCompatibleStateImageBehavior = false;
            this.ListFile.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "文件";
            this.columnHeader1.Width = 228;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "原大小";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "压缩后大小";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "状态";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 479);
            this.Controls.Add(this.ListFile);
            this.Controls.Add(this.linkadmin5);
            this.Controls.Add(this.cbEncoder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnCompressor);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Yui.Compressor -- By 天智软件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCompressor;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEncoder;
        private System.Windows.Forms.LinkLabel linkadmin5;
        private System.Windows.Forms.ListView ListFile;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

