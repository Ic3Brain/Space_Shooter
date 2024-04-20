using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    InfoPlayer info;
    


    // Start is called before the first frame update
    void Start()
    {
        info = GetComponent<InfoPlayer>();
    }

    void OnCollisionEnter2D(Collision2D other)
         
        { if (other.gameObject.tag == "EnnemyRocket") 
            {
                other.gameObject.SetActive(false);
                info.updateVie(-1);
                
            }
       }
    void OnTriggerEnter2D(Collider2D other)
         
        { if (other.gameObject.tag == "HeartBonus") 
            {
                Destroy(other.gameObject);
                info.updateVie(1);
            }
   } 
}
