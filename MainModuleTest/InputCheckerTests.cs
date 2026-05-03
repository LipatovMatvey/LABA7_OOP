using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba3_oop;

namespace LABA_5_tests
{
    [TestClass]
    public sealed class InputCheckerTests
    {
        [TestMethod]
        public void IsValidShopName_ValidNames_ReturnsTrue()
        {
            string[] validNames =
            {
                "Магазин",
                "Shop 1",
                "Торговый центр 24/7",
                "Книжный-магазин"
            };
            foreach (var name in validNames)
            {
                bool result = InputChecker.IsValidShopName(name);
                Assert.IsTrue(result, $"Имя '{name}' должно быть корректным.");
            }
        }

        [TestMethod]
        public void IsValidShopName_InvalidNames_ReturnsFalse()
        {
            string[] invalidNames =
            {
                "A",                
                "123",            
                "  Пробелы  ",     
            };
            foreach (var name in invalidNames)
            {
                bool result = InputChecker.IsValidShopName(name);
                Assert.IsFalse(result, $"Имя '{name}' должно быть некорректным.");
            }
        }

        [TestMethod]
        public void IsValidShopAddress_ValidAdresses_ReturnsTrue()
        {
            string[] validAddresses =
            {
                "ул. Красная 40/21",
                "г. Пенза, ул. Московская, 73",
                "Корректный пример 45",
                "Луговая 7"
            };
            foreach (var address in validAddresses)
            {
                bool result = InputChecker.IsValidAddress(address);
                Assert.IsTrue(result, $"Имя '{address}' должно быть корректным.");
            }
        }

    }
}
