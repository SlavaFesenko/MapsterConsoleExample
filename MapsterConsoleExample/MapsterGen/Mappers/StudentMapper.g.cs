using System.Collections.Generic;
using Mapster.Utils;
using MapsterConsoleExample.Domains;
using MapsterConsoleExample.Dtos;
using MapsterConsoleExample.MappingInterfaces;

namespace MapsterConsoleExample.MapsterGen.Mappers
{
    public partial class StudentMapper : IStudentMapper
    {
        public StudentDto MapToDto(Student p1)
        {
            return p1 == null ? null : new StudentDto()
            {
                Id = p1.Id,
                LastNameModified = p1.LastName,
                GradeString = Enum<Grade>.ToString(p1.GradeString),
                GradeInt = (int)p1.GradeInt,
                Enrollments = funcMain1(p1.Enrollments)
            };
        }
        
        private ICollection<EnrollmentDto> funcMain1(ICollection<Enrollment> p2)
        {
            if (p2 == null)
            {
                return null;
            }
            ICollection<EnrollmentDto> result = new List<EnrollmentDto>(p2.Count);
            
            IEnumerator<Enrollment> enumerator = p2.GetEnumerator();
            
            while (enumerator.MoveNext())
            {
                Enrollment item = enumerator.Current;
                result.Add(item == null ? null : new EnrollmentDto()
                {
                    EnrollmentId = item.EnrollmentId,
                    Grade = item.Grade,
                    Course = item.Course == null ? null : new CourseDto()
                    {
                        CourseId = item.Course.CourseId,
                        Title = item.Course.Title,
                        Credits = item.Course.Credits
                    }
                });
            }
            return result;
            
        }
    }
}