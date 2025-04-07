using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_04
{
    internal class User
    {
        // Статическое свойство для хранения текущего пользователя
        private static User _currentUser;

        // Свойство для доступа к текущему пользователю
        public static User CurrentUser
        {
            get { return _currentUser; }
        }

        // Пример свойства для представления пользователя, например, его имени
        public string Name { get; set; }

        // Конструктор для создания нового пользователя
        public User(string name)
        {
            Name = name;
        }

        // Метод для установки текущего пользователя
        public static void SetCurrentUser(User user)
        {
            _currentUser = user;
        }

    }
}
