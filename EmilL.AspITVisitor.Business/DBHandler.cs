using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmilL.AspITVisitor.DAL.EF;

namespace EmilL.AspITVisitor.Business
{
    public class DBHandler
    {
        private AspITVisitorModel model = new AspITVisitorModel();

        protected AspITVisitorModel Model
        {
            get { return model; }
            set { model = value; }
        }
        protected bool SaveChangeToDB()
        {
            int i = Model.SaveChanges();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    
}
