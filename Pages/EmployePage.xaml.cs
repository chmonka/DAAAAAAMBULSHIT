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
    /// Логика взаимодействия для EmployePage.xaml
    /// </summary>
    public partial class EmployePage : Page
    {
        public EmployePage()
        {
            InitializeComponent();
            EmployeData.ItemsSource = Singleton.DataBase.Employe.ToList();
          
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow backToView = MainWindow.GetWindow(this) as MainWindow;
            backToView.Frame.Navigate(new View());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var EmployeSelect = EmployeData.SelectedItem as Employe;
            if(EmployeSelect == null)
            {
                MessageBox.Show("Выберите сотрудника");
            }
            else
            {
                MainWindow goToEmployeEditPage = MainWindow.GetWindow(this) as MainWindow;
                goToEmployeEditPage.Frame.Navigate(new EmployeEditPage(EmployeSelect));
            }
  
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            EmployeData.ItemsSource = Singleton.DataBase.Employe.ToList();
        }
    }
}
