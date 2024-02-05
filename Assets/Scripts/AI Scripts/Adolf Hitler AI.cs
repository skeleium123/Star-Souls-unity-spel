using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class genericEnemyAI : MonoBehaviour
{

    //F�lj Tutorial https://www.youtube.com/watch?v=UjkSFoLxesw 1:47

    public NavMeshAgent Agent;

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    //Patrolling
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;


    //Attacking
    public float timeBetweenAttacks;
    bool alreadyAttacked;

    //States
    public float sightRange, attackrange;
    public bool playerInSightRange, playerInAttackRange;

    private void Awake()
    {
        player = GameObject.Find("Player").transform;
        Agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        //Check for Sight and attack range
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);
    }
    private void Patroling()
    {

    }
    private void chasePlayer()
    {

    }
    private void attackPlayer()
    {

    }
}
