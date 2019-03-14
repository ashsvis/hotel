using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data;
using System.Linq;
using System;

namespace Model
{
    /// <summary>
    /// Класс поддержки чтения/записи конфигурации в файл на локальном диске
    /// </summary>
    public static class SaverLoader
    {
        /// <summary>
        /// Метод загрузки сохранённой ранее конфигурации из локального файла
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static Hotel LoadFromFile(string fileName)
        {
            using (var fs = File.OpenRead(fileName))
            using (var zip = new GZipStream(fs, CompressionMode.Decompress))
            {
                var formatter = new BinaryFormatter();
                var hotel = (Hotel)formatter.Deserialize(zip);
                return hotel;
            }
        }

        /// <summary>
        /// Метод сохранения конфигурации в файл на локальном диске
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="hotel"></param>
        public static void SaveToFile(string fileName, Hotel hotel)
        {
            using (var fs = File.Create(fileName))
            using (var zip = new GZipStream(fs, CompressionMode.Compress))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(zip, hotel);
            }
        }

        public static Hotel LoadFromBase(string connection)
        {
            var hotel = new Hotel();
            var server = new Database.SqlServer { Connection = connection };
            // категории
            var dataSet = server.GetRows("Categories");
            foreach (var row in dataSet.Tables[0].Rows.Cast<DataRow>())
            {
                if (row.ItemArray.Length != 2) continue;
                hotel.Categories.Add(Guid.Parse(row.ItemArray[0].ToString()), 
                    row.ItemArray[1].ToString());
            }
            // услуги
            dataSet = server.GetRows("Services");
            foreach (var row in dataSet.Tables[0].Rows.Cast<DataRow>())
            {
                if (row.ItemArray.Length != 3) continue;
                hotel.Services.Add(Guid.Parse(row.ItemArray[0].ToString()), 
                    row.ItemArray[1].ToString(), 
                    decimal.Parse(row.ItemArray[2].ToString()));
            }
            // комнаты
            dataSet = server.GetRows("Rooms");
            foreach (var row in dataSet.Tables[0].Rows.Cast<DataRow>())
            {
                if (row.ItemArray.Length != 6) continue;
                hotel.Rooms.Add(Guid.Parse(row.ItemArray[0].ToString()),
                    Guid.Parse(row.ItemArray[1].ToString()),
                    int.Parse(row.ItemArray[2].ToString()),
                    int.Parse(row.ItemArray[3].ToString()),
                    decimal.Parse(row.ItemArray[4].ToString()),
                    row.ItemArray[5].ToString());
            }
            //TODO: подписка на услуги (галочки)!
            // должности
            dataSet = server.GetRows("EmployeeRoles");
            foreach (var row in dataSet.Tables[0].Rows.Cast<DataRow>())
            {
                if (row.ItemArray.Length != 4) continue;
                AllowedOperations allop;
                var allow = row.ItemArray[3].ToString();
                switch (allow)
                {
                    case "All":
                        allop = AllowedOperations.All;
                        break;
                    case "None":
                        allop = AllowedOperations.None;
                        break;
                    default:
                        allop = (AllowedOperations)uint.Parse(allow);
                        break;
                }
                hotel.EmployeeRoles.Add(Guid.Parse(row.ItemArray[0].ToString()),
                    row.ItemArray[1].ToString(),
                    decimal.Parse(row.ItemArray[2].ToString()), allop);
            }
            // штат сотрудников
            dataSet = server.GetRows("RegistryStaff");
            foreach (var row in dataSet.Tables[0].Rows.Cast<DataRow>())
            {
                if (row.ItemArray.Length != 6) continue;
                hotel.RegistryStaff.Add(Guid.Parse(row.ItemArray[0].ToString()),
                    row.ItemArray[1].ToString(),
                    row.ItemArray[2].ToString(),
                    row.ItemArray[3].ToString(),
                    row.ItemArray[4].ToString(),
                    Guid.Parse(row.ItemArray[5].ToString()));
            }
            // клиенты
            dataSet = server.GetRows("Clients");
            foreach (var row in dataSet.Tables[0].Rows.Cast<DataRow>())
            {
                if (row.ItemArray.Length != 9) continue;
                hotel.Clients.Add(Guid.Parse(row.ItemArray[0].ToString()),
                    row.ItemArray[1].ToString(),
                    row.ItemArray[2].ToString(),
                    row.ItemArray[3].ToString(),
                    DateTime.Parse(row.ItemArray[4].ToString()),
                    row.ItemArray[5].ToString(),
                    row.ItemArray[6].ToString(),
                    row.ItemArray[7].ToString(),
                    int.Parse(row.ItemArray[8].ToString()));
            }
            // бронирование
            dataSet = server.GetRows("Reservations");
            foreach (var row in dataSet.Tables[0].Rows.Cast<DataRow>())
            {
                if (row.ItemArray.Length != 6) continue;
                hotel.Reservations.Add(Guid.Parse(row.ItemArray[0].ToString()),
                    Guid.Parse(row.ItemArray[1].ToString()),
                    Guid.Parse(row.ItemArray[2].ToString()),
                    DateTime.Parse(row.ItemArray[3].ToString()),
                    DateTime.Parse(row.ItemArray[4].ToString()),
                    Guid.Parse(row.ItemArray[5].ToString()));
            }
            // доставка до гостиницы
            dataSet = server.GetRows("Transfers");
            foreach (var row in dataSet.Tables[0].Rows.Cast<DataRow>())
            {
                if (row.ItemArray.Length != 5) continue;
                hotel.Transfers.Add(Guid.Parse(row.ItemArray[0].ToString()),
                    Guid.Parse(row.ItemArray[1].ToString()),
                    row.ItemArray[2].ToString(),
                    DateTime.Parse(row.ItemArray[3].ToString()),
                    int.Parse(row.ItemArray[4].ToString()));
            }
            // перечень каналов
            dataSet = server.GetRows("PayChannels");
            foreach (var row in dataSet.Tables[0].Rows.Cast<DataRow>())
            {
                if (row.ItemArray.Length != 3) continue;
                hotel.PayChannels.Add(Guid.Parse(row.ItemArray[0].ToString()),
                    row.ItemArray[1].ToString(),
                    decimal.Parse(row.ItemArray[2].ToString()));
            }
            // перечень подписок
            dataSet = server.GetRows("AccordancePayChannels");
            foreach (var row in dataSet.Tables[0].Rows.Cast<DataRow>())
            {
                if (row.ItemArray.Length != 2) continue;
                hotel.AccordancePayChannels.Add(Guid.Parse(row.ItemArray[0].ToString()),
                    Guid.Parse(row.ItemArray[1].ToString()));
            }
            //TODO: подписка на каналы (галочки)!

            return hotel;
        }

