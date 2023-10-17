using System.Windows;

namespace WPFBank
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool isAdmin = (bool)cbAdmin.IsChecked!;

            if (username != "" && password != "" && isAdmin == false)
            {
                Client client = new(username, password, isAdmin);
                UserManager.People.Add(client);

                MessageBox.Show("Client added! You can now log in.");

                MainWindow mainWindow = new();
                mainWindow.Show();
                Close();

            }
            else if (username != "" && password != "" && isAdmin == true)
            {
                Admin admin = new(username, password, isAdmin);
                UserManager.People.Add(admin);

                MessageBox.Show("Admin added! You can now log in.");

                MainWindow mainWindow = new();
                mainWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Some of the fields are empty");
            }


        }
        public void UpdateUi()
        {

        }

    }
}
