namespace FinancialCrm
{
    partial class FrmSpendings
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSpendingAmount = new System.Windows.Forms.Label();
            this.lblCategorySpending = new System.Windows.Forms.Label();
            this.lblTitleSpending = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHighExpense = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalSpending = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSettingsForm = new System.Windows.Forms.Button();
            this.btnDashboardForm = new System.Windows.Forms.Button();
            this.btnBankProccesForm = new System.Windows.Forms.Button();
            this.btnBillForm = new System.Windows.Forms.Button();
            this.btnBillsForm = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategoryForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.lblSpendingAmount);
            this.panel1.Controls.Add(this.lblCategorySpending);
            this.panel1.Controls.Add(this.lblTitleSpending);
            this.panel1.Location = new System.Drawing.Point(259, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 216);
            this.panel1.TabIndex = 0;
            // 
            // lblSpendingAmount
            // 
            this.lblSpendingAmount.AutoSize = true;
            this.lblSpendingAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.lblSpendingAmount.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSpendingAmount.Location = new System.Drawing.Point(629, 55);
            this.lblSpendingAmount.Name = "lblSpendingAmount";
            this.lblSpendingAmount.Size = new System.Drawing.Size(117, 40);
            this.lblSpendingAmount.TabIndex = 21;
            this.lblSpendingAmount.Text = "00,00 ₺";
            // 
            // lblCategorySpending
            // 
            this.lblCategorySpending.AutoSize = true;
            this.lblCategorySpending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.lblCategorySpending.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategorySpending.Location = new System.Drawing.Point(361, 55);
            this.lblCategorySpending.Name = "lblCategorySpending";
            this.lblCategorySpending.Size = new System.Drawing.Size(109, 40);
            this.lblCategorySpending.TabIndex = 20;
            this.lblCategorySpending.Text = "Ulaşım";
            // 
            // lblTitleSpending
            // 
            this.lblTitleSpending.AutoSize = true;
            this.lblTitleSpending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.lblTitleSpending.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitleSpending.Location = new System.Drawing.Point(62, 55);
            this.lblTitleSpending.Name = "lblTitleSpending";
            this.lblTitleSpending.Size = new System.Drawing.Size(228, 40);
            this.lblTitleSpending.TabIndex = 19;
            this.lblTitleSpending.Text = "En Yüksek Gider";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1138, 40);
            this.panel3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giderler";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.chart2);
            this.panel4.Location = new System.Drawing.Point(259, 270);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(881, 267);
            this.panel4.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.lblHighExpense);
            this.panel6.Location = new System.Drawing.Point(3, 136);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(411, 128);
            this.panel6.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(94, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 40);
            this.label3.TabIndex = 17;
            this.label3.Text = "Toplam Gider";
            // 
            // lblHighExpense
            // 
            this.lblHighExpense.AutoSize = true;
            this.lblHighExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblHighExpense.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHighExpense.Location = new System.Drawing.Point(129, 55);
            this.lblHighExpense.Name = "lblHighExpense";
            this.lblHighExpense.Size = new System.Drawing.Size(117, 40);
            this.lblHighExpense.TabIndex = 19;
            this.lblHighExpense.Text = "00,00 ₺";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.panel5.Controls.Add(this.lblTotalSpending);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(411, 131);
            this.panel5.TabIndex = 16;
            // 
            // lblTotalSpending
            // 
            this.lblTotalSpending.AutoSize = true;
            this.lblTotalSpending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.lblTotalSpending.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalSpending.Location = new System.Drawing.Point(129, 75);
            this.lblTotalSpending.Name = "lblTotalSpending";
            this.lblTotalSpending.Size = new System.Drawing.Size(117, 40);
            this.lblTotalSpending.TabIndex = 19;
            this.lblTotalSpending.Text = "00,00 ₺";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(94, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 40);
            this.label2.TabIndex = 18;
            this.label2.Text = "En Yüksek Gider";
            // 
            // chart2
            // 
            chartArea7.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart2.Legends.Add(legend7);
            this.chart2.Location = new System.Drawing.Point(413, 6);
            this.chart2.Name = "chart2";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series7.Legend = "Legend1";
            series7.Name = "Faturalar";
            this.chart2.Series.Add(series7);
            this.chart2.Size = new System.Drawing.Size(468, 255);
            this.chart2.TabIndex = 15;
            this.chart2.Text = "chart2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.btnSettingsForm);
            this.panel2.Controls.Add(this.btnDashboardForm);
            this.panel2.Controls.Add(this.btnBankProccesForm);
            this.panel2.Controls.Add(this.btnBillForm);
            this.panel2.Controls.Add(this.btnBillsForm);
            this.panel2.Controls.Add(this.btnBanksForm);
            this.panel2.Controls.Add(this.btnCategoryForm);
            this.panel2.Location = new System.Drawing.Point(2, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 494);
            this.panel2.TabIndex = 18;
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
            this.btnSettingsForm.Click += new System.EventHandler(this.btnSettingsForm_Click);
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
            // btnBillForm
            // 
            this.btnBillForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillForm.ForeColor = System.Drawing.Color.White;
            this.btnBillForm.Location = new System.Drawing.Point(14, 235);
            this.btnBillForm.Name = "btnBillForm";
            this.btnBillForm.Size = new System.Drawing.Size(189, 42);
            this.btnBillForm.TabIndex = 3;
            this.btnBillForm.Text = "Giderler";
            this.btnBillForm.UseVisualStyleBackColor = true;
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
            // FrmSpendings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1137, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSpendings";
            this.Text = "FrmSpendings";
            this.Load += new System.EventHandler(this.FrmSpendings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTotalSpending;
        private System.Windows.Forms.Label lblSpendingAmount;
        private System.Windows.Forms.Label lblCategorySpending;
        private System.Windows.Forms.Label lblTitleSpending;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblHighExpense;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSettingsForm;
        private System.Windows.Forms.Button btnDashboardForm;
        private System.Windows.Forms.Button btnBankProccesForm;
        private System.Windows.Forms.Button btnBillForm;
        private System.Windows.Forms.Button btnBillsForm;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnCategoryForm;
    }
}