using System;
using LABA7_OOP.Model;
using MVC.Model;
using Laba3_oop;

namespace MVC.Controller
{
    public class FormController
    {
        /// <summary>
        /// Коллекция интернет-магазинов
        /// </summary>
        private InternetShopCollection _collection;

        /// <summary>
        /// Конструктор контроллера
        /// </summary>
        /// <param name="collection">Коллекция магазинов</param>
        public FormController(InternetShopCollection collection)
        {
            _collection = collection;
        }

        /// <summary>
        /// Создаёт магазин с проверкой полей
        /// </summary>
        /// <param name="name">Название магазина</param>
        /// <param name="address">Адрес склада</param>
        /// <param name="purchases">Количество покупок в сутки</param>
        /// <param name="products">Количество товаров</param>
        /// <param name="avgCheck">Средний чек</param>
        /// <param name="rating">Рейтинг (1-5)</param>
        /// <param name="isActive">Активен ли магазин</param>
        /// <returns>true, если магазин успешно создан; false, если ошибка валидации</returns>
        public bool CreateShop(string name, string address, int purchases, int products, double avgCheck, double rating, bool isActive)
        {
            if (!InputChecker.IsValidShopName(name))
            {
                BoxMessage.ShowNativeMessageBox("Ошибка",
                    "Некорректное название магазина. Допустимы буквы, цифры, пробел, дефис, кавычки, амперсанд. Длина от 2 до 40 символов.",
                    BoxMessage.ErrorCode);
                return false;
            }
            if (!InputChecker.IsValidAddress(address))
            {
                BoxMessage.ShowNativeMessageBox("Ошибка",
                    "Некорректный адрес. Допустимы буквы, цифры, пробел, дефис, точка, запятая, кавычки, амперсанд. Длина от 2 до 40 символов.",
                    BoxMessage.ErrorCode);
                return false;
            }
            if (purchases < 0 || products < 0 || avgCheck < 0)
            {
                BoxMessage.ShowNativeMessageBox("Ошибка",
                    "Количество покупок, количество товаров и средний чек не могут быть отрицательными.",
                    BoxMessage.ErrorCode);
                return false;
            }
            if (rating < 1 || rating > 5)
            {
                BoxMessage.ShowNativeMessageBox("Ошибка", "Рейтинг должен быть от 1 до 5.",
                    BoxMessage.ErrorCode);
                return false;
            }

            var newShop = new InternetShop(name, address, purchases, products, avgCheck, rating, isActive);
            _collection.Add(newShop);
            return true;
        }

        /// <summary>
        /// Удаляет магазин по индексу
        /// </summary>
        /// <param name="index">Индекс магазина в коллекции</param>
        /// <returns>true, если удаление выполнено; false, если магазин не найден</returns>
        public bool DeleteShop(int index)
        {
            var shop = _collection.GetAt(index);
            if (shop == null) return false;
            _collection.Remove(shop);
            return true;
        }

        /// <summary>
        /// Получает магазин по индексу
        /// </summary>
        /// <param name="index">Индекс магазина в коллекции</param>
        /// <returns>Объект магазина или null, если индекс некорректен</returns>
        public InternetShop? GetShop(int index)
        {
            return _collection.GetAt(index);
        }
    }
}