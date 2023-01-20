/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.*/

// int cycle (int num, int cyc)
// {
//     int summ = 1;
//     for (int curent = 1; curent <= cyc; curent++)
//     {
//         summ *= num;
//     }
// return summ;
// }
// Console.WriteLine("Input num A ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Inpun num B ");
// int cyc = Convert.ToInt32(Console.ReadLine());
// if (number !=0)
// {
//     int result = cycle(number, cyc);
//     Console.WriteLine($"Result {result}");
// }
// else
// {
//     Console.WriteLine ("Input correct num");
// }

/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. */

// int summ (int num)
// {
//     int sum = 0;
//     for (int i = num; i != 0; i /= 10)
//     {
//         sum += i % 10;
//     }
//     return sum;
// }
// Console.WriteLine("Input a number ");
// int numb = Convert.ToInt32(Console.ReadLine());
// int sum = summ(numb);
// Console.WriteLine($"Sum of all {numb} is {sum}");


/* Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.*/

// int[] CreateArray(int length)
// {
//     int[] array = new int [length];
//     for (int i=0; i<length; i++)
//     {
//         Console.Write($"Input {i+1} elem: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     Console.Write("Array is ");
//     for (int i = 0; i < array.Length - 1; i++)
//     Console.Write(array[i] + " | ");
//     Console.Write($"{array[array.Length-1]} ");
//     Console.WriteLine();
// }
// Console.WriteLine("Input length of array");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(m);
// ShowArray(array);


