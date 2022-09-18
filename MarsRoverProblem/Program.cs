using MarsRoverProblem.Repository.Invoker;
using MarsRoverProblem.Repository.Provider;
using MarsRoverProblem.Service;
using MarsRoverProblem.Service.Provider;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MarsRoverProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var maxPoints = Console.ReadLine().Split(' ');
            var currentLocation = Console.ReadLine().Split(' ');
            var movement = Console.ReadLine();

            var services = new ServiceCollection();
            services.AddSingleton<IMarsRoverProblemSolutionService, MarsRoverProblemSolutionService>();
            services.AddSingleton<Invoker, ExecuteAction>();
            var _serviceProvider = services.BuildServiceProvider(true);
            var _marsRoverProblemSolutionService = _serviceProvider.GetService<IMarsRoverProblemSolutionService>();
            var _invoker = _serviceProvider.GetService<Invoker>();

            var coordinates = _marsRoverProblemSolutionService.MoveRoverSync(maxPoints, currentLocation, movement, _invoker);
            if (coordinates != null)
                Console.WriteLine(coordinates.X + " " + coordinates.Y + " " + coordinates.Dir);
            else
                Console.WriteLine("Bad Request");

            DisposeServices(_serviceProvider);
        }

        // dispose services
        private static void DisposeServices(ServiceProvider _serviceProvider)
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }
    }
}
