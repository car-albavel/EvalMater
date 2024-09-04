using Microsoft.EntityFrameworkCore;

namespace Web.Api.AttackingSharpp.Shared.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options)
        : base(options){ }

        public DbSet<QuizItem> QuizItems { get; set; }
    }
}
