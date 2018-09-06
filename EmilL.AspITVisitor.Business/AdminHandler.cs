using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmilL.AspITVisitor.DAL.EF;

namespace EmilL.AspITVisitor.Business
{
    public class AdminHandler : DBHandler
    {
        public List<Admin> GetAllAdmins()
        {
            return Model.Admins.ToList();
        }
        public Admin GetAdmin(int id)
        {
            return Model.Admins.Find(id);
        }
        public bool AddAdmin(Admin admin)
        {
            Model.Admins.Add(admin);
            return SaveChangeToDB();
        }
        public bool RemoveAdmin(int id)
        {
            Model.Admins.Remove(Model.Admins.Find(id));
            return SaveChangeToDB();
        }
        public bool UpdateAdmin(int id, Admin admin)
        {
            var adm = Model.Admins.Find(id);
            adm.LastName = admin.LastName;
            adm.FirstName = admin.FirstName;
            return SaveChangeToDB();
        }
    }
}
