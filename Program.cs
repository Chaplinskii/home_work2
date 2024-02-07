// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.

// int SumNumber(string x)
// {
//     int digit = Convert.ToInt32(x);
//     int sum = 0;
//     while (digit != 0)
//     {

//         sum = sum + (digit % 10);
//         digit = digit / 10;

//     }
//     return sum;
// }

// Console.Clear();
// while (true)
// {
//     Console.Write("Введите целое число: ");
//     string x = (Console.ReadLine()!);
//     if (x == "q")
//     {
//         Console.WriteLine("Stop programms!");
//         break;
//     }
//     int number = 0;
//     if (int.TryParse(x, out number))
//     {
//         if (SumNumber(x) % 2 == 0)
//         {
//             Console.WriteLine("Stop programms!");
//             break;
//         }
//     }
// }


// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

//  void inputArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(100, 1000);
// }
// Console.Clear();
// Console.Write("Введите кол-во чисел: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// int count = 0;
// foreach (int element in array){
//     if (element % 2 == 0)
//         count++;
// }
// Console.WriteLine(count);

// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

// void inputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(100, 1000);
// }
// Console.Clear();
// Console.Write("Введите кол-во чисел: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// inputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// int temp1 = 0;
// int temp2 = 0;
// for (int i = 0; i < array.Length / 2; i++)
// {
//     temp1 = array[i];
//     temp2 = array[array.Length - (1 + i)];
//     array[i] = temp2;
//     array[array.Length - (1 + i)] = temp1;
// }
// Console.WriteLine($"Перевернутый массив: [{string.Join(", ", array)}]");