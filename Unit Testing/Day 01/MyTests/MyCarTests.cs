using CarsApp;

namespace MyTests
{
    public class MyCarTests
    {
        private readonly Car _car;
        private readonly Car _otherCar;
        public MyCarTests()
        {
            _car = new Car();
            _otherCar = new Car();
        }
        [Fact]
        public void Equals_SimilarCars_ShouldBeTrue()
        {
            // Arrange
            _car.Type = CarType.Honda;
            _otherCar.Type = CarType.Honda;

            // Act
            var result = _car.Equals(_otherCar);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Equals_DifferentCars_ShouldBeFalse()
        {
            // Arrange
            _car.Type = CarType.Honda;
            _otherCar.Type = CarType.Toyota;

            // Act
            var result = _car.Equals(_otherCar);

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData("red")]
        public void SetColor_ChangeColor_ShouldBeSaved(string color)
        {
            // Arrange
            // _car

            // Act
            _car.SetColor(color);

            // Assert
            Assert.Equal(_car.GetColor(), color);
        }

        [Fact]
        public void NullableColor_ShouldBeNull()
        {
            // Arrange
            // _car

            // Act
            var color = _car.GetColor();

            Assert.Null(color);
        }

        [Theory]
        [InlineData("green")]
        //[InlineData("red")] fail
        public void GetColor_Color_ContainsSubstring(string check)
        {
            // Arrange
            _car.SetColor(check);

            // Act
            var color = _car.GetColor();

            // Assert
            Assert.Contains("ee", check);
        }

        [Theory]
        [InlineData("green")]
        [InlineData("gray")] 
        public void GetColor_Color_StartsWithSubstring(string check)
        {
            // Arrange
            _car.SetColor(check);

            // Act
            var color = _car.GetColor();

            // Assert
            Assert.StartsWith("gr", check);
        }
    }
}
