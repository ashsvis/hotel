﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Database
{
    public class SqlServer
    {
        public string Connection { get; set; } = "Data Source=EPKS;Initial Catalog=Hotel;User ID=mngr;Password=mngr";
        public string LastError { get; set; } = string.Empty;

        /// <summary>
        /// Запрос на вставку данных
        /// </summary>
        /// <param name="table">Имя таблицы</param>
        /// <param name="row">Набор данных для вставки</param>
        /// <returns></returns>
        public bool InsertInto(string table, Dictionary<string, string> columns)
        {
            using (var con = new SqlConnection(Connection))
            {
                try
                {
                    con.Open();
                    var names = new List<string>();
                    var values = new List<string>();
                    foreach (var key in columns.Keys)
                    {
                        names.Add("[" + key + "]");
                        values.Add("'" + columns[key] + "'");
                    }
                    var sql = string.Format("INSERT INTO [{0}] ({1}) VALUES({2})",
                            table.ToLower(), string.Join(", ", names), string.Join(", ", values));
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                    LastError = "";
                    return true;
                }
                catch (Exception ex)
                {
                    LastError = ex.Message;
                    return false;
                }
            }
        }

        /// <summary>
        /// Запрос на изменение данных
        /// </summary>
        /// <param name="table">Имя таблицы</param>
        /// <param name="columns">Набор данных для изменения</param>
        /// <returns></returns>
        public bool UpdateInto(string table, Dictionary<string, string> columns)
        {
            using (var con = new SqlConnection(Connection))
            {
                try
                {
                    con.Open();
                    var values = new List<string>();
                    var indexName = columns.Keys.First();
                    var indexValue = columns[indexName];
                    foreach (var key in columns.Keys.Skip(1))
                    {
                        values.Add("[" + key + "] = '" + columns[key] + "'");
                    }
                    var sql = string.Format("UPDATE [{0}] SET {1} WHERE [{2}]='{3}'",
                            table.ToLower(), string.Join(", ", values), indexName, indexValue);
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                    LastError = "";
                    return true;
                }
                catch (Exception ex)
                {
                    LastError = ex.Message;
                    return false;
                }
            }
        }

        /// <summary>
        /// Удаление строки из таблицы
        /// </summary>
        /// <param name="table">Имя таблицы</param>
        /// <param name="columns">Данные ключа для удаления</param>
        /// <returns></returns>
        public bool DeleteInto(string table, Dictionary<string, string> columns)
        {
            using (var con = new SqlConnection(Connection))
            {
                try
                {
                    con.Open();
                    var indexName = columns.Keys.First();
                    var indexValue = columns[indexName];
                    var sql = string.Format("DELETE FROM [{0}] WHERE [{1}]='{2}'", table, indexName, indexValue);
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                    LastError = "";
                    return true;
                }
                catch (Exception ex)
                {
                    LastError = ex.Message;
                    return false;
                }
            }
        }

        /// <summary>
        /// Получение набора данных из таблицы
        /// </summary>
        /// <param name="table">Имя таблицы</param>
        /// <param name="likefield">Имя поля для фильтра</param>
        /// <param name="text2find">Значение для фильтра</param>
        /// <returns></returns>
        public DataSet GetRows(string table, string likefield = null, string text2find = null)
        {
            using (var con = new SqlConnection(Connection))
            {
                var sql = BuildQuery(table, likefield, text2find);
                using (var da = new SqlDataAdapter(sql, con))
                {
                    var ds = new DataSet();
                    try
                    {
                        da.Fill(ds, table);
                        LastError = "";
                    }
                    catch (Exception ex)
                    {
                        LastError = ex.Message;
                    }
                    return ds;
                }
            }
        }

        /// <summary>
        /// Построение текста запроса SELECT
        /// </summary>
        /// <param name="table">Имя таблицы</param>
        /// <param name="likefield">Имя поля для фильтра</param>
        /// <param name="text2find">Значение для фильтра</param>
        /// <returns></returns>
        private string BuildQuery(string table, string likefield = null, string text2find = null)
        {
            var sql = string.Format("SELECT * FROM [{0}]", table);
            //switch (table.ToLower())
            //{
            //    case "course":
            //        sql = string.Format("select C.[Id], C.[FacultyID], F.[Faculty], C.[Course]" +
            //            " from [{0}] C, [Faculty] F where C.[FacultyID] = F.[Id] order by F.[Faculty], C.[Course]", table);
            //        break;
            //}
            if (!string.IsNullOrWhiteSpace(likefield) && !string.IsNullOrWhiteSpace(text2find))
                sql += string.Format(" WHERE ([{0}] LIKE '{1}%')", likefield, text2find);

            return sql;
        }

    }
}
