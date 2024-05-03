using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class InfoPlayer : MonoBehaviour
{   private int score = 0;
    private int vies = 5;

    private const int MAX_VIES = 5;

    private GameController gameScript;
    

    
    /*Commence la partie avec le max de vies*/
    void Start()
        {
            vies = MAX_VIES;
            InterfaceController.updateVie(vies);
        }

    
    
    /*ajoute le score a chaque destruction d'ennemy*/
    //appelé par le script de collisions des ennemy
    public void addScore(int value)
    
    {
        score += value; //score + value
        Debug.Log("score actuel du player : " + score);

        InterfaceController.updateScore (score);
    }

    /*Gestionnaire de vies, si vies 0 = game over*/
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
        GameController.instance.isInGame = false;
         gameObject.SetActive(false);
        
            
            InterfaceController.Instance.gameOverPanel.SetActive(true);
            ViesBonusController.DestroyAll();
            Collisions.instance.audio1.Stop();
        }
            InterfaceController.updateVie(vies);
}
    /*remet les paramètres de base*/
    public void restart(){

    
    vies = MAX_VIES;
    score = 0;
    GameController.instance.isInGame = true;
    gameObject.SetActive(true);
    GameController.instance.restartWaves();
    InterfaceController.updateVie(vies);
    InterfaceController.updateScore(score);
    InterfaceController.HideGameOver();
    Collisions.instance.audio1.Play();
    }
}

   
