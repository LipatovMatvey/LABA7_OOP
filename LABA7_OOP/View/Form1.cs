using Laba3_oop;
using LABA7_OOP.Controller;
using LABA7_OOP.Model;
using LABA7_OOP.View;

namespace LABA7_OOP
{
    public partial class Form1 : Form, IShopView
    {
        public event Action CreateShop;
        public event Action<int> DeleteShop;
        public event Action<int> SelectShop;
        public event Action ResetFields;
        public event Action ShowInfo;

        /// <summary>
        /// Конструктор
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            button1.Click += (s, e) => CreateShop?.Invoke();
            resetButton.Click += (s, e) => ResetFields?.Invoke();
            btnDeleteObject.Click += (s, e) => DeleteShop?.Invoke(cmbObjectsList.SelectedIndex);
            cmbObjectsList.SelectionChangeCommitted += (s, e) => SelectShop?.Invoke(cmbObjectsList.SelectedIndex);
            btnShowInfo.Click += (s, e) => ShowInfo?.Invoke();
            var model = new ShopModel();
            var controller = new ShopController(model, this);
        }

        public (string name, string address, int purchaseCount, int productCount, 
            double averageCheck, double rating, bool isActive) GetInputData()
        {
            return (
                textBox1.Text.Trim(),
                textBox2.Text.Trim(),
                (int)numericUpDown1.Value,
                (int)numericUpDown2.Value,
                (double)numericUpDown3.Value,
                (double)numericUpDown4.Value,
                comboBox1.SelectedIndex == 0
            );
        }

        public void DisplayShopInfo(InternetShop shop)
        {
            if (shop == null) return;
            txtDisplayInfo.Text = shop.ToString();
        }

        public void UpdateObjectsList(List<InternetShop> shops, InternetShop currentShop)
        {
            cmbObjectsList.Items.Clear();
            for (int i = 0; i < shops.Count; i++)
            {
                string display = $"{i + 1}. {shops[i].Name}";
                if (shops[i] == currentShop)
                    display += " (текущий)";
                cmbObjectsList.Items.Add(display);
            }
            if (currentShop != null)
                cmbObjectsList.SelectedIndex = shops.IndexOf(currentShop);
            else if (cmbObjectsList.Items.Count > 0)
                cmbObjectsList.SelectedIndex = -1;

            lblObjectCount.Text = $"Создано объектов: {shops.Count}";
            lblCurrentObject.Text = currentShop != null ? $"Текущий объект: {currentShop.Name}" : "Текущий объект: не выбран";
        }

        public void ShowMessage(string text, bool isError = false)
        {
            uint type = isError ? BoxMessage.ErrorCode : BoxMessage.SuccessCode;
            BoxMessage.ShowNativeMessageBox(isError ? "Ошибка" : "Информация", text, type);
        }

        public void ClearInputFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            comboBox1.SelectedIndex = -1;
        }
           
        /// <summary>
        /// Обработчик нажатия кнопки "Закрыть"
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Аргументы события</param>
        private void BtnBack(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Обработчик нажатия кнопки очистки текстового поля с информацией
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Аргументы события</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplayInfo.Clear();
        }
    }
}