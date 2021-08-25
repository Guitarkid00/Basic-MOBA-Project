using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    //This scripts holds everything related to the units stats
    //Eventually this will be able to increase during the game

    [Header ("PlayerStats")]
    public int playerMaxHP;
    public int playerCurrentHP;
    public int playerMovementSpeed; //Used with the navmesh to control how fast the unit moves
    public float playerAttackSpeed; //Used for combat to determine how many attacks can go out within a second
    public int playerAttackRange; //Used for combat for how far the unit can be to attack. If outside of this range, the unit moves toward the target to attack
    public int playerSize; //Eventually will be used to determine where the character can walk

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
