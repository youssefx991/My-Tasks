using _7_NetCORE.Models;
using Microsoft.EntityFrameworkCore;

namespace _7_NetCORE.RepoServices
{
    public class StudentRepoService : IStudentRepository
    {
        //MainDbContext Context = new MainDbContext();

        //request service of type MainDbContext, create & inject obj of it using the options

        public MainDbContext Context { get; }
        public StudentRepoService(MainDbContext context)
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
            //if(ModelState.IsValid) 
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
                var updatedStd = Context.Students.Find(std.StudentID);

                updatedStd.StdName = std.StdName;
                updatedStd.Age = std.Age;
                updatedStd.Email = std.Email;
                updatedStd.IsActive = std.IsActive;
                updatedStd.Address = std.Address;
                updatedStd.Mobile = std.Mobile;
                updatedStd.Mark = std.Mark;
                updatedStd.Password = std.Password;
                updatedStd.BirthDate = std.BirthDate;
                updatedStd.DeptID = std.DeptID;

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
