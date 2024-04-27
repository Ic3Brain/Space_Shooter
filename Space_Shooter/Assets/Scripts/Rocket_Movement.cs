using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Rocket_Movement : MonoBehaviour
{
    public float speed = 12f;
    Transform myTransform;
    private Coroutine _returnToPoolTimerCoroutine;
    
     
    // Start is called before the first frame update
    void Awake()
    {
        myTransform = GetComponent<Transform>();
    }

    private void OnEnable()
    {
        _returnToPoolTimerCoroutine = StartCoroutine(ReturnToPoolAfterTime());
    }


    private IEnumerator ReturnToPoolAfterTime()
    {
        float elapsedTime = 0f;
        while(elapsedTime < 2f)
        {
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        ObjectPool.ReturnObjectToPool(gameObject);
    }       


    // Update is called once per frame
    void Update()
    { 
        myTransform.Translate(Vector3.up*Time.deltaTime*speed);
    }
}
