using MarsRoverProblem.Data.Constants;

namespace MarsRoverProblem.Data.Entities
{
    public class Coordinates
    {
        // x coordinate
        public int X { get; set; }

       
        // y coordinate
        public int Y { get; set; }

        
        // rover facing direction
        public Directions Dir { get; set; }
    }
}
