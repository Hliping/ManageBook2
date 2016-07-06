namespace ManageBook
{
    partial class FrmNoArriveBook
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtDelect = new System.Windows.Forms.TextBox();
            this.cmbInformation = new System.Windows.Forms.ComboBox();
            this.dgvNoArrive = new System.Windows.Forms.DataGridView();
            this.库存编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.教材名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作者 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出版社 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.订购数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.已到数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.未到数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoArrive)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(582, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 40;
            this.label3.Text = "未到教材";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.txtDelect);
            this.groupBox1.Controls.Add(this.cmbInformation);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1311, 90);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = ":";
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelect.Location = new System.Drawing.Point(855, 27);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 30);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "查 询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtDelect
            // 
            this.txtDelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDelect.Location = new System.Drawing.Point(587, 28);
            this.txtDelect.Name = "txtDelect";
            this.txtDelect.Size = new System.Drawing.Size(221, 29);
            this.txtDelect.TabIndex = 2;
            // 
            // cmbInformation
            // 
            this.cmbInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbInformation.FormattingEnabled = true;
            this.cmbInformation.Items.AddRange(new object[] {
            "———全部———",
            "教材名称",
            "ISBN码",
            "作者",
            "出版社"});
            this.cmbInformation.Location = new System.Drawing.Point(380, 29);
            this.cmbInformation.Name = "cmbInformation";
            this.cmbInformation.Size = new System.Drawing.Size(184, 27);
            this.cmbInformation.TabIndex = 0;
            this.cmbInformation.Text = "———全部———";
            this.cmbInformation.SelectionChangeCommitted += new System.EventHandler(this.cmbInformation_SelectionChangeCommitted);
            // 
            // dgvNoArrive
            // 
            this.dgvNoArrive.AllowUserToAddRows = false;
            this.dgvNoArrive.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvNoArrive.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNoArrive.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvNoArrive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoArrive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.库存编号,
            this.教材名称,
            this.作者,
            this.ISBN码,
            this.出版社,
            this.价格,
            this.订购数量,
            this.已到数量,
            this.未到数量});
            this.dgvNoArrive.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvNoArrive.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvNoArrive.Location = new System.Drawing.Point(12, 164);
            this.dgvNoArrive.Name = "dgvNoArrive";
            this.dgvNoArrive.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvNoArrive.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNoArrive.RowTemplate.Height = 23;
            this.dgvNoArrive.Size = new System.Drawing.Size(1311, 504);
            this.dgvNoArrive.TabIndex = 38;
            // 
            // 库存编号
            // 
            this.库存编号.DataPropertyName = "StockBookID";
            this.库存编号.HeaderText = "库存编号";
            this.库存编号.Name = "库存编号";
            this.库存编号.ReadOnly = true;
            this.库存编号.Visible = false;
            // 
            // 教材名称
            // 
            this.教材名称.DataPropertyName = "BookName";
            this.教材名称.HeaderText = "教材名称";
            this.教材名称.Name = "教材名称";
            this.教材名称.ReadOnly = true;
            this.教材名称.Width = 250;
            // 
            // 作者
            // 
            this.作者.DataPropertyName = "Author";
            this.作者.HeaderText = "作者";
            this.作者.Name = "作者";
            this.作者.ReadOnly = true;
            this.作者.Width = 150;
            // 
            // ISBN码
            // 
            this.ISBN码.DataPropertyName = "ISBN";
            this.ISBN码.HeaderText = "ISBN码";
            this.ISBN码.Name = "ISBN码";
            this.ISBN码.ReadOnly = true;
            this.ISBN码.Width = 200;
            // 
            // 出版社
            // 
            this.出版社.DataPropertyName = "Publish";
            this.出版社.HeaderText = "出版社";
            this.出版社.Name = "出版社";
            this.出版社.ReadOnly = true;
            this.出版社.Width = 250;
            // 
            // 价格
            // 
            this.价格.DataPropertyName = "Price";
            this.价格.HeaderText = "价格";
            this.价格.Name = "价格";
            this.价格.ReadOnly = true;
            // 
            // 订购数量
            // 
            this.订购数量.DataPropertyName = "BookTotalNum";
            this.订购数量.HeaderText = "订购数量";
            this.订购数量.Name = "订购数量";
            this.订购数量.ReadOnly = true;
            this.订购数量.Width = 110;
            // 
            // 已到数量
            // 
            this.已到数量.DataPropertyName = "ArriveQuantity";
            this.已到数量.HeaderText = "已到数量";
            this.已到数量.Name = "已到数量";
            this.已到数量.ReadOnly = true;
            this.已到数量.Width = 108;
            // 
            // 未到数量
            // 
            this.未到数量.DataPropertyName = "NoArriveQuantity";
            this.未到数量.HeaderText = "未到数量";
            this.未到数量.Name = "未到数量";
            this.未到数量.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddBook});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // tsmiAddBook
            // 
            this.tsmiAddBook.Name = "tsmiAddBook";
            this.tsmiAddBook.Size = new System.Drawing.Size(124, 22);
            this.tsmiAddBook.Text = "选择入库";
            this.tsmiAddBook.Click += new System.EventHandler(this.tsmiAddBook_Click);
            // 
            // FrmNoArriveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 680);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNoArrive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNoArriveBook";
            this.Text = "FrmNoArriveBook";
            this.Load += new System.EventHandler(this.FrmNoArriveBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoArrive)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtDelect;
        private System.Windows.Forms.ComboBox cmbInformation;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn 库存编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 教材名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作者;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出版社;
        private System.Windows.Forms.DataGridViewTextBoxColumn 价格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 订购数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 已到数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 未到数量;
        internal System.Windows.Forms.DataGridView dgvNoArrive;
    }
}