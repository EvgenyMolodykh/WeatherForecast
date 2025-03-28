using BeautifulWeather.Storages;
using System.Windows;

namespace BeautifulWeather.Views.Auth
{
    /// <summary>
    /// Interaction logic for AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        private UserStorage userStorage { get; } = new UserStorage();
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void Enter_Button_Click(object sender, RoutedEventArgs e)
        {
            var inputLogin = AuthorizationLogin_TextBox.Text;
            var inputPassword = AuthorizationPassword_TextBox.Text;

            if (string.IsNullOrEmpty(inputLogin) || string.IsNullOrEmpty(inputPassword)) return;

            if (!userStorage.CheckLogin(inputLogin))
            {
                MessageBox.Show("Пользователь с таким именем не зарегистрирован!");
                return;
            }

            var user = userStorage.TryGetUserByLogin(inputLogin);

            if (!userStorage.CheckPassword(user, inputPassword))
            {
                MessageBox.Show("Введен неверный пароль!");
                return;
            }

            userStorage.SingIn(user);
            MessageBox.Show("Вход выполнен успешно!");
            Close();
        }
    }
}
