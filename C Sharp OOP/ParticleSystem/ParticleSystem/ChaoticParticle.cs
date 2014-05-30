using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class ChaoticParticle : Particle
    {
        private readonly int speedRow;
        private readonly int speedCol;
        public ChaoticParticle(MatrixCoords position, MatrixCoords speed, Random rndGenerated, int speedX, int speedY)
            : base(position, speed)
        {
            this.RandomGenerated = rndGenerated;
            this.speedRow = speedX;
            this.speedCol = speedY;
        }

        public Random RandomGenerated { get; private set; }

        protected override void Move()
        {
            base.Move();
            this.Speed = GetCoordinatesXY();
        }

        private MatrixCoords GetCoordinatesXY()
        {
            int speedRow = this.RandomGenerated.Next(-this.speedRow, this.speedCol + 1);
            int speedCol = this.RandomGenerated.Next(-this.speedRow, this.speedCol + 1);

            if (speedRow == 0 && speedCol == 0)
            {
                GetCoordinatesXY();
            }

            return new MatrixCoords(speedRow, speedCol);
        }

        public override char[,] GetImage()
        {
            return new char[,] { { 'Q' } };
        }
    }
}
