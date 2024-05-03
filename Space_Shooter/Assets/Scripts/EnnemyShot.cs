using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class EnnemyShot : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject rocket;
    public float shotTime;
    private float startTime;
    private float elapsedTime;
    private GameController gameScript;
    
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        //Instantiate(rocket, spawnPoint.transform.position, rocket.transform.rotation);
        ObjectPool.SpawnObject(rocket, spawnPoint.transform.position, rocket.transform.rotation);
        
        gameScript = GameController.instance;
    }

    
    
    // Update is called once per frame
    void Update()
    {
        if(gameScript.isInGame) {
            elapsedTime = Time.time - startTime;

        if (elapsedTime >= shotTime){
            startTime = Time.time;
            //Instantiate(rocket, spawnPoint.transform.position, rocket.transform.rotation); 
            ObjectPool.SpawnObject(rocket, spawnPoint.transform.position, rocket.transform.rotation);
            }
        }
    }
}
