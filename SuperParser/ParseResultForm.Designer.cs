
namespace SuperParser
{
    partial class ParseResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CompanyNameNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IndexCompany = new System.Windows.Forms.TextBox();
            this.AddVacancy = new System.Windows.Forms.Button();
            this.TypeContact = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.СontactTextBox = new System.Windows.Forms.TextBox();
            this.CategoryVacancy = new System.Windows.Forms.ComboBox();
            this.labelCompany = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CompanyNameNumber
            // 
            this.CompanyNameNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyNameNumber.Location = new System.Drawing.Point(229, 11);
            this.CompanyNameNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CompanyNameNumber.Name = "CompanyNameNumber";
            this.CompanyNameNumber.Size = new System.Drawing.Size(197, 30);
            this.CompanyNameNumber.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 30);
            this.label3.TabIndex = 27;
            this.label3.Text = "Номер компании";
            // 
            // IndexCompany
            // 
            this.IndexCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IndexCompany.Location = new System.Drawing.Point(288, 137);
            this.IndexCompany.Name = "IndexCompany";
            this.IndexCompany.Size = new System.Drawing.Size(166, 27);
            this.IndexCompany.TabIndex = 26;
            // 
            // AddVacancy
            // 
            this.AddVacancy.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddVacancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddVacancy.Location = new System.Drawing.Point(459, 132);
            this.AddVacancy.Margin = new System.Windows.Forms.Padding(2);
            this.AddVacancy.Name = "AddVacancy";
            this.AddVacancy.Size = new System.Drawing.Size(172, 32);
            this.AddVacancy.TabIndex = 25;
            this.AddVacancy.Text = "Добавить на портал";
            this.AddVacancy.UseVisualStyleBackColor = true;
            this.AddVacancy.Click += new System.EventHandler(this.StartParsingButton_Click);
            // 
            // TypeContact
            // 
            this.TypeContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeContact.FormattingEnabled = true;
            this.TypeContact.Items.AddRange(new object[] {
            "Телефон",
            "Email",
            "Skype",
            "Сайт",
            "Другое"});
            this.TypeContact.Location = new System.Drawing.Point(161, 100);
            this.TypeContact.Name = "TypeContact";
            this.TypeContact.Size = new System.Drawing.Size(87, 26);
            this.TypeContact.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = "Контакты";
            // 
            // СontactTextBox
            // 
            this.СontactTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.СontactTextBox.Location = new System.Drawing.Point(288, 99);
            this.СontactTextBox.Name = "СontactTextBox";
            this.СontactTextBox.Size = new System.Drawing.Size(166, 27);
            this.СontactTextBox.TabIndex = 22;
            // 
            // CategoryVacancy
            // 
            this.CategoryVacancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryVacancy.FormattingEnabled = true;
            this.CategoryVacancy.Items.AddRange(new object[] {
            "20 Банки/Финансы/Лизинг",
            "21 Бухгалтерия/Финансы предприятия",
            "22 Временная работа/Подработка/Без опыта",
            "23 Дизайн/Графика",
            "24 Домашний персонал",
            "25 Другие специальности",
            "26 Издательства/Полиграфия/Печать",
            "27 Инженеры/Конструкторы/Технологи",
            "29 Культура и искусство/Развлечения",
            "30 Курьеры/Распространители",
            "31 Маркетинг/PR/Реклама",
            "32 Медицина/Фармацевтика",
            "33 Образование/Наука/Перевод",
            "34 Обслуживание/Бытовые услуги",
            "35 Офисный персонал",
            "36 Охотничье-рыболовное хозяйство",
            "37 Охрана/Безопасность",
            "19 Программирование/Интернет/IT",
            "38 Работа для студентов",
            "39 Рабочие специальности",
            "40 Руководство/ТОП-менеджмент",
            "41 СМИ/Массмедиа",
            "42 Страхование",
            "43 Строительство/Недвижимость/Архитектура",
            "44 Торговля/Снабжение/Продажи",
            "45 Транспорт/Логистика/Автосервис",
            "46 Туризм/Гостиницы/Рестораны/Общепит",
            "47 Управление персоналом",
            "48 Физкультура и спорт",
            "49 Юристы/Адвокаты/Нотариусы"});
            this.CategoryVacancy.Location = new System.Drawing.Point(16, 62);
            this.CategoryVacancy.Name = "CategoryVacancy";
            this.CategoryVacancy.Size = new System.Drawing.Size(439, 26);
            this.CategoryVacancy.TabIndex = 21;
            // 
            // labelCompany
            // 
            this.labelCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCompany.Location = new System.Drawing.Point(15, 11);
            this.labelCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(197, 30);
            this.labelCompany.TabIndex = 19;
            this.labelCompany.Text = "Текущая компания";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(459, 60);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Выбрать компанию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SetCompanyButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(16, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 32);
            this.button2.TabIndex = 29;
            this.button2.Text = "Смена пароля";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(288, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 27);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "Логин";
            this.textBox1.Visible = false;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(459, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 27);
            this.textBox2.TabIndex = 31;
            this.textBox2.Text = "Пароль";
            this.textBox2.Visible = false;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(166, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 32);
            this.button3.TabIndex = 32;
            this.button3.Text = "Подтвердить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ParseResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 207);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CompanyNameNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IndexCompany);
            this.Controls.Add(this.AddVacancy);
            this.Controls.Add(this.TypeContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.СontactTextBox);
            this.Controls.Add(this.CategoryVacancy);
            this.Controls.Add(this.labelCompany);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ParseResultForm";
            this.Text = "ParseResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompanyNameNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IndexCompany;
        private System.Windows.Forms.Button AddVacancy;
        private System.Windows.Forms.ComboBox TypeContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox СontactTextBox;
        private System.Windows.Forms.ComboBox CategoryVacancy;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
    }
}