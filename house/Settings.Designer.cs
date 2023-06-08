namespace House
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentPass = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            // 
            // lblCurrentPass
            // 
            this.lblCurrentPass.AutoSize = true;
            this.lblCurrentPass.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPass.Location = new System.Drawing.Point(22, 73);
            this.lblCurrentPass.Name = "lblCurrentPass";
            this.lblCurrentPass.Size = new System.Drawing.Size(121, 17);
            this.lblCurrentPass.TabIndex = 1;
            this.lblCurrentPass.Text = "Current Password";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.Location = new System.Drawing.Point(22, 125);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(102, 17);
            this.lblNewPass.TabIndex = 2;
            this.lblNewPass.Text = "New Password";
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPass.Location = new System.Drawing.Point(22, 186);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(124, 17);
            this.lblConfirmPass.TabIndex = 3;
            this.lblConfirmPass.Text = "Confirm Password";
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Location = new System.Drawing.Point(164, 73);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Size = new System.Drawing.Size(123, 20);
            this.txtCurrentPass.TabIndex = 4;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(164, 125);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(123, 20);
            this.txtNewPass.TabIndex = 5;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(164, 183);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(123, 20);
            this.txtConfirmPass.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(86, 246);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update Password";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(199, 246);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Settings
            // 
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtCurrentPass);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblCurrentPass);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Text = "Passbook Management System";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.TextBox txtCurrentPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
