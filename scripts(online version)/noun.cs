﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noun : MonoBehaviour
{
    public string[] nounList;
    public string nous = "Goblin|Human|Merfolk|Angel|Ape|Troll|Cat|Elf|Giant|House|Mouse|Rabbit|Abomination|Griffin|Wizard|Bard|Tree|Bandit|Vampire|Jackal|Lizard|Dog|Computer|Ice Cream Cone|Keyboard|Person|Star|Moon|Planet|Asteroid|Meteroid|Lich|Skeleton|Bug|Zombie|Plant|Orb|Prism|Horror|Dwarf|Wraith|Cup|Straw|Hole|Bee|Crab|Spider|Bike|Bird|Stadium|Town|City|Axe|Sword|Javelin|Mace|Shield|Field|Canyon|River|Mountain|Forest|Swamp|Cliff|Fist|Foot|Lobster|Eye|Plane|Car";
    private void Start()
    {
        nounList =  nous.Split('|');
    }
}
