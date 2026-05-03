using LABA7_OOP.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LABA_5_tests
{
    [TestClass]
    public sealed class InternetShopTest
    {
        /// <summary>
        /// Проверка переопределенного метода ToString()
        /// </summary>
        [TestMethod]
        public void ToString_ShouldReturnFormattedString()
        {
            var shop = new InternetShop("Магазин", "Адрес", 5, 10, 200, 4.5, true);
            string result = shop.ToString();
            Assert.Contains("Интернет-магазин: Магазин", result);
            Assert.Contains("Адрес склада: Адрес", result);
            Assert.Contains("Количество покупок в сутки: 5", result);
            Assert.Contains("Количество товаров: 10", result);
            Assert.Contains("Средний чек: 200", result);
            Assert.Contains("Рейтинг: 4,5", result);
            Assert.Contains("Статус: Активен", result);
        }


        /// <summary>
        /// Тест работы метода ToString() после вызова конструктора по умолчанию
        /// </summary>
        [TestMethod]
        public void ToString_DefaultConstructor_ReturnsCorrectString()
        {
            InternetShop TestObject = new InternetShop();
            string expected = "Интернет-магазин: NoName\r\n" +
                "Адрес склада: NoAddress\r\n" +
                "Количество покупок в сутки: 0\r\n" +
                "Количество товаров: 0\r\n" +
                "Средний чек: 0,00 ₽\r\n" +
                "Рейтинг: 0,0\r\n" +
                "Статус: Неактивен";

            string actual = TestObject.ToString();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка работы конструктора по умолчанию
        /// </summary>
        [TestMethod]
        public void Constructor_Default_SetsDefaultValues()
        {
            InternetShop shop = new InternetShop();

            Assert.AreEqual("NoName", shop.Name);
            Assert.AreEqual("NoAddress", shop.Address);
            Assert.AreEqual(0, shop.PurchaseCount);
            Assert.AreEqual(0, shop.ProductCount);
            Assert.AreEqual(0.0, shop.AverageCheck);
            Assert.AreEqual(0.0, shop.Rating);
            Assert.IsFalse(shop.IsActive);

        }

        /// <summary>
        /// Проверка работы конструктора со всеми параметрами
        /// </summary>
        [TestMethod]
        public void Constructor_WithAllValues_SetsAllValues()
        {
            string testName = "Пятерочка";
            string testAddress = "Г. Пенза, ул. Тамбовская 9";
            int testPurchases = 500;
            int testProducts = 200;
            double testAvgCheck = 1057.8;
            double testRating = 5.0;
            bool testIsActive = true;

            InternetShop shop = new InternetShop(testName, testAddress, testPurchases, testProducts, testAvgCheck,
                testRating, testIsActive);

            Assert.AreEqual(testName, shop.Name);
            Assert.AreEqual(testAddress, shop.Address);
            Assert.AreEqual(testPurchases, shop.PurchaseCount);
            Assert.AreEqual(testProducts, shop.ProductCount);
            Assert.AreEqual(testAvgCheck, shop.AverageCheck);
            Assert.AreEqual(testRating, shop.Rating);
            Assert.IsTrue(shop.IsActive);
        }

        /// <summary>
        /// Тестирование корректной работы геттеров и сеттеров
        /// </summary>
        [TestMethod]
        public void Properties_SetAndGet_ReturnCorrectValues()
        {
            InternetShop shop = new InternetShop();

            shop.Name = "NewName";
            shop.Address = "NewAddress";
            shop.PurchaseCount = 42;
            shop.ProductCount = 100;
            shop.AverageCheck = 999.99;
            shop.Rating = 3.5;
            shop.IsActive = true;

            Assert.AreEqual("NewName", shop.Name);
            Assert.AreEqual("NewAddress", shop.Address);
            Assert.AreEqual(42, shop.PurchaseCount);
            Assert.AreEqual(100, shop.ProductCount);
            Assert.AreEqual(999.99, shop.AverageCheck);
            Assert.AreEqual(3.5, shop.Rating);
            Assert.IsTrue(shop.IsActive);
        }

    }
}
