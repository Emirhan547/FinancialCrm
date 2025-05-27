using FinancialCrm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBankProcess : Form
    {
        public FrmBankProcess()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities3 db = new FinancialCrmDbEntities3();
        private void FrmBankProcess_Load(object sender, EventArgs e)
        {
            var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + " " + bankProcess1.ProcessDate;
            lblAmount1.Text = bankProcess1.Amoun + " ₺";

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + " " + bankProcess2.ProcessDate;
            lblAmount2.Text = bankProcess2.Amoun + " ₺";

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " " + bankProcess3.ProcessDate;
            lblAmount3.Text = bankProcess3.Amoun + " ₺";

            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " " + bankProcess4.ProcessDate;
            lblAmount4.Text = bankProcess4.Amoun + " ₺";

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + " " + bankProcess5.ProcessDate;
            lblAmount5.Text = bankProcess5.Amoun + " ₺";

            var bankProcess6 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(6).Skip(5).FirstOrDefault();
            lblBankProcess6.Text = bankProcess6.Description + " " + bankProcess6.ProcessDate;
            lblAmount6.Text = bankProcess6.Amoun + " ₺";
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.ShowDialog();
            this.Hide();
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.ShowDialog();
            this.Hide();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.ShowDialog();
            this.Hide();
        }

        private void btnSpendingForm_Click(object sender, EventArgs e)
        {
            FrmSpendings frmSpendings = new FrmSpendings();
            frmSpendings.ShowDialog();
            this.Hide();
        }

        private void btnBillsForm_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.ShowDialog();
            this.Hide();
        }

        private void btnSettingsForm_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.ShowDialog();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }
    }
    }

