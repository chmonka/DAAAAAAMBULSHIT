using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestDem.DataBase;
namespace TestDem.Pages
{
    /// <summary>
    /// Логика взаимодействия для EmployeEditPage.xaml
    /// </summary>
    public partial class EmployeEditPage : Page
    {
        public EmployeEditPage(Employe EmployeSelect)
        {
            InitializeComponent();
            EmployeEditData.DataContext = EmployeSelect;
            ComBoxRole.ItemsSource = Singleton.DataBase.Role.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Singleton.DataBase.SaveChanges();
            MainWindow window = MainWindow.GetWindow(this) as MainWindow;
            window.Frame.Navigate(new EmployePage());
        }
    }
}
