using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashSequence : MonoBehaviour
{
    public static int SceneNum;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneNum == 0)
        {
            StartCoroutine(toSplash());
        }
        if (SceneNum == 1)
        {
           toGame();
        }
    }

    IEnumerator toSplash ()
    {
        yield return new WaitForSeconds(2);
        SceneNum = 1;
        SceneManager.LoadScene(1);
    }

    IEnumerator toGame()
    {
        yield return new WaitForSeconds(2);
        SceneNum = 2;
        SceneManager.LoadScene(0);
    }
}
