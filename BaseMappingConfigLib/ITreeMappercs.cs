using EntitiesLib;
using Mapster;

namespace BaseMappingConfigLib
{
    // [Mapper]
    public interface ITreeMapper
    {
        TreeDto MapToDto(TreePoco carPoco);
    }
}