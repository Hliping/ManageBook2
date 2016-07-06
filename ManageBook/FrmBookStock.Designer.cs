namespace ManageBook
{
    partial class FrmBookStock
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
            this.dgvBookStock = new System.Windows.Forms.DataGridView();
            this.grbBookStock = new System.Windows.Forms.GroupBox();
            this.txtBookStock = new System.Windows.Forms.TextBox();
            this.btnBookStock = new System.Windows.Forms.Button();
            this.cmbBookStock = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookStock)).BeginInit();
            this.grbBookStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBookStock
            // 
            this.dgvBookStock.AllowUserToAddRows = false;
            this.dgvBookStock.AllowUserToDeleteRows = false;
            this.dgvBookStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookStock.Location = new System.Drawing.Point(12, 171);
            this.dgvBookStock.Name = "dgvBookStock";
            this.dgvBookStock.ReadOnly = true;
            this.dgvBookStock.RowTemplate.Height = 23;
            this.dgvBookStock.Size = new System.Drawing.Size(1311, 479);
            this.dgvBookStock.TabIndex = 0;
            // 
            // grbBookStock
            // 
            this.grbBookStock.Controls.Add(this.label2);
            this.grbBookStock.Controls.Add(this.txtBookStock);
            this.grbBookStock.Controls.Add(this.btnBookStock);
            this.grbBookStock.Controls.Add(this.cmbBookStock);
            this.grbBookStock.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grbBookStock.Location = new System.Drawing.Point(12, 12);
            this.grbBookStock.Name = "grbBookStock";
            this.grbBookStock.Size = new System.Drawing.Size(1311, 90);
            this.grbBookStock.TabIndex = 1;
            this.grbBookStock.TabStop = false;
            this.grbBookStock.Text = "查询";
            // 
            // txtBookStock
            // 
            this.txtBookStock.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBookStock.Location = new System.Drawing.Point(563, 29);
            this.txtBookStock.Name = "txtBookStock";
            this.txtBookStock.Size = new System.Drawing.Size(205, 29);
            this.txtBookStock.TabIndex = 2;
            // 
            // btnBookStock
            // 
            this.btnBookStock.Location = new System.Drawing.Point(801, 28);
            this.btnBookStock.Name = "btnBookStock";
            this.btnBookStock.Size = new System.Drawing.Size(75, 30);
            this.btnBookStock.TabIndex = 1;
            this.btnBookStock.Text = "查询";
            this.btnBookStock.UseVisualStyleBackColor = true;
            this.btnBookStock.Click += new System.EventHandler(this.btnBookStock_Click);
            // 
            // cmbBookStock
            // 
            this.cmbBookStock.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbBookStock.FormattingEnabled = true;
            this.cmbBookStock.Items.AddRange(new object[] {
            "———全部———",
            "教材名称",
            "ISBN码",
            "作者",
            "出版社"});
            this.cmbBookStock.Location = new System.Drawing.Point(353, 31);
            this.cmbBookStock.Name = "cmbBookStock";
            this.cmbBookStock.Size = new System.Drawing.Size(184, 27);
            this.cmbBookStock.TabIndex = 0;
            this.cmbBookStock.Text = "———全部———";
            this.cmbBookStock.SelectionChangeCommitted += new System.EventHandler(this.cmbBookStock_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(565, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "教材库存";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = ":";
            // 
            // FrmBookStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 652);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbBookStock);
            this.Controls.Add(this.dgvBookStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBookStock";
            this.Text = "教材库存";
            this.Load += new System.EventHandler(this.FrmBookStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookStock)).EndInit();
            this.grbBookStock.ResumeLayout(false);
            this.grbBookStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookStock;
        private System.Windows.Forms.GroupBox grbBookStock;
        private System.Windows.Forms.Button btnBookStock;
        private System.Windows.Forms.ComboBox cmbBookStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookStock;
        private System.Windows.Forms.Label label2;
    }
}