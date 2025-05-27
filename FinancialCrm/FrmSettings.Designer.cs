namespace FinancialCrm
{
    partial class FrmSettings
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPasswordUpdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSettingsForm = new System.Windows.Forms.Button();
            this.btnDashboardForm = new System.Windows.Forms.Button();
            this.btnBankProccesForm = new System.Windows.Forms.Button();
            this.btnSpendingsForm = new System.Windows.Forms.Button();
            this.btnBillsForm = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategoryForm = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsername.Location = new System.Drawing.Point(312, 193);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(148, 28);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Mevcut Şifren:";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCurrentPassword.Location = new System.Drawing.Point(468, 190);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(167, 36);
            this.txtCurrentPassword.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewPassword.Location = new System.Drawing.Point(468, 267);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(167, 36);
            this.txtNewPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(330, 270);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(114, 28);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Yeni Şifren:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(458, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 58);
            this.label3.TabIndex = 4;
            this.label3.Text = "Admin";
            // 
            // btnPasswordUpdate
            // 
            this.btnPasswordUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.btnPasswordUpdate.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPasswordUpdate.ForeColor = System.Drawing.Color.White;
            this.btnPasswordUpdate.Location = new System.Drawing.Point(468, 349);
            this.btnPasswordUpdate.Name = "btnPasswordUpdate";
            this.btnPasswordUpdate.Size = new System.Drawing.Size(167, 41);
            this.btnPasswordUpdate.TabIndex = 5;
            this.btnPasswordUpdate.Text = "Şifreni Güncelle";
            this.btnPasswordUpdate.UseVisualStyleBackColor = false;
            this.btnPasswordUpdate.Click += new System.EventHandler(this.btnPasswordUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 40);
            this.panel2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-4, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ayarlar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnSettingsForm);
            this.panel1.Controls.Add(this.btnDashboardForm);
            this.panel1.Controls.Add(this.btnBankProccesForm);
            this.panel1.Controls.Add(this.btnSpendingsForm);
            this.panel1.Controls.Add(this.btnBillsForm);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.btnCategoryForm);
            this.panel1.Location = new System.Drawing.Point(4, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 494);
            this.panel1.TabIndex = 18;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(14, 409);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(189, 42);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Çıkış Yap";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSettingsForm
            // 
            this.btnSettingsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettingsForm.ForeColor = System.Drawing.Color.White;
            this.btnSettingsForm.Location = new System.Drawing.Point(14, 350);
            this.btnSettingsForm.Name = "btnSettingsForm";
            this.btnSettingsForm.Size = new System.Drawing.Size(189, 42);
            this.btnSettingsForm.TabIndex = 6;
            this.btnSettingsForm.Text = "Ayarlar";
            this.btnSettingsForm.UseVisualStyleBackColor = true;
            // 
            // btnDashboardForm
            // 
            this.btnDashboardForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboardForm.ForeColor = System.Drawing.Color.White;
            this.btnDashboardForm.Location = new System.Drawing.Point(14, 6);
            this.btnDashboardForm.Name = "btnDashboardForm";
            this.btnDashboardForm.Size = new System.Drawing.Size(189, 42);
            this.btnDashboardForm.TabIndex = 5;
            this.btnDashboardForm.Text = "Dashboard";
            this.btnDashboardForm.UseVisualStyleBackColor = true;
            this.btnDashboardForm.Click += new System.EventHandler(this.btnDashboardForm_Click);
            // 
            // btnBankProccesForm
            // 
            this.btnBankProccesForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankProccesForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankProccesForm.ForeColor = System.Drawing.Color.White;
            this.btnBankProccesForm.Location = new System.Drawing.Point(14, 174);
            this.btnBankProccesForm.Name = "btnBankProccesForm";
            this.btnBankProccesForm.Size = new System.Drawing.Size(189, 43);
            this.btnBankProccesForm.TabIndex = 4;
            this.btnBankProccesForm.Text = "Banka Hareketleri";
            this.btnBankProccesForm.UseVisualStyleBackColor = true;
            this.btnBankProccesForm.Click += new System.EventHandler(this.btnBankProccesForm_Click);
            // 
            // btnSpendingsForm
            // 
            this.btnSpendingsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendingsForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendingsForm.ForeColor = System.Drawing.Color.White;
            this.btnSpendingsForm.Location = new System.Drawing.Point(14, 235);
            this.btnSpendingsForm.Name = "btnSpendingsForm";
            this.btnSpendingsForm.Size = new System.Drawing.Size(189, 42);
            this.btnSpendingsForm.TabIndex = 3;
            this.btnSpendingsForm.Text = "Giderler";
            this.btnSpendingsForm.UseVisualStyleBackColor = true;
            this.btnSpendingsForm.Click += new System.EventHandler(this.btnSpendingsForm_Click);
            // 
            // btnBillsForm
            // 
            this.btnBillsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillsForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillsForm.ForeColor = System.Drawing.Color.White;
            this.btnBillsForm.Location = new System.Drawing.Point(14, 293);
            this.btnBillsForm.Name = "btnBillsForm";
            this.btnBillsForm.Size = new System.Drawing.Size(189, 42);
            this.btnBillsForm.TabIndex = 2;
            this.btnBillsForm.Text = "Faturalar";
            this.btnBillsForm.UseVisualStyleBackColor = true;
            this.btnBillsForm.Click += new System.EventHandler(this.btnBillsForm_Click);
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.White;
            this.btnBanksForm.Location = new System.Drawing.Point(14, 116);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(189, 42);
            this.btnBanksForm.TabIndex = 1;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = true;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // btnCategoryForm
            // 
            this.btnCategoryForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryForm.ForeColor = System.Drawing.Color.White;
            this.btnCategoryForm.Location = new System.Drawing.Point(14, 60);
            this.btnCategoryForm.Name = "btnCategoryForm";
            this.btnCategoryForm.Size = new System.Drawing.Size(189, 42);
            this.btnCategoryForm.TabIndex = 0;
            this.btnCategoryForm.Text = "Kategoriler";
            this.btnCategoryForm.UseVisualStyleBackColor = true;
            this.btnCategoryForm.Click += new System.EventHandler(this.btnCategoryForm_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1137, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPasswordUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.lblUsername);
            this.Name = "FrmSettings";
            this.Text = "FrmSettings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPasswordUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSettingsForm;
        private System.Windows.Forms.Button btnDashboardForm;
        private System.Windows.Forms.Button btnBankProccesForm;
        private System.Windows.Forms.Button btnSpendingsForm;
        private System.Windows.Forms.Button btnBillsForm;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnCategoryForm;
    }
}