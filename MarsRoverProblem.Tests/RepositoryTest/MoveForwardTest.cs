using MarsRoverProblem.Data.Constants;
using MarsRoverProblem.Repository.Command;
using MarsRoverProblem.Repository.Provider;
using MarsRoverProblem.Tests.MockObjects;
using System.Collections.Generic;
using Xunit;

namespace MarsRoverProblem.Tests.RepositoryTest
{
    public class MoveForwardTest
    {
        
        // command reference
        private readonly Command _command;

        
        // max coordinates
        private readonly List<int> _maxLst;

        
        // constructor for instantiating references
        public MoveForwardTest()
        {
            _maxLst = MockData.MaxLst;
            _command = new MoveForward(_maxLst);
        }

        
        // test for execute
        [Theory]
        [InlineData(Directions.N)]
        [InlineData(Directions.E)]
        [InlineData(Directions.W)]
        [InlineData(Directions.S)]
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

                case Directions.W:
                    coordinates.Dir = Directions.W;
                    break;

                case Directions.S:
                    coordinates.Dir = Directions.S;
                    break;
            }

            //Act
            var result = _command.Execute(coordinates);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(coordinates, result);
        }

        
        // test for Execute failure
        
        [Theory]
        [InlineData(true, false, false, false)]
        [InlineData(false, true, false, false)]
        [InlineData(false, false, true, false)]
        [InlineData(false, false, false, true)]
        [InlineData(true, true, false, false)]
        [InlineData(true, false, false, true)]
        [InlineData(false, true, true, false)]
        [InlineData(false, false, true, true)]
        public void ExecuteTest_Failure(bool isYExceed, bool isXExceed, bool isYLess, bool isXLess)
        {
            //Arrange
            var coordinates = MockData.Coordinates();
            if (isYExceed)
            {
                coordinates.Y = 6;
                coordinates.Dir = Directions.N;
            }
            if (isXExceed)
            {
                coordinates.X = 6;
                coordinates.Dir = Directions.E;
            }
            if (isYLess)
            {
                coordinates.Y = 0;
                coordinates.Dir = Directions.S;
            }
            if (isXLess)
            {
                coordinates.X = 0;
                coordinates.Dir = Directions.W;
            }

            //Act
            var result = _command.Execute(coordinates);

            //Assert
            Assert.Null(result);
        }
    }
}
