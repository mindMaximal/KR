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

        //Метод возвращающий или устанавливающий название организации
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

        //Метод возвращающий или устанавливающий ФИО исполнителя
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

        //Метод возвращающий или устанавливающий телефона
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
