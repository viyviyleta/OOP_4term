using lab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;  
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace bank
{
    public partial class Form2 : Form
    {
        private List<BankAccount> accounts;
        private List<Owner> owners;

        internal Form2(List<BankAccount> accounts, List<Owner> owners)
        {
            InitializeComponent();
            this.accounts = accounts;
            this.owners = owners;
        }

        public class PassportValidationAttribute : ValidationAttribute
        {
            private static readonly string PassportPattern = @"^[A-Z]{2}\d{7}$";

            public PassportValidationAttribute()
            {
                ErrorMessage = "Ошибка в номере паспорта! Формат: две заглавные латинские буквы + 7 цифр.";
            }

            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                if (value is string passportNumber && Regex.IsMatch(passportNumber, PassportPattern))
                {
                    return ValidationResult.Success;
                }
                return new ValidationResult(ErrorMessage);
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Дата рождения не может быть в будущем!",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(textBox_surname.Text, @"^[А-Яа-я]+(-[А-Яа-я]+)?$"))
            {
                MessageBox.Show("Ошибка в фамилии! Введите только русские буквы, допускается один дефис.",
                                "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(textBox_Name.Text, @"^[А-Яа-я]+(-[А-Яа-я]+)?$"))
            {
                MessageBox.Show("Ошибка в имени! Введите только русские буквы, допускается один дефис.",
                                "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_surname.Text) ||
              string.IsNullOrWhiteSpace(textBox_Name.Text) ||
              string.IsNullOrWhiteSpace(textBox_pasportNumber.Text) ||
              string.IsNullOrEmpty(maskedTextBox_accountsNumber.Text) ||
              string.IsNullOrEmpty(textBox_Balance.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены!",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Owner newOwner = new Owner
            {
                Name = textBox_surname.Text + ' ' + textBox_Name.Text + " " + textBox_patronymic.Text,
                birthDay = dateTimePicker1.Value,
                passport = textBox_pasportNumber.Text
            };

            BankAccount newAccount = new BankAccount
            {
                Number = maskedTextBox_accountsNumber.Text,
                DepositType = comboBox_deposits.Text,
                balance = decimal.TryParse(textBox_Balance.Text, out decimal balanceResult) ? balanceResult : -1,
                OpenTime = DateTime.Now,
                smsNotific = checkBox_SMS.Checked,
                internetBank = checkBox_InternetBank.Checked,
                owner = newOwner
            };

            var contextOwner = new ValidationContext(newOwner);
            var resultsOwner = new List<ValidationResult>();

            if (!Validator.TryValidateObject(newOwner, contextOwner, resultsOwner, true))
            {
                MessageBox.Show(string.Join("\n", resultsOwner.Select(r => r.ErrorMessage)),
                                "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var contextAccount = new ValidationContext(newAccount);
            var resultsAccount = new List<ValidationResult>();

            if (!Validator.TryValidateObject(newAccount, contextAccount, resultsAccount, true))
            {
                MessageBox.Show(string.Join("\n", resultsAccount.Select(r => r.ErrorMessage)),
                                "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SearchNumber(newAccount.Number))
            {
                MessageBox.Show("Данный счет уже существует");
                return;
            }

            owners.Add(newOwner);
            accounts.Add(newAccount);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            textBox_pasportNumber.Clear();
            textBox_Name.Clear();
            textBox_surname.Clear();
            textBox_patronymic.Clear();
            dateTimePicker1.Value = DateTime.Now;
            maskedTextBox_accountsNumber.Clear();
            textBox_Balance.Clear();
            comboBox_deposits.SelectedIndex = -1;
            checkBox_SMS.Checked = false;
            checkBox_InternetBank.Checked = false;
        }

        private bool SearchNumber(string text)
        {
            foreach (var item in accounts)
            {
                if (String.Equals(text, item.Number))
                {
                    return true;
                }
            }
            return false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
