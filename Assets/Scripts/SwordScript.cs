using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SwordScript : MonoBehaviour
{
    // Start is called before the first frame update
    public CapsuleCollider swordCapsule;
    public Animator swrdAnimator;
    bool InCombat = false;
    public GameObject weaponHand;
    public GameObject rightHipHolster;
    public Vector3 positionoffset;
    void Start()
    { 
        swordCapsule = GetComponentInChildren<CapsuleCollider>();
        swrdAnimator = GetComponentInChildren<Animator>();
        weaponHand = GameObject.Find("Right_Hand");
        rightHipHolster = GameObject.Find("Right_UpperLeg");
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
                activestate();
            }
            else
            {
                InCombat = false;
                swrdAnimator.SetBool("InCombat", false);
                inactivestate();
            }
            
        }
        
    }
    public void activestate()
    {
       this.transform.SetParent(weaponHand.transform);
        this.transform.position = weaponHand.transform.position + positionoffset; 
    }
    public void inactivestate()
    {
        this.transform.SetParent(rightHipHolster.transform);
        
    }
}
