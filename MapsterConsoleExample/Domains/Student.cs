using System;
using System.Collections.Generic;

namespace MapsterConsoleExample.Domains
{
    public class Student
    {
        // one-2-one mapping check
        public int Id { get; set; }
        
        // ignore case mapping check (FirstMidName in dto, no rules applied)
        public string FirstmidName { get; set; } // NOT MAPPING WITHOUT RULES
        
        // another prop name mapping check (LastNameModified in dto, rule applied)
        public string LastName { get; set; }
        
        // convert enum=>string mapping check (no rules)
        public Grade GradeString { get; set; }
        
        // convert enum=>int mapping check (no rules)
        public Grade GradeInt { get; set; }
        
        // ignore property mapping check (rule applied)
        public DateTime EnrollmentDate { get; set; }
        
        // collection of complex type mapping check
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}