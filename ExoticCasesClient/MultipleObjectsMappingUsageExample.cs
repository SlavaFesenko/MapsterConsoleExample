using System;
using System.Collections.Generic;
using ExoticCasesConsole.MultipleObjectsMapping;
using ExoticCasesConsole.MapsterGen.Mappers;

namespace ExoticCasesClient
{
    public static class MultipleObjectsMappingUsageExample
    {
        // TODO: use as a fundamental for unit test
        public static void Demonstrate()
        {
            IAnimalMapper mapper = new AnimalMapper();
            
            AnimalDto1 animalDto1 = new AnimalDto1 {Id = 1, Numbers = new List<int> {1, 2}};
            AnimalDto2 animalDto2 = new AnimalDto2 {Id = 1, Numbers = new List<int> {3, 4}};
            
            AnimalPoco animalPoco = mapper.MapToPoco((animalDto1, animalDto2));
            
            if (animalPoco.Numbers.Count != 4)
            {
                Console.WriteLine("AAAA!");
                throw new ApplicationException();
            }
            else
            {
                Console.WriteLine(string.Join(", ", animalPoco.Numbers));
            }
        }
    }
}