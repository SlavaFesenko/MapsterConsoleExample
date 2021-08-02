using Mapster;

namespace ExoticCasesLib
{
    public class MapsterInterfacesRegister : IRegister
    {
        public virtual void Register(TypeAdapterConfig config)
        {
            // TODO: map UserPoco Shadow in UserDto
            config.NewConfig<UserPoco, UserDto>();
        }
    }
}