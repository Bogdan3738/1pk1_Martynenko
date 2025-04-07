namespace Task_23_06
{
    /*Напишите программу со следующими функциями:
1. Выведите информации о всех дисках в системе
2. Выведите содержимое каталога C:\Users (названия папок)
3. Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
a) Создание вложенного каталога “temp”
b) Вывод информации о текущем каталоге (имя, родитель и тд)
c) Вывод информации о вложенном каталоге
4. Переместите каталог “temp” по пути “D:\work\newTemp”
a) Реализуйте вывод информационного сообщения об успешном (или нет)
перемещении
5. Удалите каталог “D:\work\temp” и выведите сообщение об успешном (или нет)
удалении.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Вывести информацию о всех дисках в системе
            Console.WriteLine("Информация о всех дисках в системе:");
            foreach (var drive in DriveInfo.GetDrives())
            {
                Console.WriteLine($"Имя: {drive.Name}, Тип: {drive.DriveType}, " +
                                  $"Свободное пространство: {drive.AvailableFreeSpace / (1024 * 1024)} MB, " +
                                  $"Объём: {drive.TotalSize / (1024 * 1024)} MB");
            }

            // 2. Вывести содержимое каталога C:\Users (названия папок)
            Console.WriteLine("\nСодержимое каталога C:\\Users:");
            var usersDirectory = @"C:\Users";
            foreach (var dir in Directory.GetDirectories(usersDirectory))
            {
                Console.WriteLine(Path.GetFileName(dir));
            }

            // 3. Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
            var workDirectory = @"D:\work";
            Directory.CreateDirectory(workDirectory);

            // a) Создание вложенного каталога “temp”
            var tempDirectory = Path.Combine(workDirectory, "temp");
            Directory.CreateDirectory(tempDirectory);
            Console.WriteLine($"Создан каталог: {tempDirectory}");

            // b) Вывод информации о текущем каталоге
            var currentDirectoryInfo = new DirectoryInfo(workDirectory);
            Console.WriteLine($"Текущий каталог: {currentDirectoryInfo.FullName}");
            Console.WriteLine($"Родительский каталог: {currentDirectoryInfo.Parent?.FullName}");

            // c) Вывод информации о вложенном каталоге
            var tempDirectoryInfo = new DirectoryInfo(tempDirectory);
            Console.WriteLine($"Информация о каталоге 'temp':");
            Console.WriteLine($"Имя: {tempDirectoryInfo.Name}");
            Console.WriteLine($"Полное имя: {tempDirectoryInfo.FullName}");
            Console.WriteLine($"Родительский каталог: {tempDirectoryInfo.Parent?.FullName}");

            // 4. Переместите каталог “temp” по пути “D:\work\newTemp”
            var newTempDirectory = Path.Combine(workDirectory, "newTemp");
            try
            {
                Directory.Move(tempDirectory, newTempDirectory);
                Console.WriteLine($"Каталог 'temp' успешно перемещён в: {newTempDirectory}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при перемещении каталога: {ex.Message}");
            }

            // 5. Удалите каталог “D:\work\temp” и выведите сообщение об успешном (или нет) удалении
            try
            {
                Directory.Delete(newTempDirectory);
                Console.WriteLine($"Каталог '{newTempDirectory}' успешно удалён.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при удалении каталога: {ex.Message}");
            }
        }
    }
    
}
