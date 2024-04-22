using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collisions : MonoBehaviour
{   private GameObject player;  
    public int scoredestruction = 10;
    public int viesperdu = -1;
    public GameObject bonus;

    public AudioClip explosion;
    private AudioSource audio1;





    // Start is called before the first frame update
    void Start() {
        player = GameObject.FindGameObjectWithTag ("Player");
        audio1 = GameObject.Find("GameHolder").GetComponent<AudioSource>();
    }
    
    void OnCollisionEnter2D(Collision2D other)
         
        { if (other.gameObject.tag == "Rocket") 
            {
                player.GetComponent<InfoPlayer>().addScore(scoredestruction);

                int indice = Random.Range(0,5);
                if(indice == 0){  

                GameObject bonusGO = Instantiate(bonus,transform.position,bonus.transform.rotation) as GameObject;}
                
                audio1.PlayOneShot(explosion,0.4f);
                Destroy (this.gameObject);// destroy l'ennemy
                Destroy (other.gameObject);// destroy la rocket

                
            }
        if (other.gameObject.tag == "Player"){   
        Debug.Log ("Ennemy rentre en collision avec le player");

        player.GetComponent<InfoPlayer>().updateVie(viesperdu);
        }
        
        
        
    }
        
}
