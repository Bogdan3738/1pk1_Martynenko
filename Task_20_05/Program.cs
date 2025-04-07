namespace Task_20_05
{
    /*Напишите программу, имитирующую систему авторизации с использованием перечисления AccessLevel:
• Guest (только чтение)
• User (чтение + комментарии)
• Moderator (удаление контента)
• Admin (полный доступ)
Создайте метод, который проверяет, может ли пользователь выполнить действие (например, удалитьпост).На основе уровня доступа выводите сообщение (например,
"Ошибка: Недостаточно прав!").
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            User guest = new User("Guest User", AccessLevel.Guest);
            User user = new User("Regular User", AccessLevel.User);
            User moderator = new User("Moderator User", AccessLevel.Moderator);
            User admin = new User("Admin User", AccessLevel.Admin);

            // Проверяем действия разных пользователей
            CheckUserAction(guest, "delete_post");
            CheckUserAction(user, "delete_post");
            CheckUserAction(moderator, "delete_post");
            CheckUserAction(admin, "delete_post");
        }

        static void CheckUserAction(User user, string action)
        {
            if (user.CanPerformAction(action))
            {
                Console.WriteLine($"{user.Name} может выполнить действие: {action}");
            }
            else
            {
                Console.WriteLine($"Ошибка: {user.Name} не имеет прав на выполнение действия: {action}");
            }
        }
    }
}

