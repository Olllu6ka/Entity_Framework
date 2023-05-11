using _Second.Model;
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

namespace _Second.Views
{
    /// <summary>
    /// Логика взаимодействия для Base.xaml
    /// </summary>
    public partial class Base : Page
    {
        Model1 model1 = new Model1();
        
        public Base()
        {
            InitializeComponent();
        }

        private void Click_ButtonBack(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Click_ButtonExit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
             Users users = new Users()
             {
                Id = 1,
                Name = "Vlad",
                LastName = "Dv",
                Age = 1
            };
            model1.MyEntities.Add(users);
            UsersGrid.ItemsSource = model1.MyEntities.Local.ToList();
        }
        
    }
}
