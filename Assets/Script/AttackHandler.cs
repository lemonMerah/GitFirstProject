using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackHandler : MonoBehaviour
{
    public Animator charAnimator;
    void Start()
    {
        print("Running..!");
        charAnimator = GetComponent<Animator>();
        
    }

    void AttackNow()
    {
        charAnimator.SetTrigger("goAttack");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Space button Pressed!");
            AttackNow();
        }
    }
}
