using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using PP_Nominas.Models;

namespace PP_Nominas.ViewModels
{
    public class DashboardViewModel : INotifyPropertyChanged
    {
        private string _userName = "Administrador";

        public event PropertyChangedEventHandler? PropertyChanged;

        public string UserName
        {
            get => _userName;
            set
            {
                if (_userName != value)
                {
                    _userName = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(WelcomeMessage));
                }
            }
        }

        public string WelcomeMessage => $"Hola {UserName}";

        public string CurrentDate => $"Hoy es {DateTime.Now.ToString("D")}";

        public ObservableCollection<KeyMetric> KeyMetrics { get; } = new();
        public ObservableCollection<Reminder> Reminders { get; } = new();

        public ICommand NavigateToPayrollCommand { get; }
        public ICommand NavigateToEmployeesCommand { get; }
        public ICommand NavigateToAttendanceCommand { get; }
        public ICommand NavigateToReportsCommand { get; }

        public DashboardViewModel()
        {
            NavigateToPayrollCommand = new Command(OnNavigateToPayroll);
            NavigateToEmployeesCommand = new Command(OnNavigateToEmployees);
            NavigateToAttendanceCommand = new Command(OnNavigateToAttendance);
            NavigateToReportsCommand = new Command(OnNavigateToReports);

            LoadSampleData();
        }

        public void LoadData()
        {
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            KeyMetrics.Clear();
            KeyMetrics.Add(new KeyMetric { Title = "Empleados", Value = "124", Description = "Activos" });
            KeyMetrics.Add(new KeyMetric { Title = "Nóminas", Value = "12", Description = "Este año" });
            KeyMetrics.Add(new KeyMetric { Title = "Pendientes", Value = "3", Description = "Por procesar" });

            Reminders.Clear();
            Reminders.Add(new Reminder
            {
                Title = "Pago de nómina",
                Description = "Procesar nómina del mes actual",
                DueDate = DateTime.Now.AddDays(3)
            });
            Reminders.Add(new Reminder
            {
                Title = "Declaraciones fiscales",
                Description = "Enviar declaración mensual",
                DueDate = DateTime.Now.AddDays(5)
            });
        }

        private void OnNavigateToPayroll()
        {
            Console.WriteLine("Navegar a nóminas");
        }

        private void OnNavigateToEmployees()
        {
            Console.WriteLine("Navegar a empleados");
        }

        private void OnNavigateToAttendance()
        {
            Console.WriteLine("Navegar a asistencias");
        }

        private void OnNavigateToReports()
        {
            Console.WriteLine("Navegar a reportes");
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}