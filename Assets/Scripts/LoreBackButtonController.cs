using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoreBackButtonController : MonoBehaviour
{
    [SerializeField] private GameObject currentScreen;
    [SerializeField] private GameObject mainMenu;

    public void LoreBackButton()
    {
        currentScreen.SetActive(false);
        mainMenu.SetActive(true);
    }
}
