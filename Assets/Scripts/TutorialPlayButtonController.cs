using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialPlayButtonController : MonoBehaviour
{
    public void PlayButton()
    {
        
        SceneManager.LoadScene("LivingRoom1");
    }
}
