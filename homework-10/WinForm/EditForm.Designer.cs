namespace WinForm
{
    partial class EditForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddDetails = new System.Windows.Forms.Button();
            this.DeleteDetails = new System.Windows.Forms.Button();
            this.SaveDetails = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Phone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CustomerBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "订单信息";
            // 
            // Phone
            // 
            this.Phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Phone", true));
            this.Phone.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Phone.Location = new System.Drawing.Point(229, 66);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(183, 30);
            this.Phone.TabIndex = 5;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(OrderSystem.Order);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(134, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "联系电话";
            // 
            // CustomerBox
            // 
            this.CustomerBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Customer", true));
            this.CustomerBox.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CustomerBox.Location = new System.Drawing.Point(229, 24);
            this.CustomerBox.Name = "CustomerBox";
            this.CustomerBox.Size = new System.Drawing.Size(183, 30);
            this.CustomerBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(154, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "客户名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 279);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "订单明细";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.goodDataGridViewTextBoxColumn,
            this.goodNumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.detailsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(587, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "序号";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // goodDataGridViewTextBoxColumn
            // 
            this.goodDataGridViewTextBoxColumn.DataPropertyName = "Good";
            this.goodDataGridViewTextBoxColumn.HeaderText = "商品名";
            this.goodDataGridViewTextBoxColumn.Name = "goodDataGridViewTextBoxColumn";
            this.goodDataGridViewTextBoxColumn.Width = 150;
            // 
            // goodNumDataGridViewTextBoxColumn
            // 
            this.goodNumDataGridViewTextBoxColumn.DataPropertyName = "GoodNum";
            this.goodNumDataGridViewTextBoxColumn.HeaderText = "数量";
            this.goodNumDataGridViewTextBoxColumn.Name = "goodNumDataGridViewTextBoxColumn";
            this.goodNumDataGridViewTextBoxColumn.Width = 150;
            // 
            // detailsBindingSource
            // 
            this.detailsBindingSource.DataMember = "details";
            this.detailsBindingSource.DataSource = this.orderBindingSource;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AddDetails);
            this.groupBox3.Controls.Add(this.DeleteDetails);
            this.groupBox3.Controls.Add(this.SaveDetails);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 385);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(593, 71);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "完成";
            // 
            // AddDetails
            // 
            this.AddDetails.Font = new System.Drawing.Font("楷体", 10F);
            this.AddDetails.Location = new System.Drawing.Point(229, 22);
            this.AddDetails.Name = "AddDetails";
            this.AddDetails.Size = new System.Drawing.Size(120, 37);
            this.AddDetails.TabIndex = 2;
            this.AddDetails.Text = "添加明细";
            this.AddDetails.UseVisualStyleBackColor = true;
            this.AddDetails.Click += new System.EventHandler(this.AddDetails_Click);
            // 
            // DeleteDetails
            // 
            this.DeleteDetails.Font = new System.Drawing.Font("楷体", 10F);
            this.DeleteDetails.Location = new System.Drawing.Point(76, 22);
            this.DeleteDetails.Name = "DeleteDetails";
            this.DeleteDetails.Size = new System.Drawing.Size(120, 37);
            this.DeleteDetails.TabIndex = 1;
            this.DeleteDetails.Text = "删除明细";
            this.DeleteDetails.UseVisualStyleBackColor = true;
            this.DeleteDetails.Click += new System.EventHandler(this.DeleteDetails_Click);
            // 
            // SaveDetails
            // 
            this.SaveDetails.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SaveDetails.Location = new System.Drawing.Point(387, 22);
            this.SaveDetails.Name = "SaveDetails";
            this.SaveDetails.Size = new System.Drawing.Size(120, 37);
            this.SaveDetails.TabIndex = 0;
            this.SaveDetails.Text = "完成";
            this.SaveDetails.UseVisualStyleBackColor = true;
            this.SaveDetails.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 456);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox CustomerBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SaveDetails;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource detailsBindingSource;
        private System.Windows.Forms.Button AddDetails;
        private System.Windows.Forms.Button DeleteDetails;
    }
}