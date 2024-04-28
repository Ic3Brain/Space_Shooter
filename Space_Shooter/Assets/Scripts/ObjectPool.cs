using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using System.Linq;

public class ObjectPool : MonoBehaviour
{
    public static List<PooledObjectInfo> ObjectPools = new List<PooledObjectInfo>();

     public static GameObject SpawnObject(GameObject objectToSpawn, UnityEngine.Vector3 spawnPosition, UnityEngine.Quaternion spawnRotation)
     {
         PooledObjectInfo pool = ObjectPools.Find(p => p.LookupString == objectToSpawn.name);

   
    // Si le pool n'existe pas, créer le !
    if (pool == null)
    {
        pool = new PooledObjectInfo() {LookupString = objectToSpawn.name};
        ObjectPools.Add(pool);
    }
    // Regarde s'il n'y a pas d'object inactif dans le pool
    GameObject spawnableObj = pool.InactiveObjects.FirstOrDefault();

    

    if (spawnableObj == null)
        {
        // Si il n'y a pas d'object inactif, en créer un nouveau ! 
        spawnableObj = Instantiate(objectToSpawn, spawnPosition, spawnRotation);
        }

        else
        {
                // Si il y a un object inactif disponible, réactivez le !
                spawnableObj.transform.position = spawnPosition;
                spawnableObj.transform.rotation = spawnRotation;
                pool.InactiveObjects.Remove(spawnableObj);
                spawnableObj.SetActive(true);
        }

        return spawnableObj;
    }
            // Retour des objects dans le pool
    public static void ReturnObjectToPool(GameObject obj)
    {
            string goName = obj.name.Substring(0, obj.name.Length - 7);  // by taking off 7, we are removing the (clone) from the nam of the passed in obj            
            
            PooledObjectInfo pool = ObjectPools.Find(p => p.LookupString == goName);

            if (pool == null)
            {
                    Debug.LogWarning("trying to release an object that is not pooled: " + obj.name);
            }

            else
            {
                obj.SetActive(false);
                pool.InactiveObjects.Add(obj);  
            }
    }
}

public class PooledObjectInfo
{
    public string LookupString;
    public List<GameObject> InactiveObjects = new List<GameObject>();

}

