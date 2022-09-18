using MarsRoverProblem.Data.Constants;
using MarsRoverProblem.Data.Entities;

namespace MarsRoverProblem.Repository.Command
{
    public class MoveRight : Provider.Command
    {
        
        // execute rotation
        
        public Coordinates Execute(Coordinates coordinates)
        {
            switch (coordinates.Dir)
            {
                case Directions.N:
                    coordinates.Dir = Directions.E;
                    break;

                case Directions.E:
                    coordinates.Dir = Directions.S;
                    break;

                case Directions.S:
                    coordinates.Dir = Directions.W;
                    break;

                case Directions.W:
                    coordinates.Dir = Directions.N;
                    break;
            }
            return coordinates;
        }
    }
}
