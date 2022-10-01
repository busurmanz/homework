// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
class Program 
{
  static void Main() {
    Console.WriteLine("Введите начало числового отрезка ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите конец числового отрезка ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    for(int i = M; i < N; i++)
    {
        if(i > 0)
            Console.WriteLine(i);
    }
  }
}
