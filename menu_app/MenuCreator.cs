using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace menu_app
{
    public class MenuCreator
    {
        private string[] Lines;//содержимое файла
        Sign window;
        Menu menu = new Menu();
        

        public MenuCreator(string filePath, Sign window)
        {
            this.window = window;
            Lines = File.ReadAllLines(filePath);
            Build(window);
        }
        private void Build(Sign window)
        {
            MenuItem currentParent = null;

            foreach (string menuItemData in Lines)
            {
                string[] menuItemParts = menuItemData.Split(' ');

                int level = Convert.ToInt32(menuItemParts[0]);
                string header = menuItemParts[1];
                int status = Convert.ToInt32(menuItemParts[2]);
                string methodName = menuItemParts.Length > 3 ? menuItemParts[3] : null;
                MenuItem menuItem = new MenuItem();
                menuItem.Header = header;

                if (status == 1)
                {
                    menuItem.IsEnabled = false;
                }
                else if (status == 2)
                {
                    menuItem.Visibility = Visibility.Collapsed;
                }
                if (!string.IsNullOrEmpty(methodName))
                {
                    if (methodName == "FirstMethod")
                        menuItem.Click += window.FirstMethod;

                    else if (methodName == "SecondMethod")
                        menuItem.Click += window.SecondMethod;

                    else if (methodName == "ThirdMethod")
                        menuItem.Click += window.ThirdMethod;
                }
                if (level == 0)
                {
                    menu.Items.Add(menuItem);
                    currentParent = menuItem;
                }
                else if (level > 0 && currentParent != null)
                {
                    if (currentParent.Items.Count > 0)
                    {
                        MenuItem lastChild = currentParent.Items[currentParent.Items.Count - 1] as MenuItem;
                        if (lastChild != null && lastChild.Header is Separator)
                        {
                            currentParent.Items.RemoveAt(currentParent.Items.Count - 1);
                        }
                    }

                    currentParent.Items.Add(menuItem);

                    if (level == 1)
                    {
                        currentParent = menuItem;
                    }
                }
            }
            window.stackPanel.Children.Add(menu);
        }

    }
}
