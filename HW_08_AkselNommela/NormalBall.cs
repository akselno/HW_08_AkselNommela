using System;
using System.Collections.Generic;
using System.Text;

namespace HW_08_AkselNommela
{
    class NormalBall : IBalls
    {
        protected double _startingPosition;
        protected double _finalPosition;
        protected double _time;
        protected double _ballDiameter;
        protected int _goalCoordinates = Math.Abs(-45);
        protected double _goalDepth;
        protected double _ballWeight;
        protected int _totalGoalCount;
        protected int _missedGoals;
        protected int _totalNumberOfGoalAttempts;
        protected string _sponsorName;
        protected double _ballCoordinate;

        public NormalBall(string name)
        {
            _sponsorName = name;
            _totalGoalCount = 0;
            _ballDiameter = 0.70;
            _goalDepth = 1.7;
            _ballWeight = 0.45;
        }

        public void CalculateAvgSpeed(double startingPosition, double finalPosition, double time)
        {
            _startingPosition = startingPosition;
            _finalPosition = finalPosition;
            _time = time;

            if (CheckCoordinatesForAvgSpeed())
            {
                double avgSpeedInKPH = 3.6 * (Math.Abs(finalPosition - startingPosition) / time);
                Console.WriteLine($"Average speed: {avgSpeedInKPH} km/h.");
            }
        }

        public void CheckIfGoalCounted(double ballCoordinate)
        {
            _ballCoordinate = ballCoordinate;

            if (CheckBallCoordinates())
            {
                if (Math.Abs(ballCoordinate) - _ballDiameter >= _goalCoordinates - _goalDepth)
                {
                    _totalGoalCount++;
                    Console.WriteLine("GOOOAAL!");
                }
                else
                {
                    _missedGoals++;
                    Console.WriteLine("No goal.");
                }
            }
        }

        public void TotalNumberOfGoalAttempts()
        {
            _totalNumberOfGoalAttempts = _totalGoalCount + _missedGoals;

            Console.WriteLine($"Total number of goal attempts: {_totalNumberOfGoalAttempts}");
            Console.WriteLine($"Total number of goals: {_totalGoalCount}");
        }

        public void CalculateKineticEnergy(double velocity)
        {
            if(velocity >= 0)
            {
                double kineticEnergy = 0.5 * _ballWeight * Math.Pow(velocity, 2);
                Console.WriteLine($"Kinetic energy of the ball is: {kineticEnergy} J.");
            }
            else
            {
                Console.WriteLine("Velocity must be positive");
            }
        }

        public virtual void CreateUniqueCode()
        {
            string ballCodeName;
            Random rnd = new Random();
            int randomNumber1 = rnd.Next(0, 9);
            int randomNumber2 = rnd.Next(0, 9);
            int randomNumber3 = rnd.Next(0, 9);
            int randomNumber4 = rnd.Next(0, 9);
            int randomNumber5 = rnd.Next(0, 9);

            if (_sponsorName.Length < 4)
            {
                ballCodeName = _sponsorName;
            }
            else
            {
                ballCodeName = _sponsorName.Substring(0,4);
            }
            Console.WriteLine($"Ball's unique code is: {ballCodeName}{randomNumber1}" +
                $"{randomNumber2}{randomNumber3}{randomNumber4}{randomNumber5}");
        }
        public bool CheckCoordinatesForAvgSpeed()
        {
            if (_startingPosition >= -45 && _startingPosition <= 45 && _finalPosition >= -45 && _finalPosition <= 45)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input, ball outside of the pitch (has to be between -45 and 45).");
                return false;
            }
        }
        public bool CheckBallCoordinates()
        {
            if (_ballCoordinate >= -45 && _ballCoordinate <= 45)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input, ball outside of the pitch (has to be between -45 and 45).");
                return false;
            }
        }
    } 
}
