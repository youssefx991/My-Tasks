using CarAPI.Entities;
using CarAPI.Repositories_DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarApiTests.Fake
{
    internal class FakeCarsRepository : ICarsRepository
    {
        public bool AddCar(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllCars()
        {
            throw new NotImplementedException();
        }

        public Car GetCarById(int id)
        {
            var car = new Car(id, CarType.Audi, 0);
            return car;
        }

        public bool Remove(int carId)
        {
            throw new NotImplementedException();
        }
    }

    internal class FakeCarsWithOwnerRepository : ICarsRepository
    {
        public bool AddCar(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllCars()
        {
            throw new NotImplementedException();
        }

        public Car GetCarById(int id)
        {
            var car = new Car(id, CarType.Audi, 0);
            car.Owner = new Owner();
            return car;
        }

        public bool Remove(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
