using MapsterConsoleExample.Domains;

namespace MapsterConsoleExample.Dtos
{
    public class EnrollmentDto
    {
        public int EnrollmentId { get; set; }
        public Grade? Grade { get; set; }
        public CourseDto Course { get; set; }
    }
}