//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();

// 1 способ
//Console.WriteLine("Введите число: ");
//int a = Convert.ToInt32(Console.ReadLine());

int a = new Random().Next(100, 1000);
//Console.WriteLine(a);

int result = a / 10 % 10;

Console.WriteLine($"Вторая цифра числа {a} : {result}");