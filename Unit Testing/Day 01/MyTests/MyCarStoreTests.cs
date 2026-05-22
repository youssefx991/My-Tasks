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
        public void ColorAllCars_WithSameColor_AllColored()
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
        public void ColorAllCars_WithSameColorExecptOne_AllColored()
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
            cars[1].SetColor("blue");

            // Assert
            Assert.Single(cars, car => car.GetColor() == "blue");
        }
    }
}
