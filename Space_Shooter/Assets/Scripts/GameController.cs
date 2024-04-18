using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ennemyPrefab;
    public Vector3 spawnRange;
    public int nbreEnnemyParVague;
    public float waveTime;
    public float spawnTime;
    public bool isInGame = true;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(generateWave());
        Debug.Log(Screen.width);

        spawnRange.x = ((Screen.width*0.5f)/178)-0.25f;
        
    }

    
    
    IEnumerator generateWave(){
        

        while(isInGame){
        
            for(int i = 0; i <nbreEnnemyParVague; i++) {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRange.x,spawnRange.x),Random.Range(spawnRange.y,spawnRange.y-1), 0);
            Instantiate(ennemyPrefab,spawnPos,Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }
        
        yield return new WaitForSeconds(waveTime);
    
    }
        


     }   
    
}
