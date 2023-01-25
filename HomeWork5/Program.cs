/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//   int[] array = new int[size];
//   Random random = new Random();
//   for(int i = 0; i < size; i ++)
//   {
//   array [i] = random.Next(minValue, maxValue + 1); 
//   }
//   return array;
// }
// void ShowArray(int[] array)
// {
//    Console.Write("Array is [ ");
//    for(int i = 0; i<array.Length - 1; i++)

//    Console.Write(array[i] + " | ");
//    Console.Write($"{array[array.Length - 1]} ]");
//    Console.WriteLine();
// }
// int EvenSelect (int[]array)
// {
//     int even = 0;
//     for(int i = 0; i<array.Length; i++)
//     {
//         if(array[i] % 2 == 0) even++;
//     }
//     return even;

// }

// Console.WriteLine("Input a length array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a min arr: ");
// int min = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Input a max arr: ");
// int max = Convert.ToInt32(Console.ReadLine());
// if(min>99 && min<=999 && max>99 && max<=999)
// {
// int[]arr = CreateRandomArray(size, min, max);
// ShowArray(arr);

// Console.WriteLine("");
// Console.WriteLine($"Even num is - {EvenSelect(arr)}");
// }
// else
// {
//     Console.WriteLine("Inter correct num");
// }



/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях. */

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//   int[] array = new int[size];
//   Random random = new Random();
//   for(int i = 0; i < size; i ++)
//   {
//   array [i] = random.Next(minValue, maxValue + 1); 
//   }
//   return array;
// }
// void ShowArray(int[] array)
// {
//    Console.Write("Array is [ ");
//    for(int i = 0; i<array.Length - 1; i++)

//    Console.Write(array[i] + " | ");
//    Console.Write($"{array[array.Length - 1]}");
//    Console.WriteLine();
// }
// int Summa (int[]array)
// {
//     int sum = 0;
//     for(int i = 0; i<array.Length; i+=2)
//     {
//         sum+=array[i];
//     }
//     return sum;

// }

// Console.WriteLine("Input a length array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a min arr: ");
// int min = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Input a max arr: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[]arr = CreateRandomArray(size, min, max);
// ShowArray(arr);

// Console.WriteLine("");
// Console.WriteLine($"Sum - {Summa(arr)}");


/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива. */

// double[] CreateRandomArray(int length, int minValue, int maxValue)
// {
//   double[] array = new double[length];
//   for(int i = 0; i < length; i ++)
//   {
//   array [i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
//   }
//   return array;
// }
// void ShowArray(double[] array)
// {
//    Console.Write("Array is [ ");
//    for(int i = 0; i<array.Length - 1; i++)

//    Console.Write(array[i] + " | ");
//    Console.Write($"{array[array.Length - 1]}");
//    Console.WriteLine();
// }
// void MinMax (double[]array)
// {
//     double[] arr = array;
//     Console.WriteLine($"Min num - {arr.Min()}");
//     Console.WriteLine($"Max num - {arr.Max()}");

// }

// Console.WriteLine("Input a length array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a min arr: ");
// int min = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Input a max arr: ");
// int max = Convert.ToInt32(Console.ReadLine());

// double[]arr = CreateRandomArray(size, min, max);
// ShowArray(arr);

// Console.WriteLine("");
// MinMax(arr);


