namespace owmq_backend.Database.Entity;

[Index(nameof(Filename), IsUnique=true)]
public class mapScreenshot{
	public int Id {get; set;}
	public string Filename {get; set;}
	public string Map {get; set;}
}
