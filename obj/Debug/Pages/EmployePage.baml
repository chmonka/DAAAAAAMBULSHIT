   M S B A M L   `   `   `  ����B  >TestDem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TestDem.PagesTestDem.Pages  5          TestDem.Pages.EmployePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:TestDem.Pages     5      -   5          N� Title$  EmployePage��5	       N� 
Background
 �����.��5      � .+�5   
   �� .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��	20 0 20 0q�5      $��
Назад��6(   68   �� 5      -   5        $��Изменить��5      6(   5      �� 5   
   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ EmployeData��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *Name+  5      $ Фамилия��6-    6>   �� *	MidName+  5      $ Отчество��6-    6?   �� *
LastName+  5      $ 
Логин��6-    6<   �� *Login+  5      $ Пароль��6-    6=   �� *
Password+  5      $ Роль��6-    6;   �� *Role.RoleName+5       5!      5"      5#      5$      