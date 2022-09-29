/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
class Program
 {
  static void Main() {
    Console.WriteLine("Введите количество строк ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.NextDouble() * 100;
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
  }
}
*/

/*
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
class Program
 {
  static void Main() {
    int m = 8;
    int n = 5;
    int[,] array = new int[m, n];
    
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(100);
        }
    }
    
    Console.WriteLine("Введите номер строки элемента ");
    int m1 = Convert.ToInt32(Console.ReadLine());
    if ((m1 >= 0) && (m1 < m))
    {
        Console.WriteLine("Введите номер элемента в строке ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        if ((n1 >= 0) && (n1 < n))
        {
            Console.WriteLine("Элемент массива равен " + array[m1, n1]);
        }
        else
            Console.WriteLine("Такого столбца нет в массиве ");
    }
    else
        Console.WriteLine("Такой строки нет в массиве ");
  }
}
*/

