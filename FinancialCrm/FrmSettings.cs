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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities3 db=new FinancialCrmDbEntities3();

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            var username = db.Users.FirstOrDefault();
            lblUsername.Text = username.Username;

            // Şifre alanlarını gizle
            txtCurrentPassword.PasswordChar = '*';
            txtNewPassword.PasswordChar = '*';
        }

        private void btnPasswordUpdate_Click(object sender, EventArgs e)
        {
            var user = db.Users.FirstOrDefault();
            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;

            if (currentPassword == user.Password)
            {
                user.Password = newPassword;
                db.SaveChanges();
                MessageBox.Show("Şifreniz Güncellenmiştir");
            }
            else
            {
                MessageBox.Show("Mevcut Şifrenizi Yanlış Girdiniz.");
            }
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Close();
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Close();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Close();
        }

        private void btnBankProccesForm_Click(object sender, EventArgs e)
        {
            FrmBankProcess frm = new FrmBankProcess();
            frm.Show();
            this.Close();
        }

        private void btnSpendingsForm_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Close();
        }

        private void btnBillsForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Close();
        }
    }
    }

