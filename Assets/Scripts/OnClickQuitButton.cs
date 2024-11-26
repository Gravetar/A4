using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickQuitButton : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Quit from application");
        Application.Quit();
    }
}
