using MarsRoverProblem.Data.Entities;

namespace MarsRoverProblem.Repository.Provider
{
    public interface Command
    {
        
        // execute rover rotation/movement
        public Coordinates Execute(Coordinates coordinates);
    }
}
