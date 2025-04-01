using lab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace bank
{
    public partial class Form1 : Form
    {
        private List<BankAccount> bankAccounts;
        private List<Owner> owners;
        public Form1()
        {
            bankAccounts = new List<BankAccount>();
            owners = new List<Owner>();
            InitializeComponent();
            textBox_Information.ReadOnly = true;
        }

        private void ClearInformation()
        {
            textBox_Information.Clear();
            dataGridView1.Rows.Clear();
        }

        private void UpdLabel()
        {
            listBox_accounts.Items.Clear();
            foreach (var account in bankAccounts)
            {
                listBox_accounts.Items.Add($"{account.Number} - {account.owner.Name} ({account.owner.passport})");
            }
        }

        private void SaveToJson()
        {
            try
            {
                string json = JsonConvert.SerializeObject(bankAccounts, Formatting.Indented);
                File.WriteAllText("bank.json", json);
                MessageBox.Show("Данные сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        private void LoadFromJson()
        {
            try
            {
                if (File.Exists("bank.json"))
                {
                    string json = File.ReadAllText("bank.json");
                    bankAccounts = JsonConvert.DeserializeObject<List<BankAccount>>(json) ?? new List<BankAccount>();
                    UpdLabel();
                    MessageBox.Show("Данные загружены!");
                }
                else
                {
                    MessageBox.Show("Файл не найден!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message);
            }
        }


        private void listBox_accounts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            ClearInformation();
            Form2 form2 = new Form2(bankAccounts, owners);
            form2.ShowDialog();
            UpdLabel();
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            ClearInformation();
            if (listBox_accounts.SelectedIndex >= 0)
            {
                Form3 form4 = new Form3(this.bankAccounts[listBox_accounts.SelectedIndex]);
                form4.ShowDialog();
                UpdLabel();
            }
            else
            {
                MessageBox.Show("Выберите номер счета,для которого вы хотите добавить транзакцию!", "Важно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            if(listBox_accounts.SelectedIndex >= 0)
            {
                ClearInformation();

                BankAccount selectedAccount = bankAccounts[listBox_accounts.SelectedIndex];

                if(selectedAccount != null)
                {
                    string output = $"--------Информация о счете--------\r\n" +
                                    $"Номер счета: {selectedAccount.Number}\r\n" +
                                    $"Тип вклада: {selectedAccount.DepositType}\r\n" +
                                    $"Баланс: {selectedAccount.balance:F2} руб.\r\n" +
                                    $"Дата открытия: {selectedAccount.OpenTime:dd.MM.yyyy}\r\n" +
                                    $"\r\n--------Информация о владельце--------\r\n" +
                                    $"ФИО владельца: {selectedAccount.owner.Name}\r\n" +
                                    $"Дата рождения: {selectedAccount.owner.birthDay:dd.MM.yyyy}\r\n" +
                                    $"Паспорт: {selectedAccount.owner.passport}\r\n" +
                                    $"\r\n--------Дополнительные услуги--------\r\n" +
                                    $"СМС-уведомления: {(selectedAccount.smsNotific ? "Да" : "Нет")}\r\n" +
                                    $"Интернет-банк: {(selectedAccount.internetBank ? "Да" : "Нет")}\r\n";

                    textBox_Information.Text = output;
                    

                    foreach (var item in selectedAccount.transactions)
                    {
                        dataGridView1.Rows.Add(item.type, item.Amount, item.Date);
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка! Счет не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Выберите счет для отображения информации!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClearInformation();

            if (listBox_accounts.SelectedIndex >= 0)
            {
                bankAccounts.RemoveAt(listBox_accounts.SelectedIndex);
                listBox_accounts.Items.RemoveAt(listBox_accounts.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Выберите счет, который вы хотите удалить!", "Важно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            ClearInformation();
            SaveToJson();
        }

        private void btnDownloud_Click(object sender, EventArgs e)
        {
            ClearInformation();
            LoadFromJson();
        }

        private void btnCalculateBudget_Click(object sender, EventArgs e)
        {
            if (listBox_accounts.SelectedIndex >= 0)
            {
                BankAccount selectedAccount = bankAccounts[listBox_accounts.SelectedIndex];

                if (selectedAccount != null)
                {
                    decimal totalIncome = 0; 
                    decimal totalExpenses = 0; 

                    foreach (var transaction in selectedAccount.transactions)
                    {
                        if (transaction.type == "Пополнение")
                        {
                            totalIncome += transaction.Amount;
                        }
                        else if (transaction.type == "Снятие средств" || transaction.type == "Перевод средств")
                        {
                            totalExpenses += transaction.Amount;
                        }
                    }

                    decimal budget = selectedAccount.balance + totalIncome - totalExpenses;

                    textBox1.Text = budget.ToString("F") + " руб.";
                    textBox1.ForeColor = Color.Black;
                }
                else
                {
                    MessageBox.Show("Ошибка! Счет не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Выберите счет для расчета бюджета!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
