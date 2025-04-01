using lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace bank
{
    public partial class FormSearch : Form
    {
        private List<BankAccount> accounts;
        private Form1 mainForm;

        public FormSearch(List<BankAccount> accounts, Form1 mainForm)
        {
            InitializeComponent();
            this.accounts = accounts;
            this.mainForm = mainForm;
        }

        private void but_Click(object sender, EventArgs e)
        {
            string depositType = textBox_Sur.Text.Trim(); 
            string balanceText = textBox_Namel.Text.Trim(); 

            if (string.IsNullOrWhiteSpace(depositType) && string.IsNullOrWhiteSpace(balanceText))
            {
                MessageBox.Show("Введите хотя бы одно значение для поиска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal balance;
            bool isBalanceValid = decimal.TryParse(balanceText, out balance);

            if (!string.IsNullOrWhiteSpace(balanceText) && (!isBalanceValid || balance <= 0))
            {
                MessageBox.Show("Ошибка! Баланс должен быть положительным числом.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var results = accounts.Where(a =>
                (string.IsNullOrWhiteSpace(depositType) || a.DepositType.Equals(depositType, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrWhiteSpace(balanceText) || (isBalanceValid && a.balance == balance))
            ).ToList();

            if (results.Count == 0)
            {
                MessageBox.Show("Ничего не найдено.", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            mainForm.SetSearchResults(results);

            this.Close();
        }
    }
}
