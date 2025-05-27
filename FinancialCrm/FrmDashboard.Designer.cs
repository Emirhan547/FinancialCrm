namespace FinancialCrm
{
    partial class FrmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblLastBankProcessAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.lblBillTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSettingsForm = new System.Windows.Forms.Button();
            this.btnDashboardForm = new System.Windows.Forms.Button();
            this.btnBankProccesForm = new System.Windows.Forms.Button();
            this.btnBillForm = new System.Windows.Forms.Button();
            this.btnBillsForm = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategoryForm = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panel5.Controls.Add(this.lblLastBankProcessAmount);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(852, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(287, 141);
            this.panel5.TabIndex = 10;
            // 
            // lblLastBankProcessAmount
            // 
            this.lblLastBankProcessAmount.AutoSize = true;
            this.lblLastBankProcessAmount.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastBankProcessAmount.ForeColor = System.Drawing.Color.White;
            this.lblLastBankProcessAmount.Location = new System.Drawing.Point(28, 33);
            this.lblLastBankProcessAmount.Name = "lblLastBankProcessAmount";
            this.lblLastBankProcessAmount.Size = new System.Drawing.Size(156, 58);
            this.lblLastBankProcessAmount.TabIndex = 6;
            this.lblLastBankProcessAmount.Text = "0.00  ₺";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(71, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gelen Son Havale";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel4.Controls.Add(this.lblBillAmount);
            this.panel4.Controls.Add(this.lblBillTitle);
            this.panel4.Location = new System.Drawing.Point(561, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 141);
            this.panel4.TabIndex = 9;
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillAmount.ForeColor = System.Drawing.Color.White;
            this.lblBillAmount.Location = new System.Drawing.Point(28, 48);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(156, 58);
            this.lblBillAmount.TabIndex = 5;
            this.lblBillAmount.Text = "0.00  ₺";
            // 
            // lblBillTitle
            // 
            this.lblBillTitle.AutoSize = true;
            this.lblBillTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillTitle.ForeColor = System.Drawing.Color.White;
            this.lblBillTitle.Location = new System.Drawing.Point(60, 9);
            this.lblBillTitle.Name = "lblBillTitle";
            this.lblBillTitle.Size = new System.Drawing.Size(121, 24);
            this.lblBillTitle.TabIndex = 4;
            this.lblBillTitle.Text = "Fatura Başlığı";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.panel3.Controls.Add(this.lblTotalBalance);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(240, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 141);
            this.panel3.TabIndex = 8;
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.AutoSize = true;
            this.lblTotalBalance.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalBalance.ForeColor = System.Drawing.Color.White;
            this.lblTotalBalance.Location = new System.Drawing.Point(28, 48);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(228, 58);
            this.lblTotalBalance.TabIndex = 4;
            this.lblTotalBalance.Text = "0000.00  ₺";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toplam Bakiyem";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 40);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard / Genel Bakış ";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // chart1
            // 
            chartArea13.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chart1.Legends.Add(legend13);
            this.chart1.Location = new System.Drawing.Point(240, 310);
            this.chart1.Name = "chart1";
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.chart1.Series.Add(series13);
            this.chart1.Size = new System.Drawing.Size(411, 228);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea14.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chart2.Legends.Add(legend14);
            this.chart2.Location = new System.Drawing.Point(719, 310);
            this.chart2.Name = "chart2";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series14.Legend = "Legend1";
            series14.Name = "Faturalar";
            this.chart2.Series.Add(series14);
            this.chart2.Size = new System.Drawing.Size(420, 228);
            this.chart2.TabIndex = 14;
            this.chart2.Text = "chart2";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(240, 204);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(411, 100);
            this.panel6.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 63);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bankalar ve banka hesaplarındaki para miktarlarına \r\naşağıdaki grafikten ulaşabil" +
    "irsiniz.\r\n\r\n";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(719, 204);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(420, 100);
            this.panel7.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 42);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ödenen ve ödenmesi gereken fatura tutarlarına \r\naşağıdaki grafikten ulaşabilirsin" +
    "iz.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnSettingsForm);
            this.panel1.Controls.Add(this.btnDashboardForm);
            this.panel1.Controls.Add(this.btnBankProccesForm);
            this.panel1.Controls.Add(this.btnBillForm);
            this.panel1.Controls.Add(this.btnBillsForm);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.btnCategoryForm);
            this.panel1.Location = new System.Drawing.Point(2, 44);
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
            this.btnBillForm.Click += new System.EventHandler(this.btnBillForm_Click);
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
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1137, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "FrmDashboard";
            this.Text = "Dashboard Formu";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblLastBankProcessAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.Label lblBillTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
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

