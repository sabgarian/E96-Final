using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MMTutorialButtonController : MonoBehaviour
{
    [SerializeField] private GameObject currentScreen;
    [SerializeField] private GameObject tutorialScreen;

    public void TutorialButton()
    {
        currentScreen.SetActive(false);
        tutorialScreen.SetActive(true);
    }
}
