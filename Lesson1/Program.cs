/*
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
class Program {
  static void Main() {
    int a, b;
    Console.Write("a = ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("b = ");
    b = Convert.ToInt32(Console.ReadLine());
    if(a > b){
        Console.WriteLine("max = "+a);
        Console.WriteLine("min = "+b);
    }
    else
        Console.WriteLine("max = "+b);
        Console.WriteLine("min = "+a); 
  }
}
*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
class Program {
  static void Main() {
    int a1, a2, a3, max;
    Console.Write("a1 = ");
    a1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("a2 = ");
    a2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("a3 = ");
    a3 = Convert.ToInt32(Console.ReadLine());
    max = a1;
    if(a2 > max)
        max = a2;
    if(a3 > max)
        max = a3;
    Console.WriteLine("max = "+max);
  }
}
*/


/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
class Program {
  static void Main() {
    int a;
    Console.Write("a = ");
    a = Convert.ToInt32(Console.ReadLine());
        if(a%2 == 0)
            Console.WriteLine("even");
        else
            Console.WriteLine("odd");
  }
}
*/

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
class Program {
  static void Main() {
    int N;
    Console.Write("N = ");
    N = Convert.ToInt32(Console.ReadLine());
    for(int i = 1; i < N; i++)
    {
        if(i%2 == 0)
            Console.WriteLine(i+" ");
    }
  }
}
*/
