﻿System.Console.WriteLine("Введите ваше первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите ваше второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int Multiplicity(int num1, int num2)
{
    return num1 % num2 != 0 ? num1 % num2 : 0;
    // return res;
}

int result = Multiplicity(number1, number2);
if (result == 0) System.Console.WriteLine($"Ваше число {number1} делиться на {number2} без остатка -> оно кратно");
else System.Console.WriteLine($"Ваше число {number1} не делиться на {number2} без остатка -> оно не кратно, остаток -> {result}");