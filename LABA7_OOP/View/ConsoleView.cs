using Laba3_oop;
using LABA7_OOP.Model;
using System;
using System.Collections.Generic;

namespace LABA7_OOP.View
{
    public class ConsoleView : IShopView
    {
        public event Action CreateShop;
        public event Action<int> DeleteShop;
        public event Action<int> SelectShop;
        public event Action ResetFields;
        public event Action ShowInfo;

        /// <summary>
        /// Флаг основного цикла запуска консольного интерфейса.
        /// </summary>
        private bool running = true;

        /// <summary>
        /// Локальная копия списка магазинов, получаемая из модели.
        /// </summary>
        private List<InternetShop> currentShops = new List<InternetShop>();

        /// <summary>
        /// Запускает главный цикл консольного интерфейса
        /// </summary>
        public void Run()
        {
            while (running)
            {
                ShowMenu();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": CreateShop?.Invoke(); break;
                    case "2":
                        if (currentShops.Count == 0)
                        {
                            ShowMessage("Нет созданных магазинов для удаления", true);
                            break;
                        }
                        Console.Write("Введите номер магазина для удаления: ");
                        if (int.TryParse(Console.ReadLine(), out int delIndex))
                        {
                            DeleteShop?.Invoke(delIndex - 1);
                        }
                        else
                        {
                            ShowMessage("Неверный ввод", true);
                        }
                        break;
                    case "3":
                        if (currentShops.Count == 0)
                        {
                            ShowMessage("Нет созданных магазинов для выбора", true);
                            break;
                        }
                        Console.Write("Введите номер для выбора: ");
                        if (int.TryParse(Console.ReadLine(), out int selIndex))
                        {
                            SelectShop?.Invoke(selIndex - 1);
                        }
                        else
                        {
                            ShowMessage("Неверный ввод", true);
                        }
                        break;
                    case "4": ResetFields?.Invoke(); break;
                    case "5": ShowInfo?.Invoke(); break;
                    case "0": running = false; break;
                    default: ShowMessage("Неверный пункт меню", true); break;
                }
            }
        }

        /// <summary>
        /// Выводит пункты меню в консоль для взаимодействия с пользователем
        /// </summary>
        private void ShowMenu()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("=== Управление интернет-магазинами ===");
            Console.WriteLine("1. Создать магазин");
            Console.WriteLine("2. Удалить магазин");
            Console.WriteLine("3. Выбрать магазин");
            Console.WriteLine("4. Сбросить поля ввода");
            Console.WriteLine("5. Показать информацию о текущем магазине");
            Console.WriteLine("0. Выход");
            Console.Write("Ваш выбор: ");
        }

        public (string name, string address, int purchaseCount, int productCount, 
            double averageCheck, double rating, bool isActive) GetInputData()
        {
            Console.WriteLine("\n=== Ввод данных магазина ===");

            string name;
            do
            {
                Console.Write("Название: ");
                name = Console.ReadLine();
                if (!InputChecker.IsValidShopName(name))
                    Console.WriteLine("Некорректное имя. Допустимы буквы, цифры, пробелы, длина 2-40 символов.");
            } while (!InputChecker.IsValidShopName(name));

            string address;
            do
            {
                Console.Write("Адрес: ");
                address = Console.ReadLine();
                if (!InputChecker.IsValidAddress(address))
                    Console.WriteLine("Некорректный адрес.");
            } while (!InputChecker.IsValidAddress(address));
            Console.Write("Количество покупок в сутки: ");
            int purchases = ReadInt();
            Console.Write("Количество товаров: ");
            int products = ReadInt();
            Console.Write("Средний чек: ");
            double avgCheck = ReadDouble();
            double rating;
            do
            {
                Console.Write("Рейтинг (1-5): ");
                rating = ReadDouble();
                if (rating < 1 || rating > 5)
                    Console.WriteLine("Рейтинг должен быть от 1 до 5.");
            } while (rating < 1 || rating > 5);
            Console.Write("Активен? (да/нет или true/false): ");
            bool isActive = ReadBool();
            return (name, address, purchases, products, avgCheck, rating, isActive);
        }

        /// <summary>
        /// Считывает из консоли неотрицательное целое число
        /// </summary>
        /// <returns>Неотрицательное целое число, введённое пользователем</returns>
        private int ReadInt()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result) || result < 0)
            {
                Console.Write("Введите неотрицательное целое число: ");
            }
            return result;
        }

        /// <summary>
        /// Считывает из консоли неотрицательное дробное число
        /// </summary>
        /// <returns>Неотрицательное число типа double, введённое пользователем</returns>
        private double ReadDouble()
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), out result) || result < 0)
            {
                Console.Write("Введите неотрицательное число: ");
            }
            return result;
        }

        /// <summary>
        /// Считывает логическое значение из консоли в вариантах "да/нет" или "true/false"
        /// </summary>
        /// <returns>Булево значение, соответствующее вводу пользователя</returns>
        private bool ReadBool()
        {
            string input = Console.ReadLine().ToLower();
            if (input == "да" || input == "true")
            {
                return true;
            }
            if (input == "нет" || input == "false")
            {
                return false;
            }
            Console.Write("Введите да/нет или true/false: ");
            return ReadBool();
        }

        public void DisplayShopInfo(InternetShop shop)
        {
            Console.WriteLine("\n=== Информация о магазине ===");
            Console.WriteLine(shop.ToString());
            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }

        public void UpdateObjectsList(List<InternetShop> shops, InternetShop currentShop)
        {
            currentShops = shops;
            Console.WriteLine("\n=== Список магазинов ===");
            if (shops.Count == 0)
            {
                Console.WriteLine("Нет созданных магазинов.");
            }
            else
            {
                for (int i = 0; i < shops.Count; i++)
                {
                    string marker = (shops[i] == currentShop) ? " (текущий)" : "";
                    Console.WriteLine($"{i + 1}. {shops[i].Name}{marker}");
                }
            }
        }

        public void ShowMessage(string text, bool isError = false)
        {
            if (isError)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine(text);
            Console.ResetColor();
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }

        public void ClearInputFields()
        {
            Console.WriteLine("Поля ввода сброшены (при следующем создании будут использованы значения по умолчанию)");
        }
    }
}