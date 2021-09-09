using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionStats : MonoBehaviour
{
    [Header("MinionStats")]
    public int minionMaxHP;
    public int minionCurrentHP;
    public int minionMovementSpeed; //Used with the navmesh to control how fast the unit moves
    public float minionAttackSpeed; //Used for combat to determine how many attacks can go out within a second
    public int minionAttackRange; //Used for combat for how far the unit can be to attack. If outside of this range, the unit moves toward the target to attack
    public int minionSize; //Eventually will be used to determine where the character can walk

    // Start is called before the first frame update
    void Start()
    {

    }


// Update is called once per frame
void Update()
    {
        
    }
}
