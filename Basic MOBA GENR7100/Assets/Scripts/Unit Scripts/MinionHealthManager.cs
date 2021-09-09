using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MinionHealthManager : MonoBehaviour
{
    // Start is called before the first frame update

    MinionStats minionStats;

    public event Action<float> OnHealthPctChanged = delegate { };

    void Start()
    {
        minionStats = GetComponent<MinionStats>();
        minionStats.minionCurrentHP = minionStats.minionMaxHP;

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
        minionStats.minionCurrentHP -= amount;
        if (minionStats.minionCurrentHP <= 0)
        {
            minionStats.minionCurrentHP = 0;
        }

        float currentHealthPct = (float)minionStats.minionCurrentHP / (float)minionStats.minionMaxHP;
        OnHealthPctChanged(currentHealthPct);
    }

    public void GainHealth(int amount) //This will be called whenever a unit is meant to gain an amount of HP at once
    {
        minionStats.minionCurrentHP += amount;
        if (minionStats.minionCurrentHP > minionStats.minionMaxHP)
        {
            minionStats.minionCurrentHP = minionStats.minionMaxHP;
        }

        float currentHealthPct = (float)minionStats.minionCurrentHP / (float)minionStats.minionMaxHP;
        OnHealthPctChanged(currentHealthPct);
    }
}
