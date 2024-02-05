using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenOptionMenu : MonoBehaviour     //Created by Devin Hunt.
{
    public GameObject optionsPanel;

    public void ShowOptionsMenu()
    {   
        //Timer.timeIsRunning = false;
        optionsPanel.SetActive(true);
    }
  
    public void CloseOptionsMenu()
    {
        //Timer.timeIsRunning = true;
        optionsPanel.SetActive(false);
    }
}
