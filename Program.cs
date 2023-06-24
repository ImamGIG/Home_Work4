// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// double NumDegree(double a, double b)
// {
//     double result = 1;
//     for (double i = 1; i < b; i++)
//     {
//         result = Math.Pow(a, b);
//     }
//     return result;
// }

// System.Console.Write("Input number: A -> ");
// double a = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Input number: B -> ");
// double b = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine($" natural degree B from number A -> {NumDegree(a, b)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int SumNumbr(int N)
// {
//     int last_digit = 0;
//     for (int i = 0; N > 0; i++)
//     {
//         last_digit += N % 10;
//         N = N / 10;
//     }
//     return last_digit;
// }

// System.Console.Write("Inpud Numbers N: -> ");
// int N = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Sum of numbers {N} numbers -> {SumNumbr(N)}");
