using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMove : MonoBehaviour
{
    public float speed = 12f;
    public float tempsdevie;
    Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<Transform>();
        Destroy(gameObject, tempsdevie);
        
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.Translate(Vector3.down*Time.deltaTime*speed);
    }
}
