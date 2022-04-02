using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject PauseMenu;

    void update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pause();
        }
    }

    public void pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f; 
    }
    
    public void resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }

    public void quit()
    {
        Application.Quit();
    }
}
