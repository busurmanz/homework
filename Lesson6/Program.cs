class Program
 {
static void Main() {
    int x;
    int schet = 0;
    Console.WriteLine("Введите количество чисел ");
    int count = Convert.ToInt32(Console.ReadLine());
    int[] nums = new int[count];
    for(int i = 0; i < count; i++)
    {
        Console.WriteLine("Введите число");
        x = Convert.ToInt32(Console.ReadLine());
        if(x > 0)
        {
            schet = schet + 1;
        }
    }
    Console.WriteLine("Количество чисел больше 0 = " +schet);
  }
}