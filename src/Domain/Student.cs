namespace ACMESchool.src.Domain
{
    public class Student
    {
        public Student()
        {
            Courses = new List<Course> { };
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}
