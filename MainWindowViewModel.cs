using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1DropDownlist
{
    internal class MainWindowViewModel : BaseViewModel
    {
        public List<Dept> ListDept { get; set; } = new List<Dept>();
        public List<Emp> ListEmp1 { get; set; } = new List<Emp>();
        public List<Emp> ListEmp { get; set; } = new List<Emp>();


        private Dept SelectedDept;
        public Dept selectedDept
        {
            get { return SelectedDept; }

            set
            {

                if (SelectedDept != value)
                {
                    SelectedDept = value;
                    ListEmp1 = ListEmp.Where(x => x.DeptId == SelectedDept.DeptId).ToList();
                    OnPropertyChanged(nameof(ListEmp1));
                }
            }
        }            
        

        public MainWindowViewModel()
        {
            ListDept.Add(new Dept() { DeptId = 1, DeptName = "IT" });
            ListDept.Add(new Dept() { DeptId = 2, DeptName = "ACC" });
            ListDept.Add(new Dept() { DeptId = 3, DeptName = "HR" });

            OnPropertyChanged(nameof(ListDept));   
            
            ListEmp.Add(new Emp() { DeptId = 1,EmpId = 1, EmpName = "Ajay" });
            ListEmp.Add(new Emp() { DeptId = 2,EmpId = 2, EmpName = "Amey" });
            ListEmp.Add(new Emp() { DeptId = 3,EmpId = 3, EmpName = "Owais" });

            OnPropertyChanged(nameof(ListEmp));
        }
    }
}
