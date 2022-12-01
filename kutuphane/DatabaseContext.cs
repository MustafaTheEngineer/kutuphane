using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Data.Entity.DbContext;

namespace kutuphane
{
    public class DatabaseContext: DbContext
    {
        public DbSet<kitap> Kitaplar { get; set; }

    }
}
