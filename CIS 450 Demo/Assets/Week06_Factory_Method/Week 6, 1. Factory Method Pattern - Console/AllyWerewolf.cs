using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryMethodPattern
{
    public class AllyWerewolf : NPC
    {

        public AllyWerewolf()
        {
            this.NPCType = "Ally Werewolf";
            this.Allegiance = AllegianceType.ALLY;
            this.Weapon = "Claw";
            this.Damage = 8;
            this.Speed = 4.0f;
        }
    }
}