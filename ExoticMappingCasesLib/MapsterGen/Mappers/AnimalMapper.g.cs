using System;
using System.Collections.Generic;
using System.Linq;
using ExoticCasesConsole.MultipleObjectsMapping;

namespace ExoticCasesConsole.MapsterGen.Mappers
{
    public partial class AnimalMapper : IAnimalMapper
    {
        public AnimalPoco MapToPoco(ValueTuple<AnimalDto1, AnimalDto2> p1)
        {
            return new AnimalPoco() {Numbers = funcMain1(p1.Item1.Numbers.Union<int>(p1.Item2.Numbers))};
        }
        
        private List<int> funcMain1(IEnumerable<int> p2)
        {
            if (p2 == null)
            {
                return null;
            }
            List<int> result = new List<int>();
            
            IEnumerator<int> enumerator = p2.GetEnumerator();
            
            while (enumerator.MoveNext())
            {
                int item = enumerator.Current;
                result.Add(item);
            }
            return result;
            
        }
    }
}