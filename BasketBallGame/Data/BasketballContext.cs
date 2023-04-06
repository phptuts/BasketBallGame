using BasketBallGame.DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace BasketBallGame.Data
{
    public class BasketballContext : DbContext
    {
        public BasketballContext(DbContextOptions<BasketballContext> options): base(options)
        {

        }

        public DbSet<Game> games { get; set; } = null!;

    }


}
