using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarMachines.Machines
{
    public class Tank : Machine, WarMachines.Interfaces.ITank
    {
        public Tank(string name, double attackPoints, double defencePoints)
            :base(name, attackPoints, defencePoints)
        {
            this.ToggleDefenseMode();
            this.HealthPoints = 100;
        }
        #region ITank Members

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.defensePoints -= 30;
                this.attacPoints += 40;
            }
            else
            {
                this.defensePoints += 30;
                this.attacPoints -= 40;
            }

            this.DefenseMode = !this.DefenseMode;
        }

        #endregion

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(base.ToString());
            output.AppendFormat(" *Defense: {0}", this.DefenseMode ? "ON" : "OFF");
            return output.ToString();
        }
    }
}
