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
using System.Windows.Shapes;
using TestDem.DataBase;

namespace TestDem.Pages
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Employe employe = Singleton.DataBase.Employe.Add(new Employe()
            {
                Login = LogIn.Text,
                Password = Password.Password,
                Name =Name.Text,
                MidName = MidName.Text,
                LastName = LastName.Text,
            });
            Singleton.DataBase.SaveChanges();
            this.Close();
        }
    }
}
