using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApp
{
    public class CarStore
    {
        public List<Car> Cars { get; set; }

        public CarStore()
        {
            Cars = new List<Car>();
        }

        public CarStore(List<Car> cars)
        {
            Cars = cars;
        }

        public List<Car> GetAllStoreCars()
        {
            return Cars;
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void AddCars(List<Car> cars)
        {
            Cars.AddRange(cars);
        }

        // Todo: implement it for are equal


        //public override bool Equals(object obj)
        //{
        //    var carStore = obj as CarStore;
        //    if (carStore.Cars.Count != this.Cars.Count)
        //        return false;

        //    for (int i = 0; i < carStore.Cars.Count; i++)
        //    {
        //        var isEqual = this.Cars[i].Equals(carStore.Cars[i]);
        //        if (!isEqual) return false;
        //    }

        //    return true;
        //}

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
