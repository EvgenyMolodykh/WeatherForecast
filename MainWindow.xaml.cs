using BeautifulWeather.Models;
using BeautifulWeather.Storages;
using BeautifulWeather.Views.Auth;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace BeautifulWeather
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserStorage userStorage { get; } = new UserStorage();
        private System.Timers.Timer timer = new System.Timers.Timer();
        public MainWindow()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            InitializeComponent();
            Loaded += MainWindow_Loaded;

            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            var hour = DateTime.Now.Hour;
            LinearGradientBrush gradient;

            if (hour >=6 && hour <= 18)
            {
                gradient = new LinearGradientBrush()
                {
                    GradientStops = new GradientStopCollection
                    {
                        new GradientStop((Color)ColorConverter.ConvertFromString("#FFC371"), 0),
                        new GradientStop((Color)ColorConverter.ConvertFromString("#FF5F60"), 1)
                    }
                };
            }
            else
            {
                gradient = new LinearGradientBrush()
                {
                    GradientStops = new GradientStopCollection
                    {
                        new GradientStop(Colors.Black, 0),
                        new GradientStop(Colors.Blue, 1),
                    }
                };
            }

            Application.Current.Resources["MainWindowBackground"] = gradient;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            CheckUser();
        }

        private void Registration_Button_Click(object sender, RoutedEventArgs e)
        {
            var registration = new RegistrationWindow();
            registration.ShowDialog();
            CheckUser();
        }


        private void SignOut_Button_Click(object sender, RoutedEventArgs e)
        {
            UnAuthorized();
        }

        private void CheckUser()
        {
            var user = userStorage.TryGetSignedInUser();
            if (user != null) Authorized(user);
            else UnAuthorized();
        }

        private void Authorized(User user)
        {
            PersonalDesk_Label.Content = $"Личный кабинет: {user?.Login}";
            PersonalDesk_Label.Visibility = Visibility.Visible;
            SignOut_Button.Visibility = Visibility.Visible;
            SignIn_Button.Visibility = Visibility.Collapsed;
            Registration_Button.Visibility = Visibility.Collapsed;
        }

        private void UnAuthorized()
        {
            userStorage.SignOut();
            PersonalDesk_Label.Visibility = Visibility.Collapsed;
            SignOut_Button.Visibility = Visibility.Collapsed;
            SignIn_Button.Visibility = Visibility.Visible;
            Registration_Button.Visibility = Visibility.Visible;
        }

        private void SignIn_Button_Click(object sender, RoutedEventArgs e)
        {
            var authorization = new AuthorizationWindow();
            authorization.ShowDialog();
            if (!authorization.AuthorizationRememberMe_CheckBox.IsChecked ?? false) UnAuthorized();
            else Authorized(userStorage.TryGetSignedInUser());
        }
    }
}