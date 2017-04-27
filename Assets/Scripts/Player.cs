﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using RPGStats;

public class Player : MonoBehaviour {

    public Stat playerHealth = new Stat("Health", 100);
    public Stat playerKnowledge = new Stat("Knowledge", 1);
    public Stat playerGuts = new Stat("Guts", 1);
    public Stat playerProficiency = new Stat("Proficiency", 1);
    public Stat playerCharm = new Stat("Charm", 1);
    public Stat playerKindness = new Stat("Kindness", 1);
    
    /*playerStats = new Stats(playerKnowledge, playerGuts, playerProficiency,
        playerCharm, playerKindness);*/


}
