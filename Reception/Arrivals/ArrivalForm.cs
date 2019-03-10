using Model;
using System.Linq;
using System.Windows.Forms;

namespace Reception
{
    public partial class ArrivalForm : Form
    {
        //счетчик режима обновления
        private int updating;
        private readonly Hotel _hotel;

        public Arrival Data { get; set; }

        public ArrivalForm(Hotel hotel)
        {
            InitializeComponent();
            _hotel = hotel;
            // заполнение списка клиентов
            foreach (var client in hotel.Clients.OrderedBySurname())
                cbClientFullName.Items.Add(client);
            // заполнение списка категорий номеров
            foreach (var category in hotel.Categories.OrderBy(item => item.Value.NameCategory))
                cbCategory.Items.Add(category.Value);
            // заполнение списка вместимости
            foreach (var seat in hotel.Seats.OrderBy(item => item.NumberSeat))
                cbNumberSeat.Items.Add(seat.Descriptor);
            // заполнение списка этажей
            foreach (var floor in hotel.Rooms.Select(item => item.Floor).Distinct())
                cbFloor.Items.Add(floor);
            // заполнение списка комнат
            foreach (var roomNumber in hotel.Rooms.Select(item => item.RoomNumber))
                cbRoom.Items.Add(roomNumber);
        }

        //занесение данных из объекта данных в контролы
        public void Build(Arrival data)
        {
                Data = data;

                updating++; //включаем режим обновления


                updating--; //выключаем режим обновления
        }

        //Занесение данных из контролов в Data
        public void UpdateData()
        {
            if (updating > 0) return; //мы находимся в режиме обновления, не обрабатываем

        }
    }
}
