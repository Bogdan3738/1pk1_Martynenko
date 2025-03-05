namespace Task_13_02
{
    /*
     создать класс питомца
свойства:
кличка, вид животного, возраст, вес, отметка о состонии здоровья (здоров/нездоров)
методы:
вывод информации об объекте
изменение значения веса животного
изменение отметки о состоянии здоровья
конструторы:
предусмотрите разные варианты инициализации объектов
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet pet1 = new Pet("Стасик","Dog", 4,17, "Healthy");
            pet1.DisplayInfo();

            // Создание объекта с именем
            Pet pet2 = new Pet("Жорик", "Dog", 1, 10, "Healthy");
            pet2.DisplayInfo();

            // Создание объекта с полными параметрами
            Pet pet3 = new Pet("Роки", "Dog", 5, 20.5, "Healthy");
            pet3.DisplayInfo();

            // Изменение веса и состояния здоровья
            pet3.ChangeWeight(22.0);
            pet3.UpdateHealthStatus("Unwell");
            pet3.DisplayInfo();
        }
    }
}
