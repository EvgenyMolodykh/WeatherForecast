using Autorization.Models;
using Autorization.Repository;
using System.Windows;

namespace Autorization
{
    public partial class SingInWindow : Window
    {
        public SingInWindow()
        {
            InitializeComponent();
            SingIn_Button.Click += SingIn_Button_Click;
        }

        private void SingIn_Button_Click(object sender, RoutedEventArgs e)
        {
            ValidationInput();
            var login = RegLogin_TextBox.Text;
            var password = RegPassword_TextBox.Text;
            var rememberMe = RememberMe_Chebox.IsChecked;

            var singInUser = UserStorage.GetSingInUser();
            if (singInUser != null)
            {
                MessageBox.Show("Пользователь уже авторизован");
                return;
            }

            var users = FileProvider.Load<List<User>>(UserStorage.fileName) ?? new List<User>();
            var existingUser = users.FirstOrDefault(u => u.Login == login);
            if (existingUser == null)
            {
                MessageBox.Show("Пользователь не найден");
                return;
            }
            if (existingUser != null)
            {
                if (existingUser.Password == password)
                {
                    existingUser.IsSingIn = true;
                    FileProvider.Save(users, UserStorage.fileName);
                    MessageBox.Show("Вы успешно авторизовались");
                    Close();
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                    return;
                }
            }
        }

        private void ValidationInput()
        {
            if (string.IsNullOrEmpty(RegLogin_TextBox.Text) && string.IsNullOrEmpty(RegPassword_TextBox.Text))
            {
                MessageBox.Show("Заполните поля входа");
                return;
            }
        }
    }
}
