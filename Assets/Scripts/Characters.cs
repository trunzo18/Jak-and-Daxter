using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Characters : MonoBehaviour
{
	[SerializeField]
    private Vector3 speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Move(){
        transform.position = transform.position + speed;
    }
}
