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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities3 db = new FinancialCrmDbEntities3();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                FrmDashboard mainForm = new FrmDashboard();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
    }

