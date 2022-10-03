// See https://aka.ms/new-console-template for more information
class Program
{
int MyArr(int size)
{
int[] myArr = new int[size];

for(int i = 0; i < size; i++)
{
    Cosole.WriteLine("enter number: ");
    myArr[i] = Convert.ToInt32(Console.ReadLine());
}
return myArr[size];
}
    Console.Write(MyArr[i]+ " ");
    Console.WriteLine();
Console.WriteLine("enter size the array ");
int len = Convert.ToInt32(Console.ReadLine());
int [] xx = MyArr(len);
PrintArray(xx);

}
}