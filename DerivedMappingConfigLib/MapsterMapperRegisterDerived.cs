using BaseMappingConfigLib;
using EntitiesLib;
using Mapster;

namespace DerivedMappingConfigLib
{
    public class MapsterMapperRegisterDerived : MapsterInterfacesRegisterBase
    {
        public override void Register(TypeAdapterConfig config)
        {
            // here dto.Name is ignored
            base.Register(config);
            
            // here dto.SecondName is ignored
            config.ForType<CarPoco, CarDto>()
                .Ignore(dto => dto.SecondName);
            
            // as a result we have to get only dto.Id in mapper
        }
    }
}