//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32 (Console.ReadLine());
int a = number / 10000;
int b = number % 10;
int a2 = number % 10000 / 1000;
int b2 = number / 10 % 10;
if (a == b && a2 == b2)
Console.WriteLine ("Да, это палиндром");
else
Console.WriteLine ("Нет, это не палиндром");