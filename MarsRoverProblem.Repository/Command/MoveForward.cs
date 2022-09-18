using MarsRoverProblem.Data.Constants;
using MarsRoverProblem.Data.Entities;
using System;
using System.Collections.Generic;

namespace MarsRoverProblem.Repository.Command
{
    public class MoveForward : Provider.Command
    {
        
        // maximum limit of rover
        
        private List<int> maxLst = new List<int>();

        
        // constructor for using maxLst
        
        public MoveForward(List<int> maxLst)
        {
            this.maxLst = maxLst;
        }

       
        // execute movement
        
        public Coordinates Execute(Coordinates coordinates)
        {
            switch (coordinates.Dir)
            {
                case Directions.N:
                    if (coordinates.Y >= maxLst[1])
                        coordinates = RoverCantMove();
                    else
                        coordinates.Y += 1;
                    break;

                case Directions.E:
                    if (coordinates.X >= maxLst[0])
                        coordinates = RoverCantMove();
                    else
                        coordinates.X += 1;
                    break;

                case Directions.S:
                    if (coordinates.Y != 0)
                        coordinates.Y -= 1;
                    else
                        coordinates = RoverCantMove();
                    break;

                case Directions.W:
                    if (coordinates.X != 0)
                        coordinates.X -= 1;
                    else
                        coordinates = RoverCantMove();
                    break;
            }
            return coordinates;
        }

       
        private Coordinates RoverCantMove()
        {
            Console.WriteLine("Can't Move");
            return null;
        }
    }
}
