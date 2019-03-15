using System;
using System.Text;

namespace Model
{
    /// <summary>
    /// Генератор номеров паспортов
    /// </summary>
    public class PassportNumberGenerator
    {
        Random random = new Random();

        public string GetNumber()
        {
            var sb = new StringBuilder();
            for (var i = 0; i < 4; i++)
                sb.Append(random.Next(10));
            sb.Append(" ");
            for (var i = 0; i < 6; i++)
                sb.Append(random.Next(10));
            return sb.ToString();
        }
    }
}
