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

namespace menu_app
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        handler h = new handler("Data.txt");
       
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void Button_input_Click(object sender, RoutedEventArgs e)
        {
            string l = login.Text;
            string pass = password.Password;
           if (h.Check(l, pass) != null)
            {
                Sign sign = new Sign(h.Check(l, pass));
                sign.Show();
            }


        }
    }
}
