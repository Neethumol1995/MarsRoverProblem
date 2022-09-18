using MarsRoverProblem.Data.Entities;

namespace MarsRoverProblem.Repository.Invoker
{
    public class ExecuteAction : Provider.Invoker
    {
       
        // start movement of rover
       
        public Coordinates StartMoving(Provider.Command command, Coordinates coordinates)
        {
            return command.Execute(coordinates);
        }
    }
}
