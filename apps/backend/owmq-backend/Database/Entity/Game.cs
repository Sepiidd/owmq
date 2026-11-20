using Microsoft.EntityFrameworkCore;
namespace owmq_backend.Database.Entity;

public class Game{
	public int Id {get; set;}
	public DateTime CreatedAt {get; set;} = DateTime.UtcNow;
	//TODO: brainstorm more attributes and stuff

	public List<Round> Rounds {get; set;} = new List<Round>();
	public List<User> Users {get; set;} = new List<User>(); //implicit many to many, no explicit join table (EF Core does it)
}
