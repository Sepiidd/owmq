using Microsoft.EntityFrameworkCore;
namespace owmq_backend.Database.Entity;

public class RoundGuess{
	public int Id {get; set;}
	public DateTime CreatedAt {get; set;} = DateTime.UtcNow;
	//TODO: brainstorm more attributes and stuff

	//explicit many to many relationship between rounds and users (created as independent one to many relationships)
	public int RoundId {get; set;}
	public Round Round {get; set;} = null!;
	public int UserId {get; set;}
	public User User {get; set;} = null!;
}
