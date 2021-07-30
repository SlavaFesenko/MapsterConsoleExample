using EntitiesLib;
using Mapster;

namespace BaseMappingConfigLib
{
    // [Mapper]
    public interface ICarMapper
    {
        CarDto MapToDto(CarPoco carPoco);
    }
}