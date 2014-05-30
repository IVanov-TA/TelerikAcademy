using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarMachines.Machines
{
    public class Pilot : WarMachines.Interfaces.IPilot
    {
        private string name;
        private IList<WarMachines.Interfaces.IMachine> machines;

        public Pilot(string name)
        {
            this.machines = new List<WarMachines.Interfaces.IMachine>();

            try
            {
                this.name = name;
            }
            catch (ArgumentNullException)
            {
                
                throw new ArgumentNullException("Pilot's name must not be emtpy or null");
            }
        }
        #region IPilot Members

        public string Name
        {
            get { return this.name; }
        }

        public void AddMachine(Interfaces.IMachine machine)
        {
            if (machine == null)
            {
                throw new ArgumentNullException("Pilot can not be null");
            }

            this.machines.Add(machine);
        }

        public string Report()
        {
            var output = new StringBuilder();
            output.AppendFormat("{0} - {1}", this.Name, this.machines.Count > 1 ? this.machines.Count + " machines" : this.machines.Count == 1 ? "1 machine" : "no machines");

            var sortedMachines = this.machines.OrderBy(m => m.HealthPoints).ThenBy(m => m.Name);
            foreach (var machine in sortedMachines)
            {
                var machineCast = machine as Tank;

                if (machineCast != null)
                {
                    output.AppendFormat("\n{0}", machine);
                }
                else
                {
                    output.AppendFormat("\n{0}", machine as Fighter);
                }
            }

            return output.ToString();
        }

        #endregion

    }
}
