using Microsoft.EntityFrameworkCore;
using SD46API.Context;
using SD46API.Models;

namespace SD46API.Repo
{
    public class EmpRepo:IEmpRepo
    {
        CompanyContext db;
        public EmpRepo(CompanyContext _db)
        {
            db = _db;//new CompanyContext();
        }
        public List<Employee> getAll()
        {
            return db.Employee.ToList();
        }
        public Employee getById(int id)
        {
            return db.Employee.FirstOrDefault(d => d.Id == id);
        }
        public Employee getByName(string name)
        {
            return db.Employee.FirstOrDefault(d => d.Name == name);
        }
        public void Add(Employee d)
        {
            db.Employee.Add(d);
            db.SaveChanges();
        }
        public void Edit(Employee d)
        {
            db.Employee.Update(d);
            db.SaveChanges();
        }
        public void Delete(Employee d)
        {
            db.Employee.Remove(d);
            db.SaveChanges();
        }
        public void Save()
        {
            db.SaveChanges();
        }

        public List<Employee> getAllwithDept()
        {
            return db.Employee.Include(e => e.Department).ToList();
        }
    }
}
