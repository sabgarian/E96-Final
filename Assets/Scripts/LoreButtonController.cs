using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoreButtonController : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject loreScreen;

    public void LoreButton()
    {
        mainMenu.SetActive(false);
        loreScreen.SetActive(true);
    }
    
}
