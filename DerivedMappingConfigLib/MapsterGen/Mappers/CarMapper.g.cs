using DerivedMappingConfigLib;
using EntitiesLib;

namespace DerivedMappingConfigLib.MapsterGen.Mappers
{
    public partial class CarMapper : ICarMapper
    {
        public CarDto MapToDto(CarPoco p1)
        {
            return p1 == null ? null : new CarDto() {Id = p1.Id};
        }
    }
}