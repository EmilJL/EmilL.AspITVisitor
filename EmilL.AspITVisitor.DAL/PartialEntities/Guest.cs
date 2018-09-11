using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmilL.AspITVisitor.DAL.EF
{
    public partial class Guest
    {
        public string Name
        {
            get { return FirstName + " " + LastName; }
        }
    }
}
