using BeautifulWeather.Models;
using BeautifulWeather.Storages;

namespace BeautifulWeather.ViewModels
{
    public class HomeViewViewModel : ViewModelBase
    {
		private List<DayForecastModel> forecastDays;

		public List<DayForecastModel> ForecastDays
		{
			get => forecastDays;
			set 
			{
				forecastDays = value;
				OnPropertyChanged();
			}
		}

        private DayForecastModel selectedDay;

        public DayForecastModel SelectedDay
        {
            get => selectedDay;
            set
            {
                selectedDay = value;
                OnPropertyChanged();
            }
        }

        public HomeViewViewModel()
        {
            ForecastDays = WeatherDataStorage.GetAll();
        }
    }
}
