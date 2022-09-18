using MarsRoverProblem.Data.Constants;
using MarsRoverProblem.Repository.Command;
using MarsRoverProblem.Repository.Provider;
using MarsRoverProblem.Tests.MockObjects;
using Xunit;

namespace MarsRoverProblem.Tests.RepositoryTest
{
    public class MoveLeftTest
    {
        
        // command reference
        private readonly Command _command;

        
        // constructor for instantiating references
        public MoveLeftTest()
        {
            _command = new MoveLeft();
        }


        // test for Execute method
        /// <param name="directions"></param>
        [Theory]
        [InlineData(Directions.N)]
        [InlineData(Directions.E)]
        [InlineData(Directions.S)]
        [InlineData(Directions.W)]
        public void Execute_Test(Directions directions)
        {
            //Arrange
            var coordinates = MockData.Coordinates();
            switch (directions)
            {
                case Directions.N:
                    coordinates.Dir = Directions.N;
                    break;

                case Directions.E:
                    coordinates.Dir = Directions.E;
                    break;

                case Directions.S:
                    coordinates.Dir = Directions.S;
                    break;

                case Directions.W:
                    coordinates.Dir = Directions.W;
                    break;
            }

            //Act
            var result = _command.Execute(coordinates);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(coordinates, result);
        }
    }
}
