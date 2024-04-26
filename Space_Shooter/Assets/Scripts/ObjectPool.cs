using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{   
    public static ObjectPool instance;
    public List<GameObject> poolObjects;  //la liste (la réserve !)
    public GameObject RocketInit; //le prefab à instancier
    public int amountToPool;  //taille de notre Pool

    void Awake () {
        instance = this;
    }

    void Start () {
        poolObjects = new List<GameObject> ();
        GameObject tmp;

        //on remplit la liste 
        for (int i = 0; i < amountToPool; i++) {
            tmp = Instantiate (RocketInit);
            tmp.SetActive (false);
            poolObjects.Add (tmp);

        }
    }

    //la méthode à utiliser par le client pour obtenir une instance auprès du pooler
    public GameObject getPoolObject () {
        for (int i = 0; i < amountToPool; i++) {
            if (!poolObjects[i].activeInHierarchy) {
                return poolObjects[i];
            }
        }
        return null;
    }
}
