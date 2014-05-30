using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarMachines.Machines
{
    public abstract class Machine : WarMachines.Interfaces.IMachine
    {
        private string name;
        protected double attacPoints;
        protected double defensePoints;
        private double healthPoints;
        private IList<string> targets;

        public Machine(string name, double attackPoints, double defensePoints)
        {
            this.targets = new List<string>();
            this.Name = name;
            try
            {
                this.attacPoints = attackPoints;
                this.defensePoints = defensePoints;
            }
            catch (ArgumentNullException)
            {
                
                throw new ArgumentNullException("Attack or defence point must be value >= 0");
            }
        }

        #region IMachine Members

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Machine name can not be null or emtpy");
                }

                this.name = value;
            }
        }

        public Interfaces.IPilot Pilot { get; set; }


        public double HealthPoints 
        { 
            get
            {
                return this.healthPoints;
            }

            set 
            {
                this.healthPoints = value;
            }
        }

        public double AttackPoints
        {
            get { return this.attacPoints; }
        }

        public double DefensePoints
        {
            get { return this.defensePoints; }
        }

        public IList<string> Targets
        {
            get { return  new List<string>(this.targets); }
        }

        public void Attack(string target)
        {
            this.targets.Add(target);
        }

        #endregion

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("- {0}", this.Name).AppendLine();
            output.AppendFormat(" *Type: {0}\n *Health: {1}\n *Attack: {2}\n *Defense: {3}\n *Targets: {4}", this.GetType().Name, this.HealthPoints, this.AttackPoints, this.DefensePoints, this.targets.Count > 0 ? string.Join(", ", this.targets) : "None");
            return output.ToString();
        }
    }
}
