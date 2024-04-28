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

    
    

   /*tir si clique gauche et si jeu actif*/
    void Update()
    {   
        if (GameController.instance.isInGame && Input.GetKeyDown (KeyCode.Mouse0)) {  
        
        ObjectPool.SpawnObject(rocket, SpawnPoint.transform.position, transform.rotation);
        audio1.PlayOneShot(shot,0.3f);
       }
    }
}
