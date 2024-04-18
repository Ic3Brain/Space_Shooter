using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerCtrl : MonoBehaviour
{[SerializeField]
    float speed;

    Vector2 boundaries;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        boundaries = Vector2.zero;
        boundaries.x = (Screen.width*0.5f)/178;
        boundaries.y = (Screen.height*0.5f)/178;
       
    }

    // Update is called once per frame
    void Update()
    {
        {
            Vector3 pos = Vector3.zero;

            float horizontalDir = Input.GetAxis("Horizontal");
            pos.x = transform.position.x + (horizontalDir*Time.deltaTime*speed);
           

            float verticalDir = Input.GetAxis("Vertical");
            pos.y = transform.position.y + (verticalDir*Time.deltaTime*speed);
            
            pos.x = Mathf.Clamp(pos.x,-boundaries.x,boundaries.x);
            pos.y = Mathf.Clamp(pos.y,-boundaries.y,boundaries.y-1);
            transform.position = pos;
            
            
        
        
        
        }  

        
        
        
       
       }
}
