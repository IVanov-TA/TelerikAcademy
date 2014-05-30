using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public abstract class GatheringLocation : Location, IGatheringLocation
    {

        public GatheringLocation(string name,LocationType locType ,ItemType gatherItemType, ItemType requiredItemType)
            :base(name, locType)
        {
            this.GatheredType = gatherItemType;
            this.RequiredItem = requiredItemType;
        }

        #region IGatheringLocation Members

        public ItemType GatheredType { get; protected set; }

        public ItemType RequiredItem { get; protected set; }

        public abstract Item ProduceItem(string name);

        #endregion
    }
}
