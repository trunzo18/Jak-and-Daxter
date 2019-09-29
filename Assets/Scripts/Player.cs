using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Characters
{
	
	//private bool isAttacking = false;
	//tells if player is in air or on ground
	private bool inAir = false;
	//tells if player can jump
	private bool canJump = true;
	float nextAttack = 0;
	//private bool isRolling =false;
	//private bool isCrouching = false;
	//private int health = 3;
	//private int greenEco = 0;
	//private bool inMud = false;
	//private bool inWater = false;
	//private GameObjects[] ecos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    protected override void Update()
    {
    	//Updates the inAir bool
    	InAir();
    	//Checks for user input
        GetInput();
        //updates the character based on input
        base.Update();
    }
    //Checks user input to control player assigns it as a vecter to character direction
    public void GetInput(){
    	direction = Vector2.zero;
    	if (Input.GetKey(KeyCode.W)){
    		direction += Vector3.forward;
    	}
    	if (Input.GetKey(KeyCode.A)){
    		direction += Vector3.left;
    	}
    	if(Input.GetKey(KeyCode.S)){
    		direction += Vector3.back;
    	}
    	if(Input.GetKey(KeyCode.D)){
    		direction += Vector3.right;
    	}
    	if(Input.GetKey(KeyCode.Space)){
    		bool temp = CheckJump();
    		if (temp == true){
    			direction += (10 * Vector3.up);
    		}
    	}
    }
    //Checks if player is in air then stores it in inAir bool
    public void InAir(){
    	if(transform.position.y <1.1){
    		inAir = false;
    		
    	}
    	else{
    		inAir = true;
    		
    	}

    }
    //checks if in air or if second jump has been used
    public bool CheckJump(){
    	if(inAir == false){
    		canJump = true;
    		return true;
    	}
    	else if(inAir == true && canJump == true){
    		canJump = false;
    		return true;
    	}
    	else{
    		return false;
    	}

    }
}
