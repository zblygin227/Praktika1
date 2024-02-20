using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika1
{
    public partial class AgencyEntities : DbContext
    {
        private static AgencyEntities context;
        public static AgencyEntities GetContext()
        {
            if (context == null) context = new AgencyEntities();
            return context;
        }
    }
}
