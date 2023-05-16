using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_app
{
    public class handler
    {
        public handler(string path_users)
        {
            ReadUserInfo(path_users);
        }
        public model m = new model();

        public string Check(string user_login, string user_password) // проверка логина и пароля 
        {
            foreach (var user in m.users)
            {
                if (user.password == user_password && user.login == user_login) return user.path;

            }
            return null;
        }

        private void ReadUserInfo(string path_users) // считывается с файла вся информация о пользователях
        {
            string line;
            StreamReader streamReader = new StreamReader(path_users);
            while (!streamReader.EndOfStream)
            {
                User user = new User();

                line = streamReader.ReadLine();
                string[] splitline = line.Split(' ');
                user.login = splitline[0];
                user.password = splitline[1];
                user.path = splitline[2];
                m.users.Add(user);

            }
        }
    }
}
