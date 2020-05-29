using System;
using System.Collections.Generic;
using System.Text;

namespace KR
{
    class Organization
    {
        //Поле для хранения названия организации
        private string name;
        //Поле для хранения ФИО исполнителя
        private string fullname;
        //Поля для хранения телефона
        private string phone;

        //Стандартный конструктор
        public Organization(string name, string fullname, string phone)
        {
            this.name = name;
            this.fullname = fullname;
            this.phone = phone;
        }

        //Метод возвращающий сформированную строку из полей класса
        public string FieldsToString()
        {
            return String.Format("Название организации: {0}, ФИО: {1}, Телефон: {2}", name, fullname, phone);
        }

        //Свойство возвращающее или устанавливающее организации
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //Свойство возвращающее или устанавливающее ФИО исполнителя
        public string Fullname
        {
            get
            {
                return fullname;
            }
            set
            {
                fullname = value;
            }
        }

        //Свойство возвращающее или устанавливающее телефона
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
    }
}
