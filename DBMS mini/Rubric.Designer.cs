namespace DBMS_mini
{
    partial class Rubric
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet = new DBMS_mini.ProjectBDataSet();
            this.rubricTableAdapter = new DBMS_mini.ProjectBDataSetTableAdapters.RubricTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(261, 210);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(296, 56);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.Color.Navy;
            this.button9.Location = new System.Drawing.Point(444, 272);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(92, 36);
            this.button9.TabIndex = 7;
            this.button9.Text = "Add Rubric";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(261, 162);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(296, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Update,
            this.Delete,
            this.idDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.cloIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rubricBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(84, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 150);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rubricBindingSource
            // 
            this.rubricBindingSource.DataMember = "Rubric";
            this.rubricBindingSource.DataSource = this.projectBDataSet;
            // 
            // projectBDataSet
            // 
            this.projectBDataSet.DataSetName = "ProjectBDataSet";
            this.projectBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(80, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 39;
            this.label3.Text = "CLO Name ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(80, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "Rubric Details ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 62);
            this.panel1.TabIndex = 41;
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
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
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
            this.label5.Location = new System.Drawing.Point(79, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Rubric 📜\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.UseMnemonic = false;
            // 
            // Update
            // 
            this.Update.FillWeight = 50F;
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 50;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 50F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 50;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            // 
            // cloIdDataGridViewTextBoxColumn
            // 
            this.cloIdDataGridViewTextBoxColumn.DataPropertyName = "CloId";
            this.cloIdDataGridViewTextBoxColumn.HeaderText = "CloId";
            this.cloIdDataGridViewTextBoxColumn.Name = "cloIdDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(588, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 22);
            this.button1.TabIndex = 43;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Rubric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Rubric";
            this.Text = "Rubric";
            this.Load += new System.EventHandler(this.Rubric_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSetTableAdapters.RubricTableAdapter rubricTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}