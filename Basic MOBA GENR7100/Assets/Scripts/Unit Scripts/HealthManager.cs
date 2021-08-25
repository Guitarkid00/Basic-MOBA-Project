using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HealthManager : MonoBehaviour
{
    // Start is called before the first frame update

    PlayerStats playerStats;

    public event Action<float> OnHealthPctChanged = delegate { };

    void Start()
    {
        playerStats = GetComponent<PlayerStats>();
        playerStats.playerCurrentHP = playerStats.playerMaxHP;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //Just for testing HP Loss
        {
            TakeDamage(100);
        }
        if (Input.GetKeyDown(KeyCode.G)) //For testing HP Gain
        {
            GainHealth(100);
        }
    }

    public void TakeDamage(int amount) //This will be called whenever the unit is meant to lose an amount of HP at once
    {
        playerStats.playerCurrentHP -= amount;
        if(playerStats.playerCurrentHP <= 0)
        {
            playerStats.playerCurrentHP = 0;
        }

        float currentHealthPct = (float)playerStats.playerCurrentHP / (float)playerStats.playerMaxHP;
        OnHealthPctChanged(currentHealthPct);
    }

    public void GainHealth(int amount) //This will be called whenever a unit is meant to gain an amount of HP at once
    {
        playerStats.playerCurrentHP += amount;
        if(playerStats.playerCurrentHP > playerStats.playerMaxHP)
        {
            playerStats.playerCurrentHP = playerStats.playerMaxHP;
        }

        float currentHealthPct = (float)playerStats.playerCurrentHP / (float)playerStats.playerMaxHP;
        OnHealthPctChanged(currentHealthPct);
    }
}
