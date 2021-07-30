using Mapster;
using MapsterConsoleExample.Domains;
using MapsterConsoleExample.Dtos;

namespace MapsterConsoleExample.MappingInterfaces
{
    // [Mapper]
    public interface IStudentMapper
    {
        StudentDto MapToDto(Student student);
        // Student MapToPoco(StudentDto student);
    }
}