using MarsRoverProblem.Data.Entities;
using System;
using System.Collections.Generic;

namespace MarsRoverProblem.Tests.MockObjects
{
   
    // class for mocking data
    
    public static class MockData
    {
        
        // max coordinates
        public static string[] MaxPoints = { "5", "5" };

       
        // current rover location
        public static string[] CurrentLocation = { "1", "2", "N" };

       
        // commands for moving rover
        public static string Movement = "LMLMLMLMM";

        
        // coordinates of rover location
        public static Coordinates Coordinates()
        {
            return new Coordinates
            {
                X = 1,
                Y = 2,
                Dir = Data.Constants.Directions.N
            };
        }

       
        // list of max coordinates
        public static List<int> MaxLst => new List<int> { Convert.ToInt32(MaxPoints[0]), Convert.ToInt32(MaxPoints[1]) };
    }
}
