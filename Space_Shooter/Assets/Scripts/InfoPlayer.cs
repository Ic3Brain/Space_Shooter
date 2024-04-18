using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPlayer : MonoBehaviour
{   private int score = 0;
    public int vies = 5;

    


    // Start is called before the first frame update
    void Start()
    {
        InterfaceController.updateVie(vies);
        
    }
    //appelé par le script de collisions des ennemy
    public void addScore(int value)
    
    {
        score += value; //score + value
        Debug.Log("score actuel du player : " + score);

        InterfaceController.Instance.updateScore (score);
    }
public void updateVie(int value){

    vies += value;
    InterfaceController.updateVie(vies);
}


}

   
