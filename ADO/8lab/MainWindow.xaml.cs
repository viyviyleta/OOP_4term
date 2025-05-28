using System.Data.SqlClient;
using System.Configuration;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Linq;

namespace _8lab;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private string connectionString;
    private ObservableCollection<Horse> horses;

    public MainWindow()
    {
        InitializeComponent();
        connectionString = ConfigurationManager.ConnectionStrings["HorseDb"].ConnectionString;
        horses = new ObservableCollection<Horse>();
        dgResults.ItemsSource = horses;
        dgResults.SelectionChanged += DgResults_SelectionChanged;
        EnsureDatabaseExists();
    }

    private void EnsureDatabaseExists()
    {
        using (var conn = new SqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                string createTable = @"
                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Horses')
                    BEGIN
                        CREATE TABLE Horses (
                            Id INT IDENTITY(1,1) PRIMARY KEY,
                            Name NVARCHAR(100) NOT NULL,
                            Type NVARCHAR(50) NOT NULL,
                            PhotoPath NVARCHAR(MAX)
                        );
                    END";
                using (var cmd = new SqlCommand(createTable, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании таблицы: " + ex.Message);
            }
        }
    }

    private void LoadHorses()
    {
        horses.Clear();
        using (var conn = new SqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Horses";
                using (var cmd = new SqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            horses.Add(new Horse
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Type = reader.GetString(2),
                                PhotoPath = reader.IsDBNull(3) ? null : reader.GetString(3)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
        }
    }

    private void Create_Click(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(Name_Container.Text) || Type_Container.SelectedItem == null)
        {
            MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
            return;
        }

        using (var conn = new SqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string query = "INSERT INTO Horses (Name, Type, PhotoPath) VALUES (@Name, @Type, @PhotoPath)";
                        using (var cmd = new SqlCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Name", Name_Container.Text);
                            cmd.Parameters.AddWithValue("@Type", ((ComboBoxItem)Type_Container.SelectedItem).Content.ToString());
                            cmd.Parameters.AddWithValue("@PhotoPath", string.IsNullOrWhiteSpace(Photo_Container.Text) ? DBNull.Value : (object)Photo_Container.Text);
                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        LoadHorses();
                        Name_Container.Clear();
                        Type_Container.SelectedIndex = 0;
                        Photo_Container.Clear();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Ошибка при добавлении записи: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
            }
        }
    }

    private void Edit_Click(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(Name_Container.Text) || Type_Container.SelectedItem == null)
        {
            MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
            return;
        }

        using (var conn = new SqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string query = "UPDATE Horses SET Name = @Name, Type = @Type, PhotoPath = @PhotoPath WHERE Id = @Id";
                        using (var cmd = new SqlCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Name", Name_Container.Text);
                            cmd.Parameters.AddWithValue("@Type", ((ComboBoxItem)Type_Container.SelectedItem).Content.ToString());
                            cmd.Parameters.AddWithValue("@PhotoPath", string.IsNullOrWhiteSpace(Photo_Container.Text) ? DBNull.Value : (object)Photo_Container.Text);
                            cmd.Parameters.AddWithValue("@Id", ((Horse)dgResults.SelectedItem).Id);
                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        LoadHorses();
                        Name_Container.Clear();
                        Type_Container.SelectedIndex = 0;
                        Photo_Container.Clear();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Ошибка при изменении записи: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
            }
        }
    }

    private void Delete_Click(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NumToDelete.Text))
        {
            MessageBox.Show("Пожалуйста, введите имя для удаления.");
            return;
        }

        using (var conn = new SqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string query = "DELETE FROM Horses WHERE Name = @Name";
                        using (var cmd = new SqlCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@Name", NumToDelete.Text);
                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        LoadHorses();
                        NumToDelete.Clear();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Ошибка при удалении записи: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
            }
        }
    }

    private void Show_all_Horse_Click(object sender, RoutedEventArgs e)
    {
        horses.Clear();
        using (var conn = new SqlConnection(connectionString))
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Horses WHERE Type = 'лошадь'";
                using (var cmd = new SqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            horses.Add(new Horse
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Type = reader.GetString(2),
                                PhotoPath = reader.IsDBNull(3) ? null : reader.GetString(3)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
        }
    }

    private void SortByNum_Click(object sender, RoutedEventArgs e)
    {
        var sortedHorses = new ObservableCollection<Horse>(horses.OrderBy(h => h.Name));
        horses.Clear();
        foreach (var horse in sortedHorses)
        {
            horses.Add(horse);
        }
    }

    private void Show_all_Click(object sender, RoutedEventArgs e)
    {
        LoadHorses();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        LoadHorses();
    }

    private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {
        
    }

    private void DgResults_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (dgResults.SelectedItem is Horse selectedHorse)
        {
            Name_Container.Text = selectedHorse.Name;
            Type_Container.SelectedItem = Type_Container.Items.Cast<ComboBoxItem>().FirstOrDefault(item => item.Content.ToString() == selectedHorse.Type);
            Photo_Container.Text = selectedHorse.PhotoPath ?? string.Empty;
        }
    }

    private void Name_Container_PreviewTextInput(object sender, TextCompositionEventArgs e)
    {
       
    }

    private void Photo_Container_PreviewTextInput(object sender, TextCompositionEventArgs e)
    {
        
    }

    private void NumToDelete_PreviewTextInput(object sender, TextCompositionEventArgs e)
    {
        
    }
}