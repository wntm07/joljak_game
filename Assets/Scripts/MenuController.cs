using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void ClickDodge()
    {
        SceneManager.LoadScene("Dodge");
    }

    public void ClickZombie()
    {
        SceneManager.LoadScene("Zombie");
    }

    public void ClickExit()
    {
        Application.Quit();
    }
}