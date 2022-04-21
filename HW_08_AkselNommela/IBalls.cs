using System;
using System.Collections.Generic;
using System.Text;

namespace HW_08_AkselNommela
{
    interface IBalls
    {
        void CalculateAvgSpeed(double startingPosition, double finalPosition, double time);
        void CheckIfGoalCounted(double ballCoordinate);
        void TotalNumberOfGoalAttempts();
        void CalculateKineticEnergy(double velocity);
        void CreateUniqueCode();
    }
}
