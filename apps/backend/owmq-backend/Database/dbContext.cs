using Microsoft.EntityFrameworkCore;
using owmq_backend.Database.Entity;

namespace owmq_backend.Database;

//TODO: make db diagram and make classes and tables
public class owmqDbContext : DbContext{
	public owmqDbContext(DbContextOptions<owmqDbContext> options) : base(options){ // base() calls parent constructor, similar to super() in java
		
	}
}
