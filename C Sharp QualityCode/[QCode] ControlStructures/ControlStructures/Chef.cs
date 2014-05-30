using System;
using System.Linq;

namespace ControlStructures
{
    public class Chef
    {
        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();

            Peel(potato);
            Peel(carrot);

            Cut(potato);
            Cut(carrot);

            Bowl bowl = GetBowl();
            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private void Peel(Vegetable currentVegetable)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        private void Cut(Vegetable currentVegetable)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }
    }
}