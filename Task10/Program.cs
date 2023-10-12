﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ReadInt(string msg)  				// Объявляем функцию ReadInt с параметром msg
{
    Console.WriteLine(msg);  			// Выводим сообщение "Введите трехзначное число: "
    string numb = Console.ReadLine();	// Считываем введенную пользователем информацию и записываем в переменную
    int number;							// Объявляем числовую переменную
    number = int.Parse(numb);			// Преобразовываем строковую переменную в числовую
    return number;						// Возвращаем результат
}
int number = ReadInt("Введите трехзначное число: ");
if (number < 1000 && number > 99)  		// Если {number} трехзначное число -> продолжаем вычисления 
{
    // Делением на 10 делаем из {number} двузначное число, далее делением с остатком на 10
    // полученного двузначного числа вычисляем его последнюю цифру, остаток присваиваем в переменную {secondDigit}    
    int secondDigit = (number / 10) % 10; 
    Console.WriteLine($"Вторая цифра числа {number} является {secondDigit}");
}
else
{
    Console.WriteLine($"Введенное число {number} не является трёхзачным");
}