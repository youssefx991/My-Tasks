using CarsApp;
using System.Text.RegularExpressions;

namespace CarAppTests
{
    public class CarTests
    {

        private readonly Car _car;
        private readonly ITestOutputHelper _helper;

        public CarTests(ITestOutputHelper helper)
        {
            _car = new Car();
            _helper = helper;
            _helper.WriteLine("CTOR called");
        }

        #region Single object

        [Fact]
        [Trait("Priority", "2")]
        public void TimeToCoverProvidedDistance_Distnace100Velocity25_Time4()
        {
            // Arrange
            //var car = new Car();
            _car.Velocity = 25;

            // Act
            var result = _car.TimeToCoverProvidedDistance(100);

            // Assert
            Assert.Equal(4, result);
        }

        [Theory]
        [InlineData(0, 10)]
        [InlineData(20, 30)]
        [Trait("Category", "Parameterized")]
        [Trait("Priority", "1")]
        public void Accelerate_ToyotaCarVelocity20_Velocity30(double initialVeloctiy, double expectedVelocity)
        {
            // Arrange
            var car = new Car(CarType.Toyota);
            car.Velocity = initialVeloctiy;

            // Act
            car.Accelerate();

            // Assert
            Assert.Equal(expectedVelocity, car.Velocity);
        }

        #region Just for demo, not real unit tests

        [Fact]
        [Trait("Category", "NotParameterized")]
        [Trait("Priority", "2")]
        public void TwoCars_DifferentInstanceSameState_Equal()
        {
            var car1 = new Car(CarType.Honda, 20, DrivingMode.Forward);
            var car2 = new Car(CarType.Honda, 20, DrivingMode.Forward);


            Assert.Equal(car1, car2);
        }

        [Fact(Skip = "Testing skip behaviour")]
        [Trait("Category", "NotParameterized")]
        public void TwoCars_DifferentInstanceSameState_NotSame()
        {
            var car1 = new Car(CarType.Honda, 20, DrivingMode.Forward);
            var car2 = new Car(CarType.Honda, 20, DrivingMode.Forward);


            Assert.NotSame(car1, car2);
        }

        #endregion


        [Fact]
        public void GetMyCar_ExisitingCar_ReturnSameCar()
        {
            var car = new Car();

            var myCar = car.GetMyCar();

            Assert.Same(car, myCar);
            Assert.NotNull(myCar);
            Assert.IsType<Car>(myCar);
        }

        #endregion

        #region String

        [Fact]
        public void GetDirection_Forward_PrintForward()
        {
            // Arrange
            //var car = new Car();
            _car.DrivingMode = DrivingMode.Forward;

            // Act
            var result = _car.GetDirection();

            // Assert
            Assert.Matches(new Regex("^Forward$"), result);
            Assert.StartsWith("For", result);
            Assert.Contains("rwa", result);
        }

        [Fact]
        public void IsStopped_Velocity0_True()
        {
            var car = new Car();
            //car.Velocity = 10;
            //car.Stop(); // NEVER call another function in the unit test as it will make it brittle
            car.Velocity = 0;

            var result = car.IsStopped();

            Assert.True(result);
        }

        #endregion

        #region Exception

        [Fact]
        public void Accelerate_CarTypeHonda_ThrowException()
        {
            var car = new Car();
            car.Type = CarType.Honda;

            Assert.Throws<NotImplementedException>(() => car.Accelerate());
        }
        #endregion

    }
}
