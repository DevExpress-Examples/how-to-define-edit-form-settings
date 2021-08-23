using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.Xpf;
using DevExpress.Xpf.Grid;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DefineEditFormSettings_MVVM {
    public class Employee : BindableBase {
        public int Id { get => GetValue<int>(); set => SetValue(value); }
        public int ParentId { get => GetValue<int>(); set => SetValue(value); }
        public string Name { get => GetValue<string>(); set => SetValue(value); }
        public string Position { get => GetValue<string>(); set => SetValue(value); }
        public string Department { get => GetValue<string>(); set => SetValue(value); }
    }
    public class MainViewModel : ViewModelBase {
        public ObservableCollection<Employee> Employees { get => GetValue<ObservableCollection<Employee>>(); set => SetValue(value); }

        public MainViewModel() {
            Employees = new ObservableCollection<Employee>(GetEmployees());
        }

        [Command]
        public void OnRowEditStarting(RowEditStartingArgs args) {
            if(args.RowHandle == DataControlBase.NewItemRowHandle) {
                args.CellEditors[0].Value = Employees.Count + 1;
                args.CellEditors[4].ReadOnly = true;

            } else {
                args.CellEditors[0].ReadOnly = true;
                args.CellEditors[4].ReadOnly = false;
            }
        }

        IEnumerable<Employee> GetEmployees() {
            yield return new Employee() { Id = 1, ParentId = 0, Name = "Gregory S. Price", Department = "", Position = "President" };
            yield return new Employee() { Id = 2, ParentId = 1, Name = "Irma R. Marshall", Department = "Marketing", Position = "Vice President" };
            yield return new Employee() { Id = 3, ParentId = 1, Name = "John C. Powell", Department = "Operations", Position = "Vice President" };
            yield return new Employee() { Id = 4, ParentId = 1, Name = "Christian P. Laclair", Department = "Production", Position = "Vice President" };
            yield return new Employee() { Id = 5, ParentId = 1, Name = "Karen J. Kelly", Department = "Finance", Position = "Vice President" };

            yield return new Employee() { Id = 6, ParentId = 2, Name = "Brian C. Cowling", Department = "Marketing", Position = "Manager" };
            yield return new Employee() { Id = 7, ParentId = 2, Name = "Thomas C. Dawson", Department = "Marketing", Position = "Manager" };
            yield return new Employee() { Id = 8, ParentId = 2, Name = "Angel M. Wilson", Department = "Marketing", Position = "Manager" };
            yield return new Employee() { Id = 9, ParentId = 2, Name = "Bryan R. Henderson", Department = "Marketing", Position = "Manager" };

            yield return new Employee() { Id = 10, ParentId = 3, Name = "Harold S. Brandes", Department = "Operations", Position = "Manager" };
            yield return new Employee() { Id = 11, ParentId = 3, Name = "Michael S. Blevins", Department = "Operations", Position = "Manager" };
            yield return new Employee() { Id = 12, ParentId = 3, Name = "Jan K. Sisk", Department = "Operations", Position = "Manager" };
            yield return new Employee() { Id = 13, ParentId = 3, Name = "Sidney L. Holder", Department = "Operations", Position = "Manager" };

            yield return new Employee() { Id = 14, ParentId = 4, Name = "James L. Kelsey", Department = "Production", Position = "Manager" };
            yield return new Employee() { Id = 15, ParentId = 4, Name = "Howard M. Carpenter", Department = "Production", Position = "Manager" };
            yield return new Employee() { Id = 16, ParentId = 4, Name = "Jennifer T. Tapia", Department = "Production", Position = "Manager" };

            yield return new Employee() { Id = 17, ParentId = 5, Name = "Judith P. Underhill", Department = "Finance", Position = "Manager" };
            yield return new Employee() { Id = 18, ParentId = 5, Name = "Russell E. Belton", Department = "Finance", Position = "Manager" };
        }
    }
}
