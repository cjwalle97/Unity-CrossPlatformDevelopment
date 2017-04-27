using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using RPGStats;

public class Player : MonoBehaviour {

    public class player
    {
        Stat playerHealth = new Stat("Health", 100);
        Stat playerKnowledge = new Stat("Knowledge", 1);
        Stat playerGuts = new Stat("Guts", 1);
        Stat playerProficiency = new Stat("Proficiency", 1);
        Stat playerCharm = new Stat("Charm", 1);
        Stat playerKindness = new Stat("Kindness", 1);

        Stats playerStats = new Stats();
    }
}
