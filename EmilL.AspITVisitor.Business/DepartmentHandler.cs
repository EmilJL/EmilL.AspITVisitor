using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmilL.AspITVisitor.DAL.EF;

namespace EmilL.AspITVisitor.Business
{
    public class DepartmentHandler : DBHandler
    {
        public List<Department> getAllDepartments()
        {
            return Model.Departments.ToList();
        }
        public Department GetDepartment(int id)
        {
            return Model.Departments.Find(id);
        }
        public bool AddDepartment(Department department)
        {
            Model.Departments.Add(department);
            return SaveChangeToDB();
        }
        public bool RemoveDepartment(int id)
        {
            Model.Departments.Remove(Model.Departments.Find(id));
            return SaveChangeToDB();
        }
        public bool UpdateDepartment(int id, Department department)
        {
            var dpment = Model.Departments.Find(id);
            dpment.Address = department.Address;
            dpment.Name = department.Name;
            dpment.ZipCode = department.ZipCode;
            return SaveChangeToDB();
        }
    }
}
