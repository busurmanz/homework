/*
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
class Program
 {
static void Main() {
    int x;
    int schet = 0;
    Console.WriteLine("Введите количество чисел ");
    int count = Convert.ToInt32(Console.ReadLine());
    int[] nums = new int[count];
    for(int i = 0; i < count; i++)
    {
        Console.WriteLine("Введите число");
        x = Convert.ToInt32(Console.ReadLine());
        if(x > 0)
        {
            schet = schet + 1;
        }
    }
    Console.WriteLine("Количество чисел больше 0 = " +schet);
  }
}
*/


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
class Program
 {
  static void Main() {
    Console.WriteLine();
    Console.WriteLine("Введите коэффициент k1 ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент b1 ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент k2 ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент b2 ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;
    Console.WriteLine("Координаты точки перечения равны " +x +" " +y);
  }
}