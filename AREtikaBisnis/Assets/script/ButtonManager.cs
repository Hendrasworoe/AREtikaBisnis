using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    //to main menu
    public void MenuButton()
    {
        SceneManager.LoadScene("MenuPilihan");
    }

    //to scene AR 1
    public void ARScene()
    {
        SceneManager.LoadScene("ARScene");
    }

    //to scene AR 2
    public void ARScene2()
    {
        SceneManager.LoadScene("ARScene2");
    }

    //to scene AR 3
    public void ARScene3()
    {
        SceneManager.LoadScene("ARScene3");
    }

    //to scene AR 4
    public void ARScene4()
    {
        SceneManager.LoadScene("ARScene4");
    }

    //to scene Beginning case respons
    public void BeginningCase()
    {
        SceneManager.LoadScene("BeginingCaseFinal");
    }

    //to scene Middle case respons
    public void MiddleCase()
    {
        SceneManager.LoadScene("MiddleCaseFinal");
    }

    //exit the application
    public void ExitApp()
    {
        Application.Quit();
        Debug.Log("App is exit");
    }
}
