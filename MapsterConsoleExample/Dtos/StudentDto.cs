using System;
using System.Collections.Generic;
using MapsterConsoleExample.Domains;

namespace MapsterConsoleExample.Dtos
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string LastNameModified { get; set; } // LastName
        
        public string GradeString { get; set; }
        
        public int GradeInt { get; set; }
        
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        
        public ICollection<EnrollmentDto> Enrollments { get; set; }

        public StudentDto Shadow { get; set; }
    }
}