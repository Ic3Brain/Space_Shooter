using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMove : MonoBehaviour
{
    public float speed = 12f;
    public float tempsdevie;
    Transform myTransform;
    
    private GameController gameScript;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
        Destroy(gameObject, tempsdevie);

        gameScript = GameController.instance;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameScript.isInGame){

            myTransform.Translate(Vector3.down*Time.deltaTime*speed);
        }else{
            Destroy(this.gameObject);
        }
        
    }
}
