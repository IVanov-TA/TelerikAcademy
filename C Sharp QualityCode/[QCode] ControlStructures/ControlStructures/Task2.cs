using System;
using System.Linq;

namespace ControlStructures
{
    class Task2
    {
        //cosmetic values
        public const int MinimumXValue = int.MinValue;
        public const int MaximumXValue = int.MaxValue;

        public const int MaximumYValue = int.MaxValue / 2;
        public const int MinimumYValue = int.MinValue / 2;

        //task 2.1
        public void RefactoringPotato()
        {
            Potato potato = new Potato();
            //... 
            if (potato != null)
            {
                // the two fields are made into the abstract class - Vegetable
                if (!(potato.HasNotBeenPeeled && potato.IsRotten)) 
                {
                    Cook(potato);
                }
            }
        }

        //task 2.2
        public void RefactoringTraversingList()
        {
            int currentX = 0;
            int currentY = 0;

            bool isVisited = false;
            bool isXValid = (MinimumXValue <= currentX) && (currentX <= MaximumXValue);
            bool isYValid = (MinimumYValue <= currentY) && (currentY <= MaximumYValue);

            if ((isXValid && isYValid) && !isVisited)
            {
                VisitCell();
            }
        }

        private void VisitCell()
        {
            throw new NotImplementedException();
        }

        private void Cook(Vegetable potato)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}