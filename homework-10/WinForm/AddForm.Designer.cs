namespace WinForm
{
    partial class AddForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.SNTB = new System.Windows.Forms.TextBox();
            this.PGTB = new System.Windows.Forms.TextBox();
            this.XJTB = new System.Windows.Forms.TextBox();
            this.SNCB = new System.Windows.Forms.CheckBox();
            this.PGCB = new System.Windows.Forms.CheckBox();
            this.XJCB = new System.Windows.Forms.CheckBox();
            this.ClientPhoneTB = new System.Windows.Forms.TextBox();
            this.ClientTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddOrderButton);
            this.groupBox1.Controls.Add(this.SNTB);
            this.groupBox1.Controls.Add(this.PGTB);
            this.groupBox1.Controls.Add(this.XJTB);
            this.groupBox1.Controls.Add(this.SNCB);
            this.groupBox1.Controls.Add(this.PGCB);
            this.groupBox1.Controls.Add(this.XJCB);
            this.groupBox1.Controls.Add(this.ClientPhoneTB);
            this.groupBox1.Controls.Add(this.ClientTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 359);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加订单";
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddOrderButton.Location = new System.Drawing.Point(125, 286);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(140, 39);
            this.AddOrderButton.TabIndex = 10;
            this.AddOrderButton.Text = "添加";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // SNTB
            // 
            this.SNTB.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SNTB.Location = new System.Drawing.Point(168, 219);
            this.SNTB.Name = "SNTB";
            this.SNTB.Size = new System.Drawing.Size(123, 28);
            this.SNTB.TabIndex = 9;
            // 
            // PGTB
            // 
            this.PGTB.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PGTB.Location = new System.Drawing.Point(168, 174);
            this.PGTB.Name = "PGTB";
            this.PGTB.Size = new System.Drawing.Size(123, 28);
            this.PGTB.TabIndex = 8;
            // 
            // XJTB
            // 
            this.XJTB.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.XJTB.Location = new System.Drawing.Point(168, 126);
            this.XJTB.Name = "XJTB";
            this.XJTB.Size = new System.Drawing.Size(123, 28);
            this.XJTB.TabIndex = 7;
            // 
            // SNCB
            // 
            this.SNCB.AutoSize = true;
            this.SNCB.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SNCB.Location = new System.Drawing.Point(91, 221);
            this.SNCB.Name = "SNCB";
            this.SNCB.Size = new System.Drawing.Size(71, 23);
            this.SNCB.TabIndex = 6;
            this.SNCB.Text = "酸奶";
            this.SNCB.UseVisualStyleBackColor = true;
            // 
            // PGCB
            // 
            this.PGCB.AutoSize = true;
            this.PGCB.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PGCB.Location = new System.Drawing.Point(91, 174);
            this.PGCB.Name = "PGCB";
            this.PGCB.Size = new System.Drawing.Size(71, 23);
            this.PGCB.TabIndex = 5;
            this.PGCB.Text = "苹果";
            this.PGCB.UseVisualStyleBackColor = true;
            // 
            // XJCB
            // 
            this.XJCB.AutoSize = true;
            this.XJCB.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.XJCB.Location = new System.Drawing.Point(91, 128);
            this.XJCB.Name = "XJCB";
            this.XJCB.Size = new System.Drawing.Size(71, 23);
            this.XJCB.TabIndex = 4;
            this.XJCB.Text = "香蕉";
            this.XJCB.UseVisualStyleBackColor = true;
            // 
            // ClientPhoneTB
            // 
            this.ClientPhoneTB.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientPhoneTB.Location = new System.Drawing.Point(145, 69);
            this.ClientPhoneTB.MaxLength = 11;
            this.ClientPhoneTB.Name = "ClientPhoneTB";
            this.ClientPhoneTB.Size = new System.Drawing.Size(163, 30);
            this.ClientPhoneTB.TabIndex = 3;
            // 
            // ClientTB
            // 
            this.ClientTB.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClientTB.Location = new System.Drawing.Point(145, 33);
            this.ClientTB.Name = "ClientTB";
            this.ClientTB.Size = new System.Drawing.Size(163, 30);
            this.ClientTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(37, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "联系电话";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(47, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户名";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 359);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClientPhoneTB;
        private System.Windows.Forms.TextBox ClientTB;
        private System.Windows.Forms.TextBox SNTB;
        private System.Windows.Forms.TextBox PGTB;
        private System.Windows.Forms.TextBox XJTB;
        private System.Windows.Forms.CheckBox SNCB;
        private System.Windows.Forms.CheckBox PGCB;
        private System.Windows.Forms.CheckBox XJCB;
        private System.Windows.Forms.Button AddOrderButton;
    }
}