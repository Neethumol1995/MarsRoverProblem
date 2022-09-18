using MarsRoverProblem.Data.Entities;
using MarsRoverProblem.Repository.Provider;

namespace MarsRoverProblem.Service.Provider
{
    public interface IMarsRoverProblemSolutionService
    {
        
        // rover movement
        Coordinates MoveRoverSync(string[] maxPoints, string[] currentLocation, string movement, Invoker _invoker);
    }
}
