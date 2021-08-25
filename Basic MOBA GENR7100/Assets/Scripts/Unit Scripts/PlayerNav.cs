using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNav : MonoBehaviour
{

    NavMeshAgent agent;
    PlayerStats playerStats;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        playerStats = GetComponent<PlayerStats>();
    }



    // Update is called once per frame
    void Update()
    {
        agent.speed = playerStats.playerMovementSpeed; //Allows you to change unit speed based on the stats script. Probably will eventually be a method

        if (agent.isActiveAndEnabled)
        {
            if (Input.GetMouseButtonDown(0)) //When you left click, move the object to where you clicked
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                {
                    agent.SetDestination(hit.point);
                }
            }
        }
    }
}
