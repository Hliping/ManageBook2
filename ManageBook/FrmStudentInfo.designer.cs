namespace ManageBook
{
    partial class FrmStudentInfo
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
            this.dgvQuery = new System.Windows.Forms.DataGridView();
            this.学生信息编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.班别编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学院名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.专业名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.年级 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.班别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntxtms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntxtmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxtmsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCondition = new System.Windows.Forms.GroupBox();
            this.cmbCondition = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.grpStudentInfo = new System.Windows.Forms.GroupBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStudentMarket = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnWoman = new System.Windows.Forms.RadioButton();
            this.rbtnMan = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCollege = new System.Windows.Forms.ComboBox();
            this.cmbMajor = new System.Windows.Forms.ComboBox();
            this.cmbStudentClass = new System.Windows.Forms.ComboBox();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.btnAppend = new System.Windows.Forms.Button();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuery)).BeginInit();
            this.cntxtms.SuspendLayout();
            this.grpCondition.SuspendLayout();
            this.grpStudentInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQuery
            // 
            this.dgvQuery.AllowUserToAddRows = false;
            this.dgvQuery.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvQuery.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuery.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学生信息编号,
            this.班别编号,
            this.学院名称,
            this.专业名称,
            this.年级,
            this.班别,
            this.姓名,
            this.性别,
            this.学号,
            this.备注});
            this.dgvQuery.ContextMenuStrip = this.cntxtms;
            this.dgvQuery.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvQuery.Location = new System.Drawing.Point(351, 94);
            this.dgvQuery.Name = "dgvQuery";
            this.dgvQuery.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvQuery.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQuery.RowTemplate.Height = 23;
            this.dgvQuery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuery.Size = new System.Drawing.Size(976, 572);
            this.dgvQuery.TabIndex = 0;
            // 
            // 学生信息编号
            // 
            this.学生信息编号.DataPropertyName = "StudentInfoId";
            this.学生信息编号.HeaderText = "学生信息编号";
            this.学生信息编号.Name = "学生信息编号";
            this.学生信息编号.ReadOnly = true;
            this.学生信息编号.Visible = false;
            // 
            // 班别编号
            // 
            this.班别编号.DataPropertyName = "StudentClassId";
            this.班别编号.HeaderText = "班别编号";
            this.班别编号.Name = "班别编号";
            this.班别编号.ReadOnly = true;
            this.班别编号.Visible = false;
            // 
            // 学院名称
            // 
            this.学院名称.DataPropertyName = "CollegeName";
            this.学院名称.HeaderText = "学院名称";
            this.学院名称.Name = "学院名称";
            this.学院名称.ReadOnly = true;
            this.学院名称.Width = 120;
            // 
            // 专业名称
            // 
            this.专业名称.DataPropertyName = "MajorSimple";
            this.专业名称.HeaderText = "专业名称";
            this.专业名称.Name = "专业名称";
            this.专业名称.ReadOnly = true;
            // 
            // 年级
            // 
            this.年级.DataPropertyName = "GradeName";
            this.年级.HeaderText = "年级";
            this.年级.Name = "年级";
            this.年级.ReadOnly = true;
            // 
            // 班别
            // 
            this.班别.DataPropertyName = "ClassName";
            this.班别.HeaderText = "班别";
            this.班别.Name = "班别";
            this.班别.ReadOnly = true;
            this.班别.Width = 120;
            // 
            // 姓名
            // 
            this.姓名.DataPropertyName = "StudentName";
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            this.姓名.ReadOnly = true;
            this.姓名.Width = 113;
            // 
            // 性别
            // 
            this.性别.DataPropertyName = "StudentSex";
            this.性别.HeaderText = "性别";
            this.性别.Name = "性别";
            this.性别.ReadOnly = true;
            // 
            // 学号
            // 
            this.学号.DataPropertyName = "StudentNumber";
            this.学号.HeaderText = "学号";
            this.学号.Name = "学号";
            this.学号.ReadOnly = true;
            this.学号.Width = 130;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "StudentMarket";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            this.备注.Width = 150;
            // 
            // cntxtms
            // 
            this.cntxtms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntxtmsDelete,
            this.cntxtmsUpdate});
            this.cntxtms.Name = "cntxtms";
            this.cntxtms.Size = new System.Drawing.Size(149, 48);
            // 
            // cntxtmsDelete
            // 
            this.cntxtmsDelete.Name = "cntxtmsDelete";
            this.cntxtmsDelete.Size = new System.Drawing.Size(148, 22);
            this.cntxtmsDelete.Text = "删除学生信息";
            this.cntxtmsDelete.Click += new System.EventHandler(this.cntxtmsDelete_Click);
            // 
            // cntxtmsUpdate
            // 
            this.cntxtmsUpdate.Name = "cntxtmsUpdate";
            this.cntxtmsUpdate.Size = new System.Drawing.Size(148, 22);
            this.cntxtmsUpdate.Text = "修改学生信息";
            this.cntxtmsUpdate.Click += new System.EventHandler(this.cntxtmsUpdate_Click);
            // 
            // grpCondition
            // 
            this.grpCondition.Controls.Add(this.cmbCondition);
            this.grpCondition.Controls.Add(this.btnQuery);
            this.grpCondition.Controls.Add(this.txtCondition);
            this.grpCondition.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpCondition.Location = new System.Drawing.Point(351, 2);
            this.grpCondition.Name = "grpCondition";
            this.grpCondition.Size = new System.Drawing.Size(976, 74);
            this.grpCondition.TabIndex = 1;
            this.grpCondition.TabStop = false;
            this.grpCondition.Text = "查询";
            // 
            // cmbCondition
            // 
            this.cmbCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCondition.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbCondition.FormattingEnabled = true;
            this.cmbCondition.Items.AddRange(new object[] {
            "———全部———",
            "学生姓名",
            "学生学号",
            "班级名称",
            "专业名称",
            "学院名称",
            "年级名称"});
            this.cmbCondition.Location = new System.Drawing.Point(239, 26);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(176, 27);
            this.cmbCondition.TabIndex = 1;
            this.cmbCondition.Text = "———全部———";
            this.cmbCondition.SelectionChangeCommitted += new System.EventHandler(this.cmbCondition_SelectionChangeCommitted);
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(762, 25);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(74, 28);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtCondition
            // 
            this.txtCondition.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCondition.Location = new System.Drawing.Point(421, 25);
            this.txtCondition.Multiline = true;
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(308, 30);
            this.txtCondition.TabIndex = 2;
            // 
            // grpStudentInfo
            // 
            this.grpStudentInfo.Controls.Add(this.lbl);
            this.grpStudentInfo.Controls.Add(this.label5);
            this.grpStudentInfo.Controls.Add(this.txtStudentMarket);
            this.grpStudentInfo.Controls.Add(this.label4);
            this.grpStudentInfo.Controls.Add(this.rbtnWoman);
            this.grpStudentInfo.Controls.Add(this.rbtnMan);
            this.grpStudentInfo.Controls.Add(this.groupBox1);
            this.grpStudentInfo.Controls.Add(this.btnAppend);
            this.grpStudentInfo.Controls.Add(this.txtStudentNumber);
            this.grpStudentInfo.Controls.Add(this.txtStudentName);
            this.grpStudentInfo.Controls.Add(this.label3);
            this.grpStudentInfo.Controls.Add(this.label2);
            this.grpStudentInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpStudentInfo.Location = new System.Drawing.Point(12, 94);
            this.grpStudentInfo.Name = "grpStudentInfo";
            this.grpStudentInfo.Size = new System.Drawing.Size(319, 572);
            this.grpStudentInfo.TabIndex = 4;
            this.grpStudentInfo.TabStop = false;
            this.grpStudentInfo.Text = "学生信息添加";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl.ForeColor = System.Drawing.Color.Red;
            this.lbl.Location = new System.Drawing.Point(168, 544);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 12);
            this.lbl.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(24, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "备 注：";
            // 
            // txtStudentMarket
            // 
            this.txtStudentMarket.Location = new System.Drawing.Point(28, 416);
            this.txtStudentMarket.Multiline = true;
            this.txtStudentMarket.Name = "txtStudentMarket";
            this.txtStudentMarket.Size = new System.Drawing.Size(267, 98);
            this.txtStudentMarket.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(24, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "性 别：";
            // 
            // rbtnWoman
            // 
            this.rbtnWoman.AutoSize = true;
            this.rbtnWoman.Location = new System.Drawing.Point(253, 352);
            this.rbtnWoman.Name = "rbtnWoman";
            this.rbtnWoman.Size = new System.Drawing.Size(42, 20);
            this.rbtnWoman.TabIndex = 11;
            this.rbtnWoman.Text = "女";
            this.rbtnWoman.UseVisualStyleBackColor = true;
            // 
            // rbtnMan
            // 
            this.rbtnMan.AutoSize = true;
            this.rbtnMan.Checked = true;
            this.rbtnMan.Location = new System.Drawing.Point(143, 352);
            this.rbtnMan.Name = "rbtnMan";
            this.rbtnMan.Size = new System.Drawing.Size(42, 20);
            this.rbtnMan.TabIndex = 10;
            this.rbtnMan.TabStop = true;
            this.rbtnMan.Text = "男";
            this.rbtnMan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCollege);
            this.groupBox1.Controls.Add(this.cmbMajor);
            this.groupBox1.Controls.Add(this.cmbStudentClass);
            this.groupBox1.Controls.Add(this.cmbGrade);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(28, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 224);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // cmbCollege
            // 
            this.cmbCollege.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCollege.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbCollege.FormattingEnabled = true;
            this.cmbCollege.Location = new System.Drawing.Point(14, 26);
            this.cmbCollege.Name = "cmbCollege";
            this.cmbCollege.Size = new System.Drawing.Size(233, 27);
            this.cmbCollege.TabIndex = 4;
            this.cmbCollege.Text = "——请选择学院——";
            this.cmbCollege.SelectionChangeCommitted += new System.EventHandler(this.cmbCollege_SelectionChangeCommitted);
            // 
            // cmbMajor
            // 
            this.cmbMajor.Enabled = false;
            this.cmbMajor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMajor.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbMajor.FormattingEnabled = true;
            this.cmbMajor.Location = new System.Drawing.Point(14, 77);
            this.cmbMajor.Name = "cmbMajor";
            this.cmbMajor.Size = new System.Drawing.Size(233, 27);
            this.cmbMajor.TabIndex = 5;
            this.cmbMajor.Text = "——请选择专业——";
            this.cmbMajor.SelectionChangeCommitted += new System.EventHandler(this.cmbMajor_SelectionChangeCommitted);
            // 
            // cmbStudentClass
            // 
            this.cmbStudentClass.Enabled = false;
            this.cmbStudentClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStudentClass.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbStudentClass.FormattingEnabled = true;
            this.cmbStudentClass.Location = new System.Drawing.Point(14, 179);
            this.cmbStudentClass.Name = "cmbStudentClass";
            this.cmbStudentClass.Size = new System.Drawing.Size(233, 27);
            this.cmbStudentClass.TabIndex = 7;
            this.cmbStudentClass.Text = "——请选择班级——";
            this.cmbStudentClass.SelectedIndexChanged += new System.EventHandler(this.cmbStudentClass_SelectedIndexChanged);
            // 
            // cmbGrade
            // 
            this.cmbGrade.Enabled = false;
            this.cmbGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGrade.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(14, 128);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(233, 27);
            this.cmbGrade.TabIndex = 6;
            this.cmbGrade.Text = "——请选择年级——";
            this.cmbGrade.SelectionChangeCommitted += new System.EventHandler(this.cmbClass_SelectionChangeCommitted);
            // 
            // btnAppend
            // 
            this.btnAppend.Enabled = false;
            this.btnAppend.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAppend.Location = new System.Drawing.Point(81, 534);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(78, 32);
            this.btnAppend.TabIndex = 13;
            this.btnAppend.Text = "添加记录";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(143, 308);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(152, 26);
            this.txtStudentNumber.TabIndex = 9;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(143, 266);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(152, 26);
            this.txtStudentName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(24, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "学生学号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(24, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "学生姓名：";
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExcel.Location = new System.Drawing.Point(12, 23);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(319, 36);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "批量添加Excel数据信息";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // FrmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 678);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.grpStudentInfo);
            this.Controls.Add(this.grpCondition);
            this.Controls.Add(this.dgvQuery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStudentInfo";
            this.Text = "学生信息管理";
            this.Load += new System.EventHandler(this.FrmStudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuery)).EndInit();
            this.cntxtms.ResumeLayout(false);
            this.grpCondition.ResumeLayout(false);
            this.grpCondition.PerformLayout();
            this.grpStudentInfo.ResumeLayout(false);
            this.grpStudentInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuery;
        private System.Windows.Forms.GroupBox grpCondition;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.ComboBox cmbCondition;
        private System.Windows.Forms.ContextMenuStrip cntxtms;
        private System.Windows.Forms.ToolStripMenuItem cntxtmsDelete;
        private System.Windows.Forms.ToolStripMenuItem cntxtmsUpdate;
        private System.Windows.Forms.GroupBox grpStudentInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.ComboBox cmbCollege;
        private System.Windows.Forms.ComboBox cmbStudentClass;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.ComboBox cmbMajor;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStudentMarket;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnWoman;
        private System.Windows.Forms.RadioButton rbtnMan;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学生信息编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 班别编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学院名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 专业名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年级;
        private System.Windows.Forms.DataGridViewTextBoxColumn 班别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        private System.Windows.Forms.Label lbl;
    }
}