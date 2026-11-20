using Microsoft.EntityFrameworkCore;
namespace owmq_backend.Database.Entity;

[Index(nameof(MapName), IsUnique=true)]
public class Map{
	public int Id {get; set;}
	public required string MapName {get; set;}
	public required string MapType {get; set;}
	public string? OriginCountry {get; set;}
	public int GuessCount {get; set;}
	public int GuessCountSuccess {get; set;}
	public DateTime CreatedAt {get; set;} = DateTime.UtcNow;

	public List<ScreenshotMap> Screenshots {get; set;} = new List<ScreenshotMap>(); //one map has many screenshots, one to many relationship
}
