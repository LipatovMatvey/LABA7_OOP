using System;
using LABA7_OOP.Model;
using LABA7_OOP.View;

namespace LABA7_OOP.Controller
{
    public class ShopController
    {
        /// <summary>
        /// Ссылка на модель приложения, содержащую данные и операции над магазинами
        /// </summary>
        private ShopModel model;

        /// <summary>
        /// Представление, через которое происходит взаимодействие с пользователем
        /// </summary>
        private IShopView view;

        /// <summary>
        /// Инициализирует контроллер, привязывает модель и представление, подписывает обработчики событий
        /// представления на локальные методы и выполняет первичную синхронизацию состояния в view
        /// </summary>
        /// <param name="model">Экземпляр модели приложения</param>
        /// <param name="view">Экземпляр представления</param>
        public ShopController(ShopModel model, IShopView view)
        {
            this.model = model;
            this.view = view;
            view.CreateShop += OnCreateShop;
            view.DeleteShop += OnDeleteShop;
            view.SelectShop += OnSelectShop;
            view.ResetFields += OnResetFields;
            view.ShowInfo += OnShowInfo;
            UpdateView();
        }

        /// <summary>
        /// Обработчик события создания магазина из представления
        /// </summary>
        private void OnCreateShop()
        {
            var data = view.GetInputData();
            if (model.TryCreateShop(data.name, data.address, data.purchaseCount, data.productCount,
                                    data.averageCheck, data.rating, data.isActive, out string error))
            {
                view.ShowMessage("Магазин успешно создан");
                UpdateView();
            }
            else
            {
                view.ShowMessage($"Ошибка: {error}", true);
            }
        }

        /// <summary>
        /// Обработчик события удаления магазина по индексу
        /// </summary>
        /// <param name="index">Индекс удаляемого магазина</param>
        private void OnDeleteShop(int index)
        {
            if (index >= 0 && index < model.Shops.Count)
            {
                model.DeleteShop(index);
                view.ShowMessage("Магазин удалён");
                UpdateView();
            }
            else
            {
                view.ShowMessage("Неверный индекс", true);
            }
        }

        /// <summary>
        /// Обработчик выбора текущего магазина по индексу
        /// </summary>
        /// <param name="index">Индекс выбираемого магазина</param>
        private void OnSelectShop(int index)
        {
            if (index >= 0 && index < model.Shops.Count)
            {
                model.SelectShop(index);
                UpdateView();
                view.ShowMessage($"Выбран магазин: {model.CurrentShop.Name}");
            }
            else
            {
                view.ShowMessage("Выберите магазин из списка", true);
            }
        }

        /// <summary>
        /// Обработчик сброса полей ввода во view
        /// </summary>
        private void OnResetFields()
        {
            view.ClearInputFields();
        }

        /// <summary>
        /// Обработчик запроса на показ информации о текущем магазине
        /// </summary>
        private void OnShowInfo()
        {
            if (model.CurrentShop != null)
            {
                view.DisplayShopInfo(model.CurrentShop);
            }
            else
            {
                view.ShowMessage("Нет созданных магазинов", true);
            }
        }

        /// <summary>
        /// Синхронизирует представление с текущим состоянием модели: обновляет список объектов
        /// и, при наличии, отображает информацию о текущем магазине
        /// </summary>
        private void UpdateView()
        {
            view.UpdateObjectsList(model.Shops, model.CurrentShop);
            if (model.CurrentShop != null)
            {
                view.DisplayShopInfo(model.CurrentShop);
            }
        }
    }
}