using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace EmployeeGrid
{
    public class ColorConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                DataGridCell cell = (DataGridCell)value;
                Employee employee = (Employee)cell.DataContext;

                if (employee.Department == "HR")
                    return Brushes.Blue;

                if (employee.Salary > 60000)
                    return Brushes.Green;

                if (employee.Salary < 60000)
                    return Brushes.Red;

                return DependencyProperty.UnsetValue;
            }
            catch (Exception e)
            {
                return DependencyProperty.UnsetValue;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
