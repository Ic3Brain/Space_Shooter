using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMove : MonoBehaviour
{
    public float speed = 12f;
    public float tempsdevie;
    Transform myTransform;
    private GameController gameScript;
    
    void Start()
    {
        myTransform = GetComponent<Transform>();
        Destroy(gameObject, tempsdevie);
        gameScript = GameController.instance;
        
    }

    /*Détruire les ennemy si le jeu n'est pas en marche*/
    void Update()
    {
        if(gameScript.isInGame){

            myTransform.Translate(Vector3.down*Time.deltaTime*speed);
        }else{
            Destroy(this.gameObject);
        }
        
    }
}
