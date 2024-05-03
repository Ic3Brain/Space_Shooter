using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public static GameController instance;  
    Coroutine waveCorout;  

    

    
    /*Bloquer le joueur grace a des bordures lié a la cameraSize*/
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
    
    /*Génération des waves dans l'espace champ de la caméra*/
    void Start()
    {
        instance = this;
        
        InitBoundaries();
        
        waveCorout = StartCoroutine(generateWave());
        Debug.Log(Screen.width);

        spawnRange.x = maxX;
        
    }
    
      IEnumerator generateWave(){
        

        while(isInGame){
        
            for(int i = 0; i <nbreEnnemyParVague; i++) {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRange.x,spawnRange.x),Random.Range(spawnRange.y,spawnRange.y-1), 0);
            Instantiate(ennemyPrefab,spawnPos,ennemyPrefab.transform.rotation);
            yield return new WaitForSeconds(spawnTime);
        }
        
        yield return new WaitForSeconds(waveTime);
    
    }
        


     }   
    public void restartWaves(){
        StopCoroutine(waveCorout);
        waveCorout = StartCoroutine(generateWave());
    }
}

