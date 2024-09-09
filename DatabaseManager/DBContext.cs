using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace DatabaseManager
{
    class DBContext : DbContext
    {
        public DbSet<CityList> CityLists { get; set; }
        public DbSet<ItemList> ItemLists { get; set; }
    }
}
