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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBookStock = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookStock)).BeginInit();
            this.grbBookStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBookStock
            // 
            this.dgvBookStock.AllowUserToAddRows = false;
            this.dgvBookStock.AllowUserToDeleteRows = false;
            this.dgvBookStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookStock.Location = new System.Drawing.Point(189, 171);
            this.dgvBookStock.Name = "dgvBookStock";
            this.dgvBookStock.ReadOnly = true;
            this.dgvBookStock.RowTemplate.Height = 23;
            this.dgvBookStock.Size = new System.Drawing.Size(938, 479);
            this.dgvBookStock.TabIndex = 0;
            // 
            // grbBookStock
            // 
            this.grbBookStock.Controls.Add(this.button1);
            this.grbBookStock.Controls.Add(this.cmbBookStock);
            this.grbBookStock.Location = new System.Drawing.Point(95, 13);
            this.grbBookStock.Name = "grbBookStock";
            this.grbBookStock.Size = new System.Drawing.Size(1116, 100);
            this.grbBookStock.TabIndex = 1;
            this.grbBookStock.TabStop = false;
            this.grbBookStock.Text = "查询";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(611, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "库存";
            // 
            // cmbBookStock
            // 
            this.cmbBookStock.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbBookStock.FormattingEnabled = true;
            this.cmbBookStock.Location = new System.Drawing.Point(334, 34);
            this.cmbBookStock.Name = "cmbBookStock";
            this.cmbBookStock.Size = new System.Drawing.Size(243, 24);
            this.cmbBookStock.TabIndex = 0;
            this.cmbBookStock.SelectionChangeCommitted += new System.EventHandler(this.cmbBookStock_SelectionChangeCommitted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(855, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookStock;
        private System.Windows.Forms.GroupBox grbBookStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbBookStock;
        private System.Windows.Forms.Label label1;
    }
}