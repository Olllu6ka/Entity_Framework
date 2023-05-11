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

namespace Entity_Framework
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FirstEntities first = new FirstEntities();
        
        private int Button { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button = 1;
            foreach (var item in first.Table)
            {
                Label1.Content = item.Id + item.Name + item.LastName + item.Age;
            }
        }

        private void Users_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            
        }
    }
}
