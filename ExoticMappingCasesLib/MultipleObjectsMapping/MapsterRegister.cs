using System;
using System.Linq;
using Mapster;

namespace ExoticCasesConsole.MultipleObjectsMapping
{
    public class MapsterRegister : IRegister
    {
        public virtual void Register(TypeAdapterConfig config)
        {
            config.NewConfig<ValueTuple<AnimalDto1, AnimalDto2>, AnimalPoco>()
                .Map(poco => poco.Numbers, src => src.Item1.Numbers.Union(src.Item2.Numbers));
        }
    }
}