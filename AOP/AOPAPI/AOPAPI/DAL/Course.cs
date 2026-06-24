namespace AOPAPI.DAL
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public virtual List<UserCourse> UserCourses { get; set; }
    }
}
