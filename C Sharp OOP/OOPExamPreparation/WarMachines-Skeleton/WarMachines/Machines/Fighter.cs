using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarMachines.Machines
{
    public class Fighter : Machine, WarMachines.Interfaces.IFighter
    {
        private bool stealthMode;

        public Fighter(string name, double attackPoints, double defencePoints, bool stealthMode)
            :base(name, attackPoints, defencePoints)
        {
            this.stealthMode = stealthMode;
            this.HealthPoints = 200;
        }

        #region IFighter Members

        public bool StealthMode
        {
            get { return this.stealthMode; }
        }

        public void ToggleStealthMode()
        {
            this.stealthMode = !this.stealthMode;
        }

        #endregion

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(base.ToString());
            output.AppendFormat(" *Stealth: {0}", this.StealthMode ? "ON" : "OFF");
            return output.ToString();
        }
    }
}
