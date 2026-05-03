using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Laba3_oop
{
    public abstract class InputChecker
    {
        /// <summary>
        /// Регулярное выражение для проверки на корректность ввода имени магазина
        /// </summary>
        private static readonly string _shopNamePattern = @"^(?!\d+$)(?!.*\s{2})[A-Za-zА-Яа-яЁё0-9&""' -/]{2,40}$";

        /// <summary>
        /// Регулярное выражение для проверки на корректность ввода адреса
        /// </summary>
        private static readonly string _addressPattern = @"^(?!\d+$)(?!.*\s{2})[A-Za-zА-Яа-яЁё0-9&""'., -/]{2,40}$";

        /// <summary>
        /// Проверяет корректность имени магазина
        /// </summary>
        /// <param name="name">Имя для проверки</param>
        /// <returns>true если имя корректно, иначе false</returns>
        public static bool IsValidShopName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            return Regex.IsMatch(name, _shopNamePattern);
        }

        /// <summary>
        /// Проверяет корректность адреса склада магазина
        /// </summary>
        /// <param name="address">Адрес для проверки</param>
        /// <returns>true если адрес корректен, иначе false</returns>
        public static bool IsValidAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address)) return false;

            return Regex.IsMatch(address, _addressPattern);
        }
    }
}
