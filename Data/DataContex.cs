using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace webAPT_DEMO.Data
{
    public class DataContex : DbContext
    {
        public DataContex(DbContextOptions<DataContex> options) : base(options)
        {

        }

        public DbSet<Character> Characters =>Set<Character>();
    }
}