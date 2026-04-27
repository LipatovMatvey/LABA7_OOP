using System;
using System.Collections.Generic;
using LABA7_OOP.Model;

namespace MVC.View
{
    public class ConsoleView
    {
        /// <summary>
        /// Отображает главное меню
        /// </summary>
        public void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Управление интернет-магазинами ===");
            Console.WriteLine("1. Создать новый магазин");
            Console.WriteLine("2. Удалить магазин");
            Console.WriteLine("3. Показать все магазины");
            Console.WriteLine("4. Показать информацию о выбранном магазине");
            Console.WriteLine("5. Очистить вывод");
            Console.WriteLine("0. Выход");
            Console.Write("Ваш выбор: ");
        }

        /// <summary>
        /// Запрашивает у пользователя ввод строки
        /// </summary>
        /// <param name="prompt">Текст приглашения</param>
        /// <returns>Введённая строка</returns>
        public string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        /// <summary>
        /// Запрашивает у пользователя целое число в заданном диапазоне
        /// </summary>
        /// <param name="prompt">Текст приглашения</param>
        /// <param name="min">Минимальное допустимое значение</param>
        /// <param name="max">Максимальное допустимое значение</param>
        /// <returns>Введённое целое число</returns>
        public int GetIntInput(string prompt, int min = int.MinValue, int max = int.MaxValue)
        {
            int result;
            do
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out result) && result >= min && result <= max)
                    return result;
                Console.WriteLine($"Ошибка: введите целое число от {min} до {max}.");
            } while (true);
        }

        /// <summary>
        /// Запрашивает у пользователя число с плавающей точкой в заданном диапазоне
        /// </summary>
        /// <param name="prompt">Текст приглашения</param>
        /// <param name="min">Минимальное допустимое значение</param>
        /// <param name="max">Максимальное допустимое значение</param>
        /// <returns>Введённое число</returns>
        public double GetDoubleInput(string prompt, double min = double.MinValue, double max = double.MaxValue)
        {
            double result;
            do
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out result) && result >= min && result <= max)
                    return result;
                Console.WriteLine($"Ошибка: введите число от {min} до {max}.");
            } while (true);
        }

        /// <summary>
        /// Запрашивает у пользователя булево значение (да/нет)
        /// </summary>
        /// <param name="prompt">Текст приглашения</param>
        /// <returns>true, если пользователь ввёл "да" или "true"; иначе false</returns>
        public bool GetBoolInput(string prompt)
        {
            Console.Write(prompt + " (да/нет): ");
            string input = Console.ReadLine()?.ToLower();
            return input == "да" || input == "true";
        }

        /// <summary>
        /// Выводит сообщение пользователю
        /// </summary>
        /// <param name="message">Текст сообщения</param>
        /// <param name="isError">true — сообщение об ошибке, false — обычное сообщение</param>
        public void ShowMessage(string message, bool isError = false)
        {
            if (isError)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ошибка: {message}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(message);
                Console.ResetColor();
            }
        }

        /// <summary>
        /// Выводит информационное сообщение
        /// </summary>
        /// <param name="info">Текст информации</param>
        public void ShowInfo(string info)
        {
            Console.WriteLine(info);
        }

        /// <summary>
        /// Очищает консоль
        /// </summary>
        public void ClearDisplay()
        {
            Console.Clear();
        }

        /// <summary>
        /// Отображает список всех магазинов
        /// </summary>
        /// <param name="shops">Список магазинов для отображения</param>
        public void DisplayAllShops(List<InternetShop> shops)
        {
            if (shops.Count == 0)
            {
                Console.WriteLine("Список магазинов пуст.");
                return;
            }
            Console.WriteLine("\n=== Список магазинов ===");
            for (int i = 0; i < shops.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {shops[i].Name}");
            }
        }

        /// <summary>
        /// Позволяет пользователю выбрать магазин из списка
        /// </summary>
        /// <param name="shops">Список доступных магазинов</param>
        /// <returns>Индекс выбранного магазина или -1, если список пуст</returns>
        public int SelectShop(List<InternetShop> shops)
        {
            if (shops.Count == 0)
            {
                ShowMessage("Нет доступных магазинов.", true);
                return -1;
            }
            DisplayAllShops(shops);
            return GetIntInput("Введите номер магазина: ", 1, shops.Count) - 1;
        }

        /// <summary>
        /// Считывает название магазина
        /// </summary>
        /// <returns>Название магазина, введённое пользователем</returns>
        public string ReadShopName() => GetUserInput("Наименование магазина: ");

        /// <summary>
        /// Считывает адрес склада
        /// </summary>
        /// <returns>Адрес, введённый пользователем</returns>
        public string ReadAddress() => GetUserInput("Адрес склада: ");

        /// <summary>
        /// Считывает количество покупок в сутки
        /// </summary>
        /// <returns>Неотрицательное целое число</returns>
        public int ReadPurchaseCount() => GetIntInput("Количество покупок в сутки: ", 0);

        /// <summary>
        /// Считывает количество товаров
        /// </summary>
        /// <returns>Неотрицательное целое число</returns>
        public int ReadProductCount() => GetIntInput("Количество товаров: ", 0);

        /// <summary>
        /// Считывает средний чек
        /// </summary>
        /// <returns>Неотрицательное число</returns>
        public double ReadAverageCheck() => GetDoubleInput("Средний чек: ", 0);

        /// <summary>
        /// Считывает рейтинг магазина
        /// </summary>
        /// <returns>Число от 1 до 5</returns>
        public double ReadRating() => GetDoubleInput("Рейтинг (1-5): ", 1, 5);

        /// <summary>
        /// Считывает активность магазина
        /// </summary>
        /// <returns>true, если магазин активен; иначе false</returns>
        public bool ReadIsActive() => GetBoolInput("Магазин активен?");
    }
}