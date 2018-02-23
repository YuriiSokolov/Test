using System;
using System.Data;
using System.Data.Entity;
using System.Windows.Forms;

namespace Accounting
{
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        AccountingEntities1 AccountingDB;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                AccountingDB = new AccountingEntities1();
                Invoice Client = new Invoice();

                Client.Client = txtName.Text;
                Client.Date = txtDate.Text;
                Client.Money = Convert.ToDouble(txtMoney.Text);

                AccountingDB.Invoice.Add(Client);
                AccountingDB.SaveChanges();

                MessageBox.Show(string.Format("Клиент {0} добавлен в базу данных", txtName.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\r\n");
            }
        }
    }
}
