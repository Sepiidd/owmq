using Microsoft.EntityFrameworkCore;
using owmq_backend.Database.Entity;

namespace owmq_backend.Database;

//TODO: make db diagram and make classes and tables
public class owmqDbContext : DbContext{
	public DbSet<User> Users {get; set;}
	public DbSet<Game> Games {get; set;}
	public DbSet<Round> Rounds {get; set;}
	public DbSet<RoundGuess> RoundGuesses {get; set;}
	public DbSet<Map> Maps {get; set;}
	public DbSet<ScreenshotMap> MapScreenshots {get; set;}

	public owmqDbContext(DbContextOptions<owmqDbContext> options) : base(options){ // base() calls parent constructor, similar to super() in java
	}

}
