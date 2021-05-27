using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour
{
    public int count_scence;
    public int number_scence;

    public void CloseGame()
    {
        Application.Quit();
    }

    public void LoadtScene()
    {
        SceneManager.LoadScene(number_scence);
    } 

    public void OpenMenu()
    {
        SceneManager.LoadScene(0);
    }
}
