﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Например: 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число => "); //Вывод приглашения на экран
string imputedString = Console.ReadLine(); // Ввод пользователем данных (строка)
int number_N = Convert.ToInt32(imputedString); // Преобразование строки в целое число
int number = 2; // Присвоение переменной минимального четного значения, которое больше 1

while (number <= number_N) // Цикл работает, пока очередное четное число меньше или равно введенному пользователем числу
    {
    Console.Write($"{number}, "); //Вывод на экран четных чисел
    number = number + 2; // Четное число увеличивается на 2 на каждом круге цикла
    }

