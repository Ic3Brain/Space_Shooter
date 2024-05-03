using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViesBonusController : MonoBehaviour
{
    public static List<ViesBonusController> viesBonusControllers;
    
    
    /*destruction des coeurs bonus en fin de partie*/
   void OnEnable()
   {
        if (viesBonusControllers == null)viesBonusControllers = new List<ViesBonusController>();
        viesBonusControllers.Add(this);
   }
    void OnDisable()
    {
        viesBonusControllers.Remove(this);
    }
    public static void DestroyAll(){
        if (viesBonusControllers == null)
        return;

        for (int i = 0; i < viesBonusControllers.Count; i++){
             Destroy(viesBonusControllers[i].gameObject);
        }
        viesBonusControllers.Clear();
    }
}
