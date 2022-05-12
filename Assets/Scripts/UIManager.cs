using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIManager : MonoBehaviour
{
    //Switch the scene to index
    public void SwitchScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    //Quits the game
    public void QuitGame()
    {
#if UNITY_EDITOR 
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
