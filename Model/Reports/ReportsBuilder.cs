using System;
using System.Linq;

namespace Model
{
    /// <summary>
    /// Построитель отчетов
    /// </summary>
    public class ReportsBuilder
    {
        /// <summary>
        /// Формирование отчёта по свободным номерам на указанную дату
        /// </summary>
        /// <param name="hotel"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public Report GetEmptyRoomsByDate(Hotel hotel, DateTime date)
        {
            var report = new Report
                {
                    Caption = string.Format($"Список свободных номеров на {date.ToShortDateString()}")
                };
            report.ReportColumns.Add("Номер комнаты", "Примечание");
            // заполнение строк отчёта
            foreach (var room in hotel.Rooms.OrderBy(item => item.RoomNumber))
            {
                // подсчет занятых мест в номере для заданного диапазона
                var count = hotel.Reservations.Where(item => date >= item.ArrivalDate && date < item.DepartureDate.AddDays(1))
                                 .Count(item => item.IdRoom == room.IdRoom);
                if (room.NumberSeat - count ==  0) continue; // нет свободных мест
                var status = count != 0 ? string.Format($"ещё свободно мест: {room.NumberSeat - count}") : "";
                var category = hotel.Categories[room.IdCategory];
                report.ReportRows.Add($"{room.RoomNumber} ({category})", status);
            }
            return report;
        }

        /// <summary>
        /// Формирование отчёта по занятым номерам на указанную дату
        /// </summary>
        /// <param name="hotel"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public Report GetBusyRoomsByDate(Hotel hotel, DateTime date)
        {
            var report = new Report
            {
                Caption = string.Format($"Список занятых номеров на {date.ToShortDateString()}")
            };
            report.ReportColumns.Add("Номер комнаты", "Примечание");
            // заполнение строк отчёта
            foreach (var room in hotel.Reservations.Where(item => date >= item.ArrivalDate && date < item.DepartureDate.AddDays(1))
                                                   .Select(item => hotel.GetRoom(item.IdRoom))
                                                   .Distinct()
                                                   .OrderBy(item => item.RoomNumber))
            {
                // подсчет занятых мест в номере для заданного диапазона
                var count = hotel.Reservations.Where(item => date >= item.ArrivalDate && date < item.DepartureDate.AddDays(1))
                                 .Count(item => item.IdRoom == room.IdRoom);
                var status = room.NumberSeat - count != 0 ? string.Format($"ещё свободно мест: {room.NumberSeat - count}") : "";
                var category = hotel.Categories[room.IdCategory];
                report.ReportRows.Add($"{room.RoomNumber} ({category})", status);
            }
            return report;
        }

        /// <summary>
        /// Формирование отчёта по клиентам на указанную дату
        /// </summary>
        /// <param name="hotel"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public Report GetClientsByDate(Hotel hotel, DateTime date)
        {
            var report = new Report
            {
                Caption = string.Format($"Список постоятельцев на {date.ToShortDateString()}")
            };
            report.ReportColumns.Add("Фамилия клиента", "Номер комнаты");
            // заполнение строк отчёта
            foreach (var item in hotel.Reservations
                                      .Where(item => date >= item.ArrivalDate && date < item.DepartureDate.AddDays(1))
                                      .OrderBy(item => hotel.GetClient(item.IdClient).Surname))
            {
                var client = hotel.GetClient(item.IdClient);
                var room = hotel.GetRoom(item.IdRoom);
                var category = hotel.Categories[room.IdCategory];
                report.ReportRows.Add($"{client.Surname} {client.Name} {client.LastName}", $"{room.RoomNumber} ({category})");
            }
            return report;
        }

        /// <summary>
        /// Список постояльцев за последний месяц
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        public Report GetClientsByLastMonth(Hotel hotel)
        {
            var report = new Report
            {
                Caption = "Список постояльцев за последний месяц"
            };
            report.ReportColumns.Add("Фамилия клиента", "Номер комнаты", "Въезд", "Выезд");
            var last = DateTime.Now;
            var first = new DateTime(last.Year, last.Month, 1);
            // заполнение строк отчёта
            foreach (var item in hotel.Reservations
                                      .Where(item => item.ArrivalDate >= first && item.ArrivalDate <= last ||
                                                     item.DepartureDate >= first && item.DepartureDate <= last)
                                      .OrderBy(item => hotel.GetClient(item.IdClient).Surname))
            {
                var client = hotel.GetClient(item.IdClient);
                var room = hotel.GetRoom(item.IdRoom);
                var category = hotel.Categories[room.IdCategory];
                report.ReportRows.Add($"{client.Surname} {client.Name} {client.LastName}", $"{room.RoomNumber} ({category})", 
                                      item.ArrivalDate.ToShortDateString(), item.DepartureDate.ToShortDateString());
            }
            return report;
        }
    }
}
