using owmq_backend.Dto.Authentication;
using owmq_backend.Dto.Map;
namespace owmq_backend.Interfaces;

public interface IMapService{
    CreateOutputDto AddMap(CreateDto MapInfo);
    MapOutputDto GetMapById(int id);
}
