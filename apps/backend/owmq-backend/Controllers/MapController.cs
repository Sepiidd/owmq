using Microsoft.AspNetCore.Mvc;
using owmq_backend.Dto.Map;
using owmq_backend.Services;
using owmq_backend.Interfaces;
namespace owmq_backend.Controllers;

[ApiController]
[Route("[controller]")] // route lives at controller name: /map
public class MapController : ControllerBase{

	private readonly ILogger<AuthenticationController> _logger;
	private readonly IMapService _service;

	public MapController(ILogger<AuthenticationController> logger, IMapService MapService){
		_logger = logger;
		_service = MapService;
	}

	[HttpPost("create")]
	public ActionResult<CreateOutputDto> CreateMap(CreateDto MapInfo){
		return _service.AddMap(MapInfo);
	}
		
	[HttpGet("{id}")]
	public ActionResult<MapOutputDto> GetMapById(int id){
		return _service.GetMapById(id);
	}
}
