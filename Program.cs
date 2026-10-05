using System;

class Program
{
    static void Main()
    {
        // создаём объект класса
        Rectangle rect = new Rectangle();

        // заполняем поля
        rect.height = 2;
        rect.width = 3;

        // метод 1: показать данные
        rect.Show();

        // метод 2: периметр
        double p = rect.Perimetr();
        Console.WriteLine($"Периметр = {p}");

        Console.ReadKey();
    }
}

class Rectangle
{
    // поля (открытые)
    public double height;
    public double width;

    // метод 1: вывод данных на экран
    public void Show()
    {
        Console.WriteLine($"Прямоугольник: высота = {height}, ширина = {width}");
    }

    // метод 2: расчёт периметра
    public double Perimetr()
    {
        return 2 * height + 2 * width;
    }
}