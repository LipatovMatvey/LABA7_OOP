namespace MVC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxObjects = new GroupBox();
            lblCurrentObject = new Label();
            cmbObjectsList = new ComboBox();
            btnDeleteObject = new Button();
            groupBoxStatus = new GroupBox();
            resetButton = new Button();
            button1 = new Button();
            groupBoxInput = new GroupBox();
            label9 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            numericUpDown2 = new NumericUpDown();
            label7 = new Label();
            numericUpDown3 = new NumericUpDown();
            label8 = new Label();
            numericUpDown4 = new NumericUpDown();
            lblObjectCount = new Label();
            panel1 = new Panel();
            label11 = new Label();
            label10 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBack = new Button();
            btnClear = new Button();
            btnShowInfo = new Button();
            groupBoxDisplay = new GroupBox();
            txtDisplayInfo = new TextBox();
            groupBoxObjects.SuspendLayout();
            groupBoxStatus.SuspendLayout();
            groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            panel1.SuspendLayout();
            groupBoxDisplay.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxObjects
            // 
            groupBoxObjects.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxObjects.Controls.Add(lblCurrentObject);
            groupBoxObjects.Controls.Add(cmbObjectsList);
            groupBoxObjects.Controls.Add(btnDeleteObject);
            groupBoxObjects.Font = new Font("Trebuchet MS", 9.75F);
            groupBoxObjects.Location = new Point(10, 419);
            groupBoxObjects.Margin = new Padding(3, 2, 3, 2);
            groupBoxObjects.Name = "groupBoxObjects";
            groupBoxObjects.Padding = new Padding(3, 2, 3, 2);
            groupBoxObjects.Size = new Size(293, 74);
            groupBoxObjects.TabIndex = 46;
            groupBoxObjects.TabStop = false;
            groupBoxObjects.Text = "Управление объектами";
            // 
            // lblCurrentObject
            // 
            lblCurrentObject.Anchor = AnchorStyles.None;
            lblCurrentObject.AutoSize = true;
            lblCurrentObject.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCurrentObject.ForeColor = Color.Black;
            lblCurrentObject.Location = new Point(6, 17);
            lblCurrentObject.Name = "lblCurrentObject";
            lblCurrentObject.Size = new Size(177, 18);
            lblCurrentObject.TabIndex = 0;
            lblCurrentObject.Text = "Текущий объект: не выбран";
            // 
            // cmbObjectsList
            // 
            cmbObjectsList.Anchor = AnchorStyles.None;
            cmbObjectsList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbObjectsList.FlatStyle = FlatStyle.Flat;
            cmbObjectsList.Font = new Font("Trebuchet MS", 9.75F);
            cmbObjectsList.FormattingEnabled = true;
            cmbObjectsList.Location = new Point(6, 37);
            cmbObjectsList.Margin = new Padding(3, 2, 3, 2);
            cmbObjectsList.Name = "cmbObjectsList";
            cmbObjectsList.Size = new Size(124, 26);
            cmbObjectsList.TabIndex = 1;
            // 
            // btnDeleteObject
            // 
            btnDeleteObject.Anchor = AnchorStyles.None;
            btnDeleteObject.BackColor = Color.White;
            btnDeleteObject.FlatStyle = FlatStyle.Flat;
            btnDeleteObject.Font = new Font("Trebuchet MS", 9.75F);
            btnDeleteObject.Location = new Point(163, 37);
            btnDeleteObject.Margin = new Padding(3, 2, 3, 2);
            btnDeleteObject.Name = "btnDeleteObject";
            btnDeleteObject.Size = new Size(124, 28);
            btnDeleteObject.TabIndex = 3;
            btnDeleteObject.Text = "Удалить";
            btnDeleteObject.UseVisualStyleBackColor = false;
            btnDeleteObject.Click += btnDeleteObject_Click;
            // 
            // groupBoxStatus
            // 
            groupBoxStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxStatus.Controls.Add(resetButton);
            groupBoxStatus.Controls.Add(button1);
            groupBoxStatus.Font = new Font("Trebuchet MS", 9.75F);
            groupBoxStatus.Location = new Point(10, 362);
            groupBoxStatus.Margin = new Padding(3, 2, 3, 2);
            groupBoxStatus.Name = "groupBoxStatus";
            groupBoxStatus.Padding = new Padding(3, 2, 3, 2);
            groupBoxStatus.Size = new Size(293, 52);
            groupBoxStatus.TabIndex = 45;
            groupBoxStatus.TabStop = false;
            groupBoxStatus.Text = "Управление";
            // 
            // resetButton
            // 
            resetButton.Anchor = AnchorStyles.None;
            resetButton.FlatStyle = FlatStyle.Flat;
            resetButton.Font = new Font("Trebuchet MS", 9.75F);
            resetButton.Location = new Point(163, 20);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(124, 28);
            resetButton.TabIndex = 17;
            resetButton.Text = "Сбросить поля";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Trebuchet MS", 9.75F);
            button1.Location = new Point(6, 20);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(124, 28);
            button1.TabIndex = 2;
            button1.Text = "Создать объект";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(label9);
            groupBoxInput.Controls.Add(label3);
            groupBoxInput.Controls.Add(comboBox1);
            groupBoxInput.Controls.Add(textBox1);
            groupBoxInput.Controls.Add(label4);
            groupBoxInput.Controls.Add(textBox2);
            groupBoxInput.Controls.Add(label5);
            groupBoxInput.Controls.Add(numericUpDown1);
            groupBoxInput.Controls.Add(label6);
            groupBoxInput.Controls.Add(numericUpDown2);
            groupBoxInput.Controls.Add(label7);
            groupBoxInput.Controls.Add(numericUpDown3);
            groupBoxInput.Controls.Add(label8);
            groupBoxInput.Controls.Add(numericUpDown4);
            groupBoxInput.Font = new Font("Trebuchet MS", 9.75F);
            groupBoxInput.Location = new Point(10, 103);
            groupBoxInput.Margin = new Padding(3, 2, 3, 2);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Padding = new Padding(3, 2, 3, 2);
            groupBoxInput.Size = new Size(293, 242);
            groupBoxInput.TabIndex = 44;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 9.75F);
            label9.Location = new Point(10, 214);
            label9.Name = "label9";
            label9.Size = new Size(112, 18);
            label9.TabIndex = 15;
            label9.Text = "Статус магазина:";
            // 
            // label3
            // 
            label3.Font = new Font("Trebuchet MS", 9.75F);
            label3.Location = new Point(11, 18);
            label3.Name = "label3";
            label3.Size = new Size(76, 35);
            label3.TabIndex = 4;
            label3.Text = "Название \nмагазина:";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Trebuchet MS", 9.75F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Активен", "Неактивен" });
            comboBox1.Location = new Point(131, 212);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(158, 26);
            comboBox1.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Trebuchet MS", 9.75F);
            textBox1.Location = new Point(131, 30);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 23);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.Font = new Font("Trebuchet MS", 9.75F);
            label4.Location = new Point(10, 53);
            label4.Name = "label4";
            label4.Size = new Size(112, 36);
            label4.TabIndex = 5;
            label4.Text = "Адрес склада магазина:";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Trebuchet MS", 9.75F);
            textBox2.Location = new Point(131, 66);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 23);
            textBox2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 9.75F);
            label5.Location = new Point(6, 102);
            label5.Name = "label5";
            label5.Size = new Size(100, 18);
            label5.TabIndex = 7;
            label5.Text = "Число покупок:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown1.Font = new Font("Trebuchet MS", 9.75F);
            numericUpDown1.Location = new Point(131, 97);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(158, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 9.75F);
            label6.Location = new Point(10, 120);
            label6.Name = "label6";
            label6.Size = new Size(77, 36);
            label6.TabIndex = 9;
            label6.Text = "Количество\r\nтоваров:";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown2.Font = new Font("Trebuchet MS", 9.75F);
            numericUpDown2.Location = new Point(131, 124);
            numericUpDown2.Margin = new Padding(3, 2, 3, 2);
            numericUpDown2.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(158, 23);
            numericUpDown2.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 9.75F);
            label7.Location = new Point(12, 156);
            label7.Name = "label7";
            label7.Size = new Size(89, 18);
            label7.TabIndex = 11;
            label7.Text = "Средний чек:";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown3.Font = new Font("Trebuchet MS", 9.75F);
            numericUpDown3.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown3.Location = new Point(131, 151);
            numericUpDown3.Margin = new Padding(3, 2, 3, 2);
            numericUpDown3.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(158, 23);
            numericUpDown3.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 9.75F);
            label8.Location = new Point(10, 188);
            label8.Name = "label8";
            label8.Size = new Size(120, 18);
            label8.TabIndex = 13;
            label8.Text = "Рейтинг магазина:";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown4.DecimalPlaces = 2;
            numericUpDown4.Font = new Font("Trebuchet MS", 9.75F);
            numericUpDown4.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown4.Location = new Point(131, 183);
            numericUpDown4.Margin = new Padding(3, 2, 3, 2);
            numericUpDown4.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(158, 23);
            numericUpDown4.TabIndex = 14;
            // 
            // lblObjectCount
            // 
            lblObjectCount.AutoSize = true;
            lblObjectCount.Font = new Font("Trebuchet MS", 9.75F);
            lblObjectCount.ForeColor = Color.Blue;
            lblObjectCount.Location = new Point(10, 83);
            lblObjectCount.Name = "lblObjectCount";
            lblObjectCount.Size = new Size(134, 18);
            lblObjectCount.TabIndex = 43;
            lblObjectCount.Text = "Создано объектов: 0";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            panel1.Location = new Point(-30, -16);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(845, 91);
            panel1.TabIndex = 42;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Trebuchet MS", 11.25F);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(481, 22);
            label11.Name = "label11";
            label11.Size = new Size(145, 20);
            label11.TabIndex = 3;
            label11.Text = "Тема: Паттерн MVC";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 11.25F);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(1126, 4);
            label10.Name = "label10";
            label10.Size = new Size(145, 20);
            label10.TabIndex = 2;
            label10.Text = "Тема: Паттерн MVC";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 11.25F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(1893, 8);
            label2.Name = "label2";
            label2.Size = new Size(226, 20);
            label2.TabIndex = 1;
            label2.Text = "Тема: Порождающие паттерны";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Trebuchet MS", 11.25F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(32, 22);
            label1.Name = "label1";
            label1.Size = new Size(254, 60);
            label1.TabIndex = 0;
            label1.Text = "Лабораторная работа №7\r\nСтуденты: Липатов М. Кузнецов Н.\r\nГруппа: 24ВП2";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBack.BackColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Trebuchet MS", 9.75F);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(648, 465);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(124, 28);
            btnBack.TabIndex = 49;
            btnBack.Text = "Выход";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Trebuchet MS", 9.75F);
            btnClear.Location = new Point(648, 366);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 28);
            btnClear.TabIndex = 50;
            btnClear.Text = "Очистить";
            btnClear.Click += btnClear_Click;
            // 
            // btnShowInfo
            // 
            btnShowInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnShowInfo.FlatStyle = FlatStyle.Flat;
            btnShowInfo.Font = new Font("Trebuchet MS", 9.75F);
            btnShowInfo.Location = new Point(430, 366);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(124, 28);
            btnShowInfo.TabIndex = 51;
            btnShowInfo.Text = "Показать данные";
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // groupBoxDisplay
            // 
            groupBoxDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxDisplay.Controls.Add(txtDisplayInfo);
            groupBoxDisplay.Font = new Font("Trebuchet MS", 9.75F);
            groupBoxDisplay.Location = new Point(427, 103);
            groupBoxDisplay.Margin = new Padding(3, 2, 3, 2);
            groupBoxDisplay.Name = "groupBoxDisplay";
            groupBoxDisplay.Padding = new Padding(3, 2, 3, 2);
            groupBoxDisplay.Size = new Size(348, 258);
            groupBoxDisplay.TabIndex = 48;
            groupBoxDisplay.TabStop = false;
            groupBoxDisplay.Text = "Информация об интернет-магазине";
            // 
            // txtDisplayInfo
            // 
            txtDisplayInfo.Dock = DockStyle.Fill;
            txtDisplayInfo.Font = new Font("Consolas", 10F);
            txtDisplayInfo.Location = new Point(3, 18);
            txtDisplayInfo.Margin = new Padding(3, 2, 3, 2);
            txtDisplayInfo.Multiline = true;
            txtDisplayInfo.Name = "txtDisplayInfo";
            txtDisplayInfo.ReadOnly = true;
            txtDisplayInfo.ScrollBars = ScrollBars.Vertical;
            txtDisplayInfo.Size = new Size(342, 238);
            txtDisplayInfo.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 504);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnShowInfo);
            Controls.Add(groupBoxDisplay);
            Controls.Add(groupBoxObjects);
            Controls.Add(groupBoxStatus);
            Controls.Add(groupBoxInput);
            Controls.Add(lblObjectCount);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Лабораторная работа №7 Вариант 11";
            groupBoxObjects.ResumeLayout(false);
            groupBoxObjects.PerformLayout();
            groupBoxStatus.ResumeLayout(false);
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxDisplay.ResumeLayout(false);
            groupBoxDisplay.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxObjects;
        private Label lblCurrentObject;
        private ComboBox cmbObjectsList;
        private Button btnDeleteObject;
        private GroupBox groupBoxStatus;
        private Button resetButton;
        private Button button1;
        private GroupBox groupBoxInput;
        private Label label9;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private NumericUpDown numericUpDown2;
        private Label label7;
        private NumericUpDown numericUpDown3;
        private Label label8;
        private NumericUpDown numericUpDown4;
        private Label lblObjectCount;
        private Panel panel1;
        private Label label10;
        private Label label2;
        private Label label1;
        private Label label11;
        private Button btnBack;
        private Button btnClear;
        private Button btnShowInfo;
        private GroupBox groupBoxDisplay;
        private TextBox txtDisplayInfo;
    }
}
