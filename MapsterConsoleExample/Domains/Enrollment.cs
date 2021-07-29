namespace MapsterConsoleExample.Domains
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public Grade? Grade { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}