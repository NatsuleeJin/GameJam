using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScenceManager : MonoBehaviour
{
    public void LoadGame(string scenceName)
    {
        SceneManager.LoadScene(scenceName);
    }
}
