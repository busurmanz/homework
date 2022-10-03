class Programm 
{
  static void Main() {
    string[] array1 = {"qaz", "wsx", "qwer", "asdf", "tgb", "a", "ik", "rfvbnm", "fff"}; // Задаем массив строк
    string[] array2 = new string[array1.Length]; // Задаем пустой массив размером с изначальный
    int count = 0; // Обнуляем счетчик
    for(int i = 0; i < array1.Length; i++) // Перебираем все значения первого массива
    {
        if(array1[i].Length < 4) // Проверяем длинну подходящих строк
        {
            array2[count] = array1[i]; // Записываем подходящие строки в новый массив по порядку без пропусков
            count += 1; // Обновляем счетчик, для устранения пустых ячеек в новом массиве
        }
    }
    
    for(int i = 0; i < array2.Length; i++) // Перебираем новый массив
    {
        if(array2[i] != "") // Выводим элементы массива до момента пока не встретим пустую ячейку
            Console.WriteLine(array2[i]);
        else
            break; // Останавливаем цикл
    }
  }
}
