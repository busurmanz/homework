class Program {
  static void Main() {
    int a, b;
    Console.Write("a = ");
    a = int.Parse(Console.ReadLine());
    Console.Write("b = ");
    b = int.Parse(Console.ReadLine());
    if(a > b)
        Console.WriteLine("max = "+a);
    else
        Console.WriteLine("max = "+b); 
  }
}