using System.Data.Entity;
using CQRS.Entities;

namespace CQRS.Context
{
    public class CqrsContext : DbContext
    {
        public CqrsContext()
            : base("name=CQRSConnnectionString")
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
