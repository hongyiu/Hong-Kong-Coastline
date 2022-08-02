using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void MapZeroButton()
    {
        Debug.Log("Go back to Map menu");
        SceneManager.LoadScene(0);
    }
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
}
