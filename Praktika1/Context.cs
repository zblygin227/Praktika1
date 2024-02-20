using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika1
{
    public partial class AgentyEntities : DbContext
    {
        private static AgentyEntities context;
        public static AgentyEntities GetContext()
        {
            if (context == null) context = new AgentyEntities();
            return context;
        }
    }
}
