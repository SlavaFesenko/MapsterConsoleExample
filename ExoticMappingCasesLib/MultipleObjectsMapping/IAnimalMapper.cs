using System;
using Mapster;

namespace ExoticCasesConsole.MultipleObjectsMapping
{
    [Mapper]
    public interface IAnimalMapper
    {
        AnimalPoco MapToPoco(ValueTuple<AnimalDto1, AnimalDto2> dtos);
    }
}