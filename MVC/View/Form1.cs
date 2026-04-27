using Laba3_oop;
using LABA7_OOP.Model;
using MVC.Controller;
using MVC.Model;
using System;
using System.Windows.Forms;

namespace MVC
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Коллекция интернет-магазинов
        /// </summary>
        private InternetShopCollection _collection;

        /// <summary>
        /// Контроллер для обработки действий пользователя
        /// </summary>
        private FormController _controller;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        /// <param name="collection">Коллекция магазинов, с которой работает форма</param>
        public Form1(InternetShopCollection collection)
        {
            InitializeComponent();
            _collection = collection;
            _controller = new FormController(_collection);
            _collection.CollectionChanged += UpdateShopList;
            UpdateShopList();
            UpdateCurrentObjectLabel();
            cmbObjectsList.SelectedIndexChanged += (s, e) => UpdateCurrentObjectLabel();
        }

        /// <summary>
        /// Обновляет список магазинов в выпадающем списке и счётчик объектов
        /// </summary>
        private void UpdateShopList()
        {
            cmbObjectsList.DataSource = null;
            cmbObjectsList.DataSource = _collection.GetAll();
            cmbObjectsList.DisplayMember = "Name";
            lblObjectCount.Text = $"Создано объектов: {_collection.Count}";
        }

        /// <summary>
        /// Обновляет метку с информацией о текущем выбранном объекте
        /// </summary>
        private void UpdateCurrentObjectLabel()
        {
            if (cmbObjectsList.SelectedItem is InternetShop shop)
            {

            }
            else
            {
                lblCurrentObject.Text = "Текущий объект: не выбран";
            }
        }

        /// <summary>
        /// Обработчик кнопки создания нового магазина
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Аргументы события</param>
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string address = textBox2.Text;
            int purchases = (int)numericUpDown1.Value;
            int products = (int)numericUpDown2.Value;
            double avgCheck = (double)numericUpDown3.Value;
            double rating = (double)numericUpDown4.Value;
            bool isActive = comboBox1.SelectedItem?.ToString() == "Активен";
            bool success = _controller.CreateShop(name, address, purchases, products, avgCheck, rating, isActive);
            if (success)
            {
                BoxMessage.ShowNativeMessageBox("Успех", "Объект успешно создан.", BoxMessage.InfoCode);
            }
        }

        /// <summary>
        /// Обработчик кнопки удаления выбранного магазина
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Аргументы события</param>
        private void btnDeleteObject_Click(object sender, EventArgs e)
        {
            int index = cmbObjectsList.SelectedIndex;
            if (index < 0)
            {
                BoxMessage.ShowNativeMessageBox("Ошибка", "Не выбран объект для удаления.", BoxMessage.ErrorCode);
                return;
            }
            bool success = _controller.DeleteShop(index);
            if (success)
            {
                BoxMessage.ShowNativeMessageBox("Успех", "Объект удалён.", BoxMessage.InfoCode);
                ClearInfoDisplay();
            }
        }

        /// <summary>
        /// Обработчик кнопки показа информации о выбранном магазине
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Аргументы события</param>
        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            int index = cmbObjectsList.SelectedIndex;
            if (index < 0)
            {
                BoxMessage.ShowNativeMessageBox("Ошибка", "Не выбран объект для просмотра.", BoxMessage.ErrorCode);
                return;
            }
            var shop = _controller.GetShop(index);
            if (shop != null)
                txtDisplayInfo.Text = shop.ToString();
        }

        /// <summary>
        /// Обработчик кнопки очистки области вывода информации
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Аргументы события</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInfoDisplay();
        }

        /// <summary>
        /// Обработчик кнопки выхода
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Аргументы события</param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Обработчик кнопки сброса полей ввода
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Аргументы события</param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            comboBox1.SelectedIndex = 0;
        }

        /// <summary>
        /// Очищает текстовое поле отображения информации
        /// </summary>
        private void ClearInfoDisplay()
        {
            txtDisplayInfo.Clear();
        }
    }
}