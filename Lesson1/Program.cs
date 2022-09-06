class Program {
  static void Main() {
    int a1, a2;
    Console.Write("a1 = ");
    a1 = int.Parse(Console.ReadLine());
    Console.Write("a2 = ");
    a2 = int.Parse(Console.ReadLine());
    if(a1 > a2)
        Console.Write("max = "+a1);
    else
        Console.Write("max = "+a2); 
  }
}