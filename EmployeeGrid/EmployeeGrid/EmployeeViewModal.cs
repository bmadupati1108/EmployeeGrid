using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeGrid
{
    class EmployeeViewModel
    {
        public ICollectionView Employees
        {
            get;
        }

        public EmployeeViewModel(ICollectionView employees)
        {
            Employees = employees;
        }
    }
}
