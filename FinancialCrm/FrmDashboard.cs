using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Model;

namespace FinancialCrm
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities3 db=new FinancialCrmDbEntities3();

        int count = 0;
        private void FrmDashboard_Load(object sender, EventArgs e)
        {

            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString() + "₺";

            var lastBankProcessAmount = db.BankProcesses.OrderByDescending(x=>x.BankProcessId).Take(1).Select(y=>y.Amoun).FirstOrDefault();
            lblLastBankProcessAmount.Text = lastBankProcessAmount.ToString() + "₺";

            // Chart 1 Kodları
            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");
            foreach (var item in bankData)
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
            }
            // Chart 2 Kodları
            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko;
            foreach (var item in billData)
            {
                series.Points.AddXY(item.BillTitle, item.BillAmount);
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            count++;
            if (count % 4 ==2)
            {
                var elektrikFaturasi = db.Bills.Where(x=>x.BillTitle == "Doğalgaz Faturası").Select(y=>y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Doğalgaz Faturası";
                lblBillAmount.Text=elektrikFaturasi.ToString() + "₺";
            }
            if (count % 4 == 3)
            {
                var elektrikFaturasi = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Su Faturası";
                lblBillAmount.Text = elektrikFaturasi.ToString() + "₺";
            }
            if (count % 4 == 0)
            {
                var elektrikFaturasi = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "İnternet Faturası";
                lblBillAmount.Text = elektrikFaturasi.ToString() + "₺";
            }
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Close();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Close();
        }

        private void btnBankProccesForm_Click(object sender, EventArgs e)
        {
            FrmBankProcess frmBankProcess = new FrmBankProcess();
            frmBankProcess.Show();
            this.Close();
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmSpendings frmSpending = new FrmSpendings();
            frmSpending.Show();
            this.Close();
        }

        private void btnBillsForm_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Close();
        }

        private void btnSettingsForm_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
        }
    }
}
