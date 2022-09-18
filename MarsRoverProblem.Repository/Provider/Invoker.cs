using MarsRoverProblem.Data.Entities;

namespace MarsRoverProblem.Repository.Provider
{
    public interface Invoker
    {
        
        // start rover movement
        
        Coordinates StartMoving(Command command, Coordinates coordinates);
    }
}
