namespace FontCollections
{
    partial class frmCollection
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
            this.lvFonts = new System.Windows.Forms.ListView();
            this.btnExportTxt = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvFonts
            // 
            this.lvFonts.Location = new System.Drawing.Point(21, 35);
            this.lvFonts.Name = "lvFonts";
            this.lvFonts.Size = new System.Drawing.Size(363, 333);
            this.lvFonts.TabIndex = 0;
            this.lvFonts.UseCompatibleStateImageBehavior = false;
            this.lvFonts.View = System.Windows.Forms.View.List;
            // 
            // btnExportTxt
            // 
            this.btnExportTxt.Location = new System.Drawing.Point(259, 6);
            this.btnExportTxt.Name = "btnExportTxt";
            this.btnExportTxt.Size = new System.Drawing.Size(125, 23);
            this.btnExportTxt.TabIndex = 1;
            this.btnExportTxt.Text = "输出到txt";
            this.btnExportTxt.UseVisualStyleBackColor = true;
            this.btnExportTxt.Click += new System.EventHandler(this.btnExportTxt_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(21, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜集字体";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 380);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExportTxt);
            this.Controls.Add(this.lvFonts);
            this.Name = "frmCollection";
            this.Text = "字体收集";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvFonts;
        private System.Windows.Forms.Button btnExportTxt;
        private System.Windows.Forms.Button btnSearch;
    }
}

