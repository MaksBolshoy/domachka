// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
 
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000);
int fristDigit = number /10;
int result = fristDigit % 10;
Console.WriteLine(number);
Console.WriteLine(result);
