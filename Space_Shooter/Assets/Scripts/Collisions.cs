using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collisions : MonoBehaviour
{   private GameObject player;  
    public int scoredestruction = 10;
    public int viesperdu = -1;
    public GameObject bonus;
    public static Collisions instance;
    public AudioClip explosion;
    public AudioSource audio1;
    
    
 
 
    
    void Start() {
        
        instance = this;
        player = GameObject.FindGameObjectWithTag ("Player");
        audio1 = GameObject.Find("GameHolder").GetComponent<AudioSource>();
    }
    /*Collision rocket = addscore + proba de drop un coeur en plus
    Collision contre ennemy ou tir ennemy = -1*/
    void OnCollisionEnter2D(Collision2D other)
         
        { if (other.gameObject.tag == "Rocket") 
            {
                player.GetComponent<InfoPlayer>().addScore(scoredestruction);

                int indice = UnityEngine.Random.Range(0,20);
                if(indice == 0){ 

                    GameObject bonusGO = Instantiate(bonus,transform.position,bonus.transform.rotation) as GameObject;
                    
                }
                
                audio1.PlayOneShot(explosion,0.4f);
                Destroy (this.gameObject);// destroy l'ennemy
                ObjectPool.ReturnObjectToPool(other.gameObject);
                
            }
        if (other.gameObject.tag == "Player"){   
        Debug.Log ("Ennemy rentre en collision avec le player");

        player.GetComponent<InfoPlayer>().updateVie(viesperdu);
        }
    }
}
