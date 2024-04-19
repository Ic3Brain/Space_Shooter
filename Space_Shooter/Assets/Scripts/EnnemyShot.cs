using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class EnnemyShot : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject rocket;
    public float shotTime;
    private float startTime;
    private float elapsedTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        Instantiate(rocket, spawnPoint.transform.position, rocket.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime = Time.time - startTime;

        if (elapsedTime >= shotTime){
            startTime = Time.time;
            Instantiate(rocket, spawnPoint.transform.position, rocket.transform.rotation);  
        }

    }
}
