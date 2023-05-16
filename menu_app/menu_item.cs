using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Xaml.Permissions;

namespace menu_app
{
    public class menu_item
    {
        private string[] lines;
        private Dictionary<int, MenuItem> menuItems;

        public menu_item(string filePath)
        {
            lines = File.ReadAllLines(filePath);
            menuItems = new Dictionary<int, MenuItem>();
        }

        
    }
}
