using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public GameObject PauseMenu;

    void Update()
    {
        if (Input.GetKey("m"))
        {
            PauseMenu.SetActive(false);
        }
    }

    public void GameStart()
    {
        SceneManager.LoadScene("Game");
    }

    public void about()
    {
        PauseMenu.SetActive(true);
    }

    public void quit()
    {
        Application.Quit();
    }
}
