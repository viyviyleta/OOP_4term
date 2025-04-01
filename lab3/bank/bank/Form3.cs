using lab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank
{
    public partial class Form3 : Form
    {
        private BankAccount bankAccount;
        internal Form3(BankAccount account)
        {
            this.bankAccount = account;
            InitializeComponent();
            textBox_Balance.Text = bankAccount.balance.ToString("F");
            textBox_Balance.ForeColor = Color.LightGray;
            textBox_Balance.ReadOnly = true;

        }

        private void comboBox_TypeOperation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Sum_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_AddTransaction_Click(object sender, EventArgs e)
        {
            if (comboBox_TypeOperation.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите тип операции!",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBox_Sum.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Введите корректную сумму (положительное число)!",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string operationType = comboBox_TypeOperation.SelectedItem.ToString();
            decimal newBalance = bankAccount.balance;

            if (operationType == "Пополнение")
            {
                newBalance += amount;
            }
            else if (operationType == "Перевод средств" || operationType == "Снятие средств")
            {
                if (amount > bankAccount.balance)
                {
                    MessageBox.Show("Недостаточно средств на счете!",
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                newBalance -= amount;
            }

            bankAccount.balance = newBalance;
            textBox_Balance.Text = newBalance.ToString("F");
            textBox_Balance.ForeColor = Color.Black;

            Transaction newTransaction = new Transaction
            {
                type = this.comboBox_TypeOperation.Text,
                Amount = decimal.Parse(this.textBox_Sum.Text),
                Date = DateTime.Now
            };

            bankAccount.transactions.Add(newTransaction);

            MessageBox.Show("Операция успешно выполнена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox_Balance_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
