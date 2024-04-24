using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Accessibility;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UIElements;
using UnityEditor;


public class InterfaceController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public Transform ViePanelTransform;
    public GameObject[] vies = new GameObject[5];
    public static InterfaceController Instance;
    
    
    [SerializeField]
    private TextMeshProUGUI scoreText, vieText;
    
    
    
    void Awake(){
        Instance = this; 
        
        int i = 0;
        foreach(Transform child in ViePanelTransform) {

            vies [i] = child.gameObject;
            i++;

        }
        Debug.Log("nmbre hearts : " + vies.Length);

        gameOverPanel.SetActive(false);
    }
    public static void updateScore(int value)
    {
    Instance.scoreText.text = "Score : " + value; }
    
    private static void destroyHearts(GameObject[] gameObjects) {
        // Debug.Log("oui"+gameObjects);
         for (int i = 0; i < gameObjects.Length; i++) {
            // GameObject child = gameObjects[i] as GameObject;
            //  Debug.Log("child"+ child);
        }
            
            

    } 

    public static void updateVie(int value)
    {
    // Instance.vieText.text = "Vies : " + value; 
        
        for (int i = 0; i < Instance.vies.Length; i++) { 
        if (i > (value -1)){
            Instance.vies [i].SetActive(false);
        }else{
            Instance.vies [i].SetActive(true);
        }   
        
        }

        if(value == 0) {
            
            Instance.gameOverPanel.SetActive(true);
            // destroyHearts(Collisions.instance.gameObjects);
            Collisions.instance.audio1.Stop();


            // TO DO  détruire les coeurs, détruire les ennemis, 
        }
    }
    public static void HideGameOver(){

        Instance.gameOverPanel.SetActive(false);
    }
    
}






    


    
    
    

