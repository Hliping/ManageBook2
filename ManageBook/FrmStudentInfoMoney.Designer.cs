namespace ManageBook
{
    partial class FrmStudentInfoMoney
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStudentDetail = new System.Windows.Forms.DataGridView();
            this.cmbCollege = new System.Windows.Forms.ComboBox();
            this.cmbStudentClass = new System.Windows.Forms.ComboBox();
            this.cmbMajor = new System.Windows.Forms.ComboBox();
            this.cmbSchoolTerm = new System.Windows.Forms.ComboBox();
            this.学院名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.专业名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.班级名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学年学期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学生姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学生学号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.教材名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作者 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出版社 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.标价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.折扣 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.实价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.获书数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudentDetail
            // 
            this.dgvStudentDetail.AllowUserToAddRows = false;
            this.dgvStudentDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvStudentDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvStudentDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudentDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvStudentDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学院名称,
            this.专业名称,
            this.班级名称,
            this.学年学期,
            this.学生姓名,
            this.学生学号,
            this.性别,
            this.教材名称,
            this.ISBN码,
            this.作者,
            this.出版社,
            this.标价,
            this.折扣,
            this.实价,
            this.获书数量});
            this.dgvStudentDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvStudentDetail.Location = new System.Drawing.Point(12, 140);
            this.dgvStudentDetail.Name = "dgvStudentDetail";
            this.dgvStudentDetail.ReadOnly = true;
            this.dgvStudentDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvStudentDetail.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvStudentDetail.RowTemplate.Height = 23;
            this.dgvStudentDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentDetail.Size = new System.Drawing.Size(1315, 536);
            this.dgvStudentDetail.TabIndex = 55;
            // 
            // cmbCollege
            // 
            this.cmbCollege.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCollege.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbCollege.FormattingEnabled = true;
            this.cmbCollege.Location = new System.Drawing.Point(20, 30);
            this.cmbCollege.Name = "cmbCollege";
            this.cmbCollege.Size = new System.Drawing.Size(233, 27);
            this.cmbCollege.TabIndex = 4;
            this.cmbCollege.Text = "——请选择学院——";
            this.cmbCollege.SelectionChangeCommitted += new System.EventHandler(this.cmbCollege_SelectionChangeCommitted);
            // 
            // cmbStudentClass
            // 
            this.cmbStudentClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStudentClass.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbStudentClass.FormattingEnabled = true;
            this.cmbStudentClass.Location = new System.Drawing.Point(716, 30);
            this.cmbStudentClass.Name = "cmbStudentClass";
            this.cmbStudentClass.Size = new System.Drawing.Size(233, 27);
            this.cmbStudentClass.TabIndex = 7;
            this.cmbStudentClass.Text = "——请选择班级——";
            this.cmbStudentClass.SelectionChangeCommitted += new System.EventHandler(this.cmbStudentClass_SelectionChangeCommitted);
            // 
            // cmbMajor
            // 
            this.cmbMajor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMajor.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbMajor.FormattingEnabled = true;
            this.cmbMajor.Location = new System.Drawing.Point(371, 30);
            this.cmbMajor.Name = "cmbMajor";
            this.cmbMajor.Size = new System.Drawing.Size(233, 27);
            this.cmbMajor.TabIndex = 5;
            this.cmbMajor.Text = "——请选择专业——";
            this.cmbMajor.SelectionChangeCommitted += new System.EventHandler(this.cmbMajor_SelectionChangeCommitted);
            // 
            // cmbSchoolTerm
            // 
            this.cmbSchoolTerm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSchoolTerm.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSchoolTerm.FormattingEnabled = true;
            this.cmbSchoolTerm.Location = new System.Drawing.Point(1061, 30);
            this.cmbSchoolTerm.Name = "cmbSchoolTerm";
            this.cmbSchoolTerm.Size = new System.Drawing.Size(233, 27);
            this.cmbSchoolTerm.TabIndex = 56;
            this.cmbSchoolTerm.Text = "——请选择学期——";
            this.cmbSchoolTerm.SelectionChangeCommitted += new System.EventHandler(this.cmbSchoolTerm_SelectionChangeCommitted);
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
            this.专业名称.DataPropertyName = "MajorName";
            this.专业名称.HeaderText = "专业名称";
            this.专业名称.Name = "专业名称";
            this.专业名称.ReadOnly = true;
            // 
            // 班级名称
            // 
            this.班级名称.DataPropertyName = "ClassName";
            this.班级名称.HeaderText = "班级名称";
            this.班级名称.Name = "班级名称";
            this.班级名称.ReadOnly = true;
            // 
            // 学年学期
            // 
            this.学年学期.DataPropertyName = "TermName";
            this.学年学期.HeaderText = "学年学期";
            this.学年学期.Name = "学年学期";
            this.学年学期.ReadOnly = true;
            this.学年学期.Width = 90;
            // 
            // 学生姓名
            // 
            this.学生姓名.DataPropertyName = "StudentName";
            this.学生姓名.HeaderText = "学生姓名";
            this.学生姓名.Name = "学生姓名";
            this.学生姓名.ReadOnly = true;
            // 
            // 学生学号
            // 
            this.学生学号.DataPropertyName = "StudentNumber";
            this.学生学号.HeaderText = "学生学号";
            this.学生学号.Name = "学生学号";
            this.学生学号.ReadOnly = true;
            // 
            // 性别
            // 
            this.性别.DataPropertyName = "StudentSex";
            this.性别.HeaderText = "性别";
            this.性别.Name = "性别";
            this.性别.ReadOnly = true;
            this.性别.Width = 55;
            // 
            // 教材名称
            // 
            this.教材名称.DataPropertyName = "BookName";
            this.教材名称.HeaderText = "教材名称";
            this.教材名称.Name = "教材名称";
            this.教材名称.ReadOnly = true;
            // 
            // ISBN码
            // 
            this.ISBN码.DataPropertyName = "ISBN";
            this.ISBN码.HeaderText = "ISBN码";
            this.ISBN码.Name = "ISBN码";
            this.ISBN码.ReadOnly = true;
            // 
            // 作者
            // 
            this.作者.DataPropertyName = "Author";
            this.作者.HeaderText = "作者";
            this.作者.Name = "作者";
            this.作者.ReadOnly = true;
            // 
            // 出版社
            // 
            this.出版社.DataPropertyName = "Publish";
            this.出版社.HeaderText = "出版社";
            this.出版社.Name = "出版社";
            this.出版社.ReadOnly = true;
            // 
            // 标价
            // 
            this.标价.DataPropertyName = "Price";
            this.标价.HeaderText = "标价";
            this.标价.Name = "标价";
            this.标价.ReadOnly = true;
            this.标价.Width = 55;
            // 
            // 折扣
            // 
            this.折扣.DataPropertyName = "Discount";
            this.折扣.HeaderText = "折扣";
            this.折扣.Name = "折扣";
            this.折扣.ReadOnly = true;
            this.折扣.Width = 55;
            // 
            // 实价
            // 
            this.实价.DataPropertyName = "NetPrice";
            this.实价.HeaderText = "实价";
            this.实价.Name = "实价";
            this.实价.ReadOnly = true;
            this.实价.Width = 55;
            // 
            // 获书数量
            // 
            this.获书数量.DataPropertyName = "GetBookNum";
            this.获书数量.HeaderText = "获书数量";
            this.获书数量.Name = "获书数量";
            this.获书数量.ReadOnly = true;
            this.获书数量.Width = 78;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMajor);
            this.groupBox1.Controls.Add(this.cmbSchoolTerm);
            this.groupBox1.Controls.Add(this.cmbStudentClass);
            this.groupBox1.Controls.Add(this.cmbCollege);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1315, 78);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExcel.Location = new System.Drawing.Point(592, 96);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(154, 38);
            this.btnExcel.TabIndex = 58;
            this.btnExcel.Text = "导出信息到Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // FrmStudentInfoMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 688);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvStudentDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStudentInfoMoney";
            this.Text = "FrmStudentInfoMoney";
            this.Load += new System.EventHandler(this.FrmStudentInfoMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentDetail;
        private System.Windows.Forms.ComboBox cmbCollege;
        private System.Windows.Forms.ComboBox cmbStudentClass;
        private System.Windows.Forms.ComboBox cmbMajor;
        private System.Windows.Forms.ComboBox cmbSchoolTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学院名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 专业名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 班级名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学年学期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学生姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学生学号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 教材名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作者;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出版社;
        private System.Windows.Forms.DataGridViewTextBoxColumn 标价;
        private System.Windows.Forms.DataGridViewTextBoxColumn 折扣;
        private System.Windows.Forms.DataGridViewTextBoxColumn 实价;
        private System.Windows.Forms.DataGridViewTextBoxColumn 获书数量;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcel;
    }
}