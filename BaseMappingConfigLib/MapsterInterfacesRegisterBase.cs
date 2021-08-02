using EntitiesLib;
using Mapster;

namespace BaseMappingConfigLib
{
    public class MapsterInterfacesRegisterBase : IRegister
    {
        public virtual void Register(TypeAdapterConfig config)
        {
            config.NewConfig<CarPoco, CarDto>()
                .Ignore(dto => dto.Name);
        }
    }
}