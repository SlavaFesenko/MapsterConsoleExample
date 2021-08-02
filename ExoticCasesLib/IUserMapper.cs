using Mapster;

namespace ExoticCasesLib
{
    // [Mapper]
    public interface IUserMapper
    {
        UserDto MapToDto(UserPoco student);
    }
}