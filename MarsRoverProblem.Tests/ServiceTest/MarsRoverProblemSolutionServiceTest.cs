using FakeItEasy;
using MarsRoverProblem.Data.Entities;
using MarsRoverProblem.Repository.Provider;
using MarsRoverProblem.Service;
using MarsRoverProblem.Service.Provider;
using MarsRoverProblem.Tests.MockObjects;
using Xunit;

namespace MarsRoverProblem.Tests.ServiceTest
{
    public class MarsRoverProblemSolutionServiceTest
    {
        
        // invoker reference
        private readonly Invoker _invoker;

        
        // IMarsRoverProblemSolutionService reference
        private readonly IMarsRoverProblemSolutionService _marsRoverProblemSolutionService;

        
        // constructor for instantiating references
        public MarsRoverProblemSolutionServiceTest()
        {
            _invoker = A.Fake<Invoker>();
            _marsRoverProblemSolutionService = new MarsRoverProblemSolutionService();
        }

        
        // test for MoveRoverSync method
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void MoveRoverSync_Test(bool isCoordinateNull)
        {
            //Arrange
            var maxPoints = MockData.MaxPoints;
            var currentLocation = MockData.CurrentLocation;
            var movement = MockData.Movement;
            var coordinates = MockData.Coordinates();
            if (!isCoordinateNull)
                A.CallTo(() => _invoker.StartMoving(A<Command>._, A<Coordinates>._)).ReturnsLazily(() => coordinates);
            else
                A.CallTo(() => _invoker.StartMoving(A<Command>._, A<Coordinates>._)).ReturnsLazily(() => null);

            //Act
            var result = _marsRoverProblemSolutionService.MoveRoverSync(maxPoints, currentLocation, movement, _invoker);

            //Assert
            if (!isCoordinateNull)
            {
                Assert.NotNull(result);
                Assert.Equal(coordinates.X, result.X);
                Assert.Equal(coordinates.Y, result.Y);
                Assert.Equal(coordinates.Dir, result.Dir);
            }
            else
            {
                Assert.Null(result);
            }
        }
    }
}
