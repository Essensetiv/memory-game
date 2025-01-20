using System;
using System.Collections.Generic;

public class MemoryTrainingGame
{
    public static void Main(string[] args)
    {
        // Инициализация коллекции для хранения введенных чисел
        HashSet<int> enteredNumbers = new HashSet<int>();
        int previousNumber = -1; // Переменная для хранения предыдущего введенного числа
        int correctCount = 0; // Счетчик правильно введенных чисел

        // Приветствие и правила игры
        Console.WriteLine("Добро пожаловать в игру на память!");
        Console.WriteLine("Правила игры:");
        Console.WriteLine("1. Диапазон введенных чисел от 0 до 255.");
        Console.WriteLine("2. Запрещается вводить последовательно два числа, разность между которыми меньше 7.");
        Console.WriteLine("3. Запрещается вводить повторяющиеся числа.");
        Console.WriteLine("4. Игра закончится после первой ошибки.");
        Console.WriteLine("Начнём!");

        // Основной игровой цикл
        while (true)
        {
            Console.Write("Введите число: ");
            string userInput = Console.ReadLine();

            // Проверка на корректность ввода (целое число)
            if (!int.TryParse(userInput, out int userNumber))
            {
                Console.WriteLine("Ошибка: Введите целое число.");
                break;
            }

            // Проверка на диапазон числа
            if (userNumber < 0 || userNumber > 255)
            {
                Console.WriteLine("Ошибка: Допустимый диапазон от 0 до 255.");
                break;
            }

            // Проверка на повторное введение числа
            if (enteredNumbers.Contains(userNumber))
            {
                Console.WriteLine("Ошибка: Число уже было введено.");
                break;
            }

            // Проверка на разность с предыдущим числом
            if (previousNumber != -1 && Math.Abs(userNumber - previousNumber) < 7)
            {
                Console.WriteLine("Ошибка: Разность чисел меньше 7.");
                break;
            }

            // Если все проверки пройдены, добавляем число в коллекцию
            enteredNumbers.Add(userNumber);
            correctCount++;
            previousNumber = userNumber;

            Console.WriteLine($"Число {userNumber} принято. Продолжайте!");
        }

        // Завершение игры
        Console.WriteLine($"Игра окончена! Количество верно введенных чисел: {correctCount}");
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
