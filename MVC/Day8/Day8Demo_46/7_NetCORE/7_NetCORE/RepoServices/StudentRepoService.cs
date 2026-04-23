using _7_NetCORE.Models;
using Microsoft.EntityFrameworkCore;

namespace _7_NetCORE.RepoServices
{
    public class StudentRepoService : IStudentRepository
    {
        public StdContext Context { get; }
        public StudentRepoService(StdContext context)
        {
            Context = context;
        }

        public List<Student> GetAll()
        {
            return Context.Students.Include(s => s.Department).ToList();
        }

        public Student GetDetails(int id)
        {
            return Context.Students.Include(s => s.Department).FirstOrDefault(s => s.StudentID == id);
        }

        public void Insert(Student std)
        {
            //if(ModelState.IsValid) //maynfa3sh nesta7'dmha hena 3shan di proprty lel Controller
            if(std != null) 
            {
                Context.Students.Add(std);
                Context.SaveChanges();
            }
        }

        public void UpdateStd(Student std)
        {
            if(std != null) 
            {
                    var stdUpdated = Context.Students.Find(std.StudentID);

                    stdUpdated.StdName = std.StdName;
                    stdUpdated.Age = std.Age;
                    stdUpdated.Email = std.Email;
                    stdUpdated.IsActive = std.IsActive;
                    stdUpdated.Password = std.Password;
                    stdUpdated.DeptID = std.DeptID;

                    Context.SaveChanges();

                //Context.Students.Update(std);
                //Context.SaveChanges();
            }
        }

        public void DeleteStd(int id)
        {
            var student = Context.Students.Find(id);
            if (student != null)
            {
                Context.Students.Remove(student);
                Context.SaveChanges();
            }
        }
    }
}
