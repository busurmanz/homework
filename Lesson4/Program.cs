/*
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
class Program {
  static void Main() 
  {
    int A, B;
    double Step;
    for(int i = 0; i < 1; i++) 
    {
        Console.Write("A =");
        A = Convert.ToInt32(Console.ReadLine());
        Console.Write("B =");
        B = Convert.ToInt32(Console.ReadLine());
        Step = Math.Pow(A, B);
        Console.Write(Step);
    }
    Console.WriteLine();
  }
}
*/

/*
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
class Program {
  static void Main() 
  {
    int x, Sum;
    Sum = 0;
    Console.Write("x = ");
    x = Convert.ToInt32(Console.ReadLine());
    while(x > 0)
    {
        Sum = Sum + x % 10;
        x = x / 10;
    }
    Console.Write("Sum = "+Sum);
    Console.WriteLine();
  }
}
*/

/*
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
class Program {
  static void Main() 
  {
    int[] nums = {1, 2, 3, 4, 5, 6, 7, 8};
    for(int i = 0; i < nums.Length; i++)
    {
        Console.WriteLine(nums[i]);
    }
  }
}
*/