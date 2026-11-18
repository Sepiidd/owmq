using Microsoft.EntityFrameworkCore;

namespace owmq_backend.database

//TODO: make db diagram and make classes and tables
public class owmqDbContext : DbContext{
	public owmqDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){ // base() calls parent constructor, similar to super() in java
	}
}
