/*
//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
class Program {
  static void Main() {
    int a1, a2, n1, n2, i;
    bool flg = true;
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
    for(i = 0; i < n1/2; i++ ){
        if(nums[i] != nums[n1-i-1]){
            flg = false;
            break;
        }
    }
    if(flg)
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
  }
}
*/

/*
//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
class Program {
  static void Main() {
    int x1, x2, y1, y2, z1, z2;
    double dist;
    Console.Write("Ax = ");
    x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ay = ");
    y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Az = ");
    z1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Bx = ");
    x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("By = ");
    y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Bz = ");
    z2 = Convert.ToInt32(Console.ReadLine());
    dist = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    Console.WriteLine("dist = "+dist);
  }
}
*/

/*
//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
class Program {
  static void Main() {
    int a;
    Console.Write("a = ");
    a = Convert.ToInt32(Console.ReadLine());
    for(int i = 1; i <= a; i++){
        Console.Write(i*i*i);
        if(i != a)
            Console.Write(", ");
    }
  }
}
*/