namespace DBMS_mini
{
    partial class AddAssesment
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalWeightageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assessmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet = new DBMS_mini.ProjectBDataSet();
            this.assessmentTableAdapter = new DBMS_mini.ProjectBDataSetTableAdapters.AssessmentTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(48, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 22);
            this.label8.TabIndex = 40;
            this.label8.Text = "Total Weightage ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(48, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 22);
            this.label7.TabIndex = 39;
            this.label7.Text = "Total Marks";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(258, 239);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(130, 20);
            this.textBox4.TabIndex = 37;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(258, 207);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 20);
            this.textBox3.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(48, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "Title\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Update,
            this.Delete,
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.totalMarksDataGridViewTextBoxColumn,
            this.totalWeightageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.assessmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(52, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(539, 150);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Update
            // 
            this.Update.FillWeight = 50F;
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 50;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 50F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 50;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            this.dateCreatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalMarksDataGridViewTextBoxColumn
            // 
            this.totalMarksDataGridViewTextBoxColumn.DataPropertyName = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.HeaderText = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.Name = "totalMarksDataGridViewTextBoxColumn";
            this.totalMarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalWeightageDataGridViewTextBoxColumn
            // 
            this.totalWeightageDataGridViewTextBoxColumn.DataPropertyName = "TotalWeightage";
            this.totalWeightageDataGridViewTextBoxColumn.HeaderText = "TotalWeightage";
            this.totalWeightageDataGridViewTextBoxColumn.Name = "totalWeightageDataGridViewTextBoxColumn";
            this.totalWeightageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assessmentBindingSource
            // 
            this.assessmentBindingSource.DataMember = "Assessment";
            this.assessmentBindingSource.DataSource = this.projectBDataSet;
            // 
            // projectBDataSet
            // 
            this.projectBDataSet.DataSetName = "ProjectBDataSet";
            this.projectBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assessmentTableAdapter
            // 
            this.assessmentTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(313, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 44;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(258, 173);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(48, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 47;
            this.label2.Text = "Date Created";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 62);
            this.panel1.TabIndex = 48;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(693, 20);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 22);
            this.linkLabel1.TabIndex = 31;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Home";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(14, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lab Management System 📝\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(62, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Assessment 📜\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.UseMnemonic = false;
            // 
            // AddAssesment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(845, 496);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddAssesment";
            this.Text = "AddAssesment";
            this.Load += new System.EventHandler(this.AddAssesment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.BindingSource assessmentBindingSource;
        private ProjectBDataSetTableAdapters.AssessmentTableAdapter assessmentTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalWeightageDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}