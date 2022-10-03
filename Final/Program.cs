class Programm 
{
  static void Main() {
    string[] array1 = {"qwe", "ytr", "123456", "-2", "123", "asdfgh", ":-)"}; 
    string[] array2 = new string[array1.Length]; 
    int count = 0; 
    for(int i = 0; i < array1.Length; i++) 
    {
        if(array1[i].Length < 4) 
        {
            array2[count] = array1[i]; 
            count += 1;
        }
    }

    for(int i = 0; i < array2.Length; i++) 
    {
        if(array2[i] != " ") 
            Console.WriteLine(array2[i]);
        else
            break; 
    }
  }
}

