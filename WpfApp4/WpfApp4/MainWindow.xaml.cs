using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string ConnectionString = "Server = Localhost; Database=tesztdb;user Id=root;Password=root"; 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using var conn = new MySqlConnection(ConnectionString);
                conn.Open();
                MessageBox.Show("Sikeres kapcsolat");
            }
            catch
            {
                MessageBox.Show("Sikertelen kapcsolat");
            }
        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            using var conn = new MySqlConnection(ConnectionString);
            string querry = "SELECT * from tanulo";
            using var cmd = new MySqlCommand(querry, conn);

            using var adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            
            adapter.Fill(dt);
            dgUsers.ItemsSource = dt.DefaultView;
        }
    }
}