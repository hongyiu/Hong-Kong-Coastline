using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void MapOneButton()
    {
        Debug.Log("Go to Map 1");
        SceneManager.LoadScene(1);
    }
    public void MapTwoButton()
    {
        Debug.Log("Go to Map 2");
        SceneManager.LoadScene(2);
    }
    public void MapThreeButton()
    {
        Debug.Log("Go to Map 3");
        SceneManager.LoadScene(3);
    }
    public void MapZeroButton()
    {
        Debug.Log("Go back to Map menu");
        SceneManager.LoadScene(0);
    }
}
