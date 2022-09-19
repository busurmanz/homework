/*
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
class Program 
{
  static void Main() {
    int[] A = {255 , 264, 280, 277, 100, 133};
    int count = 0;
    for (int i = 0; i < A.Length; i++)
    {
        if (A[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    Console.WriteLine(count);
  }
}
*/

/*
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
class Program
 {
  static void Main() {
    int[] A = {5, 8, 5, 7, 0, 3};
    int count = 0;
    for (int i = 1; i < A.Length; i = i + 2)
    {
        count = count + A[i];
    }
    Console.WriteLine(count);
  }
 }
*/

