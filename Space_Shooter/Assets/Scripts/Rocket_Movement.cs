using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket_Movement : MonoBehaviour
{
    public float speed = 12f;
    Transform myTransform;
    
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    { 
        
        myTransform.Translate(Vector3.up*Time.deltaTime*speed);
        Destroy (this.gameObject, 2f);
        
    }
         
}
