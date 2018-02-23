using System;
using System.Data.Entity;
using System.Windows.Forms;
using System.Linq;

namespace Accounting
{
    public partial class Accounting : Form
    {
        public Accounting()
        {
            InitializeComponent();
        }

        AccountingEntities1 AccountingDb;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert insertFrm = new Insert();
            insertFrm.Show();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                AccountingDb = new AccountingEntities1();

                AccountingDb.Invoice.Load();

                AccountingDataView.DataSource = AccountingDb.Invoice.Local.ToBindingList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\n\r");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                AccountingDb = new AccountingEntities1();
                var search = from c in AccountingDb.Invoice
                             where c.Client == txtSearch.Text
                             select c;
                var bindingList = search.ToList();
                AccountingDataView.DataSource = bindingList;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\n\r");
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                AccountingDb = new AccountingEntities1();
                double money = AccountingDb.Invoice.Where(c => c.Client.Contains(txtSum.Text)).Sum(c => c.Money);
                MessageBox.Show(string.Format("Сума на всех счетах клиента {0} равна {1}", txtSum.Text, money.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\n\r");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(AccountingDataView.CurrentRow.Cells[0].Value);
                AccountingDb = new AccountingEntities1();
                Invoice client = AccountingDb.Invoice.Find(id);
                AccountingDb.Invoice.Remove(client);
                AccountingDb.SaveChanges();
                MessageBox.Show("Выбраная строка удалена. Нажмите Select что бы обновить список");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\n\r");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.Show();
        }
    }
}
