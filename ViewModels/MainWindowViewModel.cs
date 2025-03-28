using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace BeautifulWeather.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ICommand HomeCommand { get; }
        public ICommand LocationCommand { get; }
        public ICommand SettingsCommand { get; }
        public ICommand CloseCommand { get; }

        private ViewModelBase selectedContent;

        public ViewModelBase SelectedContent
        {
            get { return selectedContent; }
            set
            {
                selectedContent = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            HomeCommand = new RelayCommand(OpenHomeView, CanOpenHomeView);
            LocationCommand = new RelayCommand(OpenLocationView, CanOpenLocationView);
            SettingsCommand = new RelayCommand(OpenSettingsView, CanOpenSettingsView);
            CloseCommand = new RelayCommand(ApplyCloseCommand, CanApplyCloseCommand);
        }

        private bool CanApplyCloseCommand(object arg)
        {
            return true;
        }

        private bool CanOpenSettingsView(object arg)
        {
            return true;
        }

        private bool CanOpenLocationView(object arg)
        {
            return true;
        }
        private bool CanOpenHomeView(object arg)

        {
            return true;
        }

        private void ApplyCloseCommand(object obj)
        {
            Application.Current.MainWindow.Close();
        }

        private void OpenSettingsView(object obj)
        {
            SelectedContent = new SettingsViewViewModel();
        }

        private void OpenLocationView(object obj)
        {
            SelectedContent = new LocationViewViewModel();
        }

        private void OpenHomeView(object obj)
        {
            SelectedContent = new HomeViewViewModel();
        }
    }
}
