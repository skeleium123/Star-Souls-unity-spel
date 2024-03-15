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

    //Två transforms som refererar till platsen svärdet/vapnet ska sitta på i själva scenen
    public Transform Holstered;
    public Transform Equipped;

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
      /*  if (Input.GetKeyDown((KeyCode)MouseButton.Left)) 
        {
            if (InCombat == false)
            {

            }
        }*/
    }
    public void activestate()
    {
       transform.SetParent(weaponHand.transform, false);
        
        transform.position = Equipped.position;
        transform.rotation = Equipped.rotation;
    }
    public void inactivestate()
    {
        transform.SetParent(rightHipHolster.transform, false);
        transform.position = Holstered.position;
        transform.rotation = Holstered.rotation;
    }
}
