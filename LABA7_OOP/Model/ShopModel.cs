using System.Collections.Generic;
using Laba3_oop;

namespace LABA7_OOP.Model
{
    public class ShopModel
    {
        /// <summary>
        /// Список интернет-магазинов, хранимый в модели
        /// </summary>
        private List<InternetShop> shops = new List<InternetShop>();

        /// <summary>
        /// Текущий выбранный магазин
        /// </summary>
        private InternetShop? currentShop = null;

        /// <summary>
        /// Возвращает список магазинов, управляемый моделью
        /// </summary>
        public List<InternetShop> Shops => shops;

        /// <summary>
        /// Возвращает текущий выбранный магазин
        /// </summary>
        public InternetShop? CurrentShop => currentShop;

        /// <summary>
        /// Пытается создать новый интернет-магазин и добавить его в модель после проверки входных данных
        /// </summary>
        /// <param name="name">Имя магазина</param>
        /// <param name="address">Адрес магазина</param>
        /// <param name="purchaseCount">Количество покупок</param>
        /// <param name="productCount">Количество товаров в магазине</param>
        /// <param name="averageCheck">Средний чек магазина</param>
        /// <param name="rating">Рейтинг магазина</param>
        /// <param name="isActive">Признак активности магазина</param>
        /// <param name="errorMessage">Выходное сообщение с описанием ошибки при неудаче</param>
        /// <returns>True, если магазин успешно создан и добавлен; иначе false</returns>
        public bool TryCreateShop(string name, string address, int purchaseCount, int productCount,
                                  double averageCheck, double rating, bool isActive, out string errorMessage)
        {
            if (!InputChecker.IsValidShopName(name))
            {
                errorMessage = "Некорректное имя магазина";
                return false;
            }
            if (!InputChecker.IsValidAddress(address))
            {
                errorMessage = "Некорректный адрес";
                return false;
            }
            if (purchaseCount < 0 || productCount < 0 || averageCheck < 0 || rating < 0)
            {
                errorMessage = "Значения не могут быть отрицательными";
                return false;
            }
            var shop = new InternetShop(name, address, purchaseCount, productCount, averageCheck, rating, isActive);
            shops.Add(shop);
            currentShop = shop;
            errorMessage = string.Empty;
            return true;
        }

        /// <summary>
        /// Удаляет магазин по указанному индексу
        /// </summary>
        /// <param name="index">Индекс удаляемого магазина в списке</param>
        public void DeleteShop(int index)
        {
            if (index >= 0 && index < shops.Count)
            {
                bool isCurrentDeleted = (shops[index] == currentShop);
                shops.RemoveAt(index);
                if (shops.Count == 0)
                {
                    currentShop = null;
                }
                else if (isCurrentDeleted)
                {
                    currentShop = shops[0];
                }
            }
        }

        /// <summary>
        /// Устанавливает текущий магазин по указанному индексу, если индекс корректен
        /// </summary>
        /// <param name="index">Индекс магазина в списке</param>
        public void SelectShop(int index)
        {
            if (index >= 0 && index < shops.Count)
            {
                currentShop = shops[index];
            }
        }
    }
}