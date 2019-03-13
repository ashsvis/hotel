using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Model;

namespace Reception
{
    public partial class PayChannelsControl : UserControl
    {
        Hotel _hotel;
        PayChannels _channels;

        public PayChannelsControl()
        {
            InitializeComponent();
        }

        //Занесение данных из _services в контролы
        public void Build(Hotel hotel)
        {
            _hotel = hotel;
            _channels = _hotel.PayChannels;
            FillTable();
        }

        private void FillTable()
        {
            tsbChangePayChannel.Enabled = tsbDeletePayChannel.Enabled = false;
            // устанавливаем размер виртуальной таблицы
            dgvPayChannels.RowCount = _channels.Count;
            // просим перерисовать таблицу
            dgvPayChannels.Invalidate();
        }

        private void dgvPayChannel_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            var sorted = _channels.OrderBy(item => item.NameChannel).ToList();
            if (sorted.Count == 0) return;
            // для каждого столбца виртуальной таблицы
            switch (e.ColumnIndex)
            {
                case 0: // наименование канала
                    e.Value = sorted[e.RowIndex].NameChannel;
                    break;
                case 1: // стоимость просмотра канала за час
                    e.Value = sorted[e.RowIndex].PriceHour + " руб.";
                    break;
            }
        }

        private void dgvPayChannel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbChangePayChannel.Enabled = tsbDeletePayChannel.Enabled = true;
        }

        private void tsbNewPayChannel_Click(object sender, System.EventArgs e)
        {
            var frm = new PayChannelForm(_hotel); // создаем форму
            frm.Build(new PayChannel()); // создаём "пустую" услугу и заполняем контролы формы
            // показываем форму в диалоге
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                var channel = frm.Data;
                _channels.Add(channel); // добавляем в список услуг
                FillTable(); // перестраиваем таблицу
            }
        }

        private void tsbChangePayChannel_Click(object sender, System.EventArgs e)
        {
            var frm = new PayChannelForm(_hotel); // создаем форму
            var sorted = _channels.OrderBy(item => item.NameChannel).ToList();
            frm.Build(sorted[dgvPayChannels.SelectedRows[0].Index]); // заполняем контролы формы параметрами выбранного канала
            // вызываем форму на редактирование
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                // обновляем виртуальную таблицу
                FillTable();
            }
        }

        private void tsbDeletePayChannel_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show(this, "Удалить данные канала?", "Удаление канала",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var sorted = _channels.OrderBy(item => item.NameChannel).ToList();
                var channel = sorted[dgvPayChannels.SelectedRows[0].Index];
                try
                {
                    _hotel.CheckPayChannelUsed(channel);
                    _channels.Remove(channel);
                    // обновляем данные интерфейса
                    FillTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); //выводим сообщение об ошибке и не закрываем форму
                }
            }
        }
    }
}
