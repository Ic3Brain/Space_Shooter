using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{   
    public string SceneName;
    
    
    /*Lance le jeu sur la scène "game"*/
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    /*Change de scene*/
    public void changeScene()
    {
        SceneManager.LoadScene(SceneName);
    }

    /*ferme le jeu*/
    public void Quit(){
        #if UNITY_EDITOR
        EditorApplication.isPlaying = false;
        #endif 
        #if UNITY_STANDALONE
        Application.Quit();
        #endif
    }
}
