using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class ParticleRepeller : Particle
    {
        public ParticleRepeller(MatrixCoords position, MatrixCoords speed, int repellerRadius)
            :base(position, speed)
        {
            this.Power = repellerRadius;
        }

        public int Power { get; private set; }

        public override char[,] GetImage()
        {
            return new char[,] { { 'R' } };
        }
    }
}
