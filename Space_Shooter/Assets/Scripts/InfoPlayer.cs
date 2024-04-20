using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;
using UnityEngine;

public class InfoPlayer : MonoBehaviour
{   private int score = 0;
    private int vies = 5;

    private const int MAX_VIES = 5;

    private GameController gameScript;

    
    
    
    


    


    // Start is called before the first frame update
    void Start()
    {
        vies = MAX_VIES;

        InterfaceController.updateVie(vies);
        
        gameScript = GameObject.Find("GameHolder").GetComponent<GameController>();
        

        
        
    }
    //appelé par le script de collisions des ennemy
    public void addScore(int value)
    
    {
        score += value; //score + value
        Debug.Log("score actuel du player : " + score);

        InterfaceController.updateScore (score);
    }
public void updateVie(int value){

    vies += value;
    if(vies > MAX_VIES){
        vies = MAX_VIES;
    }
    if(vies < 0) {
        
        vies = 0;
    }

    if(vies <= 0){

        Debug.Log("Game Over");
        gameScript.isInGame = false;
    }

    
    InterfaceController.updateVie(vies);
}

public void restart(){

    vies = MAX_VIES;
    score = 0;
    gameScript.isInGame = true;
    gameScript.restartWaves();
    InterfaceController.updateVie(vies);
    InterfaceController.HideGameOver();
    
    
}
}

   
