using System;
using System.Collections.Generic;
using System.Text;

namespace HW_08_AkselNommela
{
    class YouthBall : NormalBall
    {
        public YouthBall(string name) : base(name)
        {
            _sponsorName = name;
            _totalGoalCount = 0;
            _ballDiameter = 0.56;
            _goalDepth = 1.4;
            _ballWeight = 0.38;
        }

        public override void CreateUniqueCode()
        {
            string ballCodeName;
            Random rnd = new Random();
            int randomNumber1 = rnd.Next(0, 9);
            int randomNumber2 = rnd.Next(0, 9);
            int randomNumber3 = rnd.Next(0, 9);

            if (_sponsorName.Length < 3)
            {
                ballCodeName = _sponsorName;
            }
            else
            {
                ballCodeName = _sponsorName.Substring(0, 3);
            }
            Console.WriteLine($"Ball's unique code is: {ballCodeName}{randomNumber1}" +
                $"{randomNumber2}{randomNumber3}");
        }
    }
}
