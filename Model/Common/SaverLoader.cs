using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;

namespace Model
{
    /// <summary>
    /// Класс поддержки чтения/записи конфигурации в файл на локальном диске
    /// </summary>
    public static class SaverLoader
    {
        /// <summary>
        /// Метод загрузки сохраненной ранее конфигурации из логального файла
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
        /// Метод сохрания конфигурации в файл на локальном диске
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
    }
}
