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
    
    /*Temps entre les tirs ennemy*/
    void Start()
    {
        startTime = Time.time;
        ObjectPool.SpawnObject(rocket, spawnPoint.transform.position, rocket.transform.rotation);
        gameScript = GameController.instance;
    }

    
    
    /*Temps entre les tirs ennemy*/
    void Update()
    {
        if(gameScript.isInGame) {
            elapsedTime = Time.time - startTime;

        if (elapsedTime >= shotTime){
            startTime = Time.time;
             ObjectPool.SpawnObject(rocket, spawnPoint.transform.position, rocket.transform.rotation);
            }
        }
    }
}
