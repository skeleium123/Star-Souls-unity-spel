using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class genericEnemyAI : MonoBehaviour
{
    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        // Disabling auto-braking allows for continuous movement
        // between points (ie, the agent doesn't slow down as it
        // approaches a destination point).
        //this units transform will be given a transform value from the points array.
        //call on the Random.Range() method inside the array
        agent.autoBraking = false;

        agent.transform.position = points[0].position; 
        agent.transform.position = points[destPoint].position;

        //Random.Range();

        GotoNextPoint();
    }

    void Update()
    {
        // Choose the next destination point when the agent gets
        // close to the current one.
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();
    }
    void GotoNextPoint()
    {
        // Returns if no points have been set up
        if (points.Length == 0)
            return;

        // Set the agent to go to the currently selected destination.
        agent.destination = points[destPoint].position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        destPoint = (destPoint + 1) % points.Length;
    }








    /*Följ Tutorial https://www.youtube.com/watch?v=UjkSFoLxesw 1:47

    public NavMeshAgent Agent;

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    public int health;

    //Patrolling
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;


    //Attacking
    public float timeBetweenAttacks;
    bool alreadyAttacked;
    public GameObject projectile;
    public GameObject melee;


    //States
    public float sightRange, attackrange;
    public bool playerInSightRange, playerInAttackRange;

    private void Awake()
    {
        Debug.Log(GameObject.FindGameObjectWithTag("Player").transform);
        player = GameObject.FindGameObjectWithTag("Player").transform;
        Agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        //Check for Sight and attack range
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackrange, whatIsPlayer);
        if (!playerInSightRange && !playerInAttackRange) Patroling();
        if (playerInSightRange && !playerInAttackRange) chasePlayer();
        if (playerInAttackRange && playerInSightRange) attackPlayer();

        

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("NoClimbObject"))
        {
            Agent.SetDestination(-transform.position);
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            Agent.SetDestination(-transform.position);
        }
        
    }
    private void Patroling()
    {
        if (!walkPointSet) SearchWalkPoint();

        if (walkPointSet)
            Agent.SetDestination(walkPoint);

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        //När walkpoint har blivit nått
        if (distanceToWalkPoint.magnitude < 1f) 
            walkPointSet = false;

    }
    private void SearchWalkPoint()
    {
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);
        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround)) 
            walkPointSet = true;
    }

    private void chasePlayer()
    {
        Agent.SetDestination(player.position);
    }
    private void attackPlayer()
    {
        Agent.SetDestination(transform.position);

        transform.LookAt(player);

        if (!alreadyAttacked)
        {
            Rigidbody rb = Instantiate(projectile, transform.position + new Vector3(0, 2, 0), Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.up * 1f, ForceMode.Impulse);
            rb.AddForce(transform.forward * 32f, ForceMode.Impulse);



            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }
    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health < 0) Invoke(nameof(DestroyEnemy), 0.5f);
    }
    private void DestroyEnemy()
    {
        Destroy(gameObject);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackrange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }*/
}
