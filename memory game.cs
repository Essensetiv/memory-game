using System;
using System.Collections.Generic;
using System.Linq;
public class Test
{
    public static void Main()
    {
        HashSet<int> a = new HashSet<int>();
        int firstNumber = -1;
        int correctCount = 0;
        Console.WriteLine("Добро пожаловать в игру на память");
        Console.WriteLine("Правила игры:");
        Console.WriteLine("1.Диапозон введеннхы чисел от 0 до 255");
        Console.WriteLine("2.Запрещается вводить последовательно два числа ,разность между которыми меньше 7");
        Console.WriteLine("3.Запрещается вводить повтолряющиеся числа");
        Console.WriteLine("4.Игра закончится после первой ошибки ");
        Console.WriteLine("Начнём!");
        while (true)
        {
            Console.WriteLine("Введите число: ");
            string userInput = Console.ReadLine();
            if (!int.TryParse(userInput, out int UserNumber)) ;
            {
                Console.WriteLine("Ошибка: Введите целое число ");
                break;
            }
            if (UserNumber < 0 || UserNumber > 255)
            {
                Console.WriteLine("Ошибка: допустимый диапозон от 0 до 255");
                break;
            }
            if (a.Contains(UserNumber))
            {
                Console.WriteLine("Ошибка: число уже было введено ");
                break;
            }
            if (firstNumber != -1 && Math.Abs(UserNumber - firstNumber) < 7) ;
            {
                Console.WriteLine("Ошибка: разность чисел меньше 7 ");
            }
            a.Add(UserNumber);
            correctCount++;
            firstNumber = UserNumber;
            Console.WriteLine($"Поздравляю! Игра окончена!Количество верных чисел {correctCount}");
        }
    }
}
