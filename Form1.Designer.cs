namespace PatientCasesBrowser
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.main_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additional_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surgery_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surgical_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entry_option = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extra_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extra_code_surgery_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.btn_buildSQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.main_code,
            this.additional_code,
            this.surgery_name,
            this.surgical_type,
            this.entry_option,
            this.extra_code,
            this.extra_code_surgery_name});
            this.dataGridView1.Location = new System.Drawing.Point(12, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(893, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "序号";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // main_code
            // 
            this.main_code.HeaderText = "主要编码";
            this.main_code.MinimumWidth = 6;
            this.main_code.Name = "main_code";
            this.main_code.ReadOnly = true;
            this.main_code.Width = 125;
            // 
            // additional_code
            // 
            this.additional_code.HeaderText = "附加编码";
            this.additional_code.MinimumWidth = 6;
            this.additional_code.Name = "additional_code";
            this.additional_code.ReadOnly = true;
            this.additional_code.Width = 125;
            // 
            // surgery_name
            // 
            this.surgery_name.HeaderText = "手术名称";
            this.surgery_name.MinimumWidth = 6;
            this.surgery_name.Name = "surgery_name";
            this.surgery_name.ReadOnly = true;
            this.surgery_name.Width = 200;
            // 
            // surgical_type
            // 
            this.surgical_type.HeaderText = "类型";
            this.surgical_type.MinimumWidth = 6;
            this.surgical_type.Name = "surgical_type";
            this.surgical_type.ReadOnly = true;
            this.surgical_type.Width = 80;
            // 
            // entry_option
            // 
            this.entry_option.HeaderText = "录入选项";
            this.entry_option.MinimumWidth = 6;
            this.entry_option.Name = "entry_option";
            this.entry_option.ReadOnly = true;
            this.entry_option.Width = 80;
            // 
            // extra_code
            // 
            this.extra_code.HeaderText = "另编码";
            this.extra_code.MinimumWidth = 6;
            this.extra_code.Name = "extra_code";
            this.extra_code.ReadOnly = true;
            this.extra_code.Width = 125;
            // 
            // extra_code_surgery_name
            // 
            this.extra_code_surgery_name.HeaderText = "另编码手术名称";
            this.extra_code_surgery_name.MinimumWidth = 6;
            this.extra_code_surgery_name.Name = "extra_code_surgery_name";
            this.extra_code_surgery_name.ReadOnly = true;
            this.extra_code_surgery_name.Width = 125;
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(12, 58);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(141, 25);
            this.textBox_number.TabIndex = 1;
            this.textBox_number.TextChanged += new System.EventHandler(this.textBox_number_TextChanged);
            // 
            // btn_buildSQL
            // 
            this.btn_buildSQL.Location = new System.Drawing.Point(13, 13);
            this.btn_buildSQL.Name = "btn_buildSQL";
            this.btn_buildSQL.Size = new System.Drawing.Size(140, 23);
            this.btn_buildSQL.TabIndex = 2;
            this.btn_buildSQL.Text = "button1";
            this.btn_buildSQL.UseVisualStyleBackColor = true;
            this.btn_buildSQL.Click += new System.EventHandler(this.btn_buildSQL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 582);
            this.Controls.Add(this.btn_buildSQL);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn main_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn additional_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn surgery_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surgical_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn entry_option;
        private System.Windows.Forms.DataGridViewTextBoxColumn extra_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn extra_code_surgery_name;
        private System.Windows.Forms.Button btn_buildSQL;
    }
}

