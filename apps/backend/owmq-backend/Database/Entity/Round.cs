using Microsoft.EntityFrameworkCore;
namespace owmq_backend.Database.Entity;

public class Round{
	public int Id {get; set;}
	public DateTime CreatedAt {get; set;} = DateTime.UtcNow;
	//TODO: brainstorm more attributes and stuff

	//a screenshot can be matched to one round, but a round only has one screenshot. one to many relationship
	public int ScreenshotId {get; set;}
	public ScreenshotMap Screenshot {get; set;} = null!; 
	public int GameId {get; set;}
	public Game Game {get; set;} = null!;
	public List<RoundGuess> Guesses {get; set;} = new List<RoundGuess>(); //one round can have many guesses, one to many relationship
}
