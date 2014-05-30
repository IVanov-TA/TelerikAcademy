using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public class AdvancedIteractionManager : InteractionManager
    {
        public AdvancedIteractionManager()
            : base()
        {
        }

        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                case "wood":
                    item = new Wood(itemNameString, itemLocation);
                    break;
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                default: item = base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
                    break;
            }

            return item;
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            switch (locationTypeString)
            {
                case "forest":
                    return new Forest(locationName);
                case "mine":
                    return new Mine(locationName);
                default:
                    return base.CreateLocation(locationTypeString, locationName);
            }
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    this.HandleGatherInteraction(actor, commandWords[2]);
                    break;

                case "craft":
                    this.HandleCraftInteraction(actor, commandWords[2], commandWords[3]);
                    break;

                default: base.HandlePersonCommand(commandWords, actor);
                    break;
            }

        }

        private void HandleCraftInteraction(Person actor, string craftedItemType, string craftedItemName)
        {
            switch (craftedItemType)
            {
                case "armor":
                    var actorInverntory = actor.ListInventory();
                    if (actorInverntory.Any((item) => item.ItemType == ItemType.Iron))
                    {
                        this.AddToPerson(actor, new Armor(craftedItemName));
                    }
                    break; // TODO: In Methods

                case "weapon":
                    actorInverntory = actor.ListInventory();
                    if (actorInverntory.Any((item) => item.ItemType == ItemType.Iron) &&
                        actorInverntory.Any((item) => item.ItemType == ItemType.Wood))
                    {
                        this.AddToPerson(actor, new Weapon(craftedItemName));
                    }
                    break; // TODO: In Methods
                default:
                    break;
            }
        }

        private void HandleGatherInteraction(Person actor, string gatherItemName)
        {
            var gatheringLocation = actor.Location as IGatheringLocation;
            if (gatheringLocation != null)
            {
                if (actor.ListInventory().Any((item) => item.ItemType == gatheringLocation.RequiredItem))
                {
                    var producedItem = gatheringLocation.ProduceItem(gatherItemName);
                    this.AddToPerson(actor, producedItem);
                }
            }
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            switch (personTypeString)
            {
                case "merchant":
                    var person =  new Merchant(personNameString, personLocation);
                    return person;
                default:  return base.CreatePerson(personTypeString, personNameString, personLocation);
            }
        }
    }
}
