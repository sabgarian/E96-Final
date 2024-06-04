using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneLoader : MonoBehaviour
{
    public LevelLoader levelLoader;
    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            levelLoader.LoadNextLevel();
        }
    }
}
