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
        if (scenceName == "GameIntro")
        {
            Destroy(this.gameObject);
        }
    }
    
}
