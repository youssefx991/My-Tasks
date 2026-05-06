using SD46API.Models;

namespace SD46API.Repo
{
    public interface IEmpRepo
    {
         List<Employee> getAll();

         Employee getById(int id);

         Employee getByName(string name);

         void Add(Employee d);

         void Edit(Employee d);

         void Delete(Employee d);
         void Save();


        List<Employee> getAllwithDept();
      
    }
}
