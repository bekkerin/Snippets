using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
// THIS SCRIPT IS ATTACHED TO THE ENEMY
// SPEED OF THE PLAYER IN NAVMESHAGENT IS 5, FOR ENEMY IS 3.5
public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent enemy;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        enemy.SetDestination(player.transform.position);

    }
}
