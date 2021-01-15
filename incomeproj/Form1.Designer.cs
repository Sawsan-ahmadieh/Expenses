namespace incomeproj
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmdDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbPrice = new System.Windows.Forms.GroupBox();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboFilterItem = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFilterEnd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFilterStart = new System.Windows.Forms.TextBox();
            this.dgvExpense = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.gbPrice.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdDetails
            // 
            this.cmdDetails.Location = new System.Drawing.Point(511, 38);
            this.cmdDetails.Name = "cmdDetails";
            this.cmdDetails.Size = new System.Drawing.Size(112, 34);
            this.cmdDetails.TabIndex = 0;
            this.cmdDetails.Text = "Details";
            this.cmdDetails.UseVisualStyleBackColor = true;
            this.cmdDetails.Click += new System.EventHandler(this.cmdDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Name:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cboItem
            // 
            this.cboItem.AllowDrop = true;
            this.cboItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(152, 38);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(353, 33);
            this.cboItem.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbPrice);
            this.groupBox1.Controls.Add(this.cmdSave);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.cboItem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdDetails);
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 431);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expenditure";
            // 
            // gbPrice
            // 
            this.gbPrice.Controls.Add(this.cmdCalculate);
            this.gbPrice.Controls.Add(this.txtDesc);
            this.gbPrice.Controls.Add(this.label6);
            this.gbPrice.Controls.Add(this.txtPrice);
            this.gbPrice.Controls.Add(this.label5);
            this.gbPrice.Controls.Add(this.txtQuantity);
            this.gbPrice.Controls.Add(this.label4);
            this.gbPrice.Location = new System.Drawing.Point(308, 78);
            this.gbPrice.Name = "gbPrice";
            this.gbPrice.Size = new System.Drawing.Size(350, 282);
            this.gbPrice.TabIndex = 6;
            this.gbPrice.TabStop = false;
            this.gbPrice.Visible = false;
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Location = new System.Drawing.Point(118, 235);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(112, 34);
            this.cmdCalculate.TabIndex = 0;
            this.cmdCalculate.Text = "Calculate";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(118, 21);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(223, 92);
            this.txtDesc.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Description:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(118, 143);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(150, 31);
            this.txtPrice.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Price:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(118, 180);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(150, 31);
            this.txtQuantity.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity:";
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(152, 281);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(112, 34);
            this.cmdSave.TabIndex = 0;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(152, 170);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(150, 31);
            this.txtDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(152, 115);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(150, 31);
            this.txtAmount.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cboFilterItem);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtFilterEnd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtFilterStart);
            this.groupBox2.Controls.Add(this.dgvExpense);
            this.groupBox2.Location = new System.Drawing.Point(676, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(830, 431);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(594, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(712, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(75, 59);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 25);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "......";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "Total:";
            // 
            // cboFilterItem
            // 
            this.cboFilterItem.AllowDrop = true;
            this.cboFilterItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboFilterItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFilterItem.FormattingEnabled = true;
            this.cboFilterItem.Location = new System.Drawing.Point(138, 21);
            this.cboFilterItem.Name = "cboFilterItem";
            this.cboFilterItem.Size = new System.Drawing.Size(219, 33);
            this.cboFilterItem.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Item Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(622, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "And";
            // 
            // txtFilterEnd
            // 
            this.txtFilterEnd.Location = new System.Drawing.Point(673, 22);
            this.txtFilterEnd.Name = "txtFilterEnd";
            this.txtFilterEnd.Size = new System.Drawing.Size(150, 31);
            this.txtFilterEnd.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Between:";
            // 
            // txtFilterStart
            // 
            this.txtFilterStart.Location = new System.Drawing.Point(466, 22);
            this.txtFilterStart.Name = "txtFilterStart";
            this.txtFilterStart.Size = new System.Drawing.Size(150, 31);
            this.txtFilterStart.TabIndex = 4;
            // 
            // dgvExpense
            // 
            this.dgvExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpense.Location = new System.Drawing.Point(6, 100);
            this.dgvExpense.Name = "dgvExpense";
            this.dgvExpense.RowHeadersWidth = 62;
            this.dgvExpense.Size = new System.Drawing.Size(818, 315);
            this.dgvExpense.TabIndex = 0;
            this.dgvExpense.Text = "dataGridView1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "MyApp";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbPrice.ResumeLayout(false);
            this.gbPrice.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.GroupBox gbPrice;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvExpense;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboFilterItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFilterEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFilterStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

