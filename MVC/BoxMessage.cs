using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Laba3_oop
{
    internal abstract class BoxMessage
    {
        /// <summary>
        /// Код успешного завершения операции для отображения в MessageBox
        /// </summary>
        static public uint SuccessCode { get; set; } = 0;

        // <summary>
        /// Код успешного завершения операции для отображения в MessageBox
        /// </summary>
        static public uint ConfirmCode { get; set; } = 4;

        /// <summary>
        /// Код для иформационного окна
        /// </summary>
        static public uint InfoCode { get; set; } = 0x40;

        /// <summary>
        /// Код ошибки для отображения в MessageBox
        /// </summary>
        static public uint ErrorCode { get; set; } = 16;

        /// <summary>
        /// Импорт функции MessageBox из библиотеки user32.dll
        /// </summary>
        /// <param name="hWnd">Дескриптор родительского окна</param>
        /// <param name="text">Текст сообщения, отображаемый в окне</param>
        /// <param name="caption">Заголовок окна сообщения</param>
        /// <param name="type">Тип сообщения</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        /// <summary>
        /// Обертка для вызова нативного MessageBox
        /// </summary>
        /// <param name="caption">Заголовок окна</param>
        /// <param name="text">Текст сообщения</param>
        /// <param name="type">Тип сообщения</param>
        /// <returns></returns>
        public static int ShowNativeMessageBox(string caption, string text, uint type)
        {
            return MessageBox(IntPtr.Zero, text, caption, type);
        }
    }
}
