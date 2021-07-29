using Mapster;
using MapsterConsoleExample.Domains;
using MapsterConsoleExample.Dtos;

namespace MapsterConsoleExample.MapsterRegisters
{
    public class MapsterInterfacesRegister : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            // Impacts MapToDto(Poco) mapping method => Major Priority
            config.NewConfig<Student, StudentDto>()
                .Ignore(dto => dto.EnrollmentDate)
                .Map(dto => dto.LastNameModified, "LastName");
                
            // Impacts MapToPoco(Dto) mapping method => Minor Priority
            config.NewConfig<StudentDto, Student>()
                .Ignore(poco => poco.EnrollmentDate)
                .Map(poco => poco.LastName, "LastNameModified");

            // config.NewConfig<Course, CourseDto>();
            // config.NewConfig<Enrollment, EnrollmentDto>();

        }
    }
}