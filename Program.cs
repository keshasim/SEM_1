// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
// double a = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите второе число: ");
// double b = Convert.ToDouble(Console.ReadLine());
// if (a > b) 
//  {
//      Console.WriteLine("Число " + a + " больше числа " + b);
//  }
//  else 
//  if (b > a) 
//  {
//      Console.WriteLine("Число " + b + " больше числа " + a);
//  }
//  else 
//  {
//     Console.WriteLine("Число " +  a + " равно числу "  + b);
//  }

//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите первое число: ");
// double a = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите второе число: ");
// double b = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите третье число: ");
// double c = Convert.ToDouble(Console.ReadLine());
// double max = a;
// if (b > a)
//     max = b;
// if (c > max)
//     max = c;
// {
//       Console.WriteLine("Число " + max + " максимальное " );
// 

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//  Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 2 == 0)
// {
//   Console.WriteLine( "Число является четным" );
// }
// else 
// {
//     Console.WriteLine( "Число является нечетным" );
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// */


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int evenNumber = 2;

// if(number > 1)
// {
//     while(number >= evenNumber)
//     {
//         Console.Write(" " + evenNumber);
//         evenNumber = evenNumber + 2;
//     }
// }