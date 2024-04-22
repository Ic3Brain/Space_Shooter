using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerCtrl : MonoBehaviour
{[SerializeField]
    float speed;
    public static float minX, maxX, minY, maxY;
    public Camera _camera;

    Vector2 boundaries;
    
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
    
    
    
    

    // Start is called before the first frame update
    void Start ()
    {    
        InitBoundaries();
    
        boundaries = Vector2.zero;
         boundaries.x = maxX;
         boundaries.y = maxY;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (GameController.instance.isInGame){
             
             Vector3 pos = Vector3.zero;

            float horizontalDir = Input.GetAxis("Horizontal");
            pos.x = transform.position.x + (horizontalDir*Time.deltaTime*speed);
           

            float verticalDir = Input.GetAxis("Vertical");
            pos.y = transform.position.y + (verticalDir*Time.deltaTime*speed);
            
             pos.x = Mathf.Clamp(pos.x,-boundaries.x,boundaries.x);
             pos.y = Mathf.Clamp(pos.y,-boundaries.y,boundaries.y-1);
             transform.position = pos;
        }
            
            
            
        
        
        
         

        
        
        
       
    }
}
