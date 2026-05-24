using CarsApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTests
{
    public class MyCarStoreTests
    {
        private readonly CarStore _carStore;
        public MyCarStoreTests()
        {
            _carStore = new CarStore();
        }
        [Fact]
        public void ColorAllCars_AllCarsChangedToRed_AllColoredRed()
        {
            // Arrange
            _carStore.AddCars(new List<Car>
            {
                new Car(CarType.Honda),
                new Car(CarType.Toyota)
            });

            // Act
            _carStore.ColorAllCars("red");
            var cars = _carStore.GetAllStoreCars();
            // Assert
            Assert.All(cars, car => Assert.Equal("red", car.GetColor()));
        }

        [Fact]
        public void ColorOneCar_OnlyOneCarChangedToRed_OnlyOneColoredRed()
        {
            // Arrange
            _carStore.AddCars(new List<Car>
            {
                new Car(CarType.Honda),
                new Car(CarType.Toyota)
            });
            // Act
            _carStore.ColorOneCar("red", 0);
            var cars = _carStore.GetAllStoreCars();
            // Assert
            Assert.Single(cars, car => car.GetColor() == "red");
        }
    }
}
