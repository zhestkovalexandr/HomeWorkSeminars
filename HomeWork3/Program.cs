/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/

// void CubNums (int num)
//     { int count = 1;
//     if (num >= count)
//     {
//         while (count <= num)
//         {
//             Console.Write(Math.Pow(count, 3) + " ");
//             count ++;
//         }

//     }
//     else
//     {
//         while (count >= num)
//         {
//             Console.Write(Math.Pow(count, 3) + " ");
//             count --;
//         }
//     }
// }
// Console.WriteLine("Input num N");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.Write("Cub =  ");
// CubNums(num);

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.*/
// double distance (double x1, double y1, double x2, double y2, double z1, double z2)
//  {
//     return Math.Sqrt (Math.Pow (x2 - x1, 2 ) + Math.Pow (y2 - y1, 2) + Math.Pow (z2 - z1, 2));
//  }
// Console.Write ("Input x1 ");
// double x1 = 
// Convert.ToDouble (Console.ReadLine());
// Console.Write ("Input y1 ");
// double y1 = 
// Convert.ToDouble (Console.ReadLine());
// Console.Write ("Input z1 ");
// double z1 = 
// Convert.ToDouble (Console.ReadLine());
// Console.Write ("Input x2 ");
// double x2 = 
// Convert.ToDouble (Console.ReadLine());
// Console.Write ("Input y2 ");
// double y2 = 
// Convert.ToDouble (Console.ReadLine());
// Console.Write ("Input z2 ");
// double z2 = 
// Convert.ToDouble (Console.ReadLine());

// Console.WriteLine($"distance between points is {Math.Round(distance(x1,y1,x2,y2,z1,z2),2)}");

/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.*/

// bool polindrome(int num)
// {
//     int revers = 0;
//     int mem = num;
//     while (num > 0)
//     {
//         int lastnum = num % 10;
//         revers = revers * 10 + lastnum;
//         num = num / 10;
//     }
//     return revers == mem;
// }

// Console.WriteLine("Input number ");
// int num = 
// Convert.ToInt32(Console.ReadLine());
// if (polindrome(num))
// Console.WriteLine($"{num} this polindrome");
// else
// Console.WriteLine($"{num} this is not polindrome");





