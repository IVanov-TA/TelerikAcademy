using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Ninja : Character,IFighter, IGatherer
    {
        private int attackPoint = 0;

        public Ninja(string name, Point position, int owner)
            :base(name, position, owner)
        {
            this.HitPoints = 1;
        }

        #region IGatherer Members

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                this.attackPoint += resource.Quantity;
                return true;
            }
            else if (resource.Type == ResourceType.Stone)
            {
                this.attackPoint += resource.Quantity * 2;
                return true;
            }

            return false;
        }

        #endregion

        #region IFighter Members

        public int AttackPoints
        {
            get { return this.attackPoint; }
        }

        public int DefensePoints
        {
            get { return int.MaxValue; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            var maxHitPoints = availableTargets.Max(t => t.HitPoints);
            var target = availableTargets.FirstOrDefault(t => t.Owner != 0 && t.Owner != this.Owner && t.HitPoints == maxHitPoints);

            return availableTargets.IndexOf(target);
        }

        #endregion
    }
}
