using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Autorization.ViewModels
{
    public partial class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public ICommand? HomeCommand { get; set; }

        private HomeView homeViewModel;

        public HomeView HomeViewModel
        {
            get { return homeViewModel; }
            set { 
                homeViewModel = value;
                OnPropertyChanged();
            }
        }
        MainWindowViewModel()
        {
            HomeCommand = new RelayCommand(OpenHomeView, CanOpenHomeView);
            
        }

        private bool CanOpenHomeView(object arg)
        {
            return true;
        }

        private void OpenHomeView(object obj)
        {
            HomeViewModel = new HomeView();
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
