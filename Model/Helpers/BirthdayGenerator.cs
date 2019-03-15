using System;

namespace Model
{
    /// <summary>
    /// Генератор дней рождения
    /// </summary>
    public class BirthdayGenerator
    {
        Random random = new Random();
        
        public DateTime GetDate()
        {
            var dt = DateTime.Now.Date;
            var year = random.Next(dt.Year - 100, dt.Year - 18);
            var month = random.Next(1, 13);
            var day = random.Next(1, 29);
            return new DateTime(year, month, day);
        }
    }
}
