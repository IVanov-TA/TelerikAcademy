using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class ChickenParticle : ChaoticParticle
    {
        private const int DelayTicks = 7;

        private bool layEgg;
        private int delayCounter = 0;

        public ChickenParticle(MatrixCoords position, MatrixCoords speed, Random randomGenerated)
            : base(position, speed, randomGenerated, 1, 1)
        {
            this.layEgg = false;
        }

        public override char[,] GetImage()
        {
            return new char[,] { { 'C', 'h', 'i', 'c', 'k', 'e', 'n' } };
        }

        public override IEnumerable<Particle> Update()
        {
            if (layEgg)
            {
                this.delayCounter++;

                if (delayCounter == ChickenParticle.DelayTicks)
                {
                    this.delayCounter = 0;
                    this.layEgg = false;
                    return GenerateChickenParticle();
                }

                return base.Update();
            }

            if (this.RandomGenerated.Next(16) % 3 == 1)
            {
                this.layEgg = true;
            }

            return base.Update();

        }

        private IEnumerable<Particle> GenerateChickenParticle()
        {
            return new List<Particle>(){new ChickenParticle(this.Position, this.Speed, this.RandomGenerated)};
        }
    }
}
