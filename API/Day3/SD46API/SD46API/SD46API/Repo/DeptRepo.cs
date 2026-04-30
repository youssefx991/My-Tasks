using Microsoft.EntityFrameworkCore;
using SD46API.Context;
using SD46API.Models;

namespace SD46API.Repo
{
    public class DeptRepo
    {
        CompanyContext db;
        public DeptRepo()
        {
            db =new CompanyContext();
        }
        public List<Department> getAll()
        {
            return db.Departments.ToList();
        }
        public Department getById(int id)
        {
            return db.Departments.FirstOrDefault(d => d.Id == id);
        }
        public Department getByName(string name)
        {
            return db.Departments.FirstOrDefault(d => d.Name == name);
        }
        public void Add(Department d)
        {
            db.Departments.Add(d);
            db.SaveChanges();
        }
        public void Edit(Department d)
        {
            db.Departments.Update(d);
            db.SaveChanges();
        }
        public void Delete(Department d)
        {
            db.Departments.Remove(d);
            db.SaveChanges();
        }
        public void Save()
        { 
            db.SaveChanges();
        }

        public Department getByIdWithEmps(int id)
        {
            return db.Departments.Include(d => d.Employees).FirstOrDefault(d => d.Id == id);
        }


    }
}
