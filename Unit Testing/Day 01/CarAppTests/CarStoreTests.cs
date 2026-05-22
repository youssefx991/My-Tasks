using CarsApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarAppTests
{
    public class CarStoreTests
    {

        #region Collection

        [Fact]
        public void GetAllStoreCars_EqualCarsSameOrder_Equal()
        {
            var store = new CarStore()
            {
                Cars = new List<Car> { new Car(CarType.Honda), new Car(CarType.Toyota) }
            };

            var storeCars = store.GetAllStoreCars();

            var expected = new List<Car> { new Car(CarType.Honda), new Car(CarType.Toyota) };

            Assert.Equal(expected, storeCars);
        }

        [Fact]
        public void GetAllStoreCars_EqualCarsSameOrder_Equivalent()
        {
            var store = new CarStore()
            {
                Cars = new List<Car> { new Car(CarType.Honda), new Car(CarType.Toyota) }
            };

            var storeCars = store.GetAllStoreCars();

            var expected = new List<Car> { new Car(CarType.Toyota), new Car(CarType.Honda) };

            Assert.Equivalent(expected, storeCars);
            Assert.NotEqual(expected, storeCars);
        }

        [Fact]
        public void GetAllStoreCars_ValidateTypeOfEach_SuccessReturnOfTypes()
        {
            var store = new CarStore()
            {
                Cars = new List<Car> { new Car(CarType.Honda), new Car(CarType.Toyota) }
            };

            var storeCars = store.GetAllStoreCars();

            Assert.Collection(storeCars,
                car => Assert.Equal(CarType.Honda, car.Type),
                car => Assert.Equal(CarType.Toyota, car.Type)
                );
        }
        #endregion
    }
}
