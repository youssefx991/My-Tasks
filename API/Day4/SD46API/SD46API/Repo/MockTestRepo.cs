using SD46API.Models;

namespace SD46API.Repo
{
    public class MockTestRepo : IDeptRepo
    {
        static List<Department> DepartmentList = new List<Department>()
        {
             new Department(){Id = 10 , Name = "SD" , Manager ="Youssef"},
             new Department(){Id = 20 , Name = "UI" , Manager ="Nada"}
        };
            
        public void Add(Department d)
        {
            throw new NotImplementedException();
        }

        public void Delete(Department d)
        {
            throw new NotImplementedException();
        }

        public void Edit(Department d)
        {
            throw new NotImplementedException();
        }

        public List<Department> getAll()
        {
            return DepartmentList;
        }

        public Department getById(int id)
        {
            throw new NotImplementedException();
        }

        public Department getByIdWithEmps(int id)
        {
            throw new NotImplementedException();
        }

        public Department getByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
