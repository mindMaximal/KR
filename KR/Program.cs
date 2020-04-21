using System;

namespace KR
{
    class Program
    {
        static void Main(string[] args)
        {
            //Массив для записи всех номеров
            Room[] rooms = new Room[5];
            int floor = 1;

            //Массив для записи всех организация
            Organization[] orgs = new Organization[5];

            //Массив для записи всех заявок
            Request[] requests = new Request[5];

            //Необходима для вывода результата работы программы
            string result;

            for (int i = 0; i < rooms.Length; i++)
            {
                //Через каждые 10 комнат повышаем этаж
                if (i % 10 == 0 && i != 0)
                {
                    floor++;
                }

                //Добавляем новую комнату
                rooms[i] = new Room(floor, i + 1);
            }

            //Создадим новые организации
            orgs[0] = new Organization("App promo", "Захарова Я. Ф.", "+7(742)965-39-79");
            orgs[1] = new Organization("Comglobal", "Линников О. В.", "+7(6868)611-04-20");
            orgs[2] = new Organization("Casa with me", "Посидайло Н. В.", "+7(3238)180-87-66");
            orgs[3] = new Organization("Tag line", "Абрамов Б. А.", "+7(3754)327-33-00");
            orgs[4] = new Organization("Home London", "Герасимов Я. В.", "+7(3891)213-38-47");

            //Созданим новые заявки
            requests[0] = new Request(rooms[0], orgs[0], new DateTime(2020, 4, 20), new DateTime(2020, 4, 25), 5);
            requests[1] = new Request(rooms[1], orgs[1], new DateTime(2020, 3, 1), new DateTime(2020, 3, 22), 7);
            requests[2] = new Request(rooms[2], orgs[2], new DateTime(2020, 6, 15), new DateTime(2020, 6, 17), 10);
            requests[3] = new Request(rooms[3], orgs[3], new DateTime(2020, 3, 4), new DateTime(2020, 3, 18), 8);
            requests[4] = new Request(rooms[4], orgs[4], new DateTime(2020, 1, 7), new DateTime(2020, 1, 8), 2);

            //Выведем в консоль результат
            result = "Комната\tЭтаж\tОрганизация\tФИО\t                Номер телефона\t        Дата прибытия\tДата убытия\tМест\r\n";

            for (int i = 0; i < requests.Length; i++)
            {
                result += "\r\n";
                result += String.Format("{0}\t{1}\t{2}\t{3, -20}\t{4}\t{5}\t{6}\t{7}", requests[i].Room.Number, requests[i].Room.Floor, requests[i].Organization.Name, requests[i].Organization.Fullname, requests[i].Organization.Phone, requests[i].Arrival.ToShortDateString(), requests[i].Departure.ToShortDateString(), requests[i].Count);
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
