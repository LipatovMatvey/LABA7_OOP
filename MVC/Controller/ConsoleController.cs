using System;
using LABA7_OOP.Model;
using MVC.Model;
using MVC.View;
using Laba3_oop;

namespace MVC.Controller
{
    public class ConsoleController
    {
        /// <summary>
        /// Коллекция интернет-магазинов
        /// </summary>
        private InternetShopCollection collection;

        /// <summary>
        /// Консольное представление
        /// </summary>
        private ConsoleView view;

        /// <summary>
        /// Конструктор контроллера
        /// </summary>
        /// <param name="collection">Коллекция магазинов</param>
        /// <param name="view">Консольное представление</param>
        public ConsoleController(InternetShopCollection collection, ConsoleView view)
        {
            this.collection = collection;
            this.view = view;
        }

        /// <summary>
        /// Запускает главный цикл обработки команд пользователя
        /// </summary>
        public void Run()
        {
            bool exit = false;
            while (!exit)
            {
                view.ShowMainMenu();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CreateShop();
                        break;
                    case "2":
                        DeleteShop();
                        break;
                    case "3":
                        ShowAllShops();
                        break;
                    case "4":
                        ShowShopDetails();
                        break;
                    case "5":
                        view.ClearDisplay();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        view.ShowMessage("Неверный выбор. Повторите.", true);
                        break;
                }
                if (!exit && choice != "5")
                {
                    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                }
            }
        }

        /// <summary>
        /// Создаёт новый магазин
        /// </summary>
        private void CreateShop()
        {
            view.ShowMessage("=== Создание нового магазина ===");
            string name = view.ReadShopName();
            if (!InputChecker.IsValidShopName(name))
            {
                view.ShowMessage("Некорректное название магазина.", true);
                return;
            }
            string address = view.ReadAddress();
            if (!InputChecker.IsValidAddress(address))
            {
                view.ShowMessage("Некорректный адрес.", true);
                return;
            }
            int purchases = view.ReadPurchaseCount();
            int products = view.ReadProductCount();
            double avgCheck = view.ReadAverageCheck();
            double rating = view.ReadRating();
            bool isActive = view.ReadIsActive();

            InternetShop shop = new InternetShop(name, address, purchases, products, avgCheck, rating, isActive);
            collection.Add(shop);
            view.ShowMessage("Магазин успешно создан!");
        }

        /// <summary>
        /// Удаляет выбранный пользователем магазин
        /// </summary>
        private void DeleteShop()
        {
            int index = view.SelectShop(collection.GetAll());
            if (index >= 0)
            {
                var shop = collection.GetAt(index);
                collection.Remove(shop);
                view.ShowMessage($"Магазин \"{shop.Name}\" удалён.");
            }
        }

        /// <summary>
        /// Отображает список всех магазинов
        /// </summary>
        private void ShowAllShops()
        {
            view.DisplayAllShops(collection.GetAll());
        }

        /// <summary>
        /// Отображает подробную информацию о выбранном магазине
        /// </summary>
        private void ShowShopDetails()
        {
            int index = view.SelectShop(collection.GetAll());
            if (index >= 0)
            {
                var shop = collection.GetAt(index);
                view.ShowInfo(shop.ToString());
            }
        }
    }
}