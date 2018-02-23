using System;
using System.Data.Entity;
using System.Windows.Forms;
using System.Linq;

namespace Accounting
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        AccountingEntities1 AccountingDB;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AccountingDB = new AccountingEntities1();

            if (txtOldName.Text != string.Empty)
            {
                try
                {
                    Invoice client = AccountingDB.Invoice.First(c => c.Client == txtOldName.Text);
                    if (txtNewDate.Text != string.Empty)
                    {
                        client.Date = txtNewDate.Text;
                    }
                    if (txtNewName.Text != string.Empty)
                    {
                        client.Client = txtNewName.Text;
                    }
                    if (txtNewMoney.Text != string.Empty)
                    {
                        client.Money = Convert.ToDouble(txtNewMoney.Text);
                    }
                    AccountingDB.SaveChanges();
                    MessageBox.Show(string.Format("Данные о пользователе {0} обновлены успешоно!!!", txtOldName.Text));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "\r\n");
                }
            }
            else if(txtID.Text != string.Empty)
            {
                try
                {
                    int id = Convert.ToInt32(txtID.Text);
                    Invoice client = AccountingDB.Invoice.First(c => c.ID == id);
                    if (txtNewDate.Text != string.Empty)
                    {
                        client.Date = txtNewDate.Text;
                    }
                    if (txtNewName.Text != string.Empty)
                    {
                        client.Client = txtNewName.Text;
                    }
                    if (txtNewMoney.Text != string.Empty)
                    {
                        client.Money = Convert.ToDouble(txtNewMoney.Text);
                    }
                    AccountingDB.SaveChanges();
                    MessageBox.Show(string.Format("Данные о пользователе с ID {0} обновлены успешоно!!!", txtID.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "\r\n");
                }
            }
            else if (txtID.Text != string.Empty && txtOldName.Text != string.Empty)
            {
                try
                {
                    int id = Convert.ToInt32(txtID.Text);
                    Invoice client = AccountingDB.Invoice.First(c => c.ID == id);
                    if (txtNewDate.Text != string.Empty)
                    {
                        client.Date = txtNewDate.Text;
                    }
                    if (txtNewName.Text != string.Empty)
                    {
                        client.Client = txtNewName.Text;
                    }
                    if (txtNewMoney.Text != string.Empty)
                    {
                        client.Money = Convert.ToDouble(txtNewMoney.Text);
                    }
                    AccountingDB.SaveChanges();
                    MessageBox.Show(string.Format("Данные о пользователе {0} обновлены успешоно!!!", txtOldName.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "\r\n");
                }
            }
            else
            {
                MessageBox.Show("Введите имя или ID пользователя!!!");
            }
        }
    }
}
