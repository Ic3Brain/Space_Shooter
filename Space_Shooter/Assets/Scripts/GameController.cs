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
    public static float minX, maxX, minY, maxY;
    public Camera _camera;



    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(generateWave());
        Debug.Log(Screen.width);

        spawnRange.x = ((Screen.width*0.5f)/178)-0.25f;
        
    }
    
    void InitBoundaries()
    {
        float vertExtent = _camera.orthographicSize - (_camera.orthographicSize * 0.1f);

        float _screenRatio = ((float)Screen.width / (float)Screen.height);
        float horzExtent;

        if (_screenRatio > 0) horzExtent = vertExtent * _screenRatio;
        else horzExtent = vertExtent * (1 - _screenRatio);

        minX = -horzExtent;
        maxX = horzExtent;
        minY = -vertExtent;
        maxY = vertExtent;
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
