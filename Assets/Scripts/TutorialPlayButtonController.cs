using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialPlayButtonController : MonoBehaviour
{
    public LevelLoader levelLoader;
    public void PlayButton()
    {
        levelLoader.LoadNextLevel();
    }
}
