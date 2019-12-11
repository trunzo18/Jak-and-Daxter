using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
	public int orbs = 0;
	public int cells = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider c){
            if (c.gameObject.CompareTag("Blue_Eco")){
                Destroy(c.gameObject);
            }
            if(c.gameObject.CompareTag("P_Cell")){
            	cells += 1;
            	Destroy(c.gameObject);
            }
            if(c.gameObject.CompareTag("P_Orb")){
            	orbs += 1;
            	Destroy(c.gameObject);
            }
        }
}
