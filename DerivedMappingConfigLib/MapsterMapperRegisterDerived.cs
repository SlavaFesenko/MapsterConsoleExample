using BaseMappingConfigLib;
using EntitiesLib;
using Mapster;

namespace DerivedMappingConfigLib
{
    public class MapsterMapperRegisterDerived : MapsterInterfacesRegisterBase
    // public class MapsterMapperRegisterDerived : IRegister
    {
        public override void Register(TypeAdapterConfig config)
        // public void Register(TypeAdapterConfig config)
        {
            base.Register(config);
            
            config.ForType<CarPoco, CarDto>()
                .Ignore(dto => dto.SecondName);
        }
    }
}