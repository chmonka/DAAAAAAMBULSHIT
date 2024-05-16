using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для View.xaml
    /// </summary>
    public partial class View : Page
    {
        public View()
        {
            InitializeComponent();
            RequestData.ItemsSource = Singleton.DataBase.Request.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow backToLogIn = MainWindow.GetWindow(this) as MainWindow;
            backToLogIn.Frame.Navigate(new LogIn());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow goEmployePage = MainWindow.GetWindow(this) as MainWindow;
            goEmployePage.Frame.Navigate(new EmployePage());
        }
    }
}
