using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour
{
    // Start is called before the first frame update
    public CapsuleCollider swordCapsule;
    public Animator swrdAnimator;
    bool InCombat = false;

    void Start()
    { 
        swordCapsule = GetComponent<CapsuleCollider>();
        swrdAnimator = GetComponent<Animator>();
   
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (InCombat == false)
            {
                InCombat = true;
                swrdAnimator.SetBool("InCombat", true);
            }
            else
            {
                InCombat = false;
                swrdAnimator.SetBool("Incombat", false);
            }
            
        }
        
    }
}
