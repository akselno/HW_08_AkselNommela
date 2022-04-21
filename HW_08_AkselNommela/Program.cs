using System;

namespace HW_08_AkselNommela
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalBall normalBall = new NormalBall("Puma");
            YouthBall youthBall = new YouthBall("Nike");

            normalBall.CreateUniqueCode();
            normalBall.CalculateKineticEnergy(1);
            normalBall.CalculateKineticEnergy(2);
            normalBall.CalculateKineticEnergy(3);
            normalBall.CalculateKineticEnergy(4);
            normalBall.CalculateKineticEnergy(5);
            normalBall.CalculateKineticEnergy(-1);
            normalBall.CalculateAvgSpeed(-46, -45, 3);
            normalBall.CalculateAvgSpeed(10, 35, 1);
            normalBall.CalculateAvgSpeed(14, -20, 1.5);
            normalBall.CalculateAvgSpeed(18, -35, 2);
            normalBall.CalculateAvgSpeed(-14, 46, 5);
            normalBall.CalculateAvgSpeed(45, -45, 8);
            normalBall.CalculateAvgSpeed(-45, 45, 10);
            normalBall.CalculateAvgSpeed(-44.5, -20, 0.8);
            normalBall.CalculateAvgSpeed(5, 40, 1.2);
            normalBall.CalculateAvgSpeed(-38, -45, 0.4);
            normalBall.CheckIfGoalCounted(-46);
            normalBall.CheckIfGoalCounted(46);
            normalBall.CheckIfGoalCounted(-44);
            normalBall.CheckIfGoalCounted(-44.5);
            normalBall.CheckIfGoalCounted(-45);
            normalBall.CheckIfGoalCounted(44);
            normalBall.CheckIfGoalCounted(43);
            normalBall.CheckIfGoalCounted(10);
            normalBall.CheckIfGoalCounted(43.7);
            normalBall.CheckIfGoalCounted(20);
            normalBall.CheckIfGoalCounted(-44);
            normalBall.CheckIfGoalCounted(44);
            normalBall.CheckIfGoalCounted(40);
            normalBall.CheckIfGoalCounted(-39);
            normalBall.CheckIfGoalCounted(42);
            normalBall.CheckIfGoalCounted(40);
            normalBall.CheckIfGoalCounted(-38);
            normalBall.CheckIfGoalCounted(-44);
            normalBall.CheckIfGoalCounted(45);
            normalBall.CheckIfGoalCounted(44.2);
            normalBall.CheckIfGoalCounted(30);
            normalBall.CheckIfGoalCounted(44.7);
            normalBall.TotalNumberOfGoalAttempts();

            Console.WriteLine("");

            youthBall.CreateUniqueCode();
            youthBall.CalculateKineticEnergy(17);
            youthBall.CalculateAvgSpeed(-25, -44.5, 2);
            youthBall.CheckIfGoalCounted(-45.5);
            youthBall.CheckIfGoalCounted(46);
            youthBall.CheckIfGoalCounted(-43);
            youthBall.CheckIfGoalCounted(43.5);
            youthBall.CheckIfGoalCounted(-44);
            youthBall.CheckIfGoalCounted(-44.5);
            youthBall.CheckIfGoalCounted(44.5);
            youthBall.CheckIfGoalCounted(-44);
            youthBall.TotalNumberOfGoalAttempts();
        }
    }
}
