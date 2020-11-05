using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EmployeeGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var employees = new ObservableCollection<Employee>(EmployeeList());
            var employeeView = new CollectionViewSource { Source = employees }.View;
            DataContext = new EmployeeViewModel(employeeView);
        }

        private List<Employee> EmployeeList()
        {
            return new List<Employee>()
            {
                new Employee
                {
                    EmployeeId = 12345,
                    EmployeeName = "Derek",
                    Department = "IT",
                    Salary = 55000.34
                },
                 new Employee
                {
                    EmployeeId = 383848,
                    EmployeeName = "Mark",
                    Department = "HR",
                    Salary = 61000
                },
                 new Employee
                {
                    EmployeeId = 2828383,
                    EmployeeName = "Lisa",
                    Department = "IT",
                    Salary = 59999.99
                },
                 new Employee
                {
                    EmployeeId = 607075,
                    EmployeeName = "James",
                    Department = "Operations",
                    Salary = 80000
                }

            };
        }
    }
}
