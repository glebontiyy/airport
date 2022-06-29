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

namespace airport
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowAdminPanel(object sender, RoutedEventArgs e)
        {
            frames.AdminPanel AdminPanel = new frames.AdminPanel();
            AdminPanel.Show();
        }

        private void ShowUserWindow(object sender, RoutedEventArgs e)
        {
            frames.UserWindow userWindow = new frames.UserWindow();
            userWindow.Show();
        }
    }
}
