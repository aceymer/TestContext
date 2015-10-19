using DomainLogic.Model;
using System.Data.Entity;

namespace DomainLogic.Context
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(string dataBaseName) : base(dataBaseName)
        {
        }

        public DbSet<Room> Rooms { get; set; }
    }
}