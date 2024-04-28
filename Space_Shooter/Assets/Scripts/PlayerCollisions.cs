using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    InfoPlayer info;

    public AudioClip bonus;
    public AudioSource audio1;
    
    void Start()
    {
        info = GetComponent<InfoPlayer>();
    }

    /*si touché par une rocket ennemy alors -1 vie*/
    void OnCollisionEnter2D(Collision2D other)
         
        { if (other.gameObject.tag == "EnnemyRocket") 
            {
                other.gameObject.SetActive(false);
                info.updateVie(-1);
                
            }
       }

       /*si la player touche un coeur sur le sol alors +1 vie*/
    void OnTriggerEnter2D(Collider2D other)
    { 
        if (other.gameObject.tag == "HeartBonus") 
        {
            Destroy(other.gameObject);
            audio1.PlayOneShot(bonus,0.3f);
            info.updateVie(1);
        }
   } 


   
}
