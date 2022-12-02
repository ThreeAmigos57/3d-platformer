using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Retry()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void GoBack()
    {
        SceneManager.LoadScene("main menu");
    }

}
