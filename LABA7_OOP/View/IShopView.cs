using Laba3_oop;
using LABA7_OOP.Model;
using System;
using System.Collections.Generic;

namespace LABA7_OOP.View
{
    public interface IShopView
    {
        /// <summary>
        /// Событие создания нового магазина
        /// </summary>
        event Action CreateShop;

        /// <summary>
        /// Событие удаления магазина
        /// </summary>
        event Action<int> DeleteShop;

        /// <summary>
        /// Событие выбора другого магазина
        /// </summary>
        event Action<int> SelectShop;

        /// <summary>
        /// Событие сброса полей ввода
        /// </summary>
        event Action ResetFields;

        /// <summary>
        /// Событие отображения информации о магазине
        /// </summary>
        event Action ShowInfo;

        /// <summary>
        /// Отображает подробную информацию о переданном магазине
        /// </summary>
        /// <param name="shop">Интернет-магазин</param>
        void DisplayShopInfo(InternetShop shop);

        /// <summary>
        /// Обновляет отображение списка всех магазинов
        /// </summary>
        /// <param name="shops">Список всех существующих магазинов</param>
        /// <param name="currentShop">Текущий выбранный магазин</param>
        void UpdateObjectsList(List<InternetShop> shops, InternetShop currentShop);

        /// <summary>
        /// Показывает пользователю информационное сообщение
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        /// <param name="isError">Признак ошибки</param>
        void ShowMessage(string text, bool isError = false);

        /// <summary>
        /// Очищает все поля ввода данных
        /// </summary>
        void ClearInputFields();

        /// <summary>
        /// Получает данные, введённые пользователем в поля ввода
        /// </summary>
        /// <returns>Кортеж, содержащий все характеристики интернет-магазина</returns>
        (string name, string address, int purchaseCount, int productCount, double averageCheck, 
            double rating, bool isActive) GetInputData();
    }
}