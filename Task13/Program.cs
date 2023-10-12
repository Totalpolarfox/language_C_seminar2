//
// Cычeв B.B.
//
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



int ReadInt(string msg)  				// Объявляем функцию ReadInt с параметром msg
{
    Console.WriteLine(msg);  			// Выводим сообщение "Введите число: "
    string numb = Console.ReadLine();	// Считываем введенную пользователем информацию и записываем в переменную
    int number;							// Объявляем числовую переменную
    number = int.Parse(numb);			// Преобразовываем строковую переменную в числовую
    return number;						// Возвращаем результат
}
int number = ReadInt("Введите число: ");

while(number > 1)
{
    int number1 = number % 10;
    number = number / 10;
    Console.WriteLine(number1);
    int[] array = new int[] {};
    array = new int[array.Length + 1];
    int index = 0;
    array[index] = number1;
    index++;
    Console.WriteLine(array);
}

