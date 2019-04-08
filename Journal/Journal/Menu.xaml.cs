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
using System.Data.SqlClient;

namespace Journal
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void LogoutClick(object sender, RoutedEventArgs e)
        {
            MainWindow Mwin = new MainWindow();
            Mwin.Show();
            this.Close();
        }

        private void ViewClick(object sender, RoutedEventArgs e)
        {

            View view = new View(); 
            view.Show();
            
            
        }

        private void NewClick(object sender, RoutedEventArgs e)
        {
            New Nent = new New();
            Nent.Show();
        }

        private void EditClick(object sender, RoutedEventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
        }
    }
}
