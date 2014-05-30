using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyEcosystem
{
    public class Bush : Plant
    {
        public Bush(Point location)
            : base(location, 4)
        {
        }

        public override void Update(int time)
        {
            base.Update(time);
        }
    }
}
