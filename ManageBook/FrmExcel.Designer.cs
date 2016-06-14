namespace ManageBook
{
    partial class FrmExcel
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
            this.dgvExcel = new System.Windows.Forms.DataGridView();
            this.btnAddStudentInfo = new System.Windows.Forms.Button();
            this.lbltisi = new System.Windows.Forms.Label();
            this.lblrecord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExcel
            // 
            this.dgvExcel.AllowUserToAddRows = false;
            this.dgvExcel.AllowUserToDeleteRows = false;
            this.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcel.Location = new System.Drawing.Point(12, 40);
            this.dgvExcel.Name = "dgvExcel";
            this.dgvExcel.ReadOnly = true;
            this.dgvExcel.RowTemplate.Height = 23;
            this.dgvExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExcel.Size = new System.Drawing.Size(843, 408);
            this.dgvExcel.TabIndex = 0;
            // 
            // btnAddStudentInfo
            // 
            this.btnAddStudentInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddStudentInfo.Location = new System.Drawing.Point(399, 478);
            this.btnAddStudentInfo.Name = "btnAddStudentInfo";
            this.btnAddStudentInfo.Size = new System.Drawing.Size(102, 30);
            this.btnAddStudentInfo.TabIndex = 1;
            this.btnAddStudentInfo.Text = "确认添加";
            this.btnAddStudentInfo.UseVisualStyleBackColor = true;
            this.btnAddStudentInfo.Click += new System.EventHandler(this.btnAddStudentInfo_Click);
            // 
            // lbltisi
            // 
            this.lbltisi.AutoSize = true;
            this.lbltisi.ForeColor = System.Drawing.Color.Red;
            this.lbltisi.Location = new System.Drawing.Point(527, 489);
            this.lbltisi.Name = "lbltisi";
            this.lbltisi.Size = new System.Drawing.Size(0, 12);
            this.lbltisi.TabIndex = 2;
            // 
            // lblrecord
            // 
            this.lblrecord.AutoSize = true;
            this.lblrecord.Location = new System.Drawing.Point(41, 12);
            this.lblrecord.Name = "lblrecord";
            this.lblrecord.Size = new System.Drawing.Size(0, 12);
            this.lblrecord.TabIndex = 3;
            // 
            // FrmExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 521);
            this.Controls.Add(this.lblrecord);
            this.Controls.Add(this.lbltisi);
            this.Controls.Add(this.btnAddStudentInfo);
            this.Controls.Add(this.dgvExcel);
            this.Name = "FrmExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "批量添加学生信息";
            this.Load += new System.EventHandler(this.FrmExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvExcel;
        private System.Windows.Forms.Button btnAddStudentInfo;
        private System.Windows.Forms.Label lbltisi;
        private System.Windows.Forms.Label lblrecord;
    }
}