namespace House
{
    partial class Fam
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
            this.txtLID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtWork = new System.Windows.Forms.TextBox();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtLID);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            this.splitContainer1.Panel1.Controls.Add(this.btnClear);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.txtWork);
            this.splitContainer1.Panel1.Controls.Add(this.txtIncome);
            this.splitContainer1.Panel1.Controls.Add(this.txtAge);
            this.splitContainer1.Panel1.Controls.Add(this.txtRole);
            this.splitContainer1.Panel1.Controls.Add(this.txtname);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 272;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtLID
            // 
            this.txtLID.Location = new System.Drawing.Point(600, 69);
            this.txtLID.Name = "txtLID";
            this.txtLID.Size = new System.Drawing.Size(100, 25);
            this.txtLID.TabIndex = 16;
            this.txtLID.Text = "0";
            this.txtLID.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(275, 226);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(578, 235);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(156, 25);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(194, 226);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(113, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtWork
            // 
            this.txtWork.Location = new System.Drawing.Point(160, 152);
            this.txtWork.Name = "txtWork";
            this.txtWork.Size = new System.Drawing.Size(181, 25);
            this.txtWork.TabIndex = 11;
            // 
            // txtIncome
            // 
            this.txtIncome.Location = new System.Drawing.Point(160, 183);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(181, 25);
            this.txtIncome.TabIndex = 10;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(160, 121);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(181, 25);
            this.txtAge.TabIndex = 8;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(160, 90);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(181, 25);
            this.txtRole.TabIndex = 7;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(160, 59);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(181, 25);
            this.txtname.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Income";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Work";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "F/M/S/D";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Family Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 174);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Fam
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Fam";
            this.Text = "Home Management System";
            this.Load += new System.EventHandler(this.Ledger_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtWork;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtLID;
    }
}