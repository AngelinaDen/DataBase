namespace DataBase
{
    partial class Form5
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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодОтделенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отделениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодДорогиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отделенияЖелезныхДорогBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._1DatabaseDataSet = new DataBase._1DatabaseDataSet();
            this.отделения_железных_дорогTableAdapter = new DataBase._1DatabaseDataSetTableAdapters.Отделения_железных_дорогTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделенияЖелезныхДорогBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1DatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Blue;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(361, 218);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 39);
            this.button6.TabIndex = 13;
            this.button6.Text = "Назад";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(261, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 39);
            this.button5.TabIndex = 12;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(361, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 39);
            this.button4.TabIndex = 11;
            this.button4.Text = "Найти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(24, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 39);
            this.button3.TabIndex = 10;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(24, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(157, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Сохранить";
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
            this.кодОтделенияDataGridViewTextBoxColumn,
            this.отделениеDataGridViewTextBoxColumn,
            this.кодДорогиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.отделенияЖелезныхДорогBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(416, 141);
            this.dataGridView1.TabIndex = 7;
            // 
            // кодОтделенияDataGridViewTextBoxColumn
            // 
            this.кодОтделенияDataGridViewTextBoxColumn.DataPropertyName = "КодОтделения";
            this.кодОтделенияDataGridViewTextBoxColumn.HeaderText = "КодОтделения";
            this.кодОтделенияDataGridViewTextBoxColumn.Name = "кодОтделенияDataGridViewTextBoxColumn";
            this.кодОтделенияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // отделениеDataGridViewTextBoxColumn
            // 
            this.отделениеDataGridViewTextBoxColumn.DataPropertyName = "Отделение";
            this.отделениеDataGridViewTextBoxColumn.HeaderText = "Отделение";
            this.отделениеDataGridViewTextBoxColumn.Name = "отделениеDataGridViewTextBoxColumn";
            this.отделениеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодДорогиDataGridViewTextBoxColumn
            // 
            this.кодДорогиDataGridViewTextBoxColumn.DataPropertyName = "КодДороги";
            this.кодДорогиDataGridViewTextBoxColumn.HeaderText = "КодДороги";
            this.кодДорогиDataGridViewTextBoxColumn.Name = "кодДорогиDataGridViewTextBoxColumn";
            this.кодДорогиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // отделенияЖелезныхДорогBindingSource
            // 
            this.отделенияЖелезныхДорогBindingSource.DataMember = "Отделения железных дорог";
            this.отделенияЖелезныхДорогBindingSource.DataSource = this._1DatabaseDataSet;
            // 
            // _1DatabaseDataSet
            // 
            this._1DatabaseDataSet.DataSetName = "_1DatabaseDataSet";
            this._1DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // отделения_железных_дорогTableAdapter
            // 
            this.отделения_железных_дорогTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(456, 289);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Отделения железных дорог";
            this.Activated += new System.EventHandler(this.Form5_Activated);
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделенияЖелезныхДорогBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1DatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public _1DatabaseDataSet _1DatabaseDataSet;
        public System.Windows.Forms.BindingSource отделенияЖелезныхДорогBindingSource;
        public _1DatabaseDataSetTableAdapters.Отделения_железных_дорогTableAdapter отделения_железных_дорогTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодОтделенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отделениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодДорогиDataGridViewTextBoxColumn;
    }
}