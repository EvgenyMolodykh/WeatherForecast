using BeautifulWeather.Models;
using BeautifulWeather.Storages;
using System.Windows;

namespace BeautifulWeather.Views.Auth
{
    /// <summary>
    /// Interaction logic for RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private UserStorage userStorage { get; } = new UserStorage();
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void Registration_Button_Click(object sender, RoutedEventArgs e)
        {
            var inputLogin = RegLogin_TextBox.Text;
            var inputPassword = RegPassword_TextBox.Text;
            var confirmPassword = RegConfirm_TextBox.Text;

            if (!inputPassword.Equals(confirmPassword))
            {
                MessageBox.Show("Пароли не совпадают! Проверьте данные ввода!");
                return;
            }

            if (userStorage.TryGetUserByLogin(inputLogin) != null)
            {
                MessageBox.Show("Аккаунт с таким именем уже зарегистрирован!");
                return;
            }

            var registeredUser = new User(inputLogin, inputPassword, true);
            userStorage.Add(registeredUser);

            MessageBox.Show("Аккаунт успешно зарегистрирован!");
            Close();
        }
    }
}
