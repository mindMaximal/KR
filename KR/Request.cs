using System;

namespace KR
{
    class Request
    {
        //Поле для хранения объекта комнаты
        private Room room;
        //Поле для хранения объекта организации
        private Organization org;
        //Поле для хранения даты прибытия
        private DateTime dateArrival;
        //Поле для хранения даты убытия
        private DateTime dateDeparture;
        //Поле для хранения количества мест
        private int count;

        public Request(Room room, Organization org, DateTime dateArrival, DateTime dateDeparture, int count)
        {
            this.room = room;
            this.org = org;
            this.dateArrival = dateArrival;
            this.dateDeparture = dateDeparture;
            this.count = count;
        }

        //Метод возвращающий сформированную строку из полей класса
        public string FieldsToString()
        {
            return String.Format("Комната: {0}, Организация: {1}, Дата прибытия: {2}, Дата убытия: {3}, Количество мест: {4}", room.Number, org.Name, dateArrival.ToShortDateString(), dateDeparture.ToShortDateString(), count);
        }

        //Метод возвращающий или устанавливающий название организации
        public Room Room
        {
            get
            {
                return room;
            }
            set
            {
                room = value;
            }
        }

        //Метод возвращающий или устанавливающий название организации
        public Organization Organization
        {
            get
            {
                return org;
            }
            set
            {
                org = value;
            }
        }

        //Метод возвращающий или устанавливающий название организации
        public DateTime Arrival
        {
            get
            {
                return dateArrival;
            }
            set
            {
                dateArrival = value;
            }
        }

        //Метод возвращающий или устанавливающий дату  убытия
        public DateTime Departure
        {
            get
            {
                return dateDeparture;
            }
            set
            {
                dateDeparture = value;
            }
        }

        //Метод возвращающий или устанавливающий количество мест
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
    }
}
