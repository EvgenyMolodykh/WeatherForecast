   M S B A M L   `   `   `  ����K  GBeautifulWeather, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:BeautifulWeather.Views.HomeBeautifulWeather.Views.Home  5   	   Q-clr-namespace:BeautifulWeather.Views.LocationBeautifulWeather.Views.Location  5   	   Q-clr-namespace:BeautifulWeather.Views.SettingsBeautifulWeather.Views.Settings  5   	   I)clr-namespace:BeautifulWeather.ViewModelsBeautifulWeather.ViewModels  5	   	   3clr-namespace:BeautifulWeatherBeautifulWeather  5
   	   !    BeautifulWeather.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >homeView)clr-namespace:BeautifulWeather.Views.Home     5   	   FlocationView-clr-namespace:BeautifulWeather.Views.Location     5   	   FsettingsView-clr-namespace:BeautifulWeather.Views.Settings     5   	   8vm)clr-namespace:BeautifulWeather.ViewModels     5	   	   0localclr-namespace:BeautifulWeather     5
   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�5   	   $=��7/BeautifulWeather;component/Resources/Fonts/#beer money)�5   	   $��15(�5   	    � 	Resources 5       �� DataType3   -BeautifulWeather.ViewModels.HomeViewViewModel*   $BeautifulWeather.Views.Home.HomeView � DataContext7   1BeautifulWeather.ViewModels.LocationViewViewModel2   ,BeautifulWeather.Views.Location.LocationView7   1BeautifulWeather.ViewModels.SettingsViewViewModel2   ,BeautifulWeather.Views.Settings.SettingsView��%  (��       5      *, +)(�� @     5      *, +)(�� �     5      *, +)�� 5   
   "  6   .R�5         6    �� 5      �� 5   
   "  6   .R�5         6(   �� 5      �� 5   
   "  6   .R�5         6(   �� 5      5       5      5   /BeautifulWeather.ViewModels.MainWindowViewModel  5   
   .��5      �    MainWindowBackground#���   6    � RowDefinitions 5   
   �� 5       �� 5!      �� 5"      $��7* �6    � ColumnDefinitions 5$   
   �� 5%      �� 5&      $��5* �6   .+�5(   
   �� -   5         ��Name$ SynopticDiagnose_Label��5)      $��Center=�5*      $��Center=�5+      $��Synoptic diagnose��5,      �� 5-   
   $��0��5.      $��2��5/      $��Center=�50      $��Center=�51      $��Weather��52      � 53   
   $��1��6    54      �� 55      $��2* �6#   �� 56      .+�58      � $��2��6    59      �� 5:      $
��Auto �6$   �� 5;      $
��Auto �6$    5=      �� 5>      �� 5?      $��2* �6'   .+�5A      �� -   5         ��Name$ SignOut_Button��5B      $��0��5C      $��0��5D      $��40��5E      $��
Выйти��5F      5G      �� 5H      -   5        $ SignIn_Button��5I      $��40��5J      $��0��5K      $��1��5L      $��
Войти��5M      5N      �� 5O      -   5        $ Registration_Button��5P      $��1��5Q      $��1��5R      $��Регистрация��5S      5T      �� 5U      -   5        $ PersonalDesk_Label��5V      $��1��5W      $��0��5X      $��Center=�5Y      $��Center=�5Z      $!��Личный кабинет��5[      5\      5]      � 5^   
   $��1��5_      $��1��5`       5a      �� 5b      �� 5c      .+�5e      �� -   5        $ Refresh_Button��5f      $��0��5g      $��1��5h      $��5q�5i      $��40��5j      $
��Left=�5k      �� 5l      -   5        $  WeatherCurrentPeriod_Label��5m      $��1��5n      $��0��5o      $
��Left=�5p      $��Center=�5q      5r      �� 5s   
   $��2��6   	 �� Orientation$	 Vertical=�6"   .+�5t      �� $
��Home��6     LeftPanelButton#��[ 5u      ��5v      �� 
 �� Path$
 HomeCommand��� 5w      $��Location��6   #��[ 5x      ��5y      �� $
 LocationCommand��� 5z      $��Settings��6   #��[ 5{      ��5|      �� $
 SettingsCommand��� 5}      $��Close��6   #��[ 5~      ��5      �� $
 CloseCommand�5�      � 5�   
   $��1��6   $��3��6   .+�5�      �� ��6   �� *SelectedContent+5�      5�      5�      