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
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace bank
{
    public partial class Form1 : Form
    {
        private List<BankAccount> bankAccounts;
        private List<Owner> owners;
        private int currentIndex = -1;
        private Timer timer;

        public Form1()
        {
            bankAccounts = new List<BankAccount>();
            owners = new List<Owner>();
            InitializeComponent();
            textBox_Information.ReadOnly = true;

            timer = new Timer { Interval = 1000 };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel4.Text = DateTime.Now.ToLongTimeString();
        }

        private void UpdateStatus(string message)
        {
            toolStripStatusLabel2.Text = message;
            toolStripStatusLabel1.Text = $"Всего счетов: {bankAccounts.Count}";
        }

        private List<BankAccount> searchResults = new List<BankAccount>();
        private void ShowSearchResults(List<BankAccount> results)
        {
            searchResults = results; 

            if (results.Count == 0)
            {
                MessageBox.Show("Результаты не найдены!", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string message = string.Join("\n", results.Select(a =>
                $"Счет: {a.Number}, Владелец: {a.owner.Name}, Баланс: {a.balance} руб. \n"));
            MessageBox.Show(message, "Результаты поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateSearchResults(results);
        }
        private void UpdateSearchResults(List<BankAccount> foundAccounts)
        {
            listBox_accounts.Items.Clear();

            foreach (var acc in foundAccounts)
            {
                listBox_accounts.Items.Add($"{acc.Number} - {acc.owner.Name} - {acc.owner.passport:C}");
            }
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
                listBox_accounts.Items.Add($"{account.Number} - {account.owner.Name} ({account.owner.passport}) {account.balance} руб. {account.OpenTime.ToShortDateString()}");
            }
        }

        private void SaveToJson()
        {
            try
            {
                string json = JsonConvert.SerializeObject(bankAccounts, Formatting.Indented);
                File.WriteAllText("bank.json", json);
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

        private void UpdateUserInfo()
        {
            if (currentIndex >= 0 && currentIndex < bankAccounts.Count)
            {
                listBox_accounts.SelectedIndex = currentIndex;
                var account = bankAccounts[currentIndex];

                string output = $"--------Информация о счете--------\r\n" +
                                $"Номер счета: {account.Number}\r\n" +
                                $"Тип вклада: {account.DepositType}\r\n" +
                                $"Баланс: {account.balance:F2} руб.\r\n" +
                                $"Дата открытия: {account.OpenTime:dd.MM.yyyy}\r\n" +
                                $"\r\n--------Информация о владельце--------\r\n" +
                                $"ФИО владельца: {account.owner.Name}\r\n" +
                                $"Дата рождения: {account.owner.birthDay:dd.MM.yyyy}\r\n" +
                                $"Паспорт: {account.owner.passport}\r\n" +
                                $"\r\n--------Дополнительные услуги--------\r\n" +
                                $"СМС-уведомления: {(account.smsNotific ? "Да" : "Нет")}\r\n" +
                                $"Интернет-банк: {(account.internetBank ? "Да" : "Нет")}\r\n";

                textBox_Information.Text = output;


                foreach (var item in account.transactions)
                {
                    dataGridView1.Rows.Add(item.type, item.Amount, item.Date);
                }
            }
        }
        private void listBox_accounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_accounts.SelectedIndex != -1)
            {
                currentIndex = listBox_accounts.SelectedIndex;
                UpdateUserInfo();
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            ClearInformation();
            Form2 form2 = new Form2(bankAccounts, owners);
            form2.ShowDialog();
            UpdateStatus("Добавлен новый банковский счет.");
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
                UpdateStatus("Операция добавлена.");
            }
            else
            {
                UpdateStatus("Ошибка: не выбран счет для транзакции.");
                MessageBox.Show("Выберите номер счета,для которого вы хотите добавить транзакцию!", "Важно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            if(listBox_accounts.SelectedIndex >= 0)
            {
                ClearInformation();
                UpdateStatus("Иноформация о пользователе");

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
                    UpdateStatus("Счет не найден");
                    MessageBox.Show("Ошибка! Счет не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                UpdateStatus("Не выбран пользователь");
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
                UpdateStatus("Аккаунт удален");
            }
            else
            {
                UpdateStatus("Не выбран аккаунт для удаления");
                MessageBox.Show("Выберите счет, который вы хотите удалить!", "Важно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            ClearInformation();
            SaveToJson(); 
            UpdateStatus("Данные сохранены в файл.");
        }

        private void btnDownloud_Click(object sender, EventArgs e)
        {
            ClearInformation();
            LoadFromJson();
            UpdateStatus("Данные загружены из файла.");
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
                    UpdateStatus("Рассчитан бюджет");
                }
                else
                {
                    MessageBox.Show("Ошибка! Счет не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                UpdateStatus("Не выбран счет");
                MessageBox.Show("Выберите счет для расчета бюджета!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Поиск ---Панель меню----------------------------------------------------------

        //Номер счета
        private void поНомеруСчетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Введите номер счета:", "Поиск по номеру", "");

            if (!Regex.IsMatch(input, @"^\d{4}-\d{4}-\d{4}$"))
            {
                MessageBox.Show("Ошибка! Номер счета введен неверно. Используйте формат 1111-1111-1111.",
                                "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var results = bankAccounts.Where(a => a.Number == input).ToList();
            ShowSearchResults(results);
            UpdateStatus("Поиск по номеру счета");
        }

        //ФИО
        private void поВладельцуФИОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Введите ФИО владельца:", "Поиск по владельцу", "");

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Введите корректное ФИО!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] parts = input.Split(' ');

            if (parts.Length <2 || parts.Length > 3)
            {
                MessageBox.Show("Ошибка! Введите Фамилию Имя Отчество(если оно есть)",
                "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string surname = parts[0];
            string name = parts[1];
            string patronymic = parts.Length == 3 ? parts[2] : "";

            if(!Regex.IsMatch(surname, @"^[А-Яа-я]+(-[А-Яа-я]+)?$"))
            {
                MessageBox.Show("Ошибка в фамилии!",
                "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(name, @"^[А-Яа-я]+(-[А-Яа-я]+)?$"))
            {
                MessageBox.Show("Ошибка в имени!",
                                "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(patronymic) && !Regex.IsMatch(patronymic, @"^[А-Яа-я]+(-[А-Яа-я]+)?$"))
            {
                MessageBox.Show("Ошибка в отчестве!",
                                "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fullName = $"{surname} {name} {patronymic}".Trim();

            var results = bankAccounts.Where(a => a.owner.Name.Contains(input)).ToList();
            ShowSearchResults(results);
            UpdateStatus("Поиск по ФИО");
        }

        //Номер паспорта
        private void поРегулярномуВыражениюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pattern = Microsoft.VisualBasic.Interaction.InputBox(
                   "Введите регулярное выражение для поиска паспорта:",
                   "Поиск по номеру паспорта",
                   "^[A-Z]{2}\\d{7}$"); 

            if (string.IsNullOrWhiteSpace(pattern))
            {
                MessageBox.Show("Введите корректное регулярное выражение!",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var results = bankAccounts
                    .Where(a => Regex.IsMatch(a.owner.passport, pattern, RegexOptions.IgnoreCase))
                    .ToList();

                if (results.Count == 0)
                {
                    MessageBox.Show("Совпадений не найдено!", "Результаты поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ShowSearchResults(results);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Некорректное регулярное выражение!",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateStatus("Поиск по паспорту");
        }

        //Расширеный поиск
        private void расширенныйПоискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearch searchForm = new FormSearch(bankAccounts, this);
            searchForm.Show(); 
        }
        public void SetSearchResults(List<BankAccount> foundAccounts)
        {
            listBox_accounts.Items.Clear();
            foreach (var acc in foundAccounts)
            {
                listBox_accounts.Items.Add($"{acc.Number} - {acc.owner.Name} - {acc.balance:C}");
            }
            UpdateStatus("Еще какой-то поиск");
        }
        

        //Сортировка-------------------------------------------------------------------
        //Баланс
        private void поБалансуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bankAccounts == null || bankAccounts.Count == 0)
            {
                MessageBox.Show("Нет счетов для сортировки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bankAccounts = bankAccounts.OrderBy(a => a.balance).ToList();

            UpdLabel();
            UpdateStatus("Сортировка по балансу");
        }

        //Дата открытия
        private void поДатеОткрытияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bankAccounts == null || bankAccounts.Count == 0)
            {
                MessageBox.Show("Нет счетов для сортировки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bankAccounts = bankAccounts.OrderByDescending(a => a.OpenTime).ToList();

            UpdLabel();
            UpdateStatus("Сортировка по дате создания");
        }

        //Сохранить поиск------
        private void сохранитьПоискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (searchResults == null || searchResults.Count == 0)
            {
                MessageBox.Show("Нет результатов поиска для сохранения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string json = JsonConvert.SerializeObject(searchResults, Formatting.Indented);
                File.WriteAllText("search_results.json", json);
                MessageBox.Show("Результаты поиска сохранены!");
                UpdateStatus("Данные сохранены в файл.");
            }
            catch (Exception ex)
            {
                UpdateStatus("Ошибка");
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }
         
        //Созранить сортировку--------
        private void сохранитьСортировкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_accounts.Items.Count == 0)
            {
                MessageBox.Show("Нет данных для сохранения сортировки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string json = JsonConvert.SerializeObject(bankAccounts, Formatting.Indented);
                File.WriteAllText("sorted_accounts.json", json);
                UpdateStatus("Данные сохранены в файл.");
                MessageBox.Show("Результаты сортировки сохранены!");
            }
            catch (Exception ex)
            {
                UpdateStatus("Ошибка");
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        //о Программе---------
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStatus("О программе");
            MessageBox.Show("Что-то похожее на банк. Бабич Виолетта Станиславовна :)",
                              "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //МЕНЮ-------------------------------------------------------------------------------
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //ПОИСК-----------
        private void поНомеруПоспортуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pattern = Microsoft.VisualBasic.Interaction.InputBox(
                   "Введите регулярное выражение для поиска паспорта:",
                   "Поиск по номеру паспорта",
                   "^[A-Z]{2}\\d{7}$");

            if (string.IsNullOrWhiteSpace(pattern))
            {
                MessageBox.Show("Введите корректное регулярное выражение!",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var results = bankAccounts
                    .Where(a => Regex.IsMatch(a.owner.passport, pattern, RegexOptions.IgnoreCase))
                    .ToList();

                if (results.Count == 0)
                {
                    MessageBox.Show("Совпадений не найдено!", "Результаты поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ShowSearchResults(results);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Некорректное регулярное выражение!",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateStatus("Поиск по паспорту");
        }

        private void поискПоФИОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Введите ФИО владельца:", "Поиск по владельцу", "");

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Введите корректное ФИО!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] parts = input.Split(' ');

            if (parts.Length < 2 || parts.Length > 3)
            {
                MessageBox.Show("Ошибка! Введите Фамилию Имя Отчество(если оно есть)",
                "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string surname = parts[0];
            string name = parts[1];
            string patronymic = parts.Length == 3 ? parts[2] : "";

            if (!Regex.IsMatch(surname, @"^[А-Яа-я]+(-[А-Яа-я]+)?$"))
            {
                MessageBox.Show("Ошибка в фамилии!",
                "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(name, @"^[А-Яа-я]+(-[А-Яа-я]+)?$"))
            {
                MessageBox.Show("Ошибка в имени!",
                                "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(patronymic) && !Regex.IsMatch(patronymic, @"^[А-Яа-я]+(-[А-Яа-я]+)?$"))
            {
                MessageBox.Show("Ошибка в отчестве!",
                                "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fullName = $"{surname} {name} {patronymic}".Trim();

            var results = bankAccounts.Where(a => a.owner.Name.Contains(input)).ToList();
            ShowSearchResults(results);
            UpdateStatus("Поиск по ФИО");
        }

        private void расширенныйПоискToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSearch searchForm = new FormSearch(bankAccounts, this);
            searchForm.Show();
        }

        //СОРТИРОВКА--------
        private void поБалансуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (bankAccounts == null || bankAccounts.Count == 0)
            {
                MessageBox.Show("Нет счетов для сортировки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bankAccounts = bankAccounts.OrderBy(a => a.balance).ToList();

            UpdLabel();
            UpdateStatus("Сортировка по балансу");
        }

        private void поДатеОткрытияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (bankAccounts == null || bankAccounts.Count == 0)
            {
                MessageBox.Show("Нет счетов для сортировки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bankAccounts = bankAccounts.OrderByDescending(a => a.OpenTime).ToList();

            UpdLabel();
            UpdateStatus("Сортировка по дате создания");
        }

        //ОСИЧТИТЬ----------
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ClearInformation();
            UpdateStatus("Отичстка");
            toolStripStatusLabel1.Text = $"Всего счетов: 0";

            listBox_accounts.Items.Clear();
        }

        //УДАЛИТЬ-----------
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ClearInformation();

            if (listBox_accounts.SelectedIndex >= 0)
            {
                bankAccounts.RemoveAt(listBox_accounts.SelectedIndex);
                listBox_accounts.Items.RemoveAt(listBox_accounts.SelectedIndex);
                UpdateStatus("Аккаунт удален");
            }
            else
            {
                UpdateStatus("Не выбран аккаунт для удаления");
                MessageBox.Show("Выберите счет, который вы хотите удалить!", "Важно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //ВПЕРЕД
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (currentIndex < bankAccounts.Count - 1)
            {
                currentIndex++;
                UpdateUserInfo();
            }
            else
            {
                MessageBox.Show("Конец.");
            }
        }

        //НАЗАД------------
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                UpdateUserInfo();
               
            }
            else
            {
                MessageBox.Show("Начало.");
            }
        }

        private void ShowMainForm()
        {
            if (!this.Visible)
            {
                this.Show(); 
            }
        }

        //ОТОТБРАЗИТЬ---------------------
        private void скрытьОтобразитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        //ЗАКРЕПИТЬ-------------------------
        private void сверхуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Dock = DockStyle.Top;
        }

        private void слеваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Dock = DockStyle.Left;
        }

        private void справаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Dock = DockStyle.Right;
        }

        private void снизуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Dock = DockStyle.Bottom;
        }
    }
}