        public static void SaveToBase(string connection, Hotel hotel)
        {
            var server = new Database.SqlServer { Connection = connection };
            // категории
            foreach (var item in hotel.Categories.Values)
            {
                var columns = new Dictionary<string, string>
                {
                    { "IdCategory", item.IdCategory.ToString() },
                    { "NameCategory", item.NameCategory }
                };
                if (!server.InsertInto("Categories", columns)) server.UpdateInto("Categories", columns);
            }
            // услуги
            foreach (var item in hotel.Services)
            {
                var columns = new Dictionary<string, string>
                {
                    { "IdService", item.IdService.ToString() },
                    { "NameService", item.NameService },
                    { "PriceDay", item.PriceDay.ToString() }
                };
                if (!server.InsertInto("Services", columns)) server.UpdateInto("Services", columns);
            }
            // комнаты
            foreach (var item in hotel.Rooms)
            {
                var columns = new Dictionary<string, string>
                {
                    { "IdRoom", item.IdRoom.ToString() },
                    { "IdCategory", item.IdCategory.ToString() },
                    { "NumberSeat", item.NumberSeat.ToString() },
                    { "Floor", item.Floor.ToString() },
                    { "PriceDay", item.PriceDay.ToString() },
                    { "RoomNumber", item.RoomNumber }
                };
                if (!server.InsertInto("Rooms", columns)) server.UpdateInto("Rooms", columns);
            }
            // должности
            foreach (var item in hotel.EmployeeRoles)
            {
                var columns = new Dictionary<string, string>
                {
                    { "IdEmployeeRole", item.IdEmployeeRole.ToString() },
                    { "NameRole", item.NameRole },
                    { "Salary", item.Salary.ToString() },
                    { "AllowedOperations", item.AllowedOperations.ToString() }
                };
                if (!server.InsertInto("EmployeeRoles", columns)) server.UpdateInto("EmployeeRoles", columns);
            }
            // штат сотрудников
            foreach (var item in hotel.RegistryStaff)
            {
                var columns = new Dictionary<string, string>
                {
                    { "IdEmployee", item.IdEmployee.ToString() },
                    { "Surname", item.Surname },
                    { "Name", item.Name },
                    { "LastName", item.LastName },
                    { "PhoneNumber", item.PhoneNumber },
                    { "IdEmployeeRole", item.IdEmployeeRole.ToString() }
                };
                if (!server.InsertInto("RegistryStaff", columns)) server.UpdateInto("RegistryStaff", columns);
            }
            // клиенты
            foreach (var item in hotel.Clients)
            {
                var columns = new Dictionary<string, string>
                {
                    { "IdClient", item.IdClient.ToString() },
                    { "Surname", item.Surname },
                    { "Name", item.Name },
                    { "LastName", item.LastName },
                    { "Birthday", item.Birthday.ToString("O") },
                    { "City", item.City },
                    { "PhoneNumber", item.PhoneNumber },
                    { "Passport", item.Passport },
                    { "NumberChild", item.NumberChild.ToString() }
                };
                if (!server.InsertInto("Clients", columns)) server.UpdateInto("Clients", columns);
            }
            // бронирование
            foreach (var item in hotel.Reservations)
            {
                var columns = new Dictionary<string, string>
                {
                    { "IdReservation", item.IdReservation.ToString() },
                    { "IdClient", item.IdClient.ToString() },
                    { "IdRoom", item.IdRoom.ToString() },
                    { "ArrivalDate", item.ArrivalDate.ToString("O") },
                    { "DepartureDate", item.DepartureDate.ToString("O") },
                    { "IdEmployee", item.IdEmployee.ToString() }
                };
                if (!server.InsertInto("Reservations", columns)) server.UpdateInto("Reservations", columns);
            }
            // доставка до гостиницы
            foreach (var item in hotel.Transfers)
            {
                var columns = new Dictionary<string, string>
                {
                    { "IdTransfer", item.IdTransfer.ToString() },
                    { "IdReservation", item.IdReservation.ToString() },
                    { "FeedAddress", item.FeedAddress },
                    { "FeedDateTime", item.FeedDateTime.ToString("O") },
                    { "NumberSeat", item.NumberSeat.ToString() }
                };
                if (!server.InsertInto("Transfers", columns)) server.UpdateInto("Transfers", columns);
            }
            // перечень каналов
            foreach (var item in hotel.PayChannels)
            {
                var columns = new Dictionary<string, string>
                {
                    { "IdPayChannel", item.IdPayChannel.ToString() },
                    { "NameChannel", item.NameChannel },
                    { "PriceHour", item.PriceHour.ToString() }
                };
                if (!server.InsertInto("PayChannels", columns)) server.UpdateInto("PayChannels", columns);
            }
            // перечень подписок
            foreach (var item in hotel.AccordancePayChannels)
            {
                var columns = new Dictionary<string, string>
                {
                    { "IdAccordancePayChannel", item.IdAccordancePayChannel.ToString() },
                    { "IdReservation", item.IdReservation.ToString() }
                };
                if (!server.InsertInto("AccordancePayChannels", columns)) server.UpdateInto("AccordancePayChannels", columns);
            }
        }
    }
}
