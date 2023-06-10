// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Например: a = 5; b = 7 ->  max = 7, min = 5
// a = -9 b = -3 -> max = -3, min = -9

Console.Write("Введите первое число => "); //Вывод приглашения на экран
string imputedString_1 = Console.ReadLine(); // Ввод пользователя (строка)
Console.Write("Введите второе число => "); //Вывод приглашения на экран
string imputedString_2 = Console.ReadLine(); // Ввод пользователя (строка)
int number_1 = Convert.ToInt32(imputedString_1); // Преобразование строки в число
int number_2 = Convert.ToInt32(imputedString_2); // Преобразование строки в число
int max = 0;
int min = 0;
//int square = number_1 * number_1; // Вычисление квадрата (логига программы)
//Console.WriteLine($"Квадрат числа {number_1} равен {square}"); // Вывод результата
//Console.Write("Введите второе число =>"); //Вывод приглашения на экран
if (number_1 > number_2)
    {
    max = number_1;
    min = number_2;
    Console.WriteLine($"Большее число: {max}. Меньшее число: {min}.");
    }

if (number_2 > number_1)
    {
    max = number_2;
    min = number_1;
    Console.WriteLine($"Большее число: {max}. Меньшее число: {min}.");
    }
if (number_1 == number_2)
    {
    Console.WriteLine($"Оба числа равны");
    }
    

