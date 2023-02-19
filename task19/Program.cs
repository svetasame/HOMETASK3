// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("введите 5 значное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 10000 > 10 && number / 10000 < 1 )
Console.WriteLine("ошибка, это не 5 значное число");
int a = number % 10; 
int b = number / 10000;
int c = number / 1000 % 10; 
int d = number % 100 / 10;
if (a == b && c == d) 
Console.WriteLine("да, число является палиндромом");
else
Console.WriteLine("нет, число не является палиндромом");