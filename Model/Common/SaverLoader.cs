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

        public static string OperationResult { get; private set; } = string.Empty;

        /// <summary>
        /// Метод загрузки сохранённой ранее конфигурации из базы данных
        /// </summary>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static Hotel LoadFromBase(string connection)
        {
            var hotel = new Hotel();
            var server = new Database.SqlServer { Connection = connection };
            // категории
            var dataSet = server.GetRows("Categories");
            if (dataSet.Tables.Count > 0)
                foreach (var row in dataSet.Tables[0].Rows.Cast<DataRow>())
                {
                    if (row.ItemArray.Length != 2) continue;
                    hotel.Categories.Add(Guid.Parse(row.ItemArray[0].ToString()),
                        row.ItemArray[1].ToString());
                }
            OperationResult = server.LastError;
            // услуги
            dataSet = server.GetRows("Services");
            if (dataSet.Tables.Count > 0)
                foreach (var row in dataSet.Tables[0].Rows.Cast<DataRow>())
                {
                    if (row.ItemArray.Length != 3) continue;
                    hotel.Services.Add(Guid.Parse(row.ItemArray[0].ToString()),
                        row.ItemArray[1].ToString(),
                        decimal.Parse(row.ItemArray[2].ToString()));
                }
            OperationResult = server.LastError;
            // комнаты
            dataSet = server.GetRows("Rooms");
            if (dataSet.Tables.Count > 0)
                foreach (var row in dataSet.Tables[0].Rows.Cast<DataRow>())
                {
                    if (row.ItemArray.Length != 6) continue;
                    var room = hotel.Rooms.Add(Guid.Parse(row.ItemArray[0].ToString()),
                        Guid.Parse(row.ItemArray[1].ToString()),
                        int.Parse(row.ItemArray[2].ToString()),
                        int.Parse(row.ItemArray[3].ToString()),
                        decimal.Parse(row.ItemArray[4].ToString()),
                        row.ItemArray[5].ToString());
                    var ds = server.GetRows("RoomServices");
                    if (ds.Tables.Count > 0)
                    {
                        foreach (var item in ds.Tables[0].Rows.Cast<DataRow>())
                        {
                            if (item.ItemArray.Length != 2) continue;
                            var roomId = Guid.Parse(item.ItemArray[0].ToString());
                            var serviceId = Guid.Parse(item.ItemArray[1].ToString());
                            if (room.IdRoom == roomId)
                            {
                                var service = hotel.Services.FirstOrDefault(s => s.IdService == serviceId);
                                if (service != null)
                                    room.Services.Add(service);
                            }
                        }
                    }
                }
            OperationResult = server.LastError;
            // должности
            dataSet = server.GetRows("EmployeeRoles");
            if (dataSet.Tables.Count > 0)
                foreach (var row in dataSet.Tables[0].Rows.Cast<DataRow>())
                {
                    if (row.ItemArray.Length != 4) continue;
                    hotel.EmployeeRoles.Add(Guid.Parse(row.ItemArray[0].ToString()),
                        row.ItemArray[1].ToString(),
                        decimal.Parse(row.ItemArray[2].ToString()),
                        (AllowedOperations)uint.Parse(row.ItemArray[3].ToString()));
                }
            OperationResult = server.LastError;
            // штат сотрудников
            dataSet = server.GetRows("RegistryStaff");
            if (dataSet.Tables.Count > 0)
                foreach (var row in dataSet.Tables[0].Rows.Cast<DataRow>())
                {
                    if (row.ItemArray.Length != 7) continue;
                    hotel.RegistryStaff.Add(Guid.Parse(row.ItemArray[0].ToString()),
                        row.ItemArray[1].ToString(),
                        row.ItemArray[2].ToString(),
                        row.ItemArray[3].ToString(),
                        row.ItemArray[4].ToString(),
                        Guid.Parse(row.ItemArray[5].ToString()),
                        row.ItemArray[6].ToString());
                }
            OperationResult = server.LastError;
            // клиенты
            dataSet = server.GetRows("Clients");
            if (dataSet.Tables.Count > 0)
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
            OperationResult = server.LastError;
            // бронирование
            dataSet = server.GetRows("Reservations");
            if (dataSet.Tables.Count > 0)
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
            OperationResult = server.LastError;
            // доставка до гостиницы
            dataSet = server.GetRows("Transfers");
            if (dataSet.Tables.Count > 0)
                foreach (var row in dataSet.Tables[0].Rows.Cast<DataRow>())
                {
                    if (row.ItemArray.Length != 5) continue;
                    hotel.Transfers.Add(Guid.Parse(row.ItemArray[0].ToString()),
                        Guid.Parse(row.ItemArray[1].ToString()),
                        row.ItemArray[2].ToString(),
                        DateTime.Parse(row.ItemArray[3].ToString()),
                        int.Parse(row.ItemArray[4].ToString()));
                }
            OperationResult = server.LastError;
            // перечень каналов
            dataSet = server.GetRows("PayChannels");
            if (dataSet.Tables.Count > 0)
                foreach (var row in dataSet.Tables[0].Rows.Cast<DataRow>())
                {
                    if (row.ItemArray.Length != 3) continue;
                    hotel.PayChannels.Add(Guid.Parse(row.ItemArray[0].ToString()),
                        row.ItemArray[1].ToString(),
                        decimal.Parse(row.ItemArray[2].ToString()));
                }
            OperationResult = server.LastError;
            // перечень подписок
            dataSet = server.GetRows("AccordancePayChannels");
            if (dataSet.Tables.Count > 0)
                foreach (var row in dataSet.Tables[0].Rows.Cast<DataRow>())
                {
                    if (row.ItemArray.Length != 2) continue;
                    var accordance = hotel.AccordancePayChannels.Add(Guid.Parse(row.ItemArray[0].ToString()),
                        Guid.Parse(row.ItemArray[1].ToString()));
                    var ds = server.GetRows("RoomPayChannels");
                    if (ds.Tables.Count > 0)
                    {
                        foreach (var item in ds.Tables[0].Rows.Cast<DataRow>())
                        {
                            if (item.ItemArray.Length != 2) continue;
                            var accordanceId = Guid.Parse(item.ItemArray[0].ToString());
                            var channelId = Guid.Parse(item.ItemArray[1].ToString());
                            if (accordance.IdAccordancePayChannel == accordanceId)
                            {
                                var channel = hotel.PayChannels.FirstOrDefault(c => c.IdPayChannel == channelId);
                                if (channel != null)
                                    accordance.PayChannels.Add(channel);
                            }
                        }
                    }
                }
            OperationResult = server.LastError;
            return hotel;
        }

        /// <summary>
        /// Метод сохранения конфигурации в базу данных
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="hotel"></param>
        public static void SaveToBase(string connection, Hotel hotel)
        {
            var server = new Database.SqlServer { Connection = connection };
            // категории
            server.DeleteInto("Categories", "IdCategory", hotel.Categories.Select(item => item.Value.IdCategory));
            OperationResult = server.LastError;
            foreach (var item in hotel.Categories.Values)
            {
                var columns = new Dictionary<string, string>
                {
                    { "IdCategory", item.IdCategory.ToString() },
                    { "NameCategory", item.NameCategory }
                };
                if (!server.InsertInto("Categories", columns)) server.UpdateInto("Categories", columns);
                OperationResult = server.LastError;
            }
            // услуги
            server.DeleteInto("Services", "IdService", hotel.Services.Select(item => item.IdService));
            OperationResult = server.LastError;
            foreach (var item in hotel.Services)
            {
                var columns = new Dictionary<string, string>
                {
                    { "IdService", item.IdService.ToString() },
                    { "NameService", item.NameService },
                    { "PriceDay", item.PriceDay.ToString() }
                };
                if (!server.InsertInto("Services", columns)) server.UpdateInto("Services", columns);
                OperationResult = server.LastError;
            }
            // комнаты
            server.DeleteInto("Rooms", "IdRoom", hotel.Rooms.Select(item => item.IdRoom));
            foreach (var room in hotel.Rooms)
            {
                var columns = new Dictionary<string, string>
                {
                    { "IdRoom", room.IdRoom.ToString() },
                    { "IdCategory", room.IdCategory.ToString() },
                    { "NumberSeat", room.NumberSeat.ToString() },
                    { "Floor", room.Floor.ToString() },
                    { "PriceDay", room.PriceDay.ToString() },
                    { "RoomNumber", room.RoomNumber }
                };
                server.DeleteInto("RoomServices", columns);
                OperationResult = server.LastError;
                if (!server.InsertInto("Rooms", columns)) server.UpdateInto("Rooms", columns);
                foreach (var service in room.Services)
                {
                    var cols = new Dictionary<string, string>
                    {
                        { "IdRoom", room.IdRoom.ToString() },
                        { "IdService", service.IdService.ToString() }
                    };
                    if (!server.InsertInto("RoomServices", cols)) server.UpdateInto("RoomServices", cols);
                    OperationResult = server.LastError;
                }
            }
            // должности
            server.DeleteInto("EmployeeRoles", "IdEmployeeRole", hotel.EmployeeRoles.Select(item => item.IdEmployeeRole));
            foreach (var item in hotel.EmployeeRoles)
            {
                var columns = new Dictionary<string, string>
                {
                    { "IdEmployeeRole", item.IdEmployeeRole.ToString() },
                    { "NameRole", item.NameRole },
                    { "Salary", item.Salary.ToString() },
                    { "AllowedOperations", ((uint)item.AllowedOperations).ToString() }
                };
                if (!server.InsertInto("EmployeeRoles", columns)) server.UpdateInto("EmployeeRoles", columns);
            }
            // штат сотрудников
            server.DeleteInto("RegistryStaff", "IdEmployee", hotel.RegistryStaff.Select(item => item.IdEmployee));
            OperationResult = server.LastError;
            foreach (var item in hotel.RegistryStaff)
            {
                var columns = new Dictionary<string, string>
                {
                    { "IdEmployee", item.IdEmployee.ToString() },
                    { "Surname", item.Surname },
                    { "Name", item.Name },
                    { "LastName", item.LastName },
                    { "PhoneNumber", item.PhoneNumber },
                    { "IdEmployeeRole", item.IdEmployeeRole.ToString() },
                    { "Password", item.Password }
                };
                if (!server.InsertInto("RegistryStaff", columns)) server.UpdateInto("RegistryStaff", columns);
                OperationResult = server.LastError;
            }
            // клиенты
            server.DeleteInto("Clients", "IdClient", hotel.Clients.Select(item => item.IdClient));
            OperationResult = server.LastError;
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
                OperationResult = server.LastError;
            }
            // бронирование
            server.DeleteInto("Reservations", "IdReservation", hotel.Reservations.Select(item => item.IdReservation));
            OperationResult = server.LastError;
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
                OperationResult = server.LastError;
            }
            // доставка до гостиницы
            server.DeleteInto("Transfers", "IdTransfer", hotel.Transfers.Select(item => item.IdTransfer));
            OperationResult = server.LastError;
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
                OperationResult = server.LastError;
            }
            // перечень каналов
            server.DeleteInto("PayChannels", "IdPayChannel", hotel.PayChannels.Select(item => item.IdPayChannel));
            OperationResult = server.LastError;
            foreach (var item in hotel.PayChannels)
            {
                var columns = new Dictionary<string, string>
                {
                    { "IdPayChannel", item.IdPayChannel.ToString() },
                    { "NameChannel", item.NameChannel },
                    { "PriceHour", item.PriceHour.ToString() }
                };
                if (!server.InsertInto("PayChannels", columns)) server.UpdateInto("PayChannels", columns);
                OperationResult = server.LastError;
            }
            // перечень подписок
            server.DeleteInto("AccordancePayChannels", "IdAccordancePayChannel", 
                hotel.AccordancePayChannels.Select(item => item.IdAccordancePayChannel));
            OperationResult = server.LastError;
            foreach (var accordance in hotel.AccordancePayChannels)
            {
                var columns = new Dictionary<string, string>
                {
                    { "IdAccordancePayChannel", accordance.IdAccordancePayChannel.ToString() },
                    { "IdReservation", accordance.IdReservation.ToString() }
                };
                server.DeleteInto("RoomPayChannels", columns);
                OperationResult = server.LastError;
                if (!server.InsertInto("AccordancePayChannels", columns)) server.UpdateInto("AccordancePayChannels", columns);
                OperationResult = server.LastError;
                foreach (var channel in accordance.PayChannels)
                {
                    var cols = new Dictionary<string, string>
                    {
                        { "IdAccordancePayChannel", accordance.IdAccordancePayChannel.ToString() },
                        { "IdPayChannel", channel.IdPayChannel.ToString() }
                    };
                    if (!server.InsertInto("RoomPayChannels", cols)) server.UpdateInto("RoomPayChannels", cols);
                    OperationResult = server.LastError;
                }
            }
        }
    }
}
