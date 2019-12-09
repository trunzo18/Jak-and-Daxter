using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
	private bool attacking = false;
	private float attackTimer = 0;
	private float attackCd = 0.3f;
	public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
    	if(Input.GetMouseButtonDown(0) && !attacking){
    		attacking = true;
    		attackTimer = attackCd;

    	}
    	if(attackTimer> 0){
    		attackTimer -= Time.deltaTime;
    	}
    	else{
    		attacking = false;
    	}
        anim.SetBool("Attacking",attacking);
    }
}
