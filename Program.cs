// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число : ");
int Number = Convert.ToInt32(Console.ReadLine());
if ((Number>99&Number<1000)|(Number<-99&Number>-1000))
{Number=Number/10;
Number=Number%10;
Console.WriteLine($"Вторая цифра трехзначного числа : {Number}");}
else {Console.WriteLine($"Введенное число {Number} не является трехзначным");}