using System.IO;
namespace helpers.Images;

public class ImagesInit{
	string _path;

	public ImagesInit(){
		_path = "images";
	}

	public ImagesInit(string path){
		_path = path;
	}

	public void readImages(){
		Console.WriteLine("images path is {0}", _path);
	}
}
