using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    InfoPlayer info;

    public AudioClip bonus;
    public AudioSource audio1;
    


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
                audio1.PlayOneShot(bonus,0.3f);
                info.updateVie(1);
            }
   } 
}
