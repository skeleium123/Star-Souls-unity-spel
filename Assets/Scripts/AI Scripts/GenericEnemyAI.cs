using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.AI;

public class genericEnemyAI : MonoBehaviour
{
    public Transform[] points;
    public Transform Cone;
    public int Conesightrange = 0;
    public int attackrage = 0;
    private NavMeshAgent agent;
    public GameObject Playerobj;

    public bool chasePlayer = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        // Disabling auto-braking allows for continuous movement
        // between points (ie, the agent doesn't slow down as it
        // approaches a destination point).
        //this units transform will be given a transform value from the points array.
        //call on the Random.Range() method inside the array

        agent.autoBraking = false;

        

        Func_GotoRandomPoint();
    }

    void Update()
    {
        if (chasePlayer == true)
        {
            Func_Chase();
        }
        else
        {
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
            {

                Func_GotoRandomPoint();
            }
        }

    }

    void Func_GotoRandomPoint()
    {
        if (points.Length == 0)
            return;


        int randomIndex = Random.Range(0, points.Length);

        agent.destination = points[randomIndex].position;
    }

    public void Func_Chase()
    {
        
        agent.SetDestination(Playerobj.transform.position);

        

    }
}