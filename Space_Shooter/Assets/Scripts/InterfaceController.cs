using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Accessibility;
using UnityEngine.UI;
using TMPro;


public class InterfaceController : MonoBehaviour
{
    public static InterfaceController Instance;

    [SerializeField]
    private TextMeshProUGUI scoreText, vieText;
    void Awake(){
        Instance = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public static void updateVie(int value)
    {
    Instance.vieText.text = "Vies : " + value;   
    }

    public void updateScore(int value)
    {
    scoreText.text = "Score : " + value;
    }
    
}
