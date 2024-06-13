using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public int lastCompleted = 0;

    public void ButtonClicked ()
    {
        if (lastCompleted == 0)
        {
            lastCompleted = 1;
        }
        else
        {
            SceneManager.LoadScene(lastCompleted);
        }
    }

    public void Complete(int temp)
    {
        lastCompleted = temp;
        SceneManager.LoadScene(lastCompleted);
    }
}
