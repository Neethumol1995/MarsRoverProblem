using FakeItEasy;
using MarsRoverProblem.Data.Entities;
using MarsRoverProblem.Repository.Invoker;
using MarsRoverProblem.Repository.Provider;
using MarsRoverProblem.Tests.MockObjects;
using Xunit;

namespace MarsRoverProblem.Tests.RepositoryTest
{
    public class ExecuteActionTest
    {
        
        // command reference
        private readonly Command _command;

        
        // invoker reference
        private readonly Invoker _invoker;

        
        // constructor for instantiating references
        public ExecuteActionTest()
        {
            _command = A.Fake<Command>();
            _invoker = new ExecuteAction();
        }

        
        // test for StartMovingSync
        [Fact]
        public void StartMovingSync_Test()
        {
            //Arrange
            var coordinates = MockData.Coordinates();
            A.CallTo(() => _command.Execute(A<Coordinates>._)).ReturnsLazily(() => coordinates);

            //Act
            var result = _invoker.StartMoving(_command, coordinates);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(result, coordinates);
        }
    }
}
