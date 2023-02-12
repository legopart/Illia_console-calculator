namespace GoogleSearch
{
    partial class frmGoogleSearch
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoogleSearch));
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.txtSearchBy = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.lblResultTitle = new System.Windows.Forms.Label();
            this.lblResultNumber = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(15, 18);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(58, 15);
            this.lblSearchBy.TabIndex = 0;
            this.lblSearchBy.Text = "Search By";
            // 
            // txtSearchBy
            // 
            this.txtSearchBy.Location = new System.Drawing.Point(79, 15);
            this.txtSearchBy.Name = "txtSearchBy";
            this.txtSearchBy.Size = new System.Drawing.Size(593, 23);
            this.txtSearchBy.TabIndex = 1;
            this.txtSearchBy.Text = "Ilya";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(678, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlResults
            // 
            this.pnlResults.Controls.Add(this.lblResultTitle);
            this.pnlResults.Controls.Add(this.lblResultNumber);
            this.pnlResults.Location = new System.Drawing.Point(22, 54);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(362, 389);
            this.pnlResults.TabIndex = 3;
            // 
            // lblResultTitle
            // 
            this.lblResultTitle.AutoSize = true;
            this.lblResultTitle.Location = new System.Drawing.Point(44, 12);
            this.lblResultTitle.Name = "lblResultTitle";
            this.lblResultTitle.Size = new System.Drawing.Size(58, 15);
            this.lblResultTitle.TabIndex = 1;
            this.lblResultTitle.Text = "Result # 1";
            this.lblResultTitle.Visible = false;
            // 
            // lblResultNumber
            // 
            this.lblResultNumber.AutoSize = true;
            this.lblResultNumber.Location = new System.Drawing.Point(11, 12);
            this.lblResultNumber.Name = "lblResultNumber";
            this.lblResultNumber.Size = new System.Drawing.Size(13, 15);
            this.lblResultNumber.TabIndex = 0;
            this.lblResultNumber.Text = "1";
            this.lblResultNumber.Visible = false;
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(390, 54);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowTemplate.Height = 25;
            this.dgvResults.Size = new System.Drawing.Size(363, 389);
            this.dgvResults.TabIndex = 4;
            // 
            // frmGoogleSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 455);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchBy);
            this.Controls.Add(this.lblSearchBy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGoogleSearch";
            this.Text = "Google search";
            this.pnlResults.ResumeLayout(false);
            this.pnlResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.TextBox txtSearchBy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.Label lblResultTitle;
        private System.Windows.Forms.Label lblResultNumber;
        private System.Windows.Forms.DataGridView dgvResults;
    }
}
