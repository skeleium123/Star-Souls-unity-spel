using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerdetection : MonoBehaviour
{
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Enemy.GetComponent<genericEnemyAI>().chasePlayer = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        for (int i = 0; i < 30000000; i++)
        {
            Debug.Log("Naï");
            if (other.gameObject.tag == "Player")
            {
                Enemy.GetComponent<genericEnemyAI>().chasePlayer = false;
            }
        }
    }
}