﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eco : MonoBehaviour
{
	public GameObject player;
     //Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider c){
    	if ( c.tag == "Player"){
    		Destroy(gameObject);

    	}
    }
}
