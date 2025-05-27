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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        FinancialCrmDbEntities3 db=new FinancialCrmDbEntities3();
        private void FrmCategories_Load(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string title = txtCategoryTitle.Text;

            Categories categories = new Categories();
            categories.CategoryName = title;

            db.Categories.Add(categories);

            db.SaveChanges();
            MessageBox.Show("Kategori Ekleme İşleminiz Gerçekleşmiştir.", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var removeCategory = db.Categories.Find(id);

            db.Categories.Remove(removeCategory);
            db.SaveChanges();

            MessageBox.Show("Kategori Silme İşleminiz Gerçekleşmiştir.", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var updateCategory = db.Categories.Find(id);

            updateCategory.CategoryName = txtCategoryTitle.Text;

            db.SaveChanges();
            MessageBox.Show("Kategori Güncelleme İşleminiz Gerçekleşmiştir.", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnBankProccesForm_Click(object sender, EventArgs e)
        {
            FrmBankProcess frm = new FrmBankProcess();
            frm.Show();
            this.Hide();
        }

        private void btnSpendingsForm_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Hide();
        }

        private void btnBillsForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
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
    }
}
