using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneSwitcher : MonoBehaviour
{
    public void aPn()
    {
        SceneManager.LoadScene(1);
    } 
    public void nPv()
    {
        SceneManager.LoadScene(2);
    }
    public void aT()
    {
        SceneManager.LoadScene(3);
    }
    public void leabve()
    {
        Application.Quit();
    }
}
