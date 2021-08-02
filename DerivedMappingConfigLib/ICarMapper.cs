using EntitiesLib;
using Mapster;

namespace DerivedMappingConfigLib
{
    // [Mapper]
    public interface ICarMapper
    {
        CarDto MapToDto(CarPoco carPoco);
    }
}