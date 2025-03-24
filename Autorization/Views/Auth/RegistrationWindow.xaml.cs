using Autorization.Models;
using Autorization.Repository;
using System.Windows;


namespace Autorization
{
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
            Registration_Button.Click += Registration_Button_Click;
        }

        private void Registration_Button_Click(object sender, RoutedEventArgs e)
        {
            var inputLogin = RegLogin_TextBox.Text;
            var inputPassword = RegPassword_TextBox.Text;
            var inputConfirmPassword = ConfirmPassword_TextBox.Text;
            validationInputRegister(inputLogin, inputPassword, inputConfirmPassword);
            var userRegister = new User(inputLogin, inputPassword, inputConfirmPassword);
            userRegister.IsSingIn = true;
            UserStorage.Add(userRegister);
            MessageBox.Show("Пользователь успешно зарегистрирован");
            Close();
        }

        private void validationInputRegister(string inputLogin, string inputPassword, string inputConfirmPassword)
        {
            if (string.IsNullOrEmpty(inputLogin))
            {
                MessageBox.Show("Логин не может быть пустым");
                return;
            }

            if (string.IsNullOrEmpty(inputPassword))
            {
                MessageBox.Show("Пароль не может быть пустым");
                return;
            }

            if (string.IsNullOrEmpty(inputPassword))
            {
                MessageBox.Show("Поле подтверждения пароля не может быть пустым");
                return;
            }

            if (inputPassword != inputPassword)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
        }

        
    }
}
