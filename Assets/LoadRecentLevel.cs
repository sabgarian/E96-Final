using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadRecentLevel : MonoBehaviour
{
    public void LoadLastLevel()
    {
        GameManager gm = GameManager.instance;
        gm.PlayMostRecentScene();
    }
}
