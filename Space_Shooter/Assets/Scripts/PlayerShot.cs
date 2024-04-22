using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Android;

public class PlayerShoot : MonoBehaviour
{

    public GameObject rocket;
    public GameObject SpawnPoint;
    
    public AudioClip shot;
    public AudioSource audio1;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (GameController.instance.isInGame && Input.GetKeyDown (KeyCode.Mouse0)) {  
        //Debug.Log("on tire des missiles");

        Instantiate(rocket, SpawnPoint.transform.position,quaternion.identity);
        audio1.PlayOneShot(shot,0.3f);
     }

    }
}
