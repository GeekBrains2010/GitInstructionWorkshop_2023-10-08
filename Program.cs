//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
//    static void PrintNumbers(int M, int N)
//     {
//         if (M <= N)
//         {
//             Console.WriteLine(M);
//             PrintNumbers(M + 1, N);
//         }
//     }

   
   
//         int M = 5; // Начальное значение
//         int N = 10; // Конечное значение

//         PrintNumbers(M, N);
    



//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// int m = 3; // Пример значения m
// int n = 2; // Пример значения n

// static int Ackermann(int m, int n)
//     {
//         // Base case for m=0
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         // Recursive case for m>0 and n=0
//         else if (n == 0)
//         {
//             return Ackermann(m - 1, 1);
//         }
//         // Recursive case for m>0 and n>0
//         else
//         {
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//         }
//     }

// int result = Ackermann(m, n);
// Console.WriteLine("Результат функции Аккермана для m = " + m + " и n = " + n + " равен " + result);
    
// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
    static void PrintReverse(int[] arr, int index)
    {
        if (index < 0)
        {
            return;
        }
        else
        {
            Console.WriteLine(arr[index]);
            PrintReverse(arr, index - 1);
        }
    }

    
        int[] arr = { 1, 2, 3, 4, 5 }; // Произвольный массив
        PrintReverse(arr, arr.Length - 1);
    
