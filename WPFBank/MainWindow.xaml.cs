using System.Windows;

namespace WPFBank
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            //User user = new();
            //user.Username = People


            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new();
            registerWindow.Show();
            Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;

            foreach (User user in UserManager.People)
            {

                if (user.Username == userName && user.Password == passWord)
                {
                    MessageBox.Show("Login successfull!");
                    AccountsWindow accountsWindow = new();
                    accountsWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("User Does not exist, Try Again!");
                }
            }
        }






        //private void UpdateUi()
        //{
        //    // Rensa listan
        //    //lstEmployees.Items.Clear();

        //    // Hämta alla amployees i "databasen"
        //    List<User> users = UserManager.People;

        //    // Toggla Show Details och Remove - knappen beroende på om vi har personer i databasen
        //    //if (people.Count > 0)
        //    //{
        //    //    btnShowDetails.IsEnabled = true;
        //    //    btnRemove.IsEnabled = true;
        //    //}
        //    //else
        //    //{
        //    //    btnShowDetails.IsEnabled = false;
        //    //    btnRemove.IsEnabled = false;
        //    //}

        //    // Lägg till varje employee från databasen i listan
        //    foreach (User user in users)
        //    {
        //        ListViewItem item = new();

        //        item.Content = user.Username + user.Password;

        //        if (person.GetType() == typeof(Employee))
        //        {
        //            item.Content += " | ";

        //            Employee employee = (Employee)person;

        //            item.Content += employee.Department.ToString();
        //            item.Tag = employee;

        //        }
        //        else
        //        {
        //            item.Content += " | Customer";

        //            item.Tag = person;
        //        }

        //        lstEmployees.Items.Add(item);
        //    }

        //    // Rensa alla inputs
        //    txtFirstName.Text = "";
        //    txtLastName.Text = "";
        //    txtAge.Text = "";
        //    txtBio.Text = "";
        //    txtSalary.Text = "";
        //    cbDepartments.SelectedIndex = -1;


        //}
    }
}
