﻿// Дано четырехзначное число. Определить: равна ли сумма двух первых его цифр 
// сумме двух его последних цифр. 

Console.WriteLine("Введите четырехзначное число:");
int x = Convert.ToInt32(Console.ReadLine());

int a = x/1000;
int b= x%1000/100;
int c = x%100/10;
int d= x%10;

if((a + b)==(d + c))
{
    Console.WriteLine("Сумма первых двух цифр числа {0} равна сумме двух последних", x);
}
else
{
    Console.WriteLine("Сумма первых двух  цифр числа {0} не равна сумме двух последних", x);
}
