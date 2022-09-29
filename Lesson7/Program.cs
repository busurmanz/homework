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

