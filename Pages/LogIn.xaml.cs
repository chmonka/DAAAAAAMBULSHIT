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
    /// Логика взаимодействия для LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Employe employe = Singleton.DataBase.Employe.FirstOrDefault(u => u.Login == Login.Text && u.Password == Password.Password);
            Context.CurrentUser.employe = employe;
            if(employe == null )
            {
                MessageBox.Show("Иди нахуй со своим демом");
                return;
            }

            if (employe.Role?.RoleName == "Admin")
            {
                MainWindow login = MainWindow.GetWindow(this) as MainWindow;
                login.Frame.Navigate(new View());
            }
            else
            {
                MessageBox.Show("У вас нет роли");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
        }
    }
}
