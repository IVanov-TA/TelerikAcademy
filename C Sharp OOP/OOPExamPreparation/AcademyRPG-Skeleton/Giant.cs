using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Giant : Character, IFighter, IGatherer
    {
        private bool gatherFlag;
        private int attackPoints = 150;

        public Giant(string name, Point position)
            :base(name, position, 0)
        {
            this.HitPoints = 200;
            this.gatherFlag = false;
        }

        #region IGatherer Members

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                if (!this.gatherFlag)
                {
                    this.gatherFlag = true;
                    this.attackPoints += 100;
                }

                return true;
            }

            return false;
        }

        #endregion

        #region IFighter Members

        public int AttackPoints
        {
            get { return this.attackPoints; }
        }

        public int DefensePoints
        {
            get { return 80; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }

        #endregion
    }
}
