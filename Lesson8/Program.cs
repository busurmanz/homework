/*
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
class Program 
{
  static void Main() {
    Console.WriteLine("¬ведите количество строк");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("¬ведите количество столбцов");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m, n];
    
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(100);
            Console.Write(array[i, j]+" ");
        }
        Console.WriteLine();
    }
    
    Console.WriteLine();
    
    int buf;
    for (int k = 0; k < m; k++)
    {
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (array[k, i] > array[k, j])
                {
                    buf = array[k, i];
                    array[k, i] = array[k, j];
                    array[k, j] = buf;
                }
            }
        }
    }
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j]+" ");
        }
        Console.WriteLine();
    }
  }
}
*/

/*
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
class Program 
{
  static void Main() {
    Console.WriteLine("Введите количество строк ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m, n];
    int[] countarray = new int[m];
    
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next() * 10;
            Console.Write(array[i, j] + " ");
            countarray[i] = countarray[i] + array[i, j];
        }
        Console.WriteLine();
    }
    
    Console.WriteLine();
    
    int index_min = countarray[0];
    for(int i = 1; i < m; i++)
        if (countarray[i] < index_min)
            index_min = i;
    
    Console.WriteLine("Строка с наименьшой суммой элементов " + index_min);
    
    for(int i = 0; i < n; i++)
        Console.Write(array[index_min, i] + " ");
        Console.WriteLine();
  }
}
*/

/*
//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
class Program 
{
  static void Main() {
    Console.WriteLine("Введите количество строк первой матрицы ");
    int m1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов первой матрицы ");
    int n1 = Convert.ToInt32(Console.ReadLine());
    int[,] matrix1 = new int[m1, n1];
    
    Console.WriteLine("Введите количество строк второй матрицы ");
    int m2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов второй матрицы ");
    int n2 = Convert.ToInt32(Console.ReadLine());
    int[,] matrix2 = new int[m2, n2];
    
    if (n1 == m2)
    {
    
        int[,] count_matrix = new int[n1, n2];
        
        Random random = new Random();
        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n1; j++)
            {
                matrix1[i, j] = random.Next(100);
                Console.Write(matrix1[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        
        for (int i = 0; i < m2; i++)
        {
            for (int j = 0; j < n2; j++)
            {
                matrix2[i, j] = random.Next(100);
                Console.Write(matrix2[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        
        for (int i = 0; i < m1; i++)
            for(int j = 0; j < n2; j++)
                for(int k = 0; k < m2; k++)
                    count_matrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    
        for (int i = 0; i < n1; i++)
        {
            for(int j = 0; j < n2; j++)
                Console.Write(count_matrix[i, j] + " ");
            Console.WriteLine();
        }
    }
    else
        Console.WriteLine("Такие матрицы нельзя перемножить ");
  }
}
*/

/*
//Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
class Program 
{
  static void Main() {
    Console.WriteLine("Введите длинну массива ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите ширину массива ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите высоту массива ");
    int z = Convert.ToInt32(Console.ReadLine());
    int[,,] array = new int[x, y, z];
    int count = x * y * z;
    int buf = 10;
    
    if (count <= 90)
    {
        for (int j = 0; j < x; j++)
            for (int k = 0; k < y; k++)
            {
                for (int m = 0; m < z; m++)
                {
                    array[j, k, m] = buf;
                    Console.WriteLine(array[j, k, m]+"("+j+" "+k+" "+m+")");
                    buf += 1;
                }
                Console.WriteLine();
            }
    }
    else
        Console.WriteLine("Нельзя задать массив такой размерности из двухзначных чисел ");
  }
}
*/

/*
//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
class Program 
{
  static void Main() {
    int[,] array = new int[4, 4];
    int buf = 0;
    Console.WriteLine();

    for (int i = 0; i < 4; i++)
    {
            array[0, i] = buf;
            buf += 1;
    }
    for (int i = 1; i < 4; i++)
    {
            array[i, 3] = buf;
            buf += 1;
    }
    for (int i = 2; i > -1; i--)
    {
            array[3, i] = buf;
            buf += 1;
    }
    for (int i = 2; i > 0; i--)
    {
            array[i, 0] = buf;
            buf += 1;
    }
    for (int i = 1; i < 3; i++)
    {
            array[1, i] = buf;
            buf += 1;
    }
    array[2, 2] = buf;
    buf += 1;
    array[2, 1] = buf;
    
    for(int i = 0; i < 4; i++)
    {
        for(int j = 0; j < 4; j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
  }
}
*/