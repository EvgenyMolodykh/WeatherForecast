   M S B A M L   `   `   `  ����K  GBeautifulWeather, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:BeautifulWeather.Views.AuthBeautifulWeather.Views.Auth  5   	   5    /BeautifulWeather.Views.Auth.AuthorizationWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:BeautifulWeather.Views.Auth     5   	     � Title$5  /Авторизация пользователя��5   	   $	��300��6*   $	��350��67    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      �  � RowDefinitions 5   
   �� 5      $
��1.5* �6   �� 5      $��2* �6   �� 5      �� 5      .+�5   
   �� $��0��5      $��Вход��5      $��Center=�5      $��Center=�5      $��20(�5      � 5   
   $��1��6    5      �� 5      �� 5       � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      .+�5       �� $��
Логин��5!      $��Center=�5"      $
��Left=�5#      $��10q�5$      �� 5%      -   5         ��Name$  AuthorizationLogin_TextBox��5&      $��1��5'      $	��200��5(      $��Right=�5)      $��20(�5*      $��10q�5+      �� 5,      $��1��5-      $��Пароль��5.      $��Center=�5/      $
��Left=�50      $��10q�51      �� 52      -   5        $# AuthorizationPassword_TextBox��53      $��1��54      $��1��55      $	��200��56      $��Right=�57      $��20(�58      $��10q�59      5:      �� 5;   
   -   5         ��Name$&  AuthorizationRememberMe_CheckBox��5<      $��2��5=      $!��Запомнить меня��5>      $��Center=�5?      $
��Left=�5@      $��10q�5A      �� 5B   
   -   5         ��Name$ Enter_Button��5C      $��3��5D      $��
Войти��5E      $��10q�5F      5G      5H      5I      