using Mapster;

namespace ExoticCasesConsole.ShadowObjectMapping
{
    public class MapsterInterfacesRegister : IRegister
    {
        public virtual void Register(TypeAdapterConfig config)
        {
            config.NewConfig<UserPoco, UserDto>()
                .Map(dto => dto.UserShadow, poco => poco)
                .TwoWays();
        }
    }
}