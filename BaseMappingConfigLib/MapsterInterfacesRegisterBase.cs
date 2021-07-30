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
            
            // config.ForType<CarPoco, CarDto>()
            //     .Ignore(dto => dto.SecondName);
            
           
            
           
        }
    }

    // public static class ConfigExtensions
    // {
    //     public static TypeAdapterConfig TypeAdapterConfigExtension(this TypeAdapterConfig config)
    //     {
    //         return config.NewConfig<CarPoco, CarDto>()
    //             .Ignore(dto => dto.Name);
    //
    //         // return config;
    //     }
    // }
}