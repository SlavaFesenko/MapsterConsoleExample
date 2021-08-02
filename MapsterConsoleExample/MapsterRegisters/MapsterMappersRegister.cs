using System.Linq;
using Mapster;
using MapsterConsoleExample.Domains;
using MapsterConsoleExample.Dtos;

namespace MapsterConsoleExample.MapsterRegisters
{
    public class MapsterRegister : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            // Impacts MapToDto(Poco) mapping method => Major Priority
            config.NewConfig<Student, StudentDto>()
                .Ignore(dto => dto.EnrollmentDate)
                .Map(dto => dto.LastNameModified, poco => poco.LastName.Where(char.IsDigit))
                // .TwoWays() => for reverse mapping (NewConfig<StudentDto, Student>())
                .IgnoreNullValues(true);
                
            // Impacts MapToPoco(Dto) mapping method => Minor Priority
            config.NewConfig<StudentDto, Student>()
                .Ignore(poco => poco.EnrollmentDate)
                .Map(poco => poco.LastName, "LastNameModified")
                .IgnoreNullValues(true);
        }
    }
}