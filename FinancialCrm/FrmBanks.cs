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
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities3 db = new FinancialCrmDbEntities3();

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var vakifBankBalance = db.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(y => y.BankBalance).FirstOrDefault();
            var isBankasiBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();

            lblisBankasiBalance.Text = isBankasiBalance.ToString() + "₺";
            lblVakifbankBalance.Text = vakifBankBalance.ToString() + "₺";
            lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + "₺";

            var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + " " + bankProcess1.Amoun + " " + bankProcess1.ProcessDate;

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2). Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + " " + bankProcess2.Amoun + " " + bankProcess2.ProcessDate;

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " " + bankProcess3.Amoun + " " + bankProcess3.ProcessDate;

            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " " + bankProcess4.Amoun + " " + bankProcess4.ProcessDate;

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + " " + bankProcess5.Amoun + " " + bankProcess5.ProcessDate;

        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void btnBankProccesForm_Click(object sender, EventArgs e)
        {
            FrmBankProcess frm = new FrmBankProcess();
            frm.Show();
            this.Hide();
        }

        private void btnSettingsForm_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Close();
        }

        private void btnBillsForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnSpendingsForm_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Hide();
        }
    }
}
