

namespace APIGorena.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<APIGorena.Models.Gorena> Gorenas { get; set; }
    }
}