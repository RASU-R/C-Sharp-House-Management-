namespace House
{
    partial class Transaction
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTID = new System.Windows.Forms.TextBox();
            this.comboPay_Type = new System.Windows.Forms.ComboBox();
            this.comboLid = new System.Windows.Forms.ComboBox();
            this.textDes = new System.Windows.Forms.TextBox();
            this.textItem = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Quantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtQuantity);
            this.splitContainer1.Panel1.Controls.Add(this.Quantity);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.txtTID);
            this.splitContainer1.Panel1.Controls.Add(this.comboPay_Type);
            this.splitContainer1.Panel1.Controls.Add(this.comboLid);
            this.splitContainer1.Panel1.Controls.Add(this.textDes);
            this.splitContainer1.Panel1.Controls.Add(this.textItem);
            this.splitContainer1.Panel1.Controls.Add(this.txtRate);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnClear);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(781, 392);
            this.splitContainer1.SplitterDistance = 248;
            this.splitContainer1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(442, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 25);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtTID
            // 
            this.txtTID.Location = new System.Drawing.Point(637, 34);
            this.txtTID.Name = "txtTID";
            this.txtTID.Size = new System.Drawing.Size(30, 25);
            this.txtTID.TabIndex = 21;
            this.txtTID.Text = "0";
            this.txtTID.Visible = false;
            // 
            // comboPay_Type
            // 
            this.comboPay_Type.FormattingEnabled = true;
            this.comboPay_Type.Items.AddRange(new object[] {
            "Cash",
            "Gpay",
            "Other"});
            this.comboPay_Type.Location = new System.Drawing.Point(119, 65);
            this.comboPay_Type.Name = "comboPay_Type";
            this.comboPay_Type.Size = new System.Drawing.Size(461, 25);
            this.comboPay_Type.TabIndex = 20;
            this.comboPay_Type.SelectedIndexChanged += new System.EventHandler(this.comboPay_Type_SelectedIndexChanged);
            // 
            // comboLid
            // 
            this.comboLid.FormattingEnabled = true;
            this.comboLid.Location = new System.Drawing.Point(119, 34);
            this.comboLid.Name = "comboLid";
            this.comboLid.Size = new System.Drawing.Size(252, 25);
            this.comboLid.TabIndex = 19;
            // 
            // textDes
            // 
            this.textDes.Location = new System.Drawing.Point(119, 172);
            this.textDes.Multiline = true;
            this.textDes.Name = "textDes";
            this.textDes.Size = new System.Drawing.Size(461, 36);
            this.textDes.TabIndex = 16;
            this.textDes.TextChanged += new System.EventHandler(this.textDes_TextChanged);
            // 
            // textItem
            // 
            this.textItem.Location = new System.Drawing.Point(119, 105);
            this.textItem.Name = "textItem";
            this.textItem.Size = new System.Drawing.Size(461, 25);
            this.textItem.TabIndex = 14;
            this.textItem.TextChanged += new System.EventHandler(this.textItem_TextChanged);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(442, 136);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(138, 25);
            this.txtRate.TabIndex = 13;
            this.txtRate.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(614, 220);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(124, 25);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(323, 222);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(215, 222);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(104, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Rate";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Item Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Item-Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Payment-Type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shopping Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(781, 140);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(14, 144);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(63, 17);
            this.Quantity.TabIndex = 23;
            this.Quantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(119, 136);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(252, 25);
            this.txtQuantity.TabIndex = 24;
            // 
            // Transaction
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(781, 392);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Transaction";
            this.Text = "House Management System";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textDes;
        private System.Windows.Forms.TextBox textItem;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboPay_Type;
        private System.Windows.Forms.ComboBox comboLid;
        private System.Windows.Forms.TextBox txtTID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label Quantity;
    }
}