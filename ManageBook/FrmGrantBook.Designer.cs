namespace ManageBook
{
    partial class FrmGrantBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBookStock = new System.Windows.Forms.DataGridView();
            this.教材编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学期编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGrantBook = new System.Windows.Forms.DataGridView();
            this.教材发放明细编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvStudentInfo = new System.Windows.Forms.DataGridView();
            this.选择 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.学院名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.专业名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.班别名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学生姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学生信息编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCollege = new System.Windows.Forms.ComboBox();
            this.cmbStudentClass = new System.Windows.Forms.ComboBox();
            this.btnAllSelect = new System.Windows.Forms.Button();
            this.btnAddGrantBook = new System.Windows.Forms.Button();
            this.btnBookSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrantBook)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookStock
            // 
            this.dgvBookStock.AllowUserToAddRows = false;
            this.dgvBookStock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvBookStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBookStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBookStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.教材编号,
            this.学期编号,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22,
            this.Column23});
            this.dgvBookStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvBookStock.Location = new System.Drawing.Point(0, 37);
            this.dgvBookStock.Name = "dgvBookStock";
            this.dgvBookStock.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvBookStock.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookStock.RowTemplate.Height = 23;
            this.dgvBookStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookStock.Size = new System.Drawing.Size(650, 250);
            this.dgvBookStock.TabIndex = 0;
            // 
            // 教材编号
            // 
            this.教材编号.DataPropertyName = "PlanBookID";
            this.教材编号.HeaderText = "教材编号";
            this.教材编号.Name = "教材编号";
            this.教材编号.ReadOnly = true;
            this.教材编号.Visible = false;
            // 
            // 学期编号
            // 
            this.学期编号.DataPropertyName = "SchoolTermID";
            this.学期编号.HeaderText = "学期编号";
            this.学期编号.Name = "学期编号";
            this.学期编号.ReadOnly = true;
            this.学期编号.Visible = false;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "ClassName";
            this.Column15.HeaderText = "班别";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "TermSimple";
            this.Column16.HeaderText = "学年学期";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "CourseType";
            this.Column17.HeaderText = "课程类型";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "CourseName";
            this.Column18.HeaderText = "课程名称";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "BookName";
            this.Column19.HeaderText = "教材名称";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            // 
            // Column20
            // 
            this.Column20.DataPropertyName = "Author";
            this.Column20.HeaderText = "作者";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            // 
            // Column21
            // 
            this.Column21.DataPropertyName = "Publish";
            this.Column21.HeaderText = "出版社";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            // 
            // Column22
            // 
            this.Column22.DataPropertyName = "ISBN";
            this.Column22.HeaderText = "ISBN码";
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            // 
            // Column23
            // 
            this.Column23.DataPropertyName = "BookTotalNum";
            this.Column23.HeaderText = "预定数量";
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            // 
            // dgvGrantBook
            // 
            this.dgvGrantBook.AllowUserToAddRows = false;
            this.dgvGrantBook.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvGrantBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGrantBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGrantBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvGrantBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrantBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.教材发放明细编号,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dgvGrantBook.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvGrantBook.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvGrantBook.Location = new System.Drawing.Point(0, 318);
            this.dgvGrantBook.Name = "dgvGrantBook";
            this.dgvGrantBook.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvGrantBook.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGrantBook.RowTemplate.Height = 23;
            this.dgvGrantBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrantBook.Size = new System.Drawing.Size(1338, 361);
            this.dgvGrantBook.TabIndex = 1;
            // 
            // 教材发放明细编号
            // 
            this.教材发放明细编号.DataPropertyName = "GrantID";
            this.教材发放明细编号.HeaderText = "教材发放明细编号";
            this.教材发放明细编号.Name = "教材发放明细编号";
            this.教材发放明细编号.ReadOnly = true;
            this.教材发放明细编号.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CollegeName";
            this.Column1.HeaderText = "学院名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MajorSimple";
            this.Column2.HeaderText = "专业名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ClassName";
            this.Column3.HeaderText = "班级名称";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 82;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TermName";
            this.Column4.HeaderText = "学年学期";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "StudentName";
            this.Column5.HeaderText = "学生姓名";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "StudentNumber";
            this.Column6.HeaderText = "学生学号";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "StudentSex";
            this.Column7.HeaderText = "性别";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 55;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "CourseName";
            this.Column8.HeaderText = "课程名称";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "CourseType";
            this.Column9.HeaderText = "课程类型";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "BookName";
            this.Column10.HeaderText = "教材名称";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Author";
            this.Column11.HeaderText = "作者";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Publish";
            this.Column12.HeaderText = "出版社";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "ISBN";
            this.Column13.HeaderText = "ISBN码";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "GetBookNum";
            this.Column14.HeaderText = "获书数量";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(124, 22);
            this.tsmiDelete.Text = "删除明细";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(592, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "教材库存发放明细";
            // 
            // dgvStudentInfo
            // 
            this.dgvStudentInfo.AllowUserToAddRows = false;
            this.dgvStudentInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvStudentInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStudentInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudentInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.选择,
            this.学院名称,
            this.专业名称,
            this.班别名称,
            this.学生姓名,
            this.学号,
            this.性别,
            this.备注,
            this.学生信息编号});
            this.dgvStudentInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvStudentInfo.Location = new System.Drawing.Point(690, 37);
            this.dgvStudentInfo.Name = "dgvStudentInfo";
            this.dgvStudentInfo.ReadOnly = true;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvStudentInfo.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStudentInfo.RowTemplate.Height = 23;
            this.dgvStudentInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentInfo.Size = new System.Drawing.Size(650, 253);
            this.dgvStudentInfo.TabIndex = 4;
            this.dgvStudentInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentInfo_CellContentClick);
            // 
            // 选择
            // 
            this.选择.HeaderText = "选择";
            this.选择.Name = "选择";
            this.选择.ReadOnly = true;
            this.选择.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.选择.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.选择.Width = 55;
            // 
            // 学院名称
            // 
            this.学院名称.DataPropertyName = "CollegeName";
            this.学院名称.HeaderText = "学院名称";
            this.学院名称.Name = "学院名称";
            this.学院名称.ReadOnly = true;
            // 
            // 专业名称
            // 
            this.专业名称.DataPropertyName = "MajorSimple";
            this.专业名称.HeaderText = "专业名称";
            this.专业名称.Name = "专业名称";
            this.专业名称.ReadOnly = true;
            // 
            // 班别名称
            // 
            this.班别名称.DataPropertyName = "ClassName";
            this.班别名称.HeaderText = "班别名称";
            this.班别名称.Name = "班别名称";
            this.班别名称.ReadOnly = true;
            // 
            // 学生姓名
            // 
            this.学生姓名.DataPropertyName = "StudentName";
            this.学生姓名.HeaderText = "学生姓名";
            this.学生姓名.Name = "学生姓名";
            this.学生姓名.ReadOnly = true;
            // 
            // 学号
            // 
            this.学号.DataPropertyName = "StudentNumber";
            this.学号.HeaderText = "学号";
            this.学号.Name = "学号";
            this.学号.ReadOnly = true;
            // 
            // 性别
            // 
            this.性别.DataPropertyName = "StudentSex";
            this.性别.HeaderText = "性别";
            this.性别.Name = "性别";
            this.性别.ReadOnly = true;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "StudentMarket";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            // 
            // 学生信息编号
            // 
            this.学生信息编号.DataPropertyName = "StudentInfoID";
            this.学生信息编号.HeaderText = "学生信息编号";
            this.学生信息编号.Name = "学生信息编号";
            this.学生信息编号.ReadOnly = true;
            this.学生信息编号.Visible = false;
            // 
            // cmbCollege
            // 
            this.cmbCollege.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCollege.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbCollege.FormattingEnabled = true;
            this.cmbCollege.Location = new System.Drawing.Point(12, 4);
            this.cmbCollege.Name = "cmbCollege";
            this.cmbCollege.Size = new System.Drawing.Size(233, 27);
            this.cmbCollege.TabIndex = 8;
            this.cmbCollege.Text = "——请选择学院——";
            this.cmbCollege.SelectionChangeCommitted += new System.EventHandler(this.cmbCollege_SelectionChangeCommitted);
            // 
            // cmbStudentClass
            // 
            this.cmbStudentClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStudentClass.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbStudentClass.FormattingEnabled = true;
            this.cmbStudentClass.Location = new System.Drawing.Point(285, 3);
            this.cmbStudentClass.Name = "cmbStudentClass";
            this.cmbStudentClass.Size = new System.Drawing.Size(233, 27);
            this.cmbStudentClass.TabIndex = 11;
            this.cmbStudentClass.Text = "——请选择班级——";
            this.cmbStudentClass.SelectionChangeCommitted += new System.EventHandler(this.cmbStudentClass_SelectionChangeCommitted);
            // 
            // btnAllSelect
            // 
            this.btnAllSelect.Enabled = false;
            this.btnAllSelect.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAllSelect.Location = new System.Drawing.Point(689, 10);
            this.btnAllSelect.Name = "btnAllSelect";
            this.btnAllSelect.Size = new System.Drawing.Size(83, 27);
            this.btnAllSelect.TabIndex = 12;
            this.btnAllSelect.Text = "全选/取消";
            this.btnAllSelect.UseVisualStyleBackColor = true;
            this.btnAllSelect.Click += new System.EventHandler(this.btnAllSelect_Click);
            // 
            // btnAddGrantBook
            // 
            this.btnAddGrantBook.Enabled = false;
            this.btnAddGrantBook.Location = new System.Drawing.Point(1246, 291);
            this.btnAddGrantBook.Name = "btnAddGrantBook";
            this.btnAddGrantBook.Size = new System.Drawing.Size(92, 27);
            this.btnAddGrantBook.TabIndex = 13;
            this.btnAddGrantBook.Text = "添加教材明细";
            this.btnAddGrantBook.UseVisualStyleBackColor = true;
            this.btnAddGrantBook.Click += new System.EventHandler(this.btnAddGrantBook_Click);
            // 
            // btnBookSelect
            // 
            this.btnBookSelect.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBookSelect.Location = new System.Drawing.Point(568, 10);
            this.btnBookSelect.Name = "btnBookSelect";
            this.btnBookSelect.Size = new System.Drawing.Size(82, 27);
            this.btnBookSelect.TabIndex = 14;
            this.btnBookSelect.Text = "选择/取消";
            this.btnBookSelect.UseVisualStyleBackColor = true;
            this.btnBookSelect.Click += new System.EventHandler(this.btnBookSelect_Click);
            // 
            // FrmGrantBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1339, 678);
            this.Controls.Add(this.btnBookSelect);
            this.Controls.Add(this.btnAddGrantBook);
            this.Controls.Add(this.btnAllSelect);
            this.Controls.Add(this.cmbCollege);
            this.Controls.Add(this.cmbStudentClass);
            this.Controls.Add(this.dgvStudentInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvGrantBook);
            this.Controls.Add(this.dgvBookStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGrantBook";
            this.Text = "FrmGrantBook";
            this.Load += new System.EventHandler(this.FrmGrantBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrantBook)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookStock;
        private System.Windows.Forms.DataGridView dgvGrantBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvStudentInfo;
        private System.Windows.Forms.ComboBox cmbCollege;
        private System.Windows.Forms.ComboBox cmbStudentClass;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 选择;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学院名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 专业名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 班别名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学生姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学生信息编号;
        private System.Windows.Forms.Button btnAllSelect;
        private System.Windows.Forms.Button btnAddGrantBook;
        private System.Windows.Forms.Button btnBookSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn 教材编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学期编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn 教材发放明细编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
    }
}