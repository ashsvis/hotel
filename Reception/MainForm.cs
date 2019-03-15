using Model;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reception
{
    public partial class MainForm : Form
    {
        private Hotel _hotel = new Hotel(); // модель
        private AllowedOperations _allowedOperations = AllowedOperations.None; // права текущего пользователя

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            tsmiLogin.Enabled = false;
            _hotel.BuildData();
        }

        /// <summary>
        /// Выполняется при первой загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowDefault();
            tsslStatusLabel.Text = "Загрузка данных...";
            LoadFromBaseAsync();
            CenterToScreen();
        }

        /// <summary>
        /// Загрузка данных из базы асинхронно
        /// </summary>
        private void LoadFromBaseAsync()
        {
            tsmiLogin.Enabled = false;
            Task.Run(() =>
            {
                _hotel = SaverLoader.LoadFromBase(Properties.Settings.Default.ConnectionString);
                var method = new MethodInvoker(() =>
                {
                    tsmiLogin.Enabled = true;
                    var result = SaverLoader.OperationResult;
                    tsslStatusLabel.Text = string.IsNullOrWhiteSpace(result) 
                                     ? "Готово" : result.Substring(0, result.IndexOf('.') + 1);
                    statusStrip1.Refresh();
                });
                if (InvokeRequired)
                    BeginInvoke(method);
                else
                    method();
            });
        }

        /// <summary>
        /// Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Настройка жилого фонда
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiTuningRooms_Click(object sender, EventArgs e)
        {
            var rc = new RoomsControl() { Dock = DockStyle.Fill };
            rc.Build(_hotel);
            CreateAndShowUserControl(rc);
        }

        /// <summary>
        /// Размещение контрола поверх старого и удаление старого контрола
        /// </summary>
        /// <param name="rc"></param>
        private void CreateAndShowUserControl(UserControl rc)
        {
            if (panelView.Controls.Contains(rc)) return;
            panelView.Controls.Add(rc);
            if (panelView.Controls.Count > 1)
                panelView.Controls.RemoveAt(0);
        }

        /// <summary>
        /// Загрузить из файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiLoadFromFile_Click(object sender, EventArgs e)
        {
            var fileName = Path.ChangeExtension(Application.ExecutablePath, ".dat");
            if (File.Exists(fileName))
                _hotel = SaverLoader.LoadFromFile(fileName);
        }

        /// <summary>
        /// Сохранить в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSaveToFile_Click(object sender, EventArgs e)
        {
            var fileName = Path.ChangeExtension(Application.ExecutablePath, ".dat");
            SaverLoader.SaveToFile(fileName, _hotel);
        }

        /// <summary>
        /// Сохранить в базу данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSaveToBase_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                SaverLoader.SaveToBase(Properties.Settings.Default.ConnectionString, _hotel);
                var method = new MethodInvoker(() =>
                {
                    var result = SaverLoader.OperationResult;
                    tsslStatusLabel.Text = string.IsNullOrWhiteSpace(result)
                                     ? "Готово" : result.Substring(0, result.IndexOf('.') + 1);
                    statusStrip1.Refresh();
                });
                if (InvokeRequired)
                    BeginInvoke(method);
                else
                    method();
            });
        }

        private void ShowDefault()
        {
            var rc = new DefaultControl() { Dock = DockStyle.Fill };
            CreateAndShowUserControl(rc);
        }

        /// <summary>
        /// Список сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiEmployees_Click(object sender, EventArgs e)
        {
            var rc = new EmployeesControl() { Dock = DockStyle.Fill };
            rc.Build(_hotel);
            CreateAndShowUserControl(rc);
        }

        /// <summary>
        /// Список клиентов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiClients_Click(object sender, EventArgs e)
        {
            var rc = new ClientsControl() { Dock = DockStyle.Fill };
            rc.Build(_hotel);
            CreateAndShowUserControl(rc);
        }

        /// <summary>
        /// Бронирование номеров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiReservations_Click(object sender, EventArgs e)
        {
            var rc = new ReservationsControl() { Dock = DockStyle.Fill };
            rc.Build(_hotel);
            CreateAndShowUserControl(rc);
        }

        /// <summary>
        /// Перечень услуг
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiServices_Click(object sender, EventArgs e)
        {
            var rc = new ServicesControl() { Dock = DockStyle.Fill };
            rc.Build(_hotel);
            CreateAndShowUserControl(rc);
        }

        /// <summary>
        /// Категории номеров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiCategories_Click(object sender, EventArgs e)
        {
            var rc = new CategoriesControl() { Dock = DockStyle.Fill };
            rc.Build(_hotel);
            CreateAndShowUserControl(rc);
        }

        /// <summary>
        /// Должности сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiEmployeeRoles_Click(object sender, EventArgs e)
        {
            var rc = new EmployeeRolesControl() { Dock = DockStyle.Fill };
            rc.Build(_hotel);
            CreateAndShowUserControl(rc);
        }

        /// <summary>
        /// Заказ доставки к отелю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiTransfer_Click(object sender, EventArgs e)
        {
            var rc = new TransferControl() { Dock = DockStyle.Fill };
            rc.Build(_hotel);
            CreateAndShowUserControl(rc);
        }

        /// <summary>
        /// Перечень платных каналов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiPayChannelsTV_Click(object sender, EventArgs e)
        {
            var rc = new PayChannelsControl() { Dock = DockStyle.Fill };
            rc.Build(_hotel);
            CreateAndShowUserControl(rc);
        }

        /// <summary>
        /// Перечень подписанных каналов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiAccordancePayChannels_Click(object sender, EventArgs e)
        {
            var rc = new AccordancePayChannelsControl() { Dock = DockStyle.Fill };
            rc.Build(_hotel);
            CreateAndShowUserControl(rc);
        }

        /// <summary>
        /// Вызов отчёта по текущим клиентам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiCurrentClients_Click(object sender, EventArgs e)
        {
            var rc = new ReportViewControl() { Dock = DockStyle.Fill };
            var generator = new ReportsBuilder();
            var report = generator.GetClientsByDate(_hotel, DateTime.Now);
            rc.Build(_hotel, report);
            CreateAndShowUserControl(rc);
        }

        /// <summary>
        /// Вызов отчёта по свободным номерам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiEmptyRooms_Click(object sender, EventArgs e)
        {
            var rc = new ReportViewControl() { Dock = DockStyle.Fill };
            var generator = new ReportsBuilder();
            var report = generator.GetEmptyRoomsByDate(_hotel, DateTime.Now);
            rc.Build(_hotel, report);
            CreateAndShowUserControl(rc);
        }

        /// <summary>
        /// Вызов отчёта по занятым номерам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiBusyRooms_Click(object sender, EventArgs e)
        {
            var rc = new ReportViewControl() { Dock = DockStyle.Fill };
            var generator = new ReportsBuilder();
            var report = generator.GetBusyRoomsByDate(_hotel, DateTime.Now);
            rc.Build(_hotel, report);
            CreateAndShowUserControl(rc);
        }

        /// <summary>
        /// Вызов отчёта по клиентам за прошедший месяц
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiLastMonthClients_Click(object sender, EventArgs e)
        {
            var rc = new ReportViewControl() { Dock = DockStyle.Fill };
            var generator = new ReportsBuilder();
            var report = generator.GetClientsByLastMonth(_hotel);
            rc.Build(_hotel, report);
            CreateAndShowUserControl(rc);
        }

        private void tsmiConnectionString_Click(object sender, EventArgs e)
        {
            var frm = new ConnectionStringForm();
            frm.Build(Properties.Settings.Default.ConnectionString);
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                Properties.Settings.Default.ConnectionString = frm.Data;
                Properties.Settings.Default.Save();
                tsslStatusLabel.Text = "Загрузка данных...";
                ShowDefault();
                _allowedOperations = AllowedOperations.None;
                LoadFromBaseAsync();
            }
        }

        private void tsmiLogin_Click(object sender, EventArgs e)
        {
            if (_hotel.IsAdministratorDefined())
            {
                var frm = new LoginForm(_hotel);
                var users = _hotel.GetUsers();
                frm.Build(users);
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    _allowedOperations = frm.AllowedOperations;
                    ShowDefault();
                    tsslStatusLabel.Text = "";
                }
            }
            else
            {
                _allowedOperations = AllowedOperations.All;
                MessageBox.Show("Вам доступны все функции программы, пока не будет определён пользователь с административными правами");
            }
        }

        /// <summary>
        /// Разрешение пунктов меню Регистратура
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiReception_DropDownOpening(object sender, EventArgs e)
        {
            tsmiClients.Enabled = tsmiReservations.Enabled = tsmiTransfer.Enabled =
                tsmiAccordancePayChannels.Enabled = tsmiSaveToBase.Enabled = 
                _allowedOperations.HasFlag(AllowedOperations.ManageClients);
        }

        /// <summary>
        /// Разрешение пунктов меню Настройка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiTuning_DropDownOpening(object sender, EventArgs e)
        {
            tsmiEmployees.Enabled = tsmiTuningRooms.Enabled = tsmiCategories.Enabled =
                tsmiServices.Enabled = tsmiEmployeeRoles.Enabled = tsmiPayChannelsTV.Enabled = 
                _allowedOperations.HasFlag(AllowedOperations.ManageEmployees);
        }
    }
}
