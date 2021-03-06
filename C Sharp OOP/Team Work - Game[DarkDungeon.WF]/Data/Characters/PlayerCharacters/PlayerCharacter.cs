﻿using System;
using Data.Items.ItemsCollections.Inventories;

namespace Data.Characters.PlayerCharacters
{
    public class PlayerCharacter : Character
    {
        string characterClass;
        public string CharacterName
        {
            get;
            set;
        }
        public string CharacterClass
        {
            get { return this.characterClass; }
            set { this.characterClass = value; }
        }
        public Inventory Inventory { get; set; }

        public PlayerCharacter(string characterName)
            : base(100, 100, 100, 10, 10)
        {
            this.CharacterName = characterName;
            this.Inventory = new Inventory(10, 1);
        }
    }
}
