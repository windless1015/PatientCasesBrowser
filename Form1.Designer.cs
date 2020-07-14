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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.main_code,
            this.additional_code,
            this.surgery_name,
            this.surgical_type,
            this.entry_option,
            this.extra_code,
            this.extra_code_surgery_name});
            this.dataGridView.Location = new System.Drawing.Point(12, 57);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(967, 513);
            this.dataGridView.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "序号";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // main_code
            // 
            this.main_code.DataPropertyName = "main_code";
            this.main_code.HeaderText = "主要编码";
            this.main_code.MinimumWidth = 6;
            this.main_code.Name = "main_code";
            this.main_code.ReadOnly = true;
            this.main_code.Width = 125;
            // 
            // additional_code
            // 
            this.additional_code.DataPropertyName = "additional_code";
            this.additional_code.HeaderText = "附加编码";
            this.additional_code.MinimumWidth = 6;
            this.additional_code.Name = "additional_code";
            this.additional_code.ReadOnly = true;
            this.additional_code.Width = 125;
            // 
            // surgery_name
            // 
            this.surgery_name.DataPropertyName = "surgery_name";
            this.surgery_name.HeaderText = "手术名称";
            this.surgery_name.MinimumWidth = 6;
            this.surgery_name.Name = "surgery_name";
            this.surgery_name.ReadOnly = true;
            this.surgery_name.Width = 200;
            // 
            // surgical_type
            // 
            this.surgical_type.DataPropertyName = "surgical_type";
            this.surgical_type.HeaderText = "类型";
            this.surgical_type.MinimumWidth = 6;
            this.surgical_type.Name = "surgical_type";
            this.surgical_type.ReadOnly = true;
            this.surgical_type.Width = 80;
            // 
            // entry_option
            // 
            this.entry_option.DataPropertyName = "entry_option";
            this.entry_option.HeaderText = "录入选项";
            this.entry_option.MinimumWidth = 6;
            this.entry_option.Name = "entry_option";
            this.entry_option.ReadOnly = true;
            this.entry_option.Width = 80;
            // 
            // extra_code
            // 
            this.extra_code.DataPropertyName = "extra_code";
            this.extra_code.HeaderText = "另编码";
            this.extra_code.MinimumWidth = 6;
            this.extra_code.Name = "extra_code";
            this.extra_code.ReadOnly = true;
            this.extra_code.Width = 125;
            // 
            // extra_code_surgery_name
            // 
            this.extra_code_surgery_name.DataPropertyName = "extra_code_surgery_name";
            this.extra_code_surgery_name.HeaderText = "另编码手术名称";
            this.extra_code_surgery_name.MinimumWidth = 6;
            this.extra_code_surgery_name.Name = "extra_code_surgery_name";
            this.extra_code_surgery_name.ReadOnly = true;
            this.extra_code_surgery_name.Width = 125;
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(12, 13);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(141, 25);
            this.textBox_number.TabIndex = 1;
            this.textBox_number.TextChanged += new System.EventHandler(this.textBox_number_TextChanged);
            // 
            // btn_buildSQL
            // 
            this.btn_buildSQL.Enabled = false;
            this.btn_buildSQL.Location = new System.Drawing.Point(305, 12);
            this.btn_buildSQL.Name = "btn_buildSQL";
            this.btn_buildSQL.Size = new System.Drawing.Size(165, 39);
            this.btn_buildSQL.TabIndex = 2;
            this.btn_buildSQL.Text = "创建原始数据库文件";
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
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.Button btn_buildSQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn main_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn additional_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn surgery_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surgical_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn entry_option;
        private System.Windows.Forms.DataGridViewTextBoxColumn extra_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn extra_code_surgery_name;
    }
}

