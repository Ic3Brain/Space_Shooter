using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public string SceneName;
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }


    public void changeScene()
    {
        SceneManager.LoadScene(SceneName);
    }
    public void Quit(){
        #if UNITY_EDITOR
        EditorApplication.isPlaying = false;
        #endif 
        #if UNITY_STANDALONE
        Application.Quit();
        #endif
    }
}
