   M S B A M L   `   `   `  ����B  >TestDem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TestDem.PagesTestDem.Pages  5          TestDem.Pages.View   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:TestDem.Pages     5        N� 
Background
  ����� N� Title$
 View��5
      .��5      � .+�5   
   �� .+�5   
   �� $��Center=�6   $
��Left=�60    �� Orientation$ 
Horizontal=�6K   .+�5      �� -   5        $	��100��5      $��20��6%   .��6F   
Назад6M   �� 5      $	��100��6   $��20��6%   .��61   Изменить6;   �� 5      -   5        $	��100��5      $��20��6%   .��6H   Сотрудники6T   5      �� 5   
   $��Bottom=�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ RequestData��5      $	��400��6,      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер заявки��6G   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *	RequestID+6G     5      $ Дата��6B    6)   �� *Date+6B     5      $ Оборудование��6G    6)   �� *	Equipment+6G     5      $ Тип проблемы��6I    6)   �� *TypeProblem+6I     5      $ Проблема��6E    6)   �� *	Problem+6E     5      $ Статус заявки��6K    6)   �� *StatusRequest+6K     5      $ Имя��6H    6)   �� *
ClientName+6H     5      $ Фамилия��6K    6)   �� *ClientMidName+6K     5      $ Отчество��6F    6)   �� *
LastName+6F   5!      5"      5#      5$      5%      