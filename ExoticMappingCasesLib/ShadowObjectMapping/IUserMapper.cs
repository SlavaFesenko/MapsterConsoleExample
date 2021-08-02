using Mapster;

namespace ExoticCasesConsole.ShadowObjectMapping
{
    // [Mapper]
    public interface IUserMapper
    {
        UserDto MapToDto(UserPoco student);
    }
}