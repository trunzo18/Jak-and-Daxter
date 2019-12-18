using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    public int orbs = 0;
    public int cells = 0;
    public bool boost = false;
    public float bTime = 7;
    public float timeLeft = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            if(boost && timeLeft >= 0){
                timeLeft -= Time.deltaTime;
            }
            else{
                boost = false;
                timeLeft = 0;
            }

    }
    void OnTriggerEnter(Collider c){
            if (c.gameObject.CompareTag("Blue_Eco")){
                                boost = true;
                                timeLeft = bTime;
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
