using System;

namespace Model
{
    [Serializable]
    public class Hotel
    {
        public Hotel()
        {
            Rooms = new Rooms(this);
            RegistryStaff = new RegistryStaff(this);
        }

        public Categories Categories { get; set; } = new Categories();
        public Services Services { get; set; } = new Services();
        public SeatKinds Seats { get; set; } = new SeatKinds();
        public Rooms Rooms { get; set; }
        public RegistryStaff RegistryStaff { get; set; }

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
