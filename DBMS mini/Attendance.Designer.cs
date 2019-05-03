namespace DBMS_mini
{
    partial class Attendance
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
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet5 = new DBMS_mini.ProjectBDataSet5();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.studentAttendanceTableAdapter = new DBMS_mini.ProjectBDataSet5TableAdapters.StudentAttendanceTableAdapter();
            this.projectBDataSet6 = new DBMS_mini.ProjectBDataSet6();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new DBMS_mini.ProjectBDataSet6TableAdapters.StudentTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.registrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(267, 369);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(65, 25);
            this.button11.TabIndex = 85;
            this.button11.Text = "Update";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(338, 369);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(65, 25);
            this.button10.TabIndex = 84;
            this.button10.Text = "Save";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 27);
            this.button1.TabIndex = 83;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registrationNumberDataGridViewTextBoxColumn,
            this.AttendanceId,
            this.AttendanceStatus});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(79, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 150);
            this.dataGridView1.TabIndex = 82;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentAttendanceBindingSource
            // 
            this.studentAttendanceBindingSource.DataMember = "StudentAttendance";
            this.studentAttendanceBindingSource.DataSource = this.projectBDataSet5;
            // 
            // projectBDataSet5
            // 
            this.projectBDataSet5.DataSetName = "ProjectBDataSet5";
            this.projectBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(311, 108);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(48, 27);
            this.button7.TabIndex = 81;
            this.button7.Text = "Mark";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(219, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 25);
            this.button5.TabIndex = 80;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "Attendance Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker1.TabIndex = 78;
            // 
            // studentAttendanceTableAdapter
            // 
            this.studentAttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // projectBDataSet6
            // 
            this.projectBDataSet6.DataSetName = "ProjectBDataSet6";
            this.projectBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.projectBDataSet6;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 62);
            this.panel1.TabIndex = 86;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(632, 20);
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
            this.label4.Location = new System.Drawing.Point(20, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lab Management System 📝\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.UseMnemonic = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // registrationNumberDataGridViewTextBoxColumn
            // 
            this.registrationNumberDataGridViewTextBoxColumn.DataPropertyName = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.HeaderText = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.Name = "registrationNumberDataGridViewTextBoxColumn";
            // 
            // AttendanceId
            // 
            this.AttendanceId.HeaderText = "AttendanceId";
            this.AttendanceId.Name = "AttendanceId";
            // 
            // AttendanceStatus
            // 
            this.AttendanceStatus.HeaderText = "AttendanceStatus";
            this.AttendanceStatus.Name = "AttendanceStatus";
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private ProjectBDataSet5 projectBDataSet5;
        private System.Windows.Forms.BindingSource studentAttendanceBindingSource;
        private ProjectBDataSet5TableAdapters.StudentAttendanceTableAdapter studentAttendanceTableAdapter;
        private ProjectBDataSet6 projectBDataSet6;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private ProjectBDataSet6TableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceId;
        private System.Windows.Forms.DataGridViewComboBoxColumn AttendanceStatus;
    }
}