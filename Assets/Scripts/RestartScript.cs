using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{

    void OnCollisionEnter(Collision BallHit)
    {
        if (BallHit.collider.tag == "Wall")
        {
            Invoke("restart", 3f);
        }
    }

    void restart()
    {
        SceneManager.LoadScene("Game");
    }
}
