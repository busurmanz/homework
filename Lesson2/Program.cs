/*
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
class Program {
  static void Main() {
    int a1, a2, n1, n2, i;
    Console.Write("a = ");
    a1 = Convert.ToInt32(Console.ReadLine());
    a2 = a1;
    n1 = 0;
    while(a2!=0){
        n1++;
        a2/=10;
    }
    int[] nums = new int[n1];
    n2=10;
    for(i = 0; i < n1-2; i++)
        n2*=10;
    for(i = 0; i < n1; i++){
        nums[i] = a1/n2;
        a1%=n2;
        n2/=10;
    }
    Console.WriteLine("num = "+nums[1]);
  }
}
*/

/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
class Program {
  static void Main() {
    int a1, a2, n1, n2, i;
    Console.Write("a = ");
    a1 = Convert.ToInt32(Console.ReadLine());
    a2 = a1;
    n1 = 0;
    while(a2!=0){
        n1++;
        a2/=10;
    }
    if(n1<3)
        Console.WriteLine("no num");
    else{
        int[] nums = new int[n1];
    n2=10;
    for(i = 0; i < n1-2; i++)
        n2*=10;
    for(i = 0; i < n1; i++){
        nums[i] = a1/n2;
        a1%=n2;
        n2/=10;
    }
    Console.WriteLine("num = "+nums[2]);
    }
    
  }
}

*/

/*
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
class Program {
  static void Main() {
    int a;
    Console.Write("a = ");
    a = Convert.ToInt32(Console.ReadLine());
    if(a == 6 || a==7)
        Console.WriteLine("yes");
    else 
        Console.WriteLine("no");
  }
}
*/