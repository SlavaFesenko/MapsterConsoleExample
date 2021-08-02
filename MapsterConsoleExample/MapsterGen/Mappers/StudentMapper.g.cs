using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Mapster.Utils;
using MapsterConsoleExample.Domains;
using MapsterConsoleExample.Dtos;
using MapsterConsoleExample.MappingInterfaces;

namespace MapsterConsoleExample.MapsterGen.Mappers
{
    public partial class StudentMapper : IStudentMapper
    {
        private RuntimeMethodInfo RuntimeMethodInfo1;
        
        public StudentDto MapToDto(Student p1)
        {
            if (p1 == null)
            {
                return null;
            }
            StudentDto result = new StudentDto();
            
            result.Id = p1.Id;
            
            if (p1.LastName.Where<char>((Func<char, bool>)RuntimeMethodInfo1.CreateDelegate(typeof(Func<char, bool>), null)) != null)
            {
                result.LastNameModified = funcMain1(p1.LastName.Where<char>((Func<char, bool>)RuntimeMethodInfo1.CreateDelegate(typeof(Func<char, bool>), null)));
            }
            result.GradeString = Enum<Grade>.ToString(p1.GradeString);
            result.GradeInt = (int)p1.GradeInt;
            
            if (p1.Enrollments != null)
            {
                result.Enrollments = funcMain2(p1.Enrollments);
            }
            return result;
            
        }
        
        private string funcMain1(IEnumerable<char> p2)
        {
            return p2 == null ? null : p2.ToString();
        }
        
        private ICollection<EnrollmentDto> funcMain2(ICollection<Enrollment> p3)
        {
            if (p3 == null)
            {
                return null;
            }
            ICollection<EnrollmentDto> result = new List<EnrollmentDto>(p3.Count);
            
            IEnumerator<Enrollment> enumerator = p3.GetEnumerator();
            
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