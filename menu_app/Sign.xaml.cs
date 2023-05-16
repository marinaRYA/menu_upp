using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
using System.IO;

namespace menu_app
{
    /// <summary>
    /// Логика взаимодействия для Sign.xaml
    /// </summary>
    public partial class Sign : Window
    {



        public Sign(string path)
        {

            InitializeComponent();
            MenuCreator menu = new MenuCreator(path,this);

           
          

        }
        public void FirstMethod(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вызван метод 'FirstMethod'");
        }

        public  void SecondMethod(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вызван метод 'SecondMethod'");
        }

        public void ThirdMethod(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вызван метод 'ThirdMethod'");
        }



    }
}
