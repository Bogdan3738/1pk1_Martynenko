using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_05
{
    public class User
    {
        public string Name { get; set; }
        public AccessLevel Level { get; set; }

        public User(string name, AccessLevel level)
        {
            Name = name;
            Level = level;
        }

        // Метод для проверки прав на выполнение действия
        public bool CanPerformAction(string action)
        {
            switch (action.ToLower())
            {
                case "delete_post":
                    return Level == AccessLevel.Moderator || Level == AccessLevel.Admin;
                case "edit_post":
                    return Level == AccessLevel.Admin;
                case "comment":
                    return Level == AccessLevel.User || Level == AccessLevel.Moderator || Level == AccessLevel.Admin;
                case "view":
                    return Level != AccessLevel.Guest; 
                default:
                    return false;
            }
        }
    }
}
