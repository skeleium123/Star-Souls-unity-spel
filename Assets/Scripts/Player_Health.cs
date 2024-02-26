using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Health : MonoBehaviour
{
    public float health = 10;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating(nameof(HealthRegen), 1f, 1f);
    }

    /*void HealthRegen(int health)
    {
        health = health + 1;
        Debug.Log("Healing");
    }*/

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    /*public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyWeapon"))
        {
            health = health - 10;
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            
        }
    }*/
}
