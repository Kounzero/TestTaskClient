   M S B A M L   `   `   `  ����J  FEmployeesClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:EmployeesClient.WindowsEmployeesClient.Windows  5   	   3    -EmployeesClient.Windows.AddEditEmployeeWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:EmployeesClient.Windows     5   	     � Title$  AddEditEmployeeWindow��5   	   $	��450��5	   	   $	��400��5
   	   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��ФИО:��6   $��Center=�5      $��Right=�5      $��5q�5      $��0��5      �� 5   
   $ ��Дата рождения:��6   $��Center=�5       $��Right=�5!      $��5q�5"      $��1��5#      �� 5$   
   $��Пол:��6   $��Center=�5%      $��Right=�5&      $��5q�5'      $��2��5(      �� 5)   
   $��Должность:��6   $��Center=�5*      $��Right=�5+      $��5q�5,      $��3��5-      �� 5.   
   $*��$Водительские права:��6   $��Center=�5/      $��Right=�50      $��5q�51      $��4��52      �� 53   
   $!��Подразделение:��6   $��Center=�54      $��Right=�55      $��5q�56      $��5��57      �� 59   
   -   5         ��Name$ FullNameTextBox��59      $��1��5:      $��5q�5;      $��Center=�5<      ��5=      �� *
FullName+(  "System.Windows.Controls.DatePicker  5>   
   -   5          Name$ BirthDatePicker��5>      $��1��5?      $��1��5@      $��Center=�5A      $��5q�5B         SelectedDate 5C      �� *	BirthDate+�� 5D   
   -   5         ��Name$ GendersCombobox��5D      $��1��5E      $��2��5F      $��5q�5G      $��Center=�5H       �� SelectedValuePath$ id��5J       �� DisplayMemberPath$ title��5K      	 �� SelectedValue	 5I      �� *
GenderID+5K      �� 5L   
   -   5        $ PositionsCombobox��5L      $��1��5M      $��3��5N      $��5q�5O      $��Center=�5P      $ id��5R      $ title��5S      	 5Q      �� *
PositionID+5S      �� 5T   
   -   5        
 ��Name$
 HasDrivindLicenseCheckBox��5T      $��Center=�5U      $��1��5W      $��4��5X      $��5q�5Y       d� 	IsChecked 5V      �� *HasDrivingLicense+5Y      �� 5Z   
   -   5        $ SubdivisionsCombobox��5Z      $��1��5[      $��5��5\      $��5q�5]      $��Center=�5^      $ id��5`      $ title��5a      	 5_      �� *SubdivisionID+5a      �� 5c   
   -   5         ��Name$ BtnOk��5c      $��Сохранить��5d      $��1��5f      $��6��5g      $��5q�5h      $��Center=�5i      �� 5j   
   -   5        $ 	BtnCancel��5j      $��Отмена��5k      $��6��5m      $��5q�5n      $��Center=�5o      5p      5q      