using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    class ParticleSystemMain
    {
        const int SimulationRows = 30;
        const int SimulationCols = 40;

        static readonly Random RandomGenerator = new Random();

        static void Main(string[] args)
        {
            var renderer = new ConsoleRenderer(SimulationRows, SimulationCols);
            var particleOperator = new ParticleRepellerUpdater();

            var particles = new List<Particle>()
            {
               //new Particle(new MatrixCoords(5, 5), new MatrixCoords(1, 1)),
                new ParticleEmitter(new MatrixCoords(10, 10), new MatrixCoords(0, 0), RandomGenerator),
                //new ParticleEmitter(new MatrixCoords(5, 20), new MatrixCoords(0, 0), RandomGenerator),
                //new VariousLifetimeParticleEmitter(new MatrixCoords(29, 1), new MatrixCoords(0, 0), RandomGenerator),

                //new ParticleAttractor(new MatrixCoords(15, 8), new MatrixCoords(), 5),
                //new ParticleAttractor(new MatrixCoords(15, 20), new MatrixCoords(), 1),
                new ChaoticParticle(new MatrixCoords(20, 20), new MatrixCoords(1,1), RandomGenerator, 1,1),
                new ChickenParticle(new MatrixCoords(10,10), new MatrixCoords(1,1), RandomGenerator),
                new ParticleRepeller(new MatrixCoords(0, 10), new MatrixCoords(0,0), 4)
            };

            var engine = new Engine(renderer, particleOperator, particles, 500);

            engine.Run();
        }
    }
}
