using SD46API.Models;

namespace SD46API.Repo
{
    public interface IDeptRepo
    {
        List<Department> getAll();

        Department  getById(int id);

        Department  getByName(string name);

        void Add(Department  d);

        void Edit(Department  d);

        void Delete(Department  d);
        void Save();


        Department  getByIdWithEmps(int id);
    }
}
