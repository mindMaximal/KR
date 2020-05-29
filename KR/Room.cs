using System;
using System.Collections.Generic;
using System.Text;

namespace KR
{
    class Room
    {
        //Поле для хранения номера этажа
        private int floor;
        //Поле для хранения номера комнаты
        private int number;

        //Стандартный конструктор
        public Room(int floor, int number)
        {
            this.floor = floor;
            this.number = number;
        }

        //Метод возвращающий сформированную строку из полей класса
        public string FieldsToString()
        {
            return String.Format("Номер комнаты: {0}, Этаж: {1}", number, floor);
        }

        //Свойство возвращающее или устанавливающее номер этажа
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                floor = value;
            }
        }

        //Свойство возвращающее или устанавливающее номер комнаты
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
    }
}
