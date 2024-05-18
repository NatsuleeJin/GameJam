using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScenceManager : MonoBehaviour
{
    public void LoadGame(string scenceName)
    {
        SceneManager.LoadScene(scenceName);
    }

    public void LoadGameScene()
    {
        StartCoroutine(LoadGameDelay());
    }
    
    public IEnumerator LoadGameDelay()
    {
        yield return new WaitForSeconds(0.4f);
        SceneManager.LoadScene("GameIntro");
    }
}
