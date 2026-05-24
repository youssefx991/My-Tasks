using CarAPI.Entities;
using CarAPI.Models;
using CarAPI.Payment;
using CarAPI.Repositories_DAL;
using CarAPI.Services_BLL;
using CarApiTests.Fake;
using Moq;
using System.Text.RegularExpressions;

namespace CarApiTests
{
    public class OwnersServiceTests
    {
        private readonly Mock<IOwnersRepository> _ownersRepositoryMock;
        private readonly Mock<ICarsRepository> _carsRepositoryMock;
        private readonly Mock<IPaymentService> _paymentServiceMock;
        private readonly OwnersService _ownersService;

        public OwnersServiceTests()
        {
            _ownersRepositoryMock = new Mock<IOwnersRepository>();
            _carsRepositoryMock = new Mock<ICarsRepository>();
            _paymentServiceMock = new Mock<IPaymentService>();
            _ownersService = new OwnersService(
                _ownersRepositoryMock.Object,
                _carsRepositoryMock.Object,
                _paymentServiceMock.Object
                );
        }

        #region Coupled on external state

        // Intended to fail as an example of dependency on external state
        [Fact(Skip = "Always failing for demo purpose")]
        public void BuyCar_ExistingNotSoldCarExistingOwnerWithNoCar_SuccessfullProcess_Coupled()
        {
            // Arrange
            var context = new InMemoryContext();
            var ownerService = new OwnersService(
                new OwnersRepository(context),
                new CarsRepository(context),
                new CashService()
                );
            var input = new BuyCarInput()
            {
                OwnerId = 1,
                CarId = 1,
                Amount = 100
            };

            // Act
            var result = ownerService.BuyCar(input);

            // Assert
            Assert.Contains("Successfull", result);
        }

        #endregion


        #region Fake

        [Fact]
        public void BuyCar_ExistingNotSoldCarExistingOwnerWithNoCar_SuccessfullProcess_Fake()
        {
            // Arrange
            var ownerService = new OwnersService(
                new FakeOwnersRepository(),
                new FakeCarsRepository(),
                new FakePaymentService()
                );
            var input = new BuyCarInput()
            {
                OwnerId = 1,
                CarId = 1,
                Amount = 100
            };

            // Act
            var result = ownerService.BuyCar(input);

            // Assert
            Assert.Contains("Successfull", result);
        }

        [Fact]
        public void BuyCar_ExistingSoldCar_AlreadySold()
        {
            // Arrange
            var ownerService = new OwnersService(
                new FakeOwnersRepository(),
                new FakeCarsWithOwnerRepository(),
                new FakePaymentService()
                );
            var input = new BuyCarInput()
            {
                OwnerId = 1,
                CarId = 1,
                Amount = 100
            };

            // Act
            var result = ownerService.BuyCar(input);

            // Assert
            Assert.Matches(new Regex("^Already sold$"), result);
        }
        #endregion


        #region Mocking

        [Fact]
        public void BuyCar_ExistingNotSoldCarExistingOwnerWithNoCar_SuccessfullProcess_Mock()
        {
            // Arrange
            var input = new BuyCarInput()
            {
                OwnerId = 1,
                CarId = 1,
                Amount = 100
            };
            _ownersRepositoryMock.Setup(m => m.GetOwnerById(input.OwnerId)).Returns(new Owner(input.OwnerId, ""));
            _carsRepositoryMock.Setup(m => m.GetCarById(input.CarId)).Returns(new Car(input.CarId));
            _paymentServiceMock.Setup(m => m.Pay(input.Amount)).Returns("Success");

            // Act
            var result = _ownersService.BuyCar(input);

            // Assert
            Assert.Contains("Successfull", result);
            _carsRepositoryMock.Verify(m => m.GetCarById(input.CarId), Times.Once);
            _ownersRepositoryMock.Verify(m => m.GetOwnerById(input.OwnerId), Times.Once);
            _paymentServiceMock.Verify(m => m.Pay(input.Amount), Times.Once);
        }

        #endregion
    }
}
