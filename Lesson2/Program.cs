/*
class Program {
  static void Main() {
    int a1, a2, n1, n2, i;
    Console.Write("a = ");
    a1 = int.Parse(Console.ReadLine());
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
    Console.Write("num = "+nums[1]);
  }
}
*/

/*
class Program {
  static void Main() {
    int a1, a2, n1, n2, i;
    Console.Write("a = ");
    a1 = int.Parse(Console.ReadLine());
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
    Console.Write("num = "+nums[2]);
    }
    
  }
}
*/

