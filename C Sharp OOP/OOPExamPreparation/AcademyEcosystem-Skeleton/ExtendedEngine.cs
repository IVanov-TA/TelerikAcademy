using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    public class ExtendedEngine : Engine
    {
        private const string Wolf = "wolf";
        private const string Lion = "lion";
        private const string Grass = "grass";
        private const string Boar = "boar";
        private const string Zombie = "zombie";

        protected override void ExecuteBirthCommand(string[] commandWords)
        {
            string name = null;
            Point position;

            switch (commandWords[1])
            {
                case Wolf:
                    name = commandWords[2];
                    position = Point.Parse(commandWords[3]);
                    this.AddOrganism(new Wolf(name, position));
                    break;
                case Lion:
                    name = commandWords[2];
                    position = Point.Parse(commandWords[3]);
                    this.AddOrganism(new Lion(name, position));
                    break;
                case Grass:
                    position = Point.Parse(commandWords[2]);
                    this.AddOrganism(new Grass(position));
                    break;
                case Boar:
                    name = commandWords[2];
                    position = Point.Parse(commandWords[3]);
                    this.AddOrganism(new Boar(name, position));
                    break;
                case Zombie:
                    name = commandWords[2];
                    position = Point.Parse(commandWords[3]);
                    this.AddOrganism(new Zombie(name, position));
                    break;
                default: base.ExecuteBirthCommand(commandWords);
                    break;
            }
            
        }
    }
}
