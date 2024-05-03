using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Android;

public class PlayerShoot : MonoBehaviour
{
    public GameObject SpawnPoint;
    public AudioClip shot;
    public AudioSource audio1;
    public GameObject rocket;

    
    

    // Update is called once per frame
    void Update()
    {   
        if (GameController.instance.isInGame && Input.GetKeyDown (KeyCode.Mouse0)) {  
        //Debug.Log("on tire des missiles");

        //Instantiate(rocket, SpawnPoint.transform.position,quaternion.identity);
        ObjectPool.SpawnObject(rocket, SpawnPoint.transform.position, transform.rotation);
        audio1.PlayOneShot(shot,0.3f);
       }
    }
}
