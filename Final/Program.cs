class Programm 
{
  static void Main() {
    string[] array1 = {"qaz", "wsx", "qwer", "asdf", "tgb", "a", "ik", "rfvbnm", "fff"}; // «адаЄм массив строк
    string[] array2 = new string[array1.Length]; // «адаЄм пустой массив размером с изначальный
    int count = 0; // ќбнул€ем счЄтчик
    for(int i = 0; i < array1.Length; i++) // ѕеребираем все значени€ первого массива
    {
        if(array1[i].Length < 4) // ѕровер€ем длинну подход€щих строк
        {
            array2[count] = array1[i]; // «аписываем подход€щие строки в новый массив по пор€дку без пропусков
            count += 1; // ќбновл€ем счЄтчик, дл€ устранени€ пустых €чеек в новом массиве
        }
    }
    
    for(int i = 0; i < array2.Length; i++) // ѕеребираем новый массив
    {
        if(array2[i] != "") // ¬ыводим элементы массива до момента пока не встретим пустую €чейку
            Console.WriteLine(array2[i]);
        else
            break; // ќстанавливаем цикл
    }
  }
}
