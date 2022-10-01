/*
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
*/

/*
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
class Program 
{
  static void Main() {
    Console.WriteLine("Введите начало числового отрезка ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите конец числового отрезка ");
    int N = Convert.ToInt32(Console.ReadLine());
    int Sum = 0;
    Console.WriteLine();
    for(int i = M; i < N; i++)
    {
        if(i > 0)
            Sum += i;
    }
    Console.WriteLine("Сумма натуральных элементов = " + Sum);
  }
}
*/


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
class Program 
{
    static int A(int x, int y)
    {
        if (x == 0)
            return y + 1;
        else
            if ((x != 0) && (y == 0))
                return A(x - 1, 1);
            else
                return A(x - 1, A(x, y - 1));
    }
    static void Main() {
        Console.WriteLine(A(2, 3));
  }
}