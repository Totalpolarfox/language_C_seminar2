// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число (день недели): ");     // Выводим сообщение пользователю
string inputNumber = Console.ReadLine();                // Считываем введенную пользователем информацию и записываем в переменную {inputNumber}
int number = Convert.ToInt32(inputNumber);              // Конверитруем тип string в int для сравнения числа
if (number > 5 && number < 8)
{
    Console.WriteLine($"День недели {number} является выходным");
}
else if (number > 0 && number < 6)
{
    Console.WriteLine($"День недели {number} выходным не является");
}
else
{
    Console.WriteLine($"В недели не может быть {number} дней");
}