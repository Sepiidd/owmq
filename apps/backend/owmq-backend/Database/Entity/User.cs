using Microsoft.EntityFrameworkCore;
namespace owmq_backend.Database.Entity;

public class User{
	public int Id {get; set;}
	public DateTime CreatedAt {get; set;} = DateTime.UtcNow;
	//TODO: brainstorm more attributes and stuff

	public List<RoundGuess> Guesses {get; set;} = new List<RoundGuess>(); 
	public List<Game> Games {get; set;} = new List<Game>(); //implicit many to many, no explicit join table (EF Core does it)
}
