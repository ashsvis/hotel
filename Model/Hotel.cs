using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Hotel
    {
        public Categories Categories { get; set; } = new Categories();
        public Services Services { get; set; } = new Services();
        public SeatKinds Seats { get; set; } = new SeatKinds();
        public Rooms Rooms { get; set; } = new Rooms();

        public void BuildData()
        {
            Categories.Add("Эконом");
            Categories.Add("Семейный");
            Categories.Add("Стандарт");
            Categories.Add("Люкс");
            Categories.Add("Апартаменты");
            Services.Add("Интернет");
            Services.Add("Телевизор");
            Services.Add("Фен");
            Services.Add("Душевая");
            Services.Add("Кондиционер");
            Services.Add("Мини бар");
            Services.Add("Сейф");
            Seats.Add("Двухместный", 2);
            Seats.Add("Одноместный", 1);
            Seats.Add("Трёхместный", 3);
        }

    }
}
