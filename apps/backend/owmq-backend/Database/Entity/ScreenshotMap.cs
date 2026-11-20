using Microsoft.EntityFrameworkCore;
namespace owmq_backend.Database.Entity;

[Index(nameof(Filename), IsUnique=true)]
public class ScreenshotMap{
	public int Id {get; set;}
	public required string Filename {get; set;}
	public int GuessCount {get; set;}
	public int GuessCountSuccess {get; set;}
	public DateTime CreatedAt {get; set;} = DateTime.UtcNow;

	public int MapId {get; set;}
	public Map Map {get; set;} = null!; //a screenshot can be matched only to one map, one to many relationship
	public required List<Round> Rounds {get; set;} = new List<Round>(); //one screenshot can be matched to many rounds, one to many relationship
}
